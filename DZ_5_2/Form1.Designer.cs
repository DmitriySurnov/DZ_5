namespace DZ_5_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProductList = new System.Windows.Forms.ListBox();
            this.allPriceProductLabel2 = new System.Windows.Forms.Label();
            this.allPriceProductLabel = new System.Windows.Forms.Label();
            this.groupBoxProduct = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productStock = new System.Windows.Forms.ComboBox();
            this.priceProduct = new System.Windows.Forms.TextBox();
            this.btnAddList = new System.Windows.Forms.Button();
            this.labelAllPriceProduct = new System.Windows.Forms.Label();
            this.allPriceProduct = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxProduct.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductList
            // 
            this.ProductList.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ProductList.ColumnWidth = 290;
            this.ProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductList.FormattingEnabled = true;
            this.ProductList.IntegralHeight = false;
            this.ProductList.ItemHeight = 20;
            this.ProductList.Location = new System.Drawing.Point(-1, 32);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(317, 318);
            this.ProductList.TabIndex = 1;
            // 
            // allPriceProductLabel2
            // 
            this.allPriceProductLabel2.AutoSize = true;
            this.allPriceProductLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allPriceProductLabel2.Location = new System.Drawing.Point(322, 29);
            this.allPriceProductLabel2.Name = "allPriceProductLabel2";
            this.allPriceProductLabel2.Size = new System.Drawing.Size(171, 20);
            this.allPriceProductLabel2.TabIndex = 14;
            this.allPriceProductLabel2.Text = "Товаров в списке нет";
            // 
            // allPriceProductLabel
            // 
            this.allPriceProductLabel.AutoSize = true;
            this.allPriceProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allPriceProductLabel.Location = new System.Drawing.Point(322, 9);
            this.allPriceProductLabel.Name = "allPriceProductLabel";
            this.allPriceProductLabel.Size = new System.Drawing.Size(183, 20);
            this.allPriceProductLabel.TabIndex = 13;
            this.allPriceProductLabel.Text = "Цена товаров в списке";
            this.allPriceProductLabel.Visible = false;
            // 
            // groupBoxProduct
            // 
            this.groupBoxProduct.Controls.Add(this.label1);
            this.groupBoxProduct.Controls.Add(this.productStock);
            this.groupBoxProduct.Controls.Add(this.priceProduct);
            this.groupBoxProduct.Controls.Add(this.btnAddList);
            this.groupBoxProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxProduct.Location = new System.Drawing.Point(321, 94);
            this.groupBoxProduct.Name = "groupBoxProduct";
            this.groupBoxProduct.Size = new System.Drawing.Size(184, 152);
            this.groupBoxProduct.TabIndex = 15;
            this.groupBoxProduct.TabStop = false;
            this.groupBoxProduct.Text = "Товары";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "руб.";
            // 
            // productStock
            // 
            this.productStock.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.productStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productStock.FormattingEnabled = true;
            this.productStock.Location = new System.Drawing.Point(21, 29);
            this.productStock.Name = "productStock";
            this.productStock.Size = new System.Drawing.Size(144, 28);
            this.productStock.TabIndex = 4;
            this.productStock.SelectedIndexChanged += new System.EventHandler(this.ProductStock_SelectedIndexChanged);
            // 
            // priceProduct
            // 
            this.priceProduct.Enabled = false;
            this.priceProduct.Location = new System.Drawing.Point(21, 56);
            this.priceProduct.Name = "priceProduct";
            this.priceProduct.ReadOnly = true;
            this.priceProduct.Size = new System.Drawing.Size(114, 26);
            this.priceProduct.TabIndex = 3;
            this.priceProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddList
            // 
            this.btnAddList.Enabled = false;
            this.btnAddList.Location = new System.Drawing.Point(21, 88);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(144, 53);
            this.btnAddList.TabIndex = 6;
            this.btnAddList.Text = "Добавить в список";
            this.btnAddList.UseVisualStyleBackColor = true;
            this.btnAddList.Click += new System.EventHandler(this.BtnAddList_Click);
            // 
            // labelAllPriceProduct
            // 
            this.labelAllPriceProduct.AutoSize = true;
            this.labelAllPriceProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAllPriceProduct.Location = new System.Drawing.Point(446, 66);
            this.labelAllPriceProduct.Name = "labelAllPriceProduct";
            this.labelAllPriceProduct.Size = new System.Drawing.Size(38, 20);
            this.labelAllPriceProduct.TabIndex = 17;
            this.labelAllPriceProduct.Text = "руб.";
            this.labelAllPriceProduct.Visible = false;
            // 
            // allPriceProduct
            // 
            this.allPriceProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allPriceProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allPriceProduct.Location = new System.Drawing.Point(326, 66);
            this.allPriceProduct.Name = "allPriceProduct";
            this.allPriceProduct.ReadOnly = true;
            this.allPriceProduct.Size = new System.Drawing.Size(114, 19);
            this.allPriceProduct.TabIndex = 16;
            this.allPriceProduct.Text = "0";
            this.allPriceProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.allPriceProduct.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(326, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 98);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Действия";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(21, 28);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 27);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить товар";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(21, 61);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(144, 28);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Редактировать товар";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(-1, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Список товаров";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 359);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelAllPriceProduct);
            this.Controls.Add(this.allPriceProduct);
            this.Controls.Add(this.groupBoxProduct);
            this.Controls.Add(this.allPriceProductLabel2);
            this.Controls.Add(this.allPriceProductLabel);
            this.Controls.Add(this.ProductList);
            this.Name = "Form1";
            this.Text = "Учет продаж";
            this.groupBoxProduct.ResumeLayout(false);
            this.groupBoxProduct.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ProductList;
        private System.Windows.Forms.Label allPriceProductLabel2;
        private System.Windows.Forms.Label allPriceProductLabel;
        private System.Windows.Forms.GroupBox groupBoxProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox productStock;
        private System.Windows.Forms.TextBox priceProduct;
        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.Label labelAllPriceProduct;
        private System.Windows.Forms.TextBox allPriceProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label2;
    }
}

