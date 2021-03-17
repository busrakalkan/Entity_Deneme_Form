namespace EntityDenemeForm
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.buttonGiris = new System.Windows.Forms.Button();
            this.textBoxKullanıcıSifresi = new System.Windows.Forms.TextBox();
            this.buttonSifre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "KullanıcıAdı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "KullanıcıSifresi";
            // 
            // textBoxKullanıcıAdı
            // 
            this.textBoxKullanıcıAdı.Location = new System.Drawing.Point(186, 63);
            this.textBoxKullanıcıAdı.Name = "textBoxKullanıcıAdı";
            this.textBoxKullanıcıAdı.Size = new System.Drawing.Size(130, 20);
            this.textBoxKullanıcıAdı.TabIndex = 2;
            // 
            // buttonGiris
            // 
            this.buttonGiris.Location = new System.Drawing.Point(71, 181);
            this.buttonGiris.Name = "buttonGiris";
            this.buttonGiris.Size = new System.Drawing.Size(245, 31);
            this.buttonGiris.TabIndex = 4;
            this.buttonGiris.Text = "GIRIS YAP";
            this.buttonGiris.UseVisualStyleBackColor = true;
            this.buttonGiris.Click += new System.EventHandler(this.buttonGiris_Click);
            // 
            // textBoxKullanıcıSifresi
            // 
            this.textBoxKullanıcıSifresi.Location = new System.Drawing.Point(186, 120);
            this.textBoxKullanıcıSifresi.Name = "textBoxKullanıcıSifresi";
            this.textBoxKullanıcıSifresi.Size = new System.Drawing.Size(130, 20);
            this.textBoxKullanıcıSifresi.TabIndex = 5;
            this.textBoxKullanıcıSifresi.UseSystemPasswordChar = true;
            // 
            // buttonSifre
            // 
            this.buttonSifre.Location = new System.Drawing.Point(71, 229);
            this.buttonSifre.Name = "buttonSifre";
            this.buttonSifre.Size = new System.Drawing.Size(245, 31);
            this.buttonSifre.TabIndex = 6;
            this.buttonSifre.Text = "Şifremi Unuttum";
            this.buttonSifre.UseVisualStyleBackColor = true;
            this.buttonSifre.Click += new System.EventHandler(this.buttonSifre_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 300);
            this.Controls.Add(this.buttonSifre);
            this.Controls.Add(this.textBoxKullanıcıSifresi);
            this.Controls.Add(this.buttonGiris);
            this.Controls.Add(this.textBoxKullanıcıAdı);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKullanıcıAdı;
        private System.Windows.Forms.Button buttonGiris;
        private System.Windows.Forms.TextBox textBoxKullanıcıSifresi;
        private System.Windows.Forms.Button buttonSifre;
    }
}

