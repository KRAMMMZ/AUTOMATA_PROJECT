using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TokenizerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTokenize_Click(object sender, EventArgs e)
        {
            // Get the source code input from TextBox1.
            string sourceCode = txtSourceCode.Text;
            
            try
            {
                // Tokenize the input source code.
                var tokens = Tokenizer.Tokenize(sourceCode);

                // Display the tokenized output in TextBox2.
                txtOutput.Clear();
                foreach (var token in tokens)
                {
                    txtOutput.AppendText($"{token.TokenType}: '{token.Value}' at line {token.LineNumber}\r\n");
                }
            }
            catch (Exception ex)
            {
                // In case of error, show the error message in TextBox2.
                txtOutput.Clear();
                txtOutput.AppendText($"Error: {ex.Message}");
            }
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtSourceCode.Clear();
            txtOutput.Clear();
        }
    }
}
