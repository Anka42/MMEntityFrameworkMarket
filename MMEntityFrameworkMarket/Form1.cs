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
        UserDal userDal = new UserDal();
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

            tbxName.Text = "";
            tbxPrice.Text = "";
            tbxStockAmount.Text = "";
            cbxStockAmountType.SelectedItem = null;
            tbxCategory.Text = "";
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


            tbxNameUpdate.Text = "";
            tbxPriceUpdate.Text = "";
            tbxStockAmountUpdate.Text = "";
            cbxStockAmountTypeUpdate.SelectedItem = null;
            tbxCategoryUpdate.Text = "";
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwProduct.CurrentRow.Cells[1].Value.ToString();
            tbxPriceUpdate.Text = dgwProduct.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmountUpdate.Text = dgwProduct.CurrentRow.Cells[3].Value.ToString();
            cbxStockAmountTypeUpdate.Text = dgwProduct.CurrentRow.Cells[4].Value.ToString();
            tbxCategoryUpdate.Text = dgwProduct.CurrentRow.Cells[5].Value.ToString();

            grpPreview.Visible = true;
            btnRemove.Visible = true;

            lblName.Text = dgwProduct.CurrentRow.Cells[1].Value.ToString();
            lblPrice.Text = dgwProduct.CurrentRow.Cells[2].Value.ToString();
            

            lblStockAmount.Text = dgwProduct.CurrentRow.Cells[3].Value.ToString();
            lblStockAmountType.Text = dgwProduct.CurrentRow.Cells[4].Value.ToString();

            lblCategory.Text = dgwProduct.CurrentRow.Cells[5].Value.ToString();
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

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            grpPreview.Visible = false;
            btnRemove.Visible = false;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            grpPreview.Visible = false;
            btnRemove.Visible = false;

            tbxName.Text = "";
            tbxPrice.Text = "";
            tbxStockAmount.Text = "";
            cbxStockAmountType.SelectedItem = null;
            tbxCategory.Text = "";

            tbxNameUpdate.Text = "";
            tbxPriceUpdate.Text = "";
            tbxStockAmountUpdate.Text = "";
            cbxStockAmountTypeUpdate.SelectedItem = null;
            tbxCategoryUpdate.Text = "";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            grpRegister.Visible = true;
        }

        private void btnRegister2_Click(object sender, EventArgs e)
        {
            if (tbxPassword.Text == tbxPasswordRepeat.Text)
            {
                pbxTik.Visible = true;
                userDal.Ekle(new User
                {
                    FirstName = tbxFirstName.Text,
                    LastName = tbxLastName.Text,
                    UserName = tbxUserName.Text,
                    Password = tbxPassword.Text,
                    Authority = cbxAuthority.Text
                });
                MessageBox.Show("Üye Olundu!");
            }
            else
            {
                MessageBox.Show("Şifreler Aynı Değil!");
            }
        }

        private void pbxGozKapali_Click(object sender, EventArgs e)
        {
            tbxPassword.PasswordChar = '*';
            tbxPasswordRepeat.PasswordChar = '*';
            pbxGozKapali.Visible = false;
            pbxGoz.Visible = true;
        }

        private void pbxGoz_Click(object sender, EventArgs e)
        {
            tbxPassword.PasswordChar = '\0';
            tbxPasswordRepeat.PasswordChar = '\0';
            pbxGoz.Visible = false;
            pbxGozKapali.Visible = true;
        }
    }
}
