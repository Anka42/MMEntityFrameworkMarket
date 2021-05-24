
namespace MMEntityFrameworkMarket
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.lblİsimOrder = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxAdresOrder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxCustomerCardNumberOrder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxCvc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.grpOnay = new System.Windows.Forms.GroupBox();
            this.btnOrderSend = new System.Windows.Forms.Button();
            this.tbxCode = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgwListeOrder = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSiparisTutarOrder = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblKargo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblToplamUcret = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbxFis = new System.Windows.Forms.RichTextBox();
            this.btnGetCode = new System.Windows.Forms.Button();
            this.grpOnay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListeOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad : ";
            // 
            // lblİsimOrder
            // 
            this.lblİsimOrder.AutoSize = true;
            this.lblİsimOrder.Location = new System.Drawing.Point(144, 113);
            this.lblİsimOrder.Name = "lblİsimOrder";
            this.lblİsimOrder.Size = new System.Drawing.Size(0, 13);
            this.lblİsimOrder.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adres : ";
            // 
            // tbxAdresOrder
            // 
            this.tbxAdresOrder.Location = new System.Drawing.Point(138, 146);
            this.tbxAdresOrder.Multiline = true;
            this.tbxAdresOrder.Name = "tbxAdresOrder";
            this.tbxAdresOrder.Size = new System.Drawing.Size(157, 60);
            this.tbxAdresOrder.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kart Numarası : ";
            // 
            // tbxCustomerCardNumberOrder
            // 
            this.tbxCustomerCardNumberOrder.Location = new System.Drawing.Point(138, 224);
            this.tbxCustomerCardNumberOrder.MaxLength = 16;
            this.tbxCustomerCardNumberOrder.Name = "tbxCustomerCardNumberOrder";
            this.tbxCustomerCardNumberOrder.Size = new System.Drawing.Size(157, 20);
            this.tbxCustomerCardNumberOrder.TabIndex = 5;
            this.tbxCustomerCardNumberOrder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCustomerCardNumberOrder_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cvc : ";
            // 
            // tbxCvc
            // 
            this.tbxCvc.Location = new System.Drawing.Point(193, 263);
            this.tbxCvc.MaxLength = 3;
            this.tbxCvc.Name = "tbxCvc";
            this.tbxCvc.Size = new System.Drawing.Size(31, 20);
            this.tbxCvc.TabIndex = 7;
            this.tbxCvc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCvc_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Onay Kodunuz : ";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCode.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCode.Location = new System.Drawing.Point(126, 49);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(0, 17);
            this.lblCode.TabIndex = 10;
            // 
            // grpOnay
            // 
            this.grpOnay.Controls.Add(this.btnOrderSend);
            this.grpOnay.Controls.Add(this.tbxCode);
            this.grpOnay.Controls.Add(this.label6);
            this.grpOnay.Controls.Add(this.lblCode);
            this.grpOnay.Location = new System.Drawing.Point(63, 509);
            this.grpOnay.Name = "grpOnay";
            this.grpOnay.Size = new System.Drawing.Size(232, 176);
            this.grpOnay.TabIndex = 11;
            this.grpOnay.TabStop = false;
            this.grpOnay.Text = "Onay Kodu Tamamla";
            this.grpOnay.Visible = false;
            // 
            // btnOrderSend
            // 
            this.btnOrderSend.Location = new System.Drawing.Point(39, 125);
            this.btnOrderSend.Name = "btnOrderSend";
            this.btnOrderSend.Size = new System.Drawing.Size(122, 23);
            this.btnOrderSend.TabIndex = 12;
            this.btnOrderSend.Text = "Gönder";
            this.btnOrderSend.UseVisualStyleBackColor = true;
            this.btnOrderSend.Click += new System.EventHandler(this.btnOrderSend_Click);
            // 
            // tbxCode
            // 
            this.tbxCode.Location = new System.Drawing.Point(39, 86);
            this.tbxCode.MaxLength = 6;
            this.tbxCode.Name = "tbxCode";
            this.tbxCode.Size = new System.Drawing.Size(122, 20);
            this.tbxCode.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(125, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(289, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 39);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ödeme Bilgileri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(476, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Alışveriş İçeriği";
            // 
            // dgwListeOrder
            // 
            this.dgwListeOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListeOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.OrderName,
            this.OrderAmount,
            this.OrderPrice,
            this.OrderStatus});
            this.dgwListeOrder.Location = new System.Drawing.Point(318, 146);
            this.dgwListeOrder.Name = "dgwListeOrder";
            this.dgwListeOrder.Size = new System.Drawing.Size(451, 226);
            this.dgwListeOrder.TabIndex = 15;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // OrderName
            // 
            this.OrderName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderName.DataPropertyName = "OrderName";
            this.OrderName.HeaderText = "Name";
            this.OrderName.Name = "OrderName";
            // 
            // OrderAmount
            // 
            this.OrderAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderAmount.DataPropertyName = "OrderAmount";
            this.OrderAmount.HeaderText = "Amount";
            this.OrderAmount.Name = "OrderAmount";
            // 
            // OrderPrice
            // 
            this.OrderPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderPrice.DataPropertyName = "OrderPrice";
            this.OrderPrice.HeaderText = "Price";
            this.OrderPrice.Name = "OrderPrice";
            // 
            // OrderStatus
            // 
            this.OrderStatus.DataPropertyName = "OrderStatus";
            this.OrderStatus.HeaderText = "Status";
            this.OrderStatus.Name = "OrderStatus";
            this.OrderStatus.Visible = false;
            // 
            // lblSiparisTutarOrder
            // 
            this.lblSiparisTutarOrder.AutoSize = true;
            this.lblSiparisTutarOrder.Location = new System.Drawing.Point(705, 388);
            this.lblSiparisTutarOrder.Name = "lblSiparisTutarOrder";
            this.lblSiparisTutarOrder.Size = new System.Drawing.Size(13, 13);
            this.lblSiparisTutarOrder.TabIndex = 18;
            this.lblSiparisTutarOrder.Text = "0";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(756, 388);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(13, 13);
            this.label35.TabIndex = 17;
            this.label35.Text = "₺";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(625, 388);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(75, 13);
            this.label34.TabIndex = 16;
            this.label34.Text = "Toplam tutar : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(628, 418);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Kargo : ";
            // 
            // lblKargo
            // 
            this.lblKargo.AutoSize = true;
            this.lblKargo.Location = new System.Drawing.Point(705, 418);
            this.lblKargo.Name = "lblKargo";
            this.lblKargo.Size = new System.Drawing.Size(13, 13);
            this.lblKargo.TabIndex = 20;
            this.lblKargo.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(310, 418);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(239, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "50 ₺ ve üzeri siparişlerde kargo bedava !";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label37.Location = new System.Drawing.Point(310, 447);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(140, 13);
            this.label37.TabIndex = 22;
            this.label37.Text = "*Fiyatlara KDV Dahildir.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(604, 446);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "+";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(603, 459);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(166, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "-----------------------------------------------------";
            // 
            // lblToplamUcret
            // 
            this.lblToplamUcret.AutoSize = true;
            this.lblToplamUcret.Location = new System.Drawing.Point(705, 478);
            this.lblToplamUcret.Name = "lblToplamUcret";
            this.lblToplamUcret.Size = new System.Drawing.Size(13, 13);
            this.lblToplamUcret.TabIndex = 25;
            this.lblToplamUcret.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(315, 389);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(167, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Kargo ücreti sabit 9,90 ₺\'dir ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(756, 418);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "₺";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(756, 478);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "₺";
            // 
            // tbxFis
            // 
            this.tbxFis.Enabled = false;
            this.tbxFis.Location = new System.Drawing.Point(51, 293);
            this.tbxFis.Name = "tbxFis";
            this.tbxFis.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxFis.Size = new System.Drawing.Size(244, 210);
            this.tbxFis.TabIndex = 31;
            this.tbxFis.Text = "";
            this.tbxFis.Visible = false;
            // 
            // btnGetCode
            // 
            this.btnGetCode.Location = new System.Drawing.Point(233, 262);
            this.btnGetCode.Name = "btnGetCode";
            this.btnGetCode.Size = new System.Drawing.Size(62, 23);
            this.btnGetCode.TabIndex = 32;
            this.btnGetCode.Text = "Kod Al";
            this.btnGetCode.UseVisualStyleBackColor = true;
            this.btnGetCode.Click += new System.EventHandler(this.btnGetCode_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 697);
            this.Controls.Add(this.btnGetCode);
            this.Controls.Add(this.tbxFis);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblToplamUcret);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblKargo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblSiparisTutarOrder);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.dgwListeOrder);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpOnay);
            this.Controls.Add(this.tbxCvc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxCustomerCardNumberOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxAdresOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblİsimOrder);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(-30, 0);
            this.Name = "Form2";
            this.Text = "Entity Framework Market | Sipariş Ver";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grpOnay.ResumeLayout(false);
            this.grpOnay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListeOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblİsimOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxAdresOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxCustomerCardNumberOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxCvc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.GroupBox grpOnay;
        private System.Windows.Forms.Button btnOrderSend;
        private System.Windows.Forms.TextBox tbxCode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.DataGridView dgwListeOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderStatus;
        public System.Windows.Forms.Label lblSiparisTutarOrder;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblKargo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblToplamUcret;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox tbxFis;
        private System.Windows.Forms.Button btnGetCode;
    }
}