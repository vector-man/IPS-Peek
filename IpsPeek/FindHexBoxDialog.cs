using Be.Windows.Forms;
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
        private FindOptions _findOptions = new FindOptions();
        private HexBox _hexEditor;
        public FindHexBoxDialog()
        {
            InitializeComponent();

            this.Shown += UpdateStates;
            radioButtonHex.CheckedChanged += UpdateStates;
            radioButtonText.CheckedChanged += UpdateStates;

            comboBoxText.TextChanged += UpdateStates;

            hexBoxHex.PreviewKeyDown += UpdateStates;

            hexBoxHex.ByteProvider = new DynamicByteProvider(new byte[] { });

            ((DynamicByteProvider)hexBoxHex.ByteProvider).LengthChanged += UpdateStates;
        }

        void UpdateStates(object sender, EventArgs e)
        {
            hexBoxHex.Enabled = radioButtonHex.Checked;
            comboBoxText.Enabled = radioButtonText.Checked;

            buttonFind.Enabled = ((comboBoxText.Text.Length > 0) && radioButtonText.Checked) || (hexBoxHex.ByteProvider != null) && ((((DynamicByteProvider)hexBoxHex.ByteProvider).Length > 0) && radioButtonHex.Checked);

            _findOptions.Type = radioButtonHex.Checked ? FindType.Hex : FindType.Text;
            _findOptions.MatchCase = checkBoxMatchCase.Checked;
        }
        public DialogResult ShowDialog()
        {
            return ShowDialog(null);
        }
        public DialogResult ShowDialog(IWin32Window owner)
        {
            hexBoxHex.ReadOnly = false;
            DialogResult result = base.ShowDialog(owner);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                UpdateStates(null, null);
                if (_findOptions.Type == FindType.Hex)
                {
                    _findOptions.Hex = ((DynamicByteProvider)hexBoxHex.ByteProvider).Bytes.ToArray();
                }
                else
                {
                    _findOptions.Text = comboBoxText.Text;
                }
            }
            return result;
        }
        public long Find()
        {
            return _hexEditor.Find(_findOptions);
        }
        public void SetHexEditor(HexBox editor)
        {
            _hexEditor = editor;
        }
        public HexBox GetHexEditor()
        {
            return _hexEditor;
        }
        public FindOptions FindOptions
        {
            get
            {
                return _findOptions;
            }
        }

    }

}

