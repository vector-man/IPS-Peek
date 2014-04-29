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
    public partial class GoToHexBoxDialog : Form
    {
        private long _value;
        private long _relativeValue;
        private long _maximum;
        private long _minimum;
        private const long MaxOffset = 0x7FFFFFFFFFFFFFFF;
        string _direction;
        GoToType _goToType = GoToType.Hexadecimal;

        GoToType _lastGoToType;

        public GoToHexBoxDialog()
        {
            InitializeComponent();

            
            radioButtonDec.CheckedChanged += UpdateStates;
            radioButtonHex.CheckedChanged += UpdateStates;
            radioButtonOct.CheckedChanged += UpdateStates;
            textBoxOffset.TextChanged += UpdateStates;
            this.Shown += UpdateStates;
            _lastGoToType = GoToType;

            SetStrings();
        }

        private void SetStrings()
        {
            this.Text = Strings.GoToOffset;
            labelOffset.Text = Strings.Offset;
            radioButtonHex.Text = Strings.Hexadecimal;
            radioButtonDec.Text = Strings.Decimal;
            radioButtonOct.Text = Strings.Octal;
            buttonOk.Text = Strings.Ok;
            buttonCancel.Text = Strings.Cancel;
        }


        void UpdateStates(object sender, EventArgs e)
        {
            string textOffset = textBoxOffset.Text;
            if (textOffset.Length == 0 || (textOffset.Length >= 2 && textOffset.Substring(0, 2) == "0x"))
            {
                buttonOk.Enabled = false;
                return;
            }

            if (sender is TextBox || sender is GoToHexBoxDialog)
            {
                long oldValue = Value;

                if (textOffset.Substring(0, 1) == "+" || textOffset.Substring(0, 1) == "-")
                {
                    _direction = textOffset.Substring(0, 1);
                    textOffset = textOffset.Remove(0, 1);
                }
                try
                {
                    long value = Convert.ToInt64(textOffset, (int)_goToType);

                    if (_direction == "-")
                    {
                        if ((Value - value) < Minimum)
                        {
                            buttonOk.Enabled = false;
                            return;
                        }
                        _relativeValue = -value;
                    }
                    else if (_direction == "+")
                    {
                        if ((Value + value) > Maximum)
                        {
                            buttonOk.Enabled = false;
                            return;
                        }
                        _relativeValue = +value;
                    }
                    else
                    {
                        _relativeValue = 0;
                        Value = value;
                    }
                    buttonOk.Enabled = true;
                    // textBoxOffset.Text = direction + ConvertValue(Value.ToString(), (int)_goToType, (int)_goToType);
                }
                catch (Exception ex)
                {
                    buttonOk.Enabled = false;
                    Value = oldValue;
                }
                _direction = "";
            }
            else if (sender is RadioButton)
            {
                textOffset = textBoxOffset.Text;

                if (textOffset.Substring(0, 1) == "+" || textOffset.Substring(0, 1) == "-")
                {
                    _direction = textOffset.Substring(0, 1);
                    textOffset = textOffset.Remove(0, 1);
                }
                else
                {
                    _direction = string.Empty;
                }

                textBoxOffset.Text = _direction + ConvertValue(textOffset, (int)_lastGoToType, (int)_goToType);

                _lastGoToType = _goToType;
            }

        }
        // Taken from: http://www.codeproject.com/Articles/16872/Number-base-conversion-class-in-C
        public static string ConvertValue(string value, int sourceRadix, int targetRadix)
        {
            const string digits = "0123456789abcdefghijklmnopqrstuvwxyz";

            System.Numerics.BigInteger bigint = 0;

            for (int index = value.Length - 1; index >= 0; index--)
            {
                bigint += digits.IndexOf(value[index].ToString(System.Globalization.CultureInfo.InvariantCulture), StringComparison.OrdinalIgnoreCase) * System.Numerics.BigInteger.Pow(sourceRadix, value.Length - 1 - index);
            }

            System.Text.StringBuilder result = new StringBuilder();

            System.Numerics.BigInteger workingValue = bigint;
            while (workingValue > 0)
            {
                int digitValue = (int)(workingValue % targetRadix);
                result.Insert(0, digits[digitValue]);
                workingValue = (workingValue - digitValue) / targetRadix;
            }
            return result.ToString();
        }
        public long Value
        {
            get
            {
                return _value;
            }
            set
            {
                if (value > Maximum)
                {
                    throw new ArgumentOutOfRangeException("Value", value, "The assigned value is greater than the Maximum property value.");
                }
                else if (value < Minimum)
                {
                    throw new ArgumentOutOfRangeException("Value", value, "The assigned value is less than the Minimum property value.");
                }
                else
                {
                    _value = value;
                }
            }
        }
        public long Maximum
        {
            get
            {
                return _maximum;
            }
            set
            {
                _maximum = value;

                if (_minimum > _maximum)
                {
                    _minimum = _maximum;
                }
                if (_value > _maximum)
                {
                    _value = _maximum;
                }
            }
        }

        public long Minimum
        {
            get
            {
                return _minimum;
            }
            set
            {
                _minimum = value;

                if (_minimum > _maximum)
                {
                    _maximum = _minimum;
                }

                if (_value < _minimum)
                {
                    _value = _minimum;
                }
            }
        }

        public GoToType GoToType
        {
            get
            {
                return _goToType;
            }
            set
            {
                _goToType = value;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Value += _relativeValue;
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void radioButtonHex_CheckedChanged(object sender, EventArgs e)
        {
            _goToType = GoToType.Hexadecimal;
        }

        private void radioButtonDec_CheckedChanged(object sender, EventArgs e)
        {
            _goToType = GoToType.Decimal;
        }

        private void radioButtonOct_CheckedChanged(object sender, EventArgs e)
        {
            _goToType = GoToType.Octal;
        }

        private void GoToHexBoxDialog_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBoxOffset;
        }
    }
}
