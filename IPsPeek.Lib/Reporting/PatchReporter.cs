﻿using IpsPeek.Lib.Utils;

namespace IpsPeek.Lib.Reporting
{
    internal class PatchReporter
    {
        public PatchReporter(Stream stream, ITableWriter writer, string header, string footer, Dictionary<string, string> visibleColumns)
        {
            Writer = writer;
            Header = header;
            Footer = footer;
            VisibleColumns = visibleColumns;
        }

        public ITableWriter Writer
        {
            get;
            set;
        }

        public string Header
        {
            get;
            set;
        }

        public string Footer
        {
            get;
            set;
        }

        public Dictionary<string, string> VisibleColumns
        {
            get;
            set;
        }

        public void Report(Dictionary<string, string> row)
        {
            /*   bool _rowWritten = false;
               bool _headerWritten = false;
               string _offset;
               string _end;
               string _size;
               string _type;
               string _sizeHex;
               string _ipsOffset;
               string _ipsEnd;
               string _ipsSize;
               string _ipsSizeHex;
               string _modified;
               string _rows;
               string _patches;
               string _fileSize;
               string _fileName;
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
            /*
            format.Append(string.Concat("{", 0, ",", -(Math.Max(Strings.WriteOffset.Length, 6) + 1), "}"));
            format.Append(string.Concat("{", 1, ",", -(Math.Max(Strings.End.Length, 6) + 1), "}"));
            format.Append(string.Concat("{", 2, ",", -(Math.Max(Strings.Length.Length, 5) + 1), "}"));

            if (_size.First() != '-' && !row.ContainsKey("sizehex"))
            {
                _sizeHex = string.Empty;
                format.Append(string.Concat("{", 3, "}"));
            }
            else
            {
                format.Append(string.Concat("{", 3, ",", -(Math.Max(Strings.SizeHex.Length, 6) + 1), "}"));
            }

            format.Append(string.Concat("{", 4, ",", -(Math.Max(Strings.Type.Length, 3) + 1), "}"));
            format.Append(string.Concat("{", 5, ",", -(Math.Max(Strings.WriteOffset.Length, 8) + 1), "}"));
            format.Append(string.Concat("{", 6, ",", -(Math.Max(Strings.End.Length, 8) + 1), "}"));
            format.Append(string.Concat("{", 7, ",", -(Math.Max(Strings.Length.Length, 8) + 1), "}"));

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
                string stringSizeHex = row.ContainsKey("sizehex") ? Strings.SizeHex : string.Empty;
                string stringIpsSizeHex = row.ContainsKey("ipssizehex") ? Strings.IpsSizeHex : string.Empty;
                _writer.WriteLine(format.ToString(), Strings.WriteOffset, Strings.End, Strings.Length, stringSizeHex, Strings.Type, Strings.WriteOffset, Strings.End, Strings.Length, stringIpsSizeHex);
                _headerWritten = true;
                return;
                */
        }
    }
}