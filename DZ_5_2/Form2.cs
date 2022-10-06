using System;
using System.Windows.Forms;

namespace DZ_5_2
{
    public partial class Form2 : Form
    {
        public Product Tovar { get; private set; } = null;

        public Form2()
        {
            InitializeComponent();
            Text = "Добавление товара";
        }

        public Form2(Product p)
        {
            InitializeComponent();
            Text = "Редактировать товар";
            Tovar = p;
            textBox_Name.Text= Tovar.Name;
            textBox_specification.Text = Tovar.Specification;
            textBox_description.Text = Tovar.Description;
            textBox_Price.Text = Tovar.Price.ToString();
        }

        private void BtnEditAddF2_Click(object sender, EventArgs e)
        {
            if (textBox_Name.Text == "")
                ErrorBox("Название товара");
            else if (textBox_specification.Text == "")
                ErrorBox("Характеристика товара");
            else if (textBox_description.Text == "")
                ErrorBox("Описание товара");
            else
            {
                if (Tovar == (object)null)
                    Tovar = new Product();
                Tovar.Name = textBox_Name.Text;
                Tovar.Specification = textBox_specification.Text;
                Tovar.Description = textBox_description.Text;
                try
                {
                    Tovar.Price = Convert.ToDouble(textBox_Price.Text);
                    if (Tovar.Price == 0) throw new Exception();
                }
                catch (Exception)
                {
                    ErrorBox("Стоимость товара");
                    return;
                }
                DialogResult = DialogResult.OK;
            } 
        }

        private void BtnCancelF2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ErrorBox(string namePolia)
        {
            MessageBox.Show(
                   "Вы не заполнили поле или заполнено нероректно'" + namePolia + "'",
                   "Ошибка",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
        }
    }
}
