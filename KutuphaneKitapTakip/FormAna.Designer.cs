namespace KutuphaneKitapTakip
{
    partial class FormAna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAna));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonEmanetIslem = new System.Windows.Forms.Button();
            this.buttonGecikenKitaplar = new System.Windows.Forms.Button();
            this.buttonUyeIslem = new System.Windows.Forms.Button();
            this.buttonKitapIslem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kitap İşlemleri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(659, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Üye İşlemleri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Geciken Kitaplar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Emanet İşlemleri";
            // 
            // buttonEmanetIslem
            // 
            this.buttonEmanetIslem.BackgroundImage = global::KutuphaneKitapTakip.Properties.Resources.emanetislemleri;
            this.buttonEmanetIslem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEmanetIslem.Location = new System.Drawing.Point(61, 58);
            this.buttonEmanetIslem.Name = "buttonEmanetIslem";
            this.buttonEmanetIslem.Size = new System.Drawing.Size(223, 135);
            this.buttonEmanetIslem.TabIndex = 0;
            this.buttonEmanetIslem.UseVisualStyleBackColor = true;
            this.buttonEmanetIslem.Click += new System.EventHandler(this.buttonEmanetIslem_Click);
            // 
            // buttonGecikenKitaplar
            // 
            this.buttonGecikenKitaplar.BackgroundImage = global::KutuphaneKitapTakip.Properties.Resources.gecikenkitaplar;
            this.buttonGecikenKitaplar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGecikenKitaplar.Location = new System.Drawing.Point(328, 229);
            this.buttonGecikenKitaplar.Name = "buttonGecikenKitaplar";
            this.buttonGecikenKitaplar.Size = new System.Drawing.Size(223, 135);
            this.buttonGecikenKitaplar.TabIndex = 3;
            this.buttonGecikenKitaplar.UseVisualStyleBackColor = true;
            this.buttonGecikenKitaplar.Click += new System.EventHandler(this.buttonGecikenKitaplar_Click);
            // 
            // buttonUyeIslem
            // 
            this.buttonUyeIslem.BackgroundImage = global::KutuphaneKitapTakip.Properties.Resources.uyeislem;
            this.buttonUyeIslem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUyeIslem.Location = new System.Drawing.Point(591, 58);
            this.buttonUyeIslem.Name = "buttonUyeIslem";
            this.buttonUyeIslem.Size = new System.Drawing.Size(223, 135);
            this.buttonUyeIslem.TabIndex = 2;
            this.buttonUyeIslem.UseVisualStyleBackColor = true;
            this.buttonUyeIslem.Click += new System.EventHandler(this.buttonUyeIslem_Click);
            // 
            // buttonKitapIslem
            // 
            this.buttonKitapIslem.BackgroundImage = global::KutuphaneKitapTakip.Properties.Resources.KitapIslemleri;
            this.buttonKitapIslem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonKitapIslem.Location = new System.Drawing.Point(328, 58);
            this.buttonKitapIslem.Name = "buttonKitapIslem";
            this.buttonKitapIslem.Size = new System.Drawing.Size(223, 135);
            this.buttonKitapIslem.TabIndex = 1;
            this.buttonKitapIslem.UseVisualStyleBackColor = true;
            this.buttonKitapIslem.Click += new System.EventHandler(this.buttonKitapIslem_Click);
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 421);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonEmanetIslem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGecikenKitaplar);
            this.Controls.Add(this.buttonUyeIslem);
            this.Controls.Add(this.buttonKitapIslem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Kitap Takip Programı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKitapIslem;
        private System.Windows.Forms.Button buttonUyeIslem;
        private System.Windows.Forms.Button buttonGecikenKitaplar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonEmanetIslem;

    }
}

