namespace MusteriTakipSistemi
{
    partial class AnaForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            btnMusteriEkleme = new Button();
            ımageList1 = new ImageList(components);
            btnMusteriGoruntule = new Button();
            btnFiyatlar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(366, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(305, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(366, 168);
            label1.Name = "label1";
            label1.Size = new Size(306, 62);
            label1.TabIndex = 1;
            label1.Text = "Hoşgeldiniz! ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(347, 259);
            label2.Name = "label2";
            label2.Size = new Size(363, 28);
            label2.TabIndex = 2;
            label2.Text = "Lütfen yapmak istediğiniz işlemi seçin!";
            // 
            // btnMusteriEkleme
            // 
            btnMusteriEkleme.BackColor = Color.Transparent;
            btnMusteriEkleme.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMusteriEkleme.ImageAlign = ContentAlignment.TopCenter;
            btnMusteriEkleme.ImageKey = "clipart149538.png";
            btnMusteriEkleme.ImageList = ımageList1;
            btnMusteriEkleme.Location = new Point(384, 334);
            btnMusteriEkleme.Name = "btnMusteriEkleme";
            btnMusteriEkleme.Size = new Size(287, 175);
            btnMusteriEkleme.TabIndex = 3;
            btnMusteriEkleme.Text = " Müşteri Ekleme";
            btnMusteriEkleme.TextAlign = ContentAlignment.BottomCenter;
            btnMusteriEkleme.UseVisualStyleBackColor = false;
            btnMusteriEkleme.Click += btnMusteriEkleme_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "clipart1850008.png");
            ımageList1.Images.SetKeyName(1, "clipart149538.png");
            ımageList1.Images.SetKeyName(2, "kisspng-computer-icons-discounts-and-allowances-price-tag-discount-day-5adb94070612d8.4850104615243397190249.png");
            // 
            // btnMusteriGoruntule
            // 
            btnMusteriGoruntule.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMusteriGoruntule.ImageAlign = ContentAlignment.TopCenter;
            btnMusteriGoruntule.ImageKey = "clipart1850008.png";
            btnMusteriGoruntule.ImageList = ımageList1;
            btnMusteriGoruntule.Location = new Point(772, 334);
            btnMusteriGoruntule.Name = "btnMusteriGoruntule";
            btnMusteriGoruntule.Size = new Size(260, 175);
            btnMusteriGoruntule.TabIndex = 6;
            btnMusteriGoruntule.Text = " Müşteri Görüntüleme";
            btnMusteriGoruntule.TextAlign = ContentAlignment.BottomCenter;
            btnMusteriGoruntule.UseVisualStyleBackColor = true;
            btnMusteriGoruntule.Click += btnMusteriGoruntule_Click;
            // 
            // btnFiyatlar
            // 
            btnFiyatlar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFiyatlar.ImageAlign = ContentAlignment.TopCenter;
            btnFiyatlar.ImageIndex = 2;
            btnFiyatlar.ImageList = ımageList1;
            btnFiyatlar.Location = new Point(48, 334);
            btnFiyatlar.Name = "btnFiyatlar";
            btnFiyatlar.Size = new Size(249, 175);
            btnFiyatlar.TabIndex = 7;
            btnFiyatlar.Text = "Ürün Fiyatları";
            btnFiyatlar.TextAlign = ContentAlignment.BottomCenter;
            btnFiyatlar.UseVisualStyleBackColor = true;
            btnFiyatlar.Click += btnFiyatlar_Click;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1087, 651);
            Controls.Add(btnFiyatlar);
            Controls.Add(btnMusteriGoruntule);
            Controls.Add(btnMusteriEkleme);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "AnaForm";
            Text = "Müşteri Takip Sistemi";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button btnMusteriEkleme;
        private ImageList ımageList1;
        private Button btnMusteriGoruntule;
        private Button btnFiyatlar;
    }
}