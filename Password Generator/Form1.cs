using System;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class Form1 : Form
    {
        #region Constructor
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Buttons
        /// <summary>
        /// Button to generate random 15-char password
        /// </summary>
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GeneratePass();
        }

        /// <summary>
        /// Button to copy password to the clipboard
        /// </summary>
        private void CopyButton_Click(object sender, EventArgs e)
        {
            CopyToClipboard();
        }
        #endregion

        #region Generator Function
        /// <summary>
        /// Generate pass depending on active checkboxes
        /// </summary>
        private void GeneratePass()
        {
            var storage = new Storage();
            var random = new Random();
            var stringChars = new char[15];
            string combinedString;

            // Active checkboxes: 1, 2, 3, 4 
            if (LowercaseCheckBox.Checked && UppercaseCheckBox.Checked && NumbersCheckBox.Checked && SymbolsCheckBox.Checked) 
            {
                combinedString = storage.lowercaseLetters + storage.uppercaseLetters + storage.numbers + storage.symbols;
                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = combinedString[random.Next(combinedString.Length)];
                }
            }


            // Active checkboxes: 1, 2, 3 
            else if (LowercaseCheckBox.Checked && UppercaseCheckBox.Checked && NumbersCheckBox.Checked)
            {
                combinedString = storage.lowercaseLetters + storage.uppercaseLetters + storage.numbers;
                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = combinedString[random.Next(combinedString.Length)];
                }
            }

            // Active checkboxes: 2, 3, 4 
            else if (UppercaseCheckBox.Checked && NumbersCheckBox.Checked && SymbolsCheckBox.Checked)
            {
                combinedString = storage.uppercaseLetters + storage.numbers + storage.symbols;
                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = combinedString[random.Next(combinedString.Length)];
                }
            }

            // Active checkboxes: 1, 3, 4 
            else if (LowercaseCheckBox.Checked && NumbersCheckBox.Checked && SymbolsCheckBox.Checked)
            {
                combinedString = storage.lowercaseLetters + storage.numbers + storage.symbols;
                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = combinedString[random.Next(combinedString.Length)];
                }
            }

            // Active checkboxes: 1, 2, 4 
            else if (LowercaseCheckBox.Checked && UppercaseCheckBox.Checked && SymbolsCheckBox.Checked)
            {
                combinedString = storage.lowercaseLetters + storage.uppercaseLetters + storage.symbols;
                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = combinedString[random.Next(combinedString.Length)];
                }
            }

            // Active checkboxes: 1, 2 
            else if (LowercaseCheckBox.Checked && UppercaseCheckBox.Checked)
            {
                combinedString = storage.lowercaseLetters + storage.uppercaseLetters;
                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = combinedString[random.Next(combinedString.Length)];
                }
            }

            // Active checkboxes: 1, 3
            else if (LowercaseCheckBox.Checked && NumbersCheckBox.Checked)
            {
                combinedString = storage.lowercaseLetters + storage.numbers;
                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = combinedString[random.Next(combinedString.Length)];
                }
            }

            // Active checkboxes: 1, 4
            else if (LowercaseCheckBox.Checked && SymbolsCheckBox.Checked)
            {
                combinedString = storage.lowercaseLetters + storage.symbols;
                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = combinedString[random.Next(combinedString.Length)];
                }
            }

            // Active checkboxes: 2, 3
            else if (UppercaseCheckBox.Checked && NumbersCheckBox.Checked)
            {
                combinedString = storage.uppercaseLetters + storage.numbers;
                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = combinedString[random.Next(combinedString.Length)];
                }
            }

            // Active checkboxes: 2, 4
            else if (UppercaseCheckBox.Checked && SymbolsCheckBox.Checked)
            {
                combinedString = storage.uppercaseLetters + storage.symbols;
                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = combinedString[random.Next(combinedString.Length)];
                }
            }

            // Active checkboxes: 3, 4
            else if (NumbersCheckBox.Checked && SymbolsCheckBox.Checked)
            {
                combinedString = storage.numbers + storage.symbols;
                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = combinedString[random.Next(combinedString.Length)];
                }
            }

            // Active checkboxes: 1
            else if (LowercaseCheckBox.Checked)
            {
                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = storage.lowercaseLetters[random.Next(storage.lowercaseLetters.Length)];
                }
            }

            // Active checkboxes: 2
            else if (UppercaseCheckBox.Checked)
            {
                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = storage.uppercaseLetters[random.Next(storage.uppercaseLetters.Length)];
                }
            }

            // Active checkboxes: 3
            else if (NumbersCheckBox.Checked)
            {
                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = storage.numbers[random.Next(storage.numbers.Length)];
                }
            }

            // Active checkboxes: 4
            else if (SymbolsCheckBox.Checked)
            {
                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = storage.symbols[random.Next(storage.symbols.Length)];
                }
            }

            var finalString = new String(stringChars);
            OutputText.Text = finalString;
            CopyConfirmation.Text = "";
        }
        #endregion
        
        #region Copy Function

        /// <summary>
        /// Copy password to the clipboard
        /// </summary>
        private void CopyToClipboard()
        {
            Clipboard.SetText(OutputText.Text);
            CopyConfirmation.Text = "PASS IS COPIED TO CLIPBOARD!";
        }
        #endregion
    }
}
