using ProductLib;
using ProductLib.Model;
using ProductLib.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR3
{
    
    public partial class MainForm : Form, IProductView
    {
        private ProductPresenter presenter_;
        public MainForm()
        {
            InitializeComponent();
            presenter_ = new ProductPresenter(new CsvProductModel(), this);

        }
        public void ShowCategories(List<string> categories)
        {
            CategoriesListBox.DataSource = categories;
        }
        public void ShowDrugsInCategory(List<Product> product)
        {
            ProductComboBox.DataSource = null;
            ProductComboBox.DataSource = product;
            ProductComboBox.DisplayMember = "Name";
        }

        public void ShowDrugDetails(Product product)
        {
            PriceLabel.Text = product.Price;
            ManufacturerLabel.Text = product.Manufacturer;
            DateLabel.Text = product.Date;
            ProviderLabel.Text = product.Provider;
            try
            {
                DrugPictureBox.Load(product.ImagePath);
            }
            catch
            {}
        }
        public void ShowOrderSummary(Dictionary<string, int> orderItems)
        {
            string orderText = "Ваш заказ:\n";
            foreach (var item in orderItems)
            {
                orderText += $"{item.Key}: {item.Value} шт.\n";
            }
            MessageBox.Show(orderText, "Текущий заказ");
        }
        public string GetSelectedCategory()
        {
            return CategoriesListBox.SelectedItem?.ToString();
        }
        public Product GetSelectedDrug()
        {
            return ProductComboBox.SelectedItem as Product;
        }
        public int GetOrderQuantity()
        {
            return (int)QuantityNumericUpDown.Value;
        }
        private void CategoriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            presenter_.CategorySelected();
        }
        private void ProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            presenter_.DrugSelected();
        }
        private void OrderButton_Click(object sender, EventArgs e)
        {
            presenter_.AddToOrder();
        }
    }
}
