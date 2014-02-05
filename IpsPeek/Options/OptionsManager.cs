using MsgPack;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IpsPeek.Options
{
    public static class OptionsManager
    {
        private static OptionsModel _options;
        private static string _path = string.Empty;
        private static ObjectPacker packer = new ObjectPacker();
        public static void Load(string path, OptionsModel fallback)
        {
            _path = path;
            _options = fallback;
            try
            {
                OptionsModel model;
                using(FileStream file = File.OpenRead(path))
                {
                    model = packer.Unpack<OptionsModel>(file);
                }
                
                if (model != null)
                {
                    _options = model;
                }
            }
            catch //(Exception ex)
            {

                // MessageBox.Show(ex.Message);
            }

        }

        public static void Save()
        {
            using (FileStream file = File.OpenWrite(_path))
            {
                packer.Pack(file, _options);
            }
        }

        /* public static Size FormSize
          {
              get
              {
                  return _options.FormSize;
              }
              set
              {
                  _options.FormSize = value;
              }
          } */
        public static int FormTop
        {
            get
            {
                return _options.FormTop;
            }
            set
            {
                _options.FormTop = value;
            }
        }
        public static int FormLeft
        {
            get
            {
                return _options.FormLeft;
            }
            set
            {
                _options.FormLeft = value;
            }
        }
        public static int FormWidth
        {
            get
            {
                return _options.FormWidth;
            }
            set
            {
                _options.FormWidth = value;
            }
        }
        public static int FormHeight
        {
            get
            {
                return _options.FormHeight;
            }
            set
            {
                _options.FormHeight = value;
            }
        }
        public static int PanelHeight
        {
            get
            {
                return _options.PanelHeight;
            }
            set
            {
                _options.PanelHeight = value;
            }
        }
        public static bool ToolBarVisible
        {
            get
            {
                return _options.ToolBarVisible;
            }
            set
            {
                _options.ToolBarVisible = value;
            }
        }
        public static bool DataViewVisible
        {
            get
            {
                return _options.DataViewVisible;
            }
            set
            {
                _options.DataViewVisible = value;
            }
        }
        public static bool StringViewVisible
        {
            get
            {
                return _options.StringViewVisible;
            }
            set
            {
                _options.StringViewVisible = value;
            }
        }
    }
}
