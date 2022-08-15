﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IpsPeek.Reporting
{
    internal class TextReporter : IReporter
    {
        private StreamWriter _writer = null;
        private bool _rowWritten = false;
        private bool _headerWritten = false;
        private string _offset;
        private string _end;
        private string _size;
        private string _type;
        private string _sizeHex;
        private string _ipsOffset;
        private string _ipsEnd;
        private string _ipsSize;
        private string _ipsSizeHex;
        private string _modified;
        private string _rows;
        private string _patches;
        private string _fileSize;
        private string _fileName;
        /* string _offsetText;
        string _endText;
        string _sizeText;
        string _sizeHexText;
        string _typeText;
        string _ipsOffsetText;
        string _ipsEndText;
        string _ipsSizeText;
        string _ipsSizeHexText; */

        public TextReporter(Stream stream)
        {
            _writer = new StreamWriter(stream);
        }

        public void Write(Dictionary<string, string> row)
        {
            /*
             * TODO: Fix footer writing.
             * if (!_rowWritten)
              {
                  // Write the stats (should be the first row received.)
                  if (string.IsNullOrEmpty(_modified)) row.TryGetValue("modified", out _modified);
                  if (string.IsNullOrEmpty(_rows)) row.TryGetValue("rows", out _rows);
                  if (string.IsNullOrEmpty(_patches)) row.TryGetValue("patches", out _patches);
                  if (string.IsNullOrEmpty(_fileSize)) row.TryGetValue("filesize", out _fileSize);
                  if (string.IsNullOrEmpty(_fileName)) row.TryGetValue("filename", out _fileName);
                  _writer.WriteLine("Rows: {0:X} ({0}), Patches: {1:X} ({1}), Modified: {2:X} ({2})", row["rows"], row["patches"], row["modified"]);
                  _rowWritten = true;
                  return;
              }
              */
            StringBuilder format = new StringBuilder();

            if (!row.TryGetValue("offset", out _offset)) _offset = "------";
            if (!row.TryGetValue("end", out _end)) _end = "------";
            if (!row.TryGetValue("size", out _size)) _size = "----";
            if (!row.TryGetValue("sizehex", out _sizeHex)) _sizeHex = "----";
            if (!row.TryGetValue("type", out _type)) _type = "---";
            if (!row.TryGetValue("ipsoffset", out _ipsOffset)) _ipsOffset = "------";
            if (!row.TryGetValue("ipsend", out _ipsEnd)) _ipsEnd = "------";
            if (!row.TryGetValue("ipssize", out _ipsSize)) _ipsSize = string.Empty;
            if (!row.TryGetValue("ipssizehex", out _ipsSizeHex)) _ipsSizeHex = string.Empty;
            /* if (!_headerWritten)
            { */
            // TODO: Add formatting for optional Length (Hex)/IPS Length (Hex) columns.
            /* format = string.Concat("{0,", -Math.Max(Strings.WriteOffset.Length, 6) + 1, "}",
                           "{1,", -Math.Max(Strings.End.Length, 6) + 1, "}",
                           "{2,", -Math.Max(Strings.Length.Length, 5) + 1, "}",
                           () => {return string.Empty}),
                           "{4,", -Math.Max(Strings.Type.Length, 3) + 1, "}",
                           "{5,", -Math.Max(Strings.IpsStart.Length, 8) + 1, "}",
                           "{6,", -Math.Max(Strings.End.Length, 8) + 1, "}",
                           "{7,", -Math.Max(Strings.End.Length, 8) + 1, "}",
                           "{8}");

             /*format.Append(string.Concat("{0,", -Math.Max(Strings.WriteOffset.Length, 6) + 1, "}",
                           "{1,", -Math.Max(Strings.End.Length, 6) + 1, "}",
                           "{2,", -Math.Max(Strings.Length.Length, 5) + 1, "}")); */
            /* _writer.Write(string.Concat("{0,", -Math.Max(Strings.WriteOffset.Length, 6) + 1, "}",
                           "{1,", -Math.Max(Strings.End.Length, 6) + 1, "}",
                           "{2,", -Math.Max(Strings.Length.Length, 5) + 1, "}"),
                           Strings.WriteOffset, Strings.End, Strings.Length);*/
            // var paramCount = 0;
            format.Append(string.Concat("{", 0, ",", -(Math.Max(Strings.Offset.Length, 6) + 1), "}"));
            format.Append(string.Concat("{", 1, ",", -(Math.Max(Strings.End.Length, 6) + 1), "}"));
            format.Append(string.Concat("{", 2, ",", -(Math.Max(Strings.SizeHeader.Length, 5) + 1), "}"));

            if (_size.First() != '-' && !row.ContainsKey("sizehex"))
            {
                _sizeHex = string.Empty;
                format.Append(string.Concat("{", 3, "}"));
            }
            else
            {
                format.Append(string.Concat("{", 3, ",", -(Math.Max(Strings.SizeHexHeader.Length, 6) + 1), "}"));
            }

            format.Append(string.Concat("{", 4, ",", -(Math.Max(Strings.TypeHeader.Length, 3) + 1), "}"));
            format.Append(string.Concat("{", 5, ",", -(Math.Max(Strings.IpsOffsetHeader.Length, 8) + 1), "}"));
            format.Append(string.Concat("{", 6, ",", -(Math.Max(Strings.IpsEndHeader.Length, 8) + 1), "}"));
            format.Append(string.Concat("{", 7, ",", -(Math.Max(Strings.IpsSizeHeader.Length, 8) + 1), "}"));

            if (!row.ContainsKey("ipssizehex"))
            {
                _ipsSizeHex = string.Empty;
            }
            format.Append(string.Concat("{", 8, "}"));

            if (!_headerWritten)
            {
                row.TryGetValue("filename", out _fileName);
                _writer.WriteLine(Strings.ApplicationInformation, Application.ProductName, Application.ProductVersion.ToString());
                _writer.WriteLine();
                _writer.WriteLine(Strings.FileInformation, _fileName);
                _writer.WriteLine();
                string stringSizeHex = row.ContainsKey("sizehex") ? Strings.SizeHexHeader : string.Empty;
                string stringIpsSizeHex = row.ContainsKey("ipssizehex") ? Strings.IpsSizeHexHeader : string.Empty;
                _writer.WriteLine(format.ToString(), Strings.Offset, Strings.End, Strings.SizeHeader, stringSizeHex, Strings.TypeHeader, Strings.IpsOffsetHeader, Strings.IpsEndHeader, Strings.IpsSizeHeader, stringIpsSizeHex);
                _headerWritten = true;
                return;
            }

            /*  if (row.ContainsKey("ipssizehex"))
              {
                  _writer.Write(string.Concat("{0,", -Math.Max(Strings.Length.Length, 5) + 1, "}", Strings.si));
              }
              format.Append(string.Concat("{0,", -Math.Max(Strings.Type.Length, 3) + 1, "}",
                            "{1,", -Math.Max(Strings.IpsStart.Length, 8) + 1, "}",
                            "{6,", -Math.Max(Strings.End.Length, 8) + 1, "}",
                            "{7,", -Math.Max(Strings.End.Length, 8) + 1, "}"));

              if (row.ContainsKey("ipssizehex")) format.Append("{8}");
             * */

            //_writer.WriteLine(format.ToString(), Strings.WriteOffset, Strings.End, Strings.Length, Strings.Type, Strings.IpsStart, Strings.End, Strings.Length);
            /* } */

            _writer.WriteLine(format.ToString(), _offset, _end, _size, _sizeHex, _type, _ipsOffset, _ipsEnd, _ipsSize, _ipsSizeHex);
        }

        public void Close()
        {
            _writer.Close();
        }

        public void Dispose()
        {
            _writer.Dispose();
        }
    }
}