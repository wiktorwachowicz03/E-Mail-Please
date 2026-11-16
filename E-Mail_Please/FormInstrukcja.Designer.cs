namespace E_Mail_Please
{
    partial class FormInstrukcja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInstrukcja));
            labelInstrukcja = new Label();
            btnPowrot = new Button();
            SuspendLayout();
            // 
            // labelInstrukcja
            // 
            labelInstrukcja.Font = new Font("Segoe UI", 13F);
            labelInstrukcja.ForeColor = Color.White;
            labelInstrukcja.Location = new Point(12, 9);
            labelInstrukcja.Name = "labelInstrukcja";
            labelInstrukcja.Size = new Size(651, 435);
            labelInstrukcja.TabIndex = 0;
            labelInstrukcja.Text = resources.GetString("labelInstrukcja.Text");
            labelInstrukcja.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnPowrot
            // 
            btnPowrot.BackColor = Color.Maroon;
            btnPowrot.FlatStyle = FlatStyle.Flat;
            btnPowrot.ForeColor = Color.White;
            btnPowrot.Location = new Point(492, 454);
            btnPowrot.Name = "btnPowrot";
            btnPowrot.Size = new Size(180, 45);
            btnPowrot.TabIndex = 1;
            btnPowrot.Text = "POWRÓT";
            btnPowrot.UseVisualStyleBackColor = false;
            btnPowrot.Click += this.btnPowrot_Click;
            // 
            // FormInstrukcja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(684, 511);
            Controls.Add(btnPowrot);
            Controls.Add(labelInstrukcja);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormInstrukcja";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "E-MAIL PLEASE - Instrukcja";
            ResumeLayout(false);
        }

        #endregion

        private Label labelInstrukcja;
        private Button btnPowrot;
    }
}