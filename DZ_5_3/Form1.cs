using System;
using System.IO;
using System.Windows.Forms;

namespace DZ_5_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 Form = null;

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All Files(*.*)|*.*|Text File (*.txt) | *.txt || ";
            open.FilterIndex = 1;
            if (open.ShowDialog() == DialogResult.OK){
                StreamReader reader =
                File.OpenText(open.FileName);
                textBoxReadFile.Text = reader.ReadToEnd();
                reader.Close();
                btnEdit.Enabled = true;
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (Form != null){
                Form.Close();
                Form = null;
            }
            Form = new Form2();
            Form.Show(textBoxReadFile);
        }
    }
}
