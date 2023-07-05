namespace MusteriTakipSistemi
{
    partial class MusteriGoruntuleForm
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
            groupBox2 = new GroupBox();
            btnTemizle = new Button();
            btnAra = new Button();
            label9 = new Label();
            txtHarf = new TextBox();
            btnSırala1 = new Button();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label1 = new Label();
            dgvMusteriler = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(btnTemizle);
            groupBox2.Controls.Add(btnAra);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtHarf);
            groupBox2.Controls.Add(btnSırala1);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(24, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(672, 157);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filtreleme";
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.SkyBlue;
            btnTemizle.Location = new Point(496, 118);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(159, 33);
            btnTemizle.TabIndex = 7;
            btnTemizle.Text = "FİLTREYİ TEMİZLE";
            btnTemizle.UseVisualStyleBackColor = false;
            // 
            // btnAra
            // 
            btnAra.BackColor = Color.LightGray;
            btnAra.Location = new Point(545, 65);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(94, 29);
            btnAra.TabIndex = 6;
            btnAra.Text = "ARA";
            btnAra.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 70);
            label9.Name = "label9";
            label9.Size = new Size(133, 20);
            label9.TabIndex = 5;
            label9.Text = "Ad / Soyad / Şehir:";
            // 
            // txtHarf
            // 
            txtHarf.BackColor = SystemColors.Control;
            txtHarf.Location = new Point(154, 67);
            txtHarf.Name = "txtHarf";
            txtHarf.Size = new Size(371, 27);
            txtHarf.TabIndex = 4;
            // 
            // btnSırala1
            // 
            btnSırala1.BackColor = Color.LightGray;
            btnSırala1.Location = new Point(545, 25);
            btnSırala1.Name = "btnSırala1";
            btnSırala1.Size = new Size(94, 29);
            btnSırala1.TabIndex = 2;
            btnSırala1.Text = "SIRALA";
            btnSırala1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "İsme Göre Sırala ( A-Z)", "İsme Göre Sırala ( Z-A)", "Şehre Göre Sırala (A-Z)", "Şehre Göre Sırala (Z-A)", "", "" });
            comboBox1.Location = new Point(154, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(371, 28);
            comboBox1.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 34);
            label7.Name = "label7";
            label7.Size = new Size(117, 20);
            label7.TabIndex = 0;
            label7.Text = "Sıralama Ölçütü:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 194);
            label1.Name = "label1";
            label1.Size = new Size(132, 28);
            label1.TabIndex = 13;
            label1.Text = "MÜŞTERİLER";
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
            dgvMusteriler.Location = new Point(30, 225);
            dgvMusteriler.MultiSelect = false;
            dgvMusteriler.Name = "dgvMusteriler";
            dgvMusteriler.ReadOnly = true;
            dgvMusteriler.RowHeadersVisible = false;
            dgvMusteriler.RowHeadersWidth = 51;
            dgvMusteriler.RowTemplate.Height = 29;
            dgvMusteriler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMusteriler.Size = new Size(666, 474);
            dgvMusteriler.TabIndex = 14;
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
            Column4.DataPropertyName = "TelefonNo";
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
            Column5.DataPropertyName = "Urun";
            Column5.HeaderText = "Satın Alınan Ürün";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // MusteriGoruntuleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(720, 723);
            Controls.Add(dgvMusteriler);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Name = "MusteriGoruntuleForm";
            Text = "Form3";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Button btnTemizle;
        private Button btnAra;
        private Label label9;
        private TextBox txtHarf;
        private Button btnSırala1;
        private ComboBox comboBox1;
        private Label label7;
        private Label label1;
        private DataGridView dgvMusteriler;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column5;
    }
}