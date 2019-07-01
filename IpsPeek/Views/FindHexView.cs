using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace IpsPeek
{
    public partial class FindHexBoxDialog : Form
    {
        //private FindOptions _findOptions = new FindOptions();
        //private HexBox _hexEditor;
        //private FindOptions _backupOptions;
        public FindHexBoxDialog()
        {
            InitializeComponent();



            this.Shown += UpdateStates;
            radioButtonHex.CheckedChanged += UpdateStates;
            radioButtonText.CheckedChanged += UpdateStates;

            comboBoxText.TextChanged += UpdateStates;

            hexBoxHex.PreviewKeyDown += UpdateStates;


            hexBoxHex.ReadOnly = false;
            SetStrings();
        }

        private void SetStrings()
        {
            radioButtonText.Text = Strings.Text;
            radioButtonHex.Text = Strings.Hexadecimal;
            checkBoxMatchCase.Text = Strings.MatchCase;
            buttonFind.Text = Strings.Find;
            buttonCancel.Text = Strings.Cancel;
            this.Text = Strings.Find;
        }

        void UpdateStates(object sender, EventArgs e)
        {

            //hexBoxHex.Enabled = (FindOptions.Type == FindType.Hex);
            //comboBoxText.Enabled = (FindOptions.Type == FindType.Text);
            //buttonFind.Enabled = ((comboBoxText.Text.Length > 0) && radioButtonText.Checked) || (hexBoxHex.ByteProvider != null) && ((((DynamicByteProvider)hexBoxHex.ByteProvider).Length > 0) && radioButtonHex.Checked);
        }
        //public FindOptions CloneFindOptions(FindOptions options)
        //{
        //    FindOptions newOptions = new FindOptions();

        //    newOptions.Direction = options.Direction;
        //    newOptions.Hex = options.Hex;
        //    newOptions.MatchCase = options.MatchCase;
        //    newOptions.Text = options.Text;
        //    newOptions.Type = options.Type;

        //    return newOptions;
        //}
        //public long Find()
        //{
        //    return _hexEditor.Find(_findOptions);
        ////}
        //public void SetHexEditor(HexBox editor)
        //{
        //    _hexEditor = editor;
        //}
        //public HexBox GetHexEditor()
        //{
        //    return _hexEditor;
        //}
        //public FindOptions FindOptions
        //{
        //    get
        //    {
        //        return _findOptions;
        //    }
        //}

        public string[] TextItems
        {
            get
            {
                return comboBoxText.Items.OfType<string>().ToArray<string>();
            }
            set
            {
                comboBoxText.Items.Clear();
                comboBoxText.Items.AddRange(value);
            }
        }

        private void radioButtonHex_CheckedChanged(object sender, EventArgs e)
        {
            //_findOptions.Type = FindType.Hex;
        }

        private void radioButtonText_CheckedChanged(object sender, EventArgs e)
        {
            //_findOptions.Type = FindType.Text;
        }

        private void checkBoxMatchCase_CheckedChanged(object sender, EventArgs e)
        {
            //FindOptions.MatchCase = checkBoxMatchCase.Checked;
        }

        private void FindHexBoxDialog_Load(object sender, EventArgs e)
        {
            //checkBoxMatchCase.Checked = _findOptions.MatchCase;
            //if (_findOptions.Type == FindType.Hex)
            //{
            //    radioButtonHex.Checked = true;
            //}
            //else
            //{
            //    radioButtonText.Checked = true;
            //}

            //_backupOptions = CloneFindOptions(_findOptions);
            //long length = ((DynamicByteProvider)(hexBoxHex.ByteProvider)).Length;
            //((DynamicByteProvider)(hexBoxHex.ByteProvider)).DeleteBytes(0, length);
            //if (FindOptions.Hex != null) ((DynamicByteProvider)(hexBoxHex.ByteProvider)).InsertBytes(0, FindOptions.Hex);
            //comboBoxText.Text = FindOptions.Text;
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            UpdateStates(null, null);

            ////_findOptions.Hex = ((DynamicByteProvider)hexBoxHex.ByteProvider).Bytes.ToArray();
            //_findOptions.Text = comboBoxText.Text;

            //if (!comboBoxText.Items.Contains(_findOptions.Text)) comboBoxText.Items.Insert(0, _findOptions.Text);
        }

        private void FindHexBoxDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (DialogResult != System.Windows.Forms.DialogResult.OK)
            //{
            //    _findOptions = _backupOptions;
            //}
        }

    }

}

