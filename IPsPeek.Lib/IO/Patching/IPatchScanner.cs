namespace IpsPeek.Lib.IO.Patching
{
    public interface IPatchScanner<T> where T : BinaryRecord
    {
        public int ToInteger(byte[] data);

        public List<T> Scan(string patch);

        public List<T> Scan(Stream patch);

        public byte[] Read(Stream stream, int size, int offset, int count);
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
                        patches.Add(new IpsPatch(null, null, new Range((_patchStream.Position - 5), (_patchStream.Position - 1)), 5, IPSLibNet.IpsPatchRecordType.Id));

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

                                    patches.Add(new IpsPatch(offset, size, new Range((_patchStream.Position - 8), (_patchStream.Position - 1)), 8, IPSLibNet.IpsPatchRecordType.RlePatch));

                                    // Else, No RLE, so use normal patching.
                                } else {
                                    patch.ReadBytes(size);
                                    patches.Add(new IpsPatch(offset, size, new Range(((_patchStream.Position - 10) - (size - 5)), (_patchStream.Position - 1)), (size + 5), IPSLibNet.IpsPatchRecordType.NormalPatch));
                                }
                                // Else, it is the end of the file
                            } else {
                                endOfFile = true;

                                patches.Add(new IpsPatch(null, null, new Range((_patchStream.Position - 3), _patchStream.Position - 1), 3, IPSLibNet.IpsPatchRecordType.Eof));

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
                                        patches.Add(new IpsPatch(truncate, null, new Range((_patchStream.Position - 3), (_patchStream.Position - 1)), 3, IPSLibNet.IpsPatchRecordType.Truncate));
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
}