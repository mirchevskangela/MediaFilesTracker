using System;
using System.Windows.Forms;

namespace detectVideoApp
{
    public partial class WarningDialog : Form
    {

        public string Text { get; set; }
        public WarningDialog(string text)
        {
            InitializeComponent();
            this.Text = text;
        }

        private void WarningDialog_Load(object sender, EventArgs e)
        {
            mWarningTxt.Text = Text;
        }

        private void mWarningTxt_Click(object sender, EventArgs e)
        {

        }
    }
}
