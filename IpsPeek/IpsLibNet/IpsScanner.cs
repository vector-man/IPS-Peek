using IpsPeek.IpsLibNet.Exceptions;
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
            List<IpsElement> patches = new List<IpsElement>();


            // Holds data for various reasons; this will be redefined constantly below.
            byte[] data;

            if (patch.Length < 5)
            {
                throw new UnsupportedFileTypeException("The IPS patch format is not valid.", null);
            }

            // Read 'PATCH' bytes of present (if not present, this is not a valid IPS patch).
            data = Read(patch, 5, 0, 5);
            // Check header for 'PATCH.'
            // If patch is not valid...
            if ((!(System.Text.ASCIIEncoding.ASCII.GetString(data) == "PATCH")))
            {
                // Throw exception because 'PATCH' was not found in header.
                throw new UnsupportedFileTypeException("The IPS patch format is not valid.", null);
            }
            patches.Add(new IpsIdElement(0));
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
                data = Read(patch, 4, 1, 3);

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
                    patches.Add(new IpsEndOfFileElement((int)(patch.Position-3)));
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
                data = Read(patch, 4, 1, 3);
                patches.Add(new IpsResizeElement((int)(patch.Position - 3), data));
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

/* 
 	byte[] data = new byte[4];
		using (System.IO.BinaryReader patch = new System.IO.BinaryReader(_patchStream)) {
			try {
				// Check header for 'PATCH'.

				// If patch is not valid (should be set to the word PATCH).
				if ((!(System.Text.ASCIIEncoding.ASCII.GetString(patch.ReadBytes(5)) == "PATCH"))) {
					// Throw exception because 'PATCH' was not found in header.
					throw new Exceptions.UnsupportedFileTypeException("IPS patch file format is not valid.", null);

					// Else, valid patch file, continue.

				} else {
					// Add Id patch.
					patches.Add(new IpsPatch(null, null, new Range((_patchStream.Position - 5), (_patchStream.Position - 1)), 5, IPSLibNet.IpsPatchType.Id));

					int offset = 0;
					// 3 bytes, gives offset into base file.
					int size = 0;
					// 2 bytes, size of next record data, is 0 if RLE.
					bool endOfFile = false;
					// Used see if EOF is found.

					//rle stuff
					int rleCount = 0;
					// 2 bytes, the numbero f times to repeat the RLE byte.
					byte rleByte = 0;
					// The byte to repeat

					int truncate = 0;
					// Used for truncation data.

					int patchCount = 0;


					while (!endOfFile) {
						// Patch record code below ... 

						// Add 3 bytes from patch stream to data (potentially containing 'EOF').
						data(1) = (patch.ReadByte);
						data(2) = (patch.ReadByte);
						data(3) = (patch.ReadByte);

						// If not the end of the file (no 'EOF' string found).

						if (!(System.Text.ASCIIEncoding.ASCII.GetString(data, 1, 3) == "EOF")) {
							// Set offset to big-endian integer representation of offset bytes (taken from EOF).
							offset = GetCorrectInteger(data);

							// Clear data.
							Array.Clear(data, 0, 4);

							// Add 2 bytes from patch stream to data.
							data(2) = (patch.ReadByte());
							data(3) = (patch.ReadByte());

							// Set size to big-endian integer representation of size bytes.
							size = GetCorrectInteger(data);

							// Clear data.
							Array.Clear(data, 0, 4);

							// If RLE patching.

							if (size == 0) {
								// Add 2 bytes from patch stream to data.
								data(2) = patch.ReadByte;
								data(3) = patch.ReadByte;

								// Clear data.
								Array.Clear(data, 0, 4);
								// Read RLE byte
								patch.ReadByte();

								patches.Add(new IpsPatch(offset, size, new Range((_patchStream.Position - 8), (_patchStream.Position - 1)), 8, IPSLibNet.IpsPatchType.RlePatch));

								// Else, No RLE, so use normal patching.
							} else {
								patch.ReadBytes(size);
								patches.Add(new IpsPatch(offset, size, new Range(((_patchStream.Position - 10) - (size - 5)), (_patchStream.Position - 1)), (size + 5), IPSLibNet.IpsPatchType.NormalPatch));

							}
							// Else, it is the end of the file

						} else {
							endOfFile = true;

							patches.Add(new IpsPatch(null, null, new Range((_patchStream.Position - 3), _patchStream.Position - 1), 3, IPSLibNet.IpsPatchType.Eof));


							// Check for LunarIPS truncate command.
							try {
								// Add 3 bytes from patch stream to data (potentially containing truncate information).
								data(1) = patch.ReadByte;
								data(2) = patch.ReadByte;
								data(3) = patch.ReadByte;

								// Set truncate to the big-endian integer representation of the number of bytes to truncate stream.
								truncate = GetCorrectInteger(data);

								// Clear data
								Array.Clear(data, 0, 4);

								// If truncate data is right size.
								if ((truncate > 0)) {

									patches.Add(new IpsPatch(truncate, null, new Range((_patchStream.Position - 3), (_patchStream.Position - 1)), 3, IPSLibNet.IpsPatchType.Truncate));

								}
							} catch (Exception ex) {
								// Not a truncate patch, no need for exception, just silently ignore.
							}
						}
					}
				}
			} catch (Exception ex) {
				throw ex;
			}
		}
		return patches;
 */