
namespace emlak
{
    partial class İşlemler
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
            K_Ekleme = new Button();
            K_Sorgula = new Button();
            Geri = new Button();
            SuspendLayout();
            // 
            // K_Ekleme
            // 
            K_Ekleme.Location = new Point(107, 23);
            K_Ekleme.Name = "K_Ekleme";
            K_Ekleme.Size = new Size(149, 55);
            K_Ekleme.TabIndex = 0;
            K_Ekleme.Text = "Kayıt Ekleme";
            K_Ekleme.UseVisualStyleBackColor = true;
            K_Ekleme.Click += Ekleme_Click;
            // 
            // K_Sorgula
            // 
            K_Sorgula.Location = new Point(107, 82);
            K_Sorgula.Name = "K_Sorgula";
            K_Sorgula.Size = new Size(149, 55);
            K_Sorgula.TabIndex = 1;
            K_Sorgula.Text = "Kayıt Sorgula";
            K_Sorgula.UseVisualStyleBackColor = true;
            K_Sorgula.Click += K_Sorgula_Click;
            // 
            // Geri
            // 
            Geri.Location = new Point(107, 143);
            Geri.Name = "Geri";
            Geri.Size = new Size(149, 55);
            Geri.TabIndex = 2;
            Geri.Text = "Giriş Ekranı";
            Geri.UseVisualStyleBackColor = true;
            Geri.Click += Geri_Click;
            // 
            // İşlemler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 234);
            Controls.Add(Geri);
            Controls.Add(K_Sorgula);
            Controls.Add(K_Ekleme);
            Name = "İşlemler";
            Text = "İşlemler";
            Load += İşlemler_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button K_Ekleme;
        private System.Windows.Forms.Button K_Sorgula;
        private System.Windows.Forms.Button Geri;
    }
}