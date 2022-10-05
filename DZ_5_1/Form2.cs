using System;
using System.IO;
using System.Windows.Forms;

namespace DZ_5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
                textBox_path.Text = folder.SelectedPath;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (textBox_path.Text == "")
                MessageBox.Show("Не выбрана папка для поиска", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (textBoxF2.Text == "")
                MessageBox.Show("Вводите маску поиска", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                try
                {
                    string[] list = Directory.GetFiles(textBox_path.Text, textBoxF2.Text);
                    if (list.Length != 0)
                    {
                        foreach (var item in list)
                        {
                            string[] stroka = item.Split('\\');
                            listBox.Items.Add(stroka[stroka.Length-1]);
                        }
                    }
                    else MessageBox.Show("Файлов не найдено", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Что то пошло не так!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
}
