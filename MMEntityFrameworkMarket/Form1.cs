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
using System.IO;

namespace MMEntityFrameworkMarket
{
    public partial class Form1 : Form
    {
        ProductDal productDal = new ProductDal();
        OrderDal orderDal = new OrderDal();
        UserDal userDal = new UserDal();
        User user = new User();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 817;
            using (EMarketContext context = new EMarketContext())
            {
                dgwProduct.DataSource = context.Products.ToList();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (lblİsim.Visible == true)
            {
                MessageBox.Show(lblİsim.Text + " Lütfen oturumunuzu kapatarak çıkış yapınız !", "Oturum Açık !");
            }
            else { this.Close(); }
        }

        private void cbxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxSearch.Visible = true;
            pbxSearch.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            productDal.Ekle(new Product
            {
                Name = tbxName.Text,
                Price = Convert.ToDecimal(tbxPrice.Text),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text),
                StockAmountType = cbxStockAmountType.Text,
                Category = tbxCategory.Text
            });
            dgwProduct.DataSource = productDal.Listeleme();
            MessageBox.Show("Ürün Eklendi!", "Entity Framework Market");

            tbxName.Text = "";
            tbxPrice.Text = "";
            tbxStockAmount.Text = "";
            cbxStockAmountType.SelectedItem = null;
            tbxCategory.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            productDal.Guncelle(new Product
            {
                Id = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                Price = Convert.ToDecimal(tbxPriceUpdate.Text),
                StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text),
                StockAmountType = cbxStockAmountTypeUpdate.Text,
                Category = tbxCategoryUpdate.Text
            });
            dgwProduct.DataSource = productDal.Listeleme();
            MessageBox.Show("Ürün Güncellendi !", "Entity Framework Market");


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
            if (lblYetki.Text == "Yetkili")
            {
                btnRemove.Visible = true;
            }

            lblName.Text = dgwProduct.CurrentRow.Cells[1].Value.ToString();
            lblPrice.Text = dgwProduct.CurrentRow.Cells[2].Value.ToString();
            lblStockAmount.Text = dgwProduct.CurrentRow.Cells[3].Value.ToString();
            lblStockAmountType.Text = dgwProduct.CurrentRow.Cells[4].Value.ToString();
            lblCategory.Text = dgwProduct.CurrentRow.Cells[5].Value.ToString();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            productDal.Sil(new Product
            {
                Id = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
            });
            dgwProduct.DataSource = productDal.Listeleme();
            MessageBox.Show("Ürün Silindi !", "Entity Framework Market");
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
            else if (cbxSearch.SelectedIndex == 1)
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

            lblSepetName.Text = "";
            lblSepetPrice.Text = "";
            lblSepetStockAmount.Text = "";
            lblSepetStockAmountType.Text = "";
            lblToplamFiyat.Text = "";
            grpSepet.Visible = false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            grpRegister.Visible = true;
            grpLogin.Visible = false;
            this.Width = 1169;

        }

        private void btnRegister2_Click(object sender, EventArgs e)
        {

            if (tbxPassword.Text == tbxPasswordRepeat.Text)
            {
                if (tbxPassword.Text.Length < 8)
                {
                    MessageBox.Show("Şifreniz En Az 8 Karakter Olmalı!");
                }
                else if (cbxAuthority.SelectedIndex == 0)
                {
                    MessageBox.Show("Hata Kodu: 0xMAMS6SS40345842 \n Lütfen Uygulama Yöneticileri İle İletişime Geçiniz.");
                }
                else
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
            }
            else
            {
                MessageBox.Show("Şifreler Aynı Değil!");
            }


            tbxFirstName.Text = "";
            tbxLastName.Text = "";
            tbxUserName.Text = "";
            tbxPassword.Text = "";
            tbxPasswordRepeat.Text = "";
            pbxGozKapali.Visible = false;
            cbxAuthority.SelectedItem = null;
            pbxTik.Visible = false;

            grpRegister.Visible = false;
            grpLogin.Visible = true;


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

        private void pbxGozAcik2_Click(object sender, EventArgs e)
        {
            tbxPasswordLogin.PasswordChar = '\0';
            pbxGozAcik2.Visible = false;
            pbxGozKapali2.Visible = true;
        }

        private void pbxGozKapali2_Click(object sender, EventArgs e)
        {
            tbxPasswordLogin.PasswordChar = '*';
            pbxGozKapali2.Visible = false;
            pbxGozAcik2.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            grpRegister.Visible = false;
            grpLogin.Visible = true;
            this.Width = 1169;

        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            grpLogin.Visible = true;
            grpRegister.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            grpRegister.Visible = true;
            grpLogin.Visible = false;
        }

        private void btnLogin2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MMEntityFrameworkMarket\MMEntityFrameworkMarket\App_Data\ProductMM.mdf;Integrated Security=True");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Select * from Users where UserName='" + tbxUserNameLogin.Text + "'and Password='" + tbxPasswordLogin.Text + "'", connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                lblMesaj.Visible = true;
                lblİsim.Visible = true;
                lblYetki.Visible = true;
                lblİsim.Text = (string)reader["FirstName"] + "  " + (string)reader["LastName"];
                lblYetki.Text = (string)reader["Authority"];
                if (lblYetki.Text == "Yetkili")
                {
                    grpProduct.Visible = true;
                    grpUpdate.Visible = true;
                    grpLogin.Visible = false;

                    btnClean.Visible = true;
                    btnRemove.Visible = true;
                    btnRegister.Visible = false;
                    btnLogin.Visible = false;
                    btnCikis.Visible = true;
                }
                else if (lblYetki.Text == "Müsteri")
                {
                    lblMesaj.Visible = true;
                    lblİsim.Visible = true;
                    lblYetki.Visible = true;
                    grpProduct.Visible = false;
                    grpUpdate.Visible = false;
                    btnClean.Visible = true;
                    btnRemove.Visible = false;
                    btnRegister.Visible = false;
                    btnLogin.Visible = false;
                    btnOrder.Visible = true;
                    btnCikis.Visible = true;
                }

            }
            else { MessageBox.Show("Kullanıcı Adınız veya Şifreniz Hatalı!", "Hata"); }
            connection.Close();
            grpLogin.Visible = false;
            grpRegister.Visible = false;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            if (lblYetki.Text == "Müsteri")
            {
                dialog = MessageBox.Show("Eğer sipariş bölümünüz dolu ise silinecektir ! Devam edilsin mi ?", "Uyarı", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    lblYetki.Text = " ";
                    lblİsim.Visible = false;
                    lblMesaj.Visible = false;
                    grpLogin.Visible = false;
                    grpRegister.Visible = false;
                    btnClean.Visible = false;
                    grpProduct.Visible = false;
                    grpUpdate.Visible = false;
                    btnRemove.Visible = false;
                    btnOrder.Visible = false;

                    btnRegister.Visible = true;
                    btnLogin.Visible = true;

                    tbxUserNameLogin.Text = "";
                    tbxPasswordLogin.Text = "";

                    btnCikis.Visible = false;
                    this.Width = 817;
                    //Sepet temizleme
                    lblSepetName.Text = "";
                    lblSepetPrice.Text = "";
                    lblSepetStockAmount.Text = "";
                    lblSepetStockAmountType.Text = "";
                    lblToplamFiyat.Text = "";
                    grpSepet.Visible = false;
                    for (int i = 0; i < dgwOrder.Rows.Count; i++)
                    {
                        orderDal.Sil(new Order
                        {
                            id = Convert.ToInt32(dgwOrder.Rows[i].Cells[0].Value)
                        });
                    }
                    dgwOrder.DataSource = orderDal.Listeleme();
                    grpSiparis.Visible = false;
                }
                else if (dialog == DialogResult.No)
                {
                    
                }
            }
            
            else {
                lblYetki.Text = " ";
                lblİsim.Visible = false;
                lblMesaj.Visible = false;
                grpLogin.Visible = false;
                grpRegister.Visible = false;
                btnClean.Visible = false;
                grpProduct.Visible = false;
                grpUpdate.Visible = false;
                btnRemove.Visible = false;
                btnOrder.Visible = false;

                btnRegister.Visible = true;
                btnLogin.Visible = true;

                tbxUserNameLogin.Text = "";
                tbxPasswordLogin.Text = "";

                btnCikis.Visible = false;
                this.Width = 817;
            }    
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            grpSepet.Visible = true;
            lblSepetName.Text = dgwProduct.CurrentRow.Cells[1].Value.ToString();
            lblSepetPrice.Text = dgwProduct.CurrentRow.Cells[2].Value.ToString();
            lblSepetStockAmount.Text = Convert.ToString(1);
            lblSepetStockAmountType.Text = dgwProduct.CurrentRow.Cells[4].Value.ToString();
            lblToplamFiyat.Text = dgwProduct.CurrentRow.Cells[2].Value.ToString();
        }

        private void pbxArti_Click(object sender, EventArgs e)
        {
            if (lblSepetName.Text == dgwProduct.CurrentRow.Cells[1].Value.ToString())
            {
                if (Convert.ToInt32(dgwProduct.CurrentRow.Cells[3].Value.ToString()) > Convert.ToInt32(lblSepetStockAmount.Text))
                {
                    int a = Convert.ToInt32(lblSepetStockAmount.Text) + 1;
                    lblSepetStockAmount.Text = Convert.ToString(a);

                    decimal b = Convert.ToDecimal(lblSepetPrice.Text) * Convert.ToInt32(lblSepetStockAmount.Text);
                    lblToplamFiyat.Text = Convert.ToString(b);
                }
                else { MessageBox.Show("Stok sınırına ulaşıldı! Lütfen geçerli stok sayısı kadar sipariş veriniz. ", "Uyarı"); }
            }
        }

        private void pbxEksi_Click(object sender, EventArgs e)
        {
            if (lblSepetName.Text == dgwProduct.CurrentRow.Cells[1].Value.ToString())
            {
                if (0 < Convert.ToInt32(lblSepetStockAmount.Text))
                {
                    int a = Convert.ToInt32(lblSepetStockAmount.Text) - 1;
                    lblSepetStockAmount.Text = Convert.ToString(a);

                    decimal b = Convert.ToDecimal(lblSepetPrice.Text) * Convert.ToInt32(lblSepetStockAmount.Text);
                    lblToplamFiyat.Text = Convert.ToString(b);
                }
                else { MessageBox.Show("Geçersiz stok! Lütfen geçerli stok sayısı kadar sipariş veriniz. ", "Uyarı"); }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            int a = 0;
            grpSiparis.Visible = true;
            dgwOrder.DataSource = orderDal.Listeleme();
            for (int i = 0; i < dgwOrder.Rows.Count; i++)
            {
                if (Convert.ToString(lblSepetName.Text) == Convert.ToString(dgwOrder.Rows[i].Cells[1].Value))
                {
                    orderDal.Guncelle(new Order {
                        id = Convert.ToInt32(dgwOrder.Rows[i].Cells[0].Value),
                        OrderName = lblSepetName.Text,
                        OrderPrice = Convert.ToDecimal(lblToplamFiyat.Text) + Convert.ToDecimal(dgwOrder.Rows[i].Cells[3].Value),
                        OrderAmount = Convert.ToInt32(dgwOrder.Rows[i].Cells[2].Value) + Convert.ToInt32(lblSepetStockAmount.Text),
                        OrderStatus = "Siparişe Hazır !"
                    });
                    a = 1;
                }
            }
            dgwOrder.DataSource = orderDal.Listeleme();
            if (a == 0)
            {
                orderDal.Ekle(new Order
                {
                    OrderName = lblSepetName.Text,
                    OrderPrice = Convert.ToDecimal(lblToplamFiyat.Text),
                    OrderAmount = Convert.ToInt32(lblSepetStockAmount.Text),
                    OrderStatus = "Siparişe Hazır !"
                });
                dgwOrder.DataSource = orderDal.Listeleme();         
            }

            lblSiparisTutar.Text = Convert.ToString(Convert.ToDecimal(lblToplamFiyat.Text) + Convert.ToDecimal(lblSiparisTutar.Text));
            MessageBox.Show("Siparişe Hazır !", "Entity Framework Market");

            lblSepetName.Text = "";
            lblSepetPrice.Text = "";
            lblSepetStockAmount.Text = "";
            lblSepetStockAmountType.Text = "";
            lblToplamFiyat.Text = "";
        }

        private void btnGetOrder_Click(object sender, EventArgs e)
        {
        //    productDal.Guncelle(new Product
        //    {
        //        Id = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
        //        Name = tbxNameUpdate.Text,
        //        Price = Convert.ToDecimal(tbxPriceUpdate.Text),
        //        StockAmount = Convert.ToInt32(dgwProduct.CurrentRow.Cells[3].Value) - Convert.ToInt32(lblSepetStockAmount.Text),
        //        StockAmountType = cbxStockAmountTypeUpdate.Text,
        //        Category = tbxCategoryUpdate.Text
        //    });
        }

        private void btnOrderRemoveAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgwOrder.Rows.Count ; i++)
            {
                orderDal.Sil(new Order
                {
                    id = Convert.ToInt32(dgwOrder.Rows[i].Cells[0].Value)
                });
            }
            dgwOrder.DataSource = orderDal.Listeleme();
            MessageBox.Show("Tüm Siparişler Silindi !", "Entity Framework Market");
        }

        private void btnOrderRemove_Click(object sender, EventArgs e)
        {
            orderDal.Sil(new Order
            {
                id = Convert.ToInt32(dgwOrder.CurrentRow.Cells[0].Value)
            });
            dgwOrder.DataSource = orderDal.Listeleme();
            MessageBox.Show("Seçili Sipariş Silindi !", "Entity Framework Market");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (lblİsim.Visible == true)
            {
                MessageBox.Show(lblİsim.Text + " Lütfen oturumunuzu kapatarak çıkış yapınız !", "Oturum Açık !");
            }
            else { this.Close(); }
        }
    }
}
