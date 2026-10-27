namespace E_Mail_Please
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Title = new Label();
            btnNowaGra = new Button();
            btnInstrukcja = new Button();
            btnWyjscie = new Button();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = Color.Transparent;
            Title.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            Title.ForeColor = Color.White;
            Title.Location = new Point(370, 108);
            Title.Name = "Title";
            Title.Size = new Size(292, 51);
            Title.TabIndex = 0;
            Title.Text = "E-MAIL PLEASE";
            Title.Click += label1_Click;
            // 
            // btnNowaGra
            // 
            btnNowaGra.BackColor = Color.Maroon;
            btnNowaGra.FlatStyle = FlatStyle.Flat;
            btnNowaGra.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNowaGra.ForeColor = Color.White;
            btnNowaGra.Location = new Point(127, 235);
            btnNowaGra.Name = "btnNowaGra";
            btnNowaGra.Size = new Size(230, 50);
            btnNowaGra.TabIndex = 1;
            btnNowaGra.Text = "NOWA GRA";
            btnNowaGra.UseVisualStyleBackColor = false;
            btnNowaGra.Click += button1_Click;
            // 
            // btnInstrukcja
            // 
            btnInstrukcja.BackColor = Color.DarkSlateGray;
            btnInstrukcja.FlatStyle = FlatStyle.Flat;
            btnInstrukcja.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnInstrukcja.ForeColor = Color.White;
            btnInstrukcja.Location = new Point(432, 235);
            btnInstrukcja.Name = "btnInstrukcja";
            btnInstrukcja.Size = new Size(230, 50);
            btnInstrukcja.TabIndex = 2;
            btnInstrukcja.Text = "INSTRUKCJA";
            btnInstrukcja.UseVisualStyleBackColor = false;
            // 
            // btnWyjscie
            // 
            btnWyjscie.BackColor = Color.DarkSlateGray;
            btnWyjscie.FlatStyle = FlatStyle.Flat;
            btnWyjscie.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnWyjscie.ForeColor = Color.White;
            btnWyjscie.Location = new Point(747, 235);
            btnWyjscie.Name = "btnWyjscie";
            btnWyjscie.Size = new Size(230, 50);
            btnWyjscie.TabIndex = 3;
            btnWyjscie.Text = "WYJŚCIE";
            btnWyjscie.UseVisualStyleBackColor = false;
            btnWyjscie.Click += btnWyjscie_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 30, 40);
            ClientSize = new Size(1084, 661);
            Controls.Add(btnWyjscie);
            Controls.Add(btnInstrukcja);
            Controls.Add(btnNowaGra);
            Controls.Add(Title);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "E-Mail Please";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Button btnNowaGra;
        private Button btnInstrukcja;
        private Button btnWyjscie;
    }
}
