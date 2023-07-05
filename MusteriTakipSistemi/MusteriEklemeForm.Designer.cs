namespace MusteriTakipSistemi
{
    partial class MusteriEklemeForm
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
            groupBox1 = new GroupBox();
            btnKaydet = new Button();
            label7 = new Label();
            dtpTarih = new DateTimePicker();
            btnKaydetVeCik = new Button();
            cboSehirler = new ComboBox();
            txtCepNo = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            cboUrunler = new ComboBox();
            label5 = new Label();
            btnSil = new Button();
            dgvMusteriler = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            btnGuncelle = new Button();
            label6 = new Label();
            groupBox2 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            cboMusteriler = new ComboBox();
            btnEkle = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dtpTarih);
            groupBox1.Controls.Add(btnKaydetVeCik);
            groupBox1.Controls.Add(cboSehirler);
            groupBox1.Controls.Add(txtCepNo);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(24, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(382, 479);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Müşteri Bilgileri";
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.LimeGreen;
            btnKaydet.Location = new Point(19, 300);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(332, 43);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "EKLE";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 238);
            label7.Name = "label7";
            label7.Size = new Size(43, 20);
            label7.TabIndex = 15;
            label7.Text = "Tarih:";
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(84, 233);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(256, 27);
            dtpTarih.TabIndex = 14;
            // 
            // btnKaydetVeCik
            // 
            btnKaydetVeCik.BackColor = Color.Gray;
            btnKaydetVeCik.Location = new Point(16, 425);
            btnKaydetVeCik.Name = "btnKaydetVeCik";
            btnKaydetVeCik.Size = new Size(136, 36);
            btnKaydetVeCik.TabIndex = 13;
            btnKaydetVeCik.Text = "KAYDET VE ÇIK";
            btnKaydetVeCik.UseVisualStyleBackColor = false;
            btnKaydetVeCik.Click += btnKaydetVeCik_Click;
            // 
            // cboSehirler
            // 
            cboSehirler.DisplayMember = "Ad";
            cboSehirler.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSehirler.FormattingEnabled = true;
            cboSehirler.Location = new Point(82, 140);
            cboSehirler.Name = "cboSehirler";
            cboSehirler.Size = new Size(258, 28);
            cboSehirler.TabIndex = 12;
            // 
            // txtCepNo
            // 
            txtCepNo.BackColor = SystemColors.Control;
            txtCepNo.Location = new Point(84, 180);
            txtCepNo.Name = "txtCepNo";
            txtCepNo.Size = new Size(256, 27);
            txtCepNo.TabIndex = 10;
            // 
            // txtSoyad
            // 
            txtSoyad.BackColor = SystemColors.Control;
            txtSoyad.Location = new Point(82, 91);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(258, 27);
            txtSoyad.TabIndex = 8;
            // 
            // txtAd
            // 
            txtAd.BackColor = SystemColors.Control;
            txtAd.Location = new Point(82, 43);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(258, 27);
            txtAd.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 187);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 3;
            label3.Text = "Cep No:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 46);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 1;
            label1.Text = "Adı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 143);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 4;
            label4.Text = "Şehir:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 94);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 2;
            label2.Text = "Soyadı:";
            // 
            // cboUrunler
            // 
            cboUrunler.BackColor = SystemColors.ActiveBorder;
            cboUrunler.DisplayMember = "Ad";
            cboUrunler.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUrunler.FormattingEnabled = true;
            cboUrunler.Location = new Point(16, 210);
            cboUrunler.Name = "cboUrunler";
            cboUrunler.Size = new Size(216, 28);
            cboUrunler.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 187);
            label5.Name = "label5";
            label5.Size = new Size(176, 20);
            label5.TabIndex = 5;
            label5.Text = "Satın aldığı ürünü seçiniz:";
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Brown;
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(874, 529);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(107, 40);
            btnSil.TabIndex = 12;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Visible = false;
            btnSil.Click += btnSil_Click;
            // 
            // dgvMusteriler
            // 
            dgvMusteriler.AllowUserToAddRows = false;
            dgvMusteriler.AllowUserToDeleteRows = false;
            dgvMusteriler.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvMusteriler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMusteriler.BackgroundColor = Color.White;
            dgvMusteriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMusteriler.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column6, Column5 });
            dgvMusteriler.GridColor = Color.Silver;
            dgvMusteriler.Location = new Point(707, 89);
            dgvMusteriler.MultiSelect = false;
            dgvMusteriler.Name = "dgvMusteriler";
            dgvMusteriler.ReadOnly = true;
            dgvMusteriler.RowHeadersVisible = false;
            dgvMusteriler.RowHeadersWidth = 51;
            dgvMusteriler.RowTemplate.Height = 29;
            dgvMusteriler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMusteriler.Size = new Size(388, 428);
            dgvMusteriler.TabIndex = 8;
            dgvMusteriler.CellContentClick += dgvMusteriler_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Ad";
            Column1.HeaderText = "Ad";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Soyad";
            Column2.HeaderText = "Soyad";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Sehir";
            Column3.HeaderText = "Şehir";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Telefon";
            Column4.HeaderText = "Telefon No";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "SatinAlmaTarihi";
            Column6.HeaderText = "Tarih";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "Urun.Ad";
            Column5.HeaderText = "Satın Alınan Ürün";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuncelle.BackColor = Color.DarkBlue;
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.Location = new Point(987, 525);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(108, 44);
            btnGuncelle.TabIndex = 13;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(707, 47);
            label6.Name = "label6";
            label6.Size = new Size(214, 28);
            label6.TabIndex = 14;
            label6.Text = "EKLENEN MÜŞTERİLER";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(cboMusteriler);
            groupBox2.Controls.Add(btnEkle);
            groupBox2.Controls.Add(cboUrunler);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(424, 90);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 461);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ürün Ekleme";
            // 
            // label9
            // 
            label9.Location = new Point(14, 43);
            label9.Name = "label9";
            label9.Size = new Size(230, 61);
            label9.TabIndex = 19;
            label9.Text = "Lütfen müşteri seçimi yaparak aldığı ürünleri listeden ekleyiniz.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 109);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 18;
            label8.Text = "Müşteriler";
            // 
            // cboMusteriler
            // 
            cboMusteriler.BackColor = SystemColors.AppWorkspace;
            cboMusteriler.FormattingEnabled = true;
            cboMusteriler.Location = new Point(16, 140);
            cboMusteriler.Name = "cboMusteriler";
            cboMusteriler.Size = new Size(216, 28);
            cboMusteriler.TabIndex = 17;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.LimeGreen;
            btnEkle.Location = new Point(16, 404);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(216, 36);
            btnEkle.TabIndex = 16;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // MusteriEklemeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1111, 591);
            Controls.Add(groupBox2);
            Controls.Add(btnSil);
            Controls.Add(label6);
            Controls.Add(btnGuncelle);
            Controls.Add(dgvMusteriler);
            Controls.Add(groupBox1);
            Name = "MusteriEklemeForm";
            Text = "Müşteri Ekleme";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSil;
        private ComboBox cboUrunler;
        private TextBox txtCepNo;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Button btnKaydet;
        private Label label3;
        private Label label5;
        private Label label1;
        private Label label4;
        private Label label2;
        private DataGridView dgvMusteriler;
        private Button btnGuncelle;
        private Label label6;
        private ComboBox cboSehirler;
        private Button btnKaydetVeCik;
        private Label label7;
        private DateTimePicker dtpTarih;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column5;
        private GroupBox groupBox2;
        private Label label9;
        private Label label8;
        private ComboBox cboMusteriler;
        private Button btnEkle;
    }
}