using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace E_Mail_Please
{
    public partial class FormInstrukcja : Form
    {
        public FormInstrukcja()
        {
            InitializeComponent();
        }
        private void btnPowrot_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
