using System;
using System.Windows.Forms;

namespace DZ_5_3
{
    public partial class Form2 : Form
    {
        TextBox Textbox;
        public Form2()
        {
            InitializeComponent();
        }

        public void Show(TextBox Textbox)
        {
            this.Textbox = Textbox;
            textBoxWriterFile.Text = Textbox.Text;
            Show();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Textbox.Text = textBoxWriterFile.Text;
            Close();
        }
    }
}
