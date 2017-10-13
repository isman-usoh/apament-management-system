using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Apartment.UI.Dialog
{
    public partial class InputDialog : Form
    {
        string input_text;

        public string ResultText
        {
            get { return input_text; }
            private set { input_text = value; }
        }

        public InputDialog(string title, string textbox_string)
        {
            InitializeComponent();
            this.Text = title;
            this.txtInput.Text = textbox_string;
        }

        public InputDialog()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ResultText = txtInput.Text.Trim();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            if (txtInput.Text.Trim().Length > 0)
            {
                btnOk.Enabled = true;
            }
            else
            {
                btnOk.Enabled = false;
            }
        }

        private void InputDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
