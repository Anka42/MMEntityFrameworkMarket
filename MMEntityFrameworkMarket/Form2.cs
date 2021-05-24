using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMEntityFrameworkMarket
{
    public partial class Form2 : Form
    {
        public Form1 form1;
        OrderDal orderDal = new OrderDal();
        ProductDal productDal = new ProductDal();
        GetOrderDal getOrderDal = new GetOrderDal();

        public Form2()
        {
            InitializeComponent();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            lblİsimOrder.Text = form1.lblİsim.Text;
            lblSiparisTutarOrder.Text = form1.lblSiparisTutar.Text;
            dgwListeOrder.DataSource = orderDal.Listeleme();
            if (Convert.ToDecimal(lblSiparisTutarOrder.Text) >= 50)
            {
                decimal a = 0.00m;
                lblKargo.Text = Convert.ToString(a);
            }
            else
            {
                decimal b = 9.90m;
                lblKargo.Text = Convert.ToString(b);
            }
            lblToplamUcret.Text = Convert.ToString(Convert.ToDecimal(lblKargo.Text) + Convert.ToDecimal(lblSiparisTutarOrder.Text));
            //FisYazdirmaKodSatiri
            tbxFis.Text = "  Ürün İsmi            " + "Miktarı         " + "Fiyatı | \n";
            for (int i = 0; i < dgwListeOrder.Rows.Count; i++)
            {
                tbxFis.Text = tbxFis.Text + "\n    " + dgwListeOrder.Rows[i].Cells[1].Value.ToString() + "                " + dgwListeOrder.Rows[i].Cells[2].Value.ToString() + "               " + dgwListeOrder.Rows[i].Cells[3].Value.ToString() + " | ";
            }
            tbxFis.Text = tbxFis.Text + "\n" + "--------------------------------------------------------------------\n ";
            tbxFis.Text = tbxFis.Text + "Ürün Toplamı  :" + "                         " + lblSiparisTutarOrder.Text + " | \n ";
            tbxFis.Text = tbxFis.Text + "Kargo              :" + "                          " + lblKargo.Text + " | \n ";
            tbxFis.Text = tbxFis.Text + "Toplam Fiyat   :" + "                        " + lblToplamUcret.Text + " | \n";

        }
        private void btnOrderSend_Click(object sender, EventArgs e)
        {
            int cardNo = tbxCustomerCardNumberOrder.TextLength;
            int cvc = tbxCvc.TextLength;
            if (lblCode.Text == tbxCode.Text && cardNo == 16 && cvc == 3)
            {
                getOrderDal.Ekle(new GetOrder
                {
                    CustomerName = lblİsimOrder.Text,
                    CustomerAddress = tbxAdresOrder.Text,
                    CustomerCardNumber = tbxCustomerCardNumberOrder.Text,
                    CustomerCvc = tbxCvc.Text,
                    CustomerOrderContent = tbxFis.Text,
                    CustomerCode = tbxCode.Text
                });

                for (int i = 0; i < dgwListeOrder.Rows.Count; i++)
                {
                    for (int j = 0; j < form1.dgwProduct.Rows.Count; j++)
                    {
                        if (Convert.ToString(dgwListeOrder.Rows[i].Cells[1].Value) == Convert.ToString(form1.dgwProduct.Rows[j].Cells[1].Value))
                        {
                            productDal.Guncelle(new Product
                            {
                                Id = Convert.ToInt32(form1.dgwProduct.Rows[j].Cells[0].Value),
                                Name = Convert.ToString(form1.dgwProduct.Rows[j].Cells[1].Value),
                                Price = Convert.ToDecimal(form1.dgwProduct.Rows[j].Cells[2].Value),
                                StockAmount = Convert.ToInt32(form1.dgwProduct.Rows[j].Cells[3].Value) - Convert.ToInt32(dgwListeOrder.Rows[i].Cells[2].Value),
                                StockAmountType = Convert.ToString(form1.dgwProduct.Rows[j].Cells[4].Value),
                                Category = Convert.ToString(form1.dgwProduct.Rows[j].Cells[5].Value)
                            });
                        }
                    }
                }
                form1.dgwProduct.DataSource = productDal.Listeleme();

                //Silme ve Temizleme kodları
                for (int i = 0; i < dgwListeOrder.Rows.Count; i++)
                {
                    orderDal.Sil(new Order
                    {
                        id = Convert.ToInt32(dgwListeOrder.Rows[i].Cells[0].Value)
                    });
                }
                dgwListeOrder.DataSource = orderDal.Listeleme();
                lblİsimOrder.Text = "";
                tbxAdresOrder.Text = "";
                tbxCustomerCardNumberOrder.Text = "";
                tbxCvc.Text = "";
                tbxFis.Text = "";
                tbxCode.Text = "";
                lblSiparisTutarOrder.Text = "";
                lblKargo.Text = "";
                lblToplamUcret.Text = "";
                lblCode.Text = "";
                MessageBox.Show("Siparişiniz Alındı.", "MMEntityFrameworkMarket");
            }
            else
            {
                MessageBox.Show("Onay kodunuz hatalı girdiniz!!!","MMEntityFrameworkMarket");
            }
            this.Close();
        }

        private void tbxCustomerCardNumberOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbxCvc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnGetCode_Click(object sender, EventArgs e)
        {
            int cardNo = tbxCustomerCardNumberOrder.TextLength;
            int cvc = tbxCvc.TextLength;
            if (cardNo == 16 && cvc == 3)
            {
                tbxFis.Visible = true;
                grpOnay.Visible = true;
                Random random = new Random();
                lblCode.Text = Convert.ToString(random.Next(100000, 999999));
            }
            else
            {
                MessageBox.Show("Kart numaranız veya Cvc güvenlik kodunuz eksik olabilir!");
            }
        }
    }
}
