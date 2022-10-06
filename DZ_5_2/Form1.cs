using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Form2 forma = new Form2();
            if (forma.ShowDialog() == DialogResult.OK){
                productStock.Items.Add(forma.Tovar);
                btnAddList.Enabled = true;
                btnEdit.Enabled = true;
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e){
            if (productStock.SelectedIndex != -1){
                int i = productStock.SelectedIndex;
                Product p = (Product)productStock.Items[i];
                Tovar t = new Tovar(p);
                Form2 forma = new Form2(p);
                if (forma.ShowDialog() == DialogResult.OK)
                {
                    Edit(t, new Tovar(forma.Tovar));
                    productStock.Items[i] = forma.Tovar;
                    if (btnAddList.Enabled == false){
                        btnAddList.Enabled = true;
                        btnEdit.Enabled = true;
                    }
                }
            }
            else
                ErrorBox();
        }

        private void Edit(Tovar p1, Tovar p2){
            if (ProductList.Items.Count == 0) return;
            double d = Convert.ToDouble(allPriceProduct.Text);
            for (int i =0;i< ProductList.Items.Count; i++){
                if ((Tovar)ProductList.Items[i] == p1){
                    ProductList.Items[i] = p2;
                    d -= p1;
                    d += p2;
                }
            }
            allPriceProduct.Text = d.ToString();
        }

        private void ProductStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            priceProduct.Text = ((Tovar)productStock.Items[productStock.SelectedIndex]).Price.ToString();
        }

        private void BtnAddList_Click(object sender, EventArgs e)
        {
            if (productStock.SelectedIndex != -1){
                Tovar t = new Tovar((Product)productStock.Items[productStock.SelectedIndex]);
                ProductList.Items.Add(t);
                if (allPriceProductLabel.Visible == false){
                    allPriceProductLabel.Visible = true;
                    allPriceProductLabel2.Visible = false;
                    allPriceProduct.Visible = true;
                    labelAllPriceProduct.Visible = true;
                }
                double d = Convert.ToDouble(allPriceProduct.Text);
                allPriceProduct.Text = (d + t).ToString();
            }
            else
                ErrorBox();
        }
        private void ErrorBox(){
            MessageBox.Show(
                "Вы не выбрали товар",
                 "Информация",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
        }
    }
}
