using fastJSON;
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
        public static void Load(string path, OptionsModel fallback)
        {
            _path = path;
            _options = fallback;
            try
            {
                string jsonData = File.ReadAllText(path);
                OptionsModel data = (OptionsModel)fastJSON.JSON.Instance.ToObject<OptionsModel>(jsonData);
                if (data != null)
                {
                    _options = data;
                }
            }
            catch //(Exception ex)
            {

                // MessageBox.Show(ex.Message);
            }

        }

        public static void Save()
        {
            var parameters = new JSONParameters();
            parameters.UsingGlobalTypes = false;
            parameters.UseExtensions = false;
            string options = JSON.Instance.ToJSON(_options);
            File.WriteAllText(_path, options);
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
        public static long PanelHeight
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
