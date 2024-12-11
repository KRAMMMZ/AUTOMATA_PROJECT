namespace TokenizerApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtSourceCode;
        private Button btnTokenize;
        private TextBox txtOutput;
        private Label lblTitle;
        private Label lblInstructions;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtSourceCode = new TextBox();
            btnTokenize = new Button();
            txtOutput = new TextBox();
            lblTitle = new Label();
            lblInstructions = new Label();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtSourceCode
            // 
            txtSourceCode.Location = new Point(13, 150);
            txtSourceCode.Multiline = true;
            txtSourceCode.Name = "txtSourceCode";
            txtSourceCode.ScrollBars = ScrollBars.Vertical;
            txtSourceCode.Size = new Size(543, 100);
            txtSourceCode.TabIndex = 0;
            // 
            // btnTokenize
            // 
            btnTokenize.BackColor = Color.Lime;
            btnTokenize.Location = new Point(400, 256);
            btnTokenize.Name = "btnTokenize";
            btnTokenize.Size = new Size(75, 31);
            btnTokenize.TabIndex = 1;
            btnTokenize.Text = "Tokenize";
            btnTokenize.UseVisualStyleBackColor = false;
            btnTokenize.Click += btnTokenize_Click;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(13, 293);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(543, 209);
            txtOutput.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(13, 13);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(356, 24);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Lexical Analysis (Tokenizer/Scanner)";
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.ForeColor = Color.Black;
            lblInstructions.Location = new Point(13, 59);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(543, 45);
            lblInstructions.TabIndex = 4;
            lblInstructions.Text = resources.GetString("lblInstructions.Text");
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Location = new Point(481, 256);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 5;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(13, 128);
            label1.Name = "label1";
            label1.Size = new Size(190, 19);
            label1.TabIndex = 6;
            label1.Text = "ENTER SOURCE CODE :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(13, 271);
            label2.Name = "label2";
            label2.Size = new Size(81, 19);
            label2.TabIndex = 7;
            label2.Text = "OUTPUT :";
            // 
            // Form1
            // 
            BackColor = Color.Gainsboro;
            ClientSize = new Size(571, 514);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(lblInstructions);
            Controls.Add(lblTitle);
            Controls.Add(txtOutput);
            Controls.Add(btnTokenize);
            Controls.Add(txtSourceCode);
            ForeColor = Color.Black;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tokenizer";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button button1;
        private Label label1;
        private Label label2;
    }
}
