﻿namespace emlak
{
    partial class sorgu
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
            label1 = new Label();
            label2 = new Label();
            cb_il = new ComboBox();
            cb_ilce = new ComboBox();
            Satilik = new RadioButton();
            Kiralik = new RadioButton();
            Sorgula = new Button();
            dataGridView1 = new DataGridView();
            EmlakNumarasi = new DataGridViewTextBoxColumn();
            İL = new DataGridViewTextBoxColumn();
            İlce = new DataGridViewTextBoxColumn();
            KatNumarası = new DataGridViewTextBoxColumn();
            Alan = new DataGridViewTextBoxColumn();
            OdaSayisi = new DataGridViewTextBoxColumn();
            turuSayi = new DataGridViewTextBoxColumn();
            turu = new DataGridViewTextBoxColumn();
            Yasi = new DataGridViewTextBoxColumn();
            Fiyat = new DataGridViewTextBoxColumn();
            label3 = new Label();
            Ana_Menü = new Button();
            Duzenle = new Button();
            SilBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.Location = new Point(101, 77);
            label1.Name = "label1";
            label1.Size = new Size(33, 31);
            label1.TabIndex = 12;
            label1.Text = "İL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.Location = new Point(394, 77);
            label2.Name = "label2";
            label2.Size = new Size(58, 31);
            label2.TabIndex = 11;
            label2.Text = "İLÇE";
            // 
            // cb_il
            // 
            cb_il.FormattingEnabled = true;
            cb_il.Items.AddRange(new object[] { "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa ", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir", "Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce" });
            cb_il.Location = new Point(179, 80);
            cb_il.Name = "cb_il";
            cb_il.Size = new Size(171, 28);
            cb_il.TabIndex = 1;
            cb_il.SelectedIndexChanged += cb_il_SelectedIndexChanged_1;
            cb_il.SelectedValueChanged += cb_il_SelectedValueChanged;
            // 
            // cb_ilce
            // 
            cb_ilce.Enabled = false;
            cb_ilce.FormattingEnabled = true;
            cb_ilce.Location = new Point(479, 80);
            cb_ilce.Name = "cb_ilce";
            cb_ilce.Size = new Size(171, 28);
            cb_ilce.TabIndex = 2;
            // 
            // Satilik
            // 
            Satilik.AutoSize = true;
            Satilik.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            Satilik.Location = new Point(696, 77);
            Satilik.Name = "Satilik";
            Satilik.Size = new Size(103, 35);
            Satilik.TabIndex = 3;
            Satilik.TabStop = true;
            Satilik.Text = "Satılık";
            Satilik.UseVisualStyleBackColor = true;
            // 
            // Kiralik
            // 
            Kiralik.AutoSize = true;
            Kiralik.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            Kiralik.Location = new Point(831, 75);
            Kiralik.Name = "Kiralik";
            Kiralik.Size = new Size(105, 35);
            Kiralik.TabIndex = 4;
            Kiralik.TabStop = true;
            Kiralik.Text = "Kiralık";
            Kiralik.UseVisualStyleBackColor = true;
            Kiralik.CheckedChanged += Kiralik_CheckedChanged;
            // 
            // Sorgula
            // 
            Sorgula.Location = new Point(1024, 40);
            Sorgula.Name = "Sorgula";
            Sorgula.Size = new Size(197, 31);
            Sorgula.TabIndex = 5;
            Sorgula.Text = "Sorgula";
            Sorgula.UseVisualStyleBackColor = true;
            Sorgula.Click += Sorgula_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { EmlakNumarasi, İL, İlce, KatNumarası, Alan, OdaSayisi, turuSayi, turu, Yasi, Fiyat });
            dataGridView1.Location = new Point(2, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1491, 346);
            dataGridView1.TabIndex = 6;
            // 
            // EmlakNumarasi
            // 
            EmlakNumarasi.HeaderText = "Emlak Numarası";
            EmlakNumarasi.MinimumWidth = 6;
            EmlakNumarasi.Name = "EmlakNumarasi";
            EmlakNumarasi.Width = 125;
            // 
            // İL
            // 
            İL.HeaderText = "il";
            İL.MinimumWidth = 6;
            İL.Name = "İL";
            İL.Width = 125;
            // 
            // İlce
            // 
            İlce.HeaderText = "ilce";
            İlce.MinimumWidth = 6;
            İlce.Name = "İlce";
            İlce.Width = 125;
            // 
            // KatNumarası
            // 
            KatNumarası.HeaderText = "Kat Numarası";
            KatNumarası.MinimumWidth = 6;
            KatNumarası.Name = "KatNumarası";
            KatNumarası.Width = 125;
            // 
            // Alan
            // 
            Alan.HeaderText = "Alan";
            Alan.MinimumWidth = 6;
            Alan.Name = "Alan";
            Alan.Width = 125;
            // 
            // OdaSayisi
            // 
            OdaSayisi.HeaderText = "Oda Sayısı";
            OdaSayisi.MinimumWidth = 6;
            OdaSayisi.Name = "OdaSayisi";
            OdaSayisi.Width = 125;
            // 
            // turuSayi
            // 
            turuSayi.HeaderText = "Turu Sayı";
            turuSayi.MinimumWidth = 6;
            turuSayi.Name = "turuSayi";
            turuSayi.Width = 125;
            // 
            // turu
            // 
            turu.HeaderText = "Türü";
            turu.MinimumWidth = 6;
            turu.Name = "turu";
            turu.Width = 125;
            // 
            // Yasi
            // 
            Yasi.HeaderText = "Yaşı";
            Yasi.MinimumWidth = 6;
            Yasi.Name = "Yasi";
            Yasi.Width = 125;
            // 
            // Fiyat
            // 
            Fiyat.HeaderText = "Fiyat";
            Fiyat.MinimumWidth = 6;
            Fiyat.Name = "Fiyat";
            Fiyat.Width = 125;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(460, 9);
            label3.Name = "label3";
            label3.Size = new Size(521, 41);
            label3.TabIndex = 10;
            label3.Text = "Emlak sorgu ekranına hoş geldiniz";
            // 
            // Ana_Menü
            // 
            Ana_Menü.Location = new Point(1268, 75);
            Ana_Menü.Name = "Ana_Menü";
            Ana_Menü.Size = new Size(197, 31);
            Ana_Menü.TabIndex = 13;
            Ana_Menü.Text = "Ana Menü";
            Ana_Menü.UseVisualStyleBackColor = true;
            Ana_Menü.Click += Ana_Menü_Click;
            // 
            // Duzenle
            // 
            Duzenle.Location = new Point(1024, 75);
            Duzenle.Name = "Duzenle";
            Duzenle.Size = new Size(197, 31);
            Duzenle.TabIndex = 14;
            Duzenle.Text = "Düzenle";
            Duzenle.UseVisualStyleBackColor = true;
            Duzenle.Click += Duzenle_Click;
            // 
            // SilBtn
            // 
            SilBtn.Location = new Point(1268, 40);
            SilBtn.Name = "SilBtn";
            SilBtn.Size = new Size(197, 31);
            SilBtn.TabIndex = 15;
            SilBtn.Text = "Silme";
            SilBtn.UseVisualStyleBackColor = true;
            SilBtn.Click += SilBtn_Click;
            // 
            // sorgu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1491, 485);
            Controls.Add(SilBtn);
            Controls.Add(Duzenle);
            Controls.Add(Ana_Menü);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(Sorgula);
            Controls.Add(Kiralik);
            Controls.Add(Satilik);
            Controls.Add(cb_ilce);
            Controls.Add(cb_il);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "sorgu";
            Text = "sorgu";
            Load += sorgu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cb_il;
        private ComboBox cb_ilce;
        private RadioButton Satilik;
        private RadioButton Kiralik;
        private Button Sorgula;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn EmlakNumarasi;
        private DataGridViewTextBoxColumn İL;
        private DataGridViewTextBoxColumn İlce;
        private DataGridViewTextBoxColumn KatNumarası;
        private DataGridViewTextBoxColumn Alan;
        private DataGridViewTextBoxColumn OdaSayisi;
        private DataGridViewTextBoxColumn turuSayi;
        private DataGridViewTextBoxColumn turu;
        private DataGridViewTextBoxColumn Yasi;
        private DataGridViewTextBoxColumn Fiyat;
        public Label label3;
        private Button Ana_Menü;
        private Button Duzenle;
        private Button SilBtn;
    }
}