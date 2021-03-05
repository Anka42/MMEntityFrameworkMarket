using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMEntityFrameworkMarket
{
    public partial class Form2 : Form
    {
        public Form1 form1;
        OrderDal orderDal = new OrderDal();
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbxFis.Text = "Ürün " + "Sayı " + "Fiyat \n";
            for (int i = 0; i < dgwListeOrder.Rows.Count; i++)
            {
                tbxFis.Text =  "\n |" +dgwListeOrder.Rows[i].Cells[1].Value.ToString() + " | " + dgwListeOrder.Rows[i].Cells[2].Value.ToString() + " | " + dgwListeOrder.Rows[i].Cells[3].Value.ToString() + " | \n";
            }
        }
    }
}
