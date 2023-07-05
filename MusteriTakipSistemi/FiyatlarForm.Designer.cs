namespace MusteriTakipSistemi
{
    partial class FiyatlarForm
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
            dgvUrunler = new DataGridView();
            label1 = new Label();
            btnUrunEkle = new Button();
            txtUrunAdi = new TextBox();
            txtUrunFiyati = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnUrunSil = new Button();
            btnUrunGuncelle = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).BeginInit();
            SuspendLayout();
            // 
            // dgvUrunler
            // 
            dgvUrunler.AllowUserToAddRows = false;
            dgvUrunler.AllowUserToDeleteRows = false;
            dgvUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrunler.Location = new Point(12, 64);
            dgvUrunler.MultiSelect = false;
            dgvUrunler.Name = "dgvUrunler";
            dgvUrunler.ReadOnly = true;
            dgvUrunler.RowHeadersVisible = false;
            dgvUrunler.RowHeadersWidth = 51;
            dgvUrunler.RowTemplate.Height = 29;
            dgvUrunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUrunler.Size = new Size(765, 342);
            dgvUrunler.TabIndex = 1;
            dgvUrunler.CellClick += dgvUrunler_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(103, 28);
            label1.TabIndex = 2;
            label1.Text = "ÜRÜNLER";
            // 
            // btnUrunEkle
            // 
            btnUrunEkle.Location = new Point(115, 498);
            btnUrunEkle.Name = "btnUrunEkle";
            btnUrunEkle.Size = new Size(123, 48);
            btnUrunEkle.TabIndex = 3;
            btnUrunEkle.Text = "EKLE";
            btnUrunEkle.UseVisualStyleBackColor = true;
            btnUrunEkle.Click += btnUrunEkle_Click;
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(115, 422);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(264, 27);
            txtUrunAdi.TabIndex = 4;
            // 
            // txtUrunFiyati
            // 
            txtUrunFiyati.Location = new Point(114, 462);
            txtUrunFiyati.Name = "txtUrunFiyati";
            txtUrunFiyati.Size = new Size(265, 27);
            txtUrunFiyati.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 425);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 6;
            label2.Text = "Ürün Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 469);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 7;
            label3.Text = "Ürün Fiyatı:";
            // 
            // btnUrunSil
            // 
            btnUrunSil.Location = new Point(663, 420);
            btnUrunSil.Name = "btnUrunSil";
            btnUrunSil.Size = new Size(114, 47);
            btnUrunSil.TabIndex = 8;
            btnUrunSil.Text = "SİL";
            btnUrunSil.UseVisualStyleBackColor = true;
            btnUrunSil.Click += btnUrunSil_Click;
            // 
            // btnUrunGuncelle
            // 
            btnUrunGuncelle.Location = new Point(244, 498);
            btnUrunGuncelle.Name = "btnUrunGuncelle";
            btnUrunGuncelle.Size = new Size(135, 47);
            btnUrunGuncelle.TabIndex = 9;
            btnUrunGuncelle.Text = "GÜNCELLE";
            btnUrunGuncelle.UseVisualStyleBackColor = true;
            btnUrunGuncelle.Click += btnUrunGuncelle_Click;
            // 
            // FiyatlarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(800, 557);
            Controls.Add(btnUrunGuncelle);
            Controls.Add(btnUrunSil);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtUrunFiyati);
            Controls.Add(txtUrunAdi);
            Controls.Add(btnUrunEkle);
            Controls.Add(label1);
            Controls.Add(dgvUrunler);
            Name = "FiyatlarForm";
            Text = "FiyatlarForm";
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUrunler;
        private Label label1;
        private Button btnUrunEkle;
        private TextBox txtUrunAdi;
        private TextBox txtUrunFiyati;
        private Label label2;
        private Label label3;
        private Button btnUrunSil;
        private Button btnUrunGuncelle;
    }
}