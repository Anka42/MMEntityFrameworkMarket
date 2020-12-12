using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMEntityFrameworkMarket
{
    public partial class Form1 : Form
    {
        ProductDal productDal = new ProductDal();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            using (EMarketContext context = new EMarketContext())
            {
                dgwProduct.DataSource = context.Products.ToList();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxSearch.Visible = true;
            pbxSearch.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            productDal.Ekle(new Product {
                Name = tbxName.Text,
                Price = Convert.ToDecimal(tbxPrice.Text),
                StockAmount = Convert.ToDecimal(tbxStockAmount.Text),
                StockAmountType = cbxStockAmountType.Text,
                Category = tbxCategory.Text
            });
            dgwProduct.DataSource = productDal.Listeleme();
            MessageBox.Show("Ürün Eklendi!","Entity Framework Market");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            productDal.Guncelle(new Product {
                Id = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                Price = Convert.ToDecimal(tbxPriceUpdate.Text),
                StockAmount = Convert.ToDecimal(tbxStockAmountUpdate.Text),
                StockAmountType = cbxStockAmountTypeUpdate.Text,
                Category = tbxCategoryUpdate.Text
            });
            dgwProduct.DataSource = productDal.Listeleme();
            MessageBox.Show("Ürün Güncellendi !","Entity Framework Market");
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwProduct.CurrentRow.Cells[1].Value.ToString();
            tbxPriceUpdate.Text = dgwProduct.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmountUpdate.Text = dgwProduct.CurrentRow.Cells[3].Value.ToString();
            cbxStockAmountTypeUpdate.Text = dgwProduct.CurrentRow.Cells[4].Value.ToString();
            tbxCategoryUpdate.Text = dgwProduct.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            productDal.Sil(new Product {
                Id = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
            });
            dgwProduct.DataSource = productDal.Listeleme();
            MessageBox.Show("Ürün Silindi !","Entity Framework Market");
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (cbxSearch.SelectedIndex == 0)
            {
                SearchProducts(tbxSearch.Text);
                void SearchProducts(string key)
                {
                    dgwProduct.DataSource = productDal.Listeleme().Where(p => p.Name.ToLower(new CultureInfo("tr-TR", false)).Contains(key)).ToList();
                }
            }
            else if(cbxSearch.SelectedIndex == 1)
            {
                SearchProducts(tbxSearch.Text);
                void SearchProducts(string key)
                {
                    dgwProduct.DataSource = productDal.Listeleme().Where(p => p.Category.ToLower(new CultureInfo("tr-TR", false)).Contains(key)).ToList();
                }
            }
        }
    }
}
