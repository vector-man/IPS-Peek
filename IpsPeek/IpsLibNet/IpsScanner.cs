﻿using IpsPeek.IpsLibNet.Exceptions;
using IpsPeek.IpsLibNet.Patching;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace IpsLibNet
{
    public class IpsScanner
    {
        public string IpsHeader = "PATCH";
        public int ToInteger(byte[] data)
        {
            if ((BitConverter.IsLittleEndian))
            {
                Array.Reverse(data);
            }

            return BitConverter.ToInt32(data, 0);
        }

        public List<IpsElement> Scan(string patch)
        {
            using (Stream patchStream = File.OpenRead(patch))
            {
                return Scan(patchStream);
            }
        }

        public List<IpsElement> Scan(Stream patch)
        {
            patch.Seek(0, SeekOrigin.Begin);

            List<IpsElement> patches = new List<IpsElement>();


            // Holds data for various reasons; this will be redefined constantly below.
            if (patch.Length < 5)
            {
                throw new UnsupportedFileTypeException("The IPS patch format is not valid.", null);
            }

            // Read 'PATCH' bytes of present (if not present, this is not a valid IPS patch).
            var patchHeaderBytes = Read(patch, 5, 0, 5);
            var patchHeaderString = System.Text.ASCIIEncoding.ASCII.GetString(patchHeaderBytes);
            // Check header for 'PATCH.'
            // If patch is not valid...
            if (patchHeaderString != IpsHeader)
            {
                // Throw exception because 'PATCH' was not found in header.
                throw new UnsupportedFileTypeException("The IPS patch format is not valid.", null);
            }
            
            patches.Add(new IpsIdValueElement(0));
            // Valid patch file, continue...

            // 3 bytes; gives offset into base file.
            int offset = 0;
            // 2 bytes; size of next record data; is 0 if RLE.
            int size = 0;
            // Used see if EOF is found.
            bool endOfFile = false;

            // 2 bytes; counter for RLE.
            int rleCount = 0;
            // 1 byte; holds the RLE byte;
            byte[] rleByte = new byte[1];
            // 3 bytes; holds the truncation information (if any).
            //int truncate = 0;
            // Keeps track of how many patches were made (not very useful here).
            int patchCount = 0;

            // While 'EOF' was not found in the patch.
            long patchStreamLength = patch.Length;
            while (!endOfFile && patch.Position < patchStreamLength)
            {
                // Add 3 bytes from patch stream to data (potentially containing 'EOF').
                var data = Read(patch, 4, 1, 3);

                // If not the end of the file (no 'EOF' string found).
                if (!(System.Text.ASCIIEncoding.ASCII.GetString(data, 1, 3) == "EOF"))
                {
                    // Set offset to big-endian integer representation of offset bytes (taken from eof).
                    offset = ToInteger(data);

                    // Add 2 bytes from patch stream to data.
                    data = Read(patch, 4, 2, 2);
                    size = ToInteger(data);

                    // If RLE patching...
                    if (size == 0)
                    {
                        patchCount += 1;
                        // Increment patch counter.


                        // Read 2 bytes from patch stream to data.
                        data = Read(patch, 4, 2, 2);
                        // Set rleCount to the big-endian integer representation of the number of times to use RLE byte.
                        rleCount = ToInteger(data);

                        // Read 1 byte from patch stream containing the RLE byte to write.
                        rleByte = Read(patch, 1, 0, 1);


                        patches.Add(new IpsRlePatchElement(offset, (int)patch.Position - 8, rleByte[0], rleCount));
                    }
                    // No RLE; use normal patching.
                    else
                    {
                        // Increment patch counter.
                        patchCount += 1;

                        // Seek target file to offset for patching.


                        // Read the entire patch into the data buffer.
                        data = Read(patch, size, 0, size);

                        patches.Add(new IpsPatchElement(offset, (int)patch.Position - size - 5, data));
                    }
                }
                else
                {
                    endOfFile = true;
                    patches.Add(new IpsEndOfFileValueElement((int)(patch.Position - 3)));
                }
            }

            if (!endOfFile)
            {
                throw new NoEndOfFileException();
            }

            // It is the end of the file.
            // Check for the LunarIPS truncate command.
            try
            {
                // Read 3 bytes from patch stream into data (potentially containing truncate information).
                var truncate = Read(patch, 3, 0, 3);
                patches.Add(new IpsResizeValueElement((int)(patch.Position - 3), truncate));
            }
            catch
            {
                // Not a truncate patch; no need for exception, just silently ignore.
            }

            return patches;
        }

        private byte[] Read(Stream stream, int size, int offset, int count)
        {
            byte[] data = new byte[size];
            int bytesRead = stream.Read(data, offset, count);

            if (bytesRead != count)
            {
                throw new MalformedPatchException();
            }

            return data;
        }

    }

}