namespace KutuphaneKitapTakip
{
    partial class FormGecikme
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGecikme));
            this.buttonGeriGecikme = new System.Windows.Forms.Button();
            this.groupBoxGecikenKitap = new System.Windows.Forms.GroupBox();
            this.dataGridViewGeciken = new System.Windows.Forms.DataGridView();
            this.groupBoxGecikenKitap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGeciken)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGeriGecikme
            // 
            this.buttonGeriGecikme.Location = new System.Drawing.Point(976, 511);
            this.buttonGeriGecikme.Name = "buttonGeriGecikme";
            this.buttonGeriGecikme.Size = new System.Drawing.Size(100, 44);
            this.buttonGeriGecikme.TabIndex = 1;
            this.buttonGeriGecikme.Text = "Geri Dön";
            this.buttonGeriGecikme.UseVisualStyleBackColor = true;
            this.buttonGeriGecikme.Click += new System.EventHandler(this.buttonGeriGecikme_Click);
            // 
            // groupBoxGecikenKitap
            // 
            this.groupBoxGecikenKitap.Controls.Add(this.dataGridViewGeciken);
            this.groupBoxGecikenKitap.Location = new System.Drawing.Point(12, 30);
            this.groupBoxGecikenKitap.Name = "groupBoxGecikenKitap";
            this.groupBoxGecikenKitap.Size = new System.Drawing.Size(1064, 475);
            this.groupBoxGecikenKitap.TabIndex = 8;
            this.groupBoxGecikenKitap.TabStop = false;
            this.groupBoxGecikenKitap.Text = "Geciken Kitaplar";
            // 
            // dataGridViewGeciken
            // 
            this.dataGridViewGeciken.AllowUserToAddRows = false;
            this.dataGridViewGeciken.AllowUserToDeleteRows = false;
            this.dataGridViewGeciken.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGeciken.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewGeciken.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewGeciken.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewGeciken.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewGeciken.Name = "dataGridViewGeciken";
            this.dataGridViewGeciken.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGeciken.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewGeciken.RowTemplate.Height = 24;
            this.dataGridViewGeciken.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGeciken.Size = new System.Drawing.Size(1052, 448);
            this.dataGridViewGeciken.TabIndex = 15;
            // 
            // FormGecikme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 567);
            this.Controls.Add(this.groupBoxGecikenKitap);
            this.Controls.Add(this.buttonGeriGecikme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGecikme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Kitap Takip Programı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGecikme_FormClosing);
            this.Load += new System.EventHandler(this.FormGecikme_Load);
            this.groupBoxGecikenKitap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGeciken)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGeriGecikme;
        private System.Windows.Forms.GroupBox groupBoxGecikenKitap;
        private System.Windows.Forms.DataGridView dataGridViewGeciken;
    }
}