namespace KutuphaneKitapTakip
{
    partial class FormEmanet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmanet));
            this.buttonGeriEmanet = new System.Windows.Forms.Button();
            this.groupBoxEmanetListele = new System.Windows.Forms.GroupBox();
            this.dataGridViewEmanet = new System.Windows.Forms.DataGridView();
            this.groupBoxEmanetFiltreleme = new System.Windows.Forms.GroupBox();
            this.numericUpDownEmanetKitapNoFil = new System.Windows.Forms.NumericUpDown();
            this.maskedTextBoxEmanetUyeTcFil = new System.Windows.Forms.MaskedTextBox();
            this.labelEmanetUyeTc = new System.Windows.Forms.Label();
            this.labelEmanetKitapNo = new System.Windows.Forms.Label();
            this.buttonEmanetFil = new System.Windows.Forms.Button();
            this.groupBoxEmanetIslem = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxEmanetUyeTc = new System.Windows.Forms.MaskedTextBox();
            this.numericUpDownEmanetKitapNo = new System.Windows.Forms.NumericUpDown();
            this.buttonEmanetSil = new System.Windows.Forms.Button();
            this.buttonEmanetAl = new System.Windows.Forms.Button();
            this.labelislemUyeTc = new System.Windows.Forms.Label();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.buttonEmanetVer = new System.Windows.Forms.Button();
            this.labelislemKitapNo = new System.Windows.Forms.Label();
            this.groupBoxEmanetListele.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmanet)).BeginInit();
            this.groupBoxEmanetFiltreleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEmanetKitapNoFil)).BeginInit();
            this.groupBoxEmanetIslem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEmanetKitapNo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGeriEmanet
            // 
            this.buttonGeriEmanet.Location = new System.Drawing.Point(893, 652);
            this.buttonGeriEmanet.Name = "buttonGeriEmanet";
            this.buttonGeriEmanet.Size = new System.Drawing.Size(100, 44);
            this.buttonGeriEmanet.TabIndex = 0;
            this.buttonGeriEmanet.Text = "Geri Dön";
            this.buttonGeriEmanet.UseVisualStyleBackColor = true;
            this.buttonGeriEmanet.Click += new System.EventHandler(this.buttonGeriEmanet_Click);
            // 
            // groupBoxEmanetListele
            // 
            this.groupBoxEmanetListele.Controls.Add(this.dataGridViewEmanet);
            this.groupBoxEmanetListele.Location = new System.Drawing.Point(12, 275);
            this.groupBoxEmanetListele.Name = "groupBoxEmanetListele";
            this.groupBoxEmanetListele.Size = new System.Drawing.Size(981, 371);
            this.groupBoxEmanetListele.TabIndex = 7;
            this.groupBoxEmanetListele.TabStop = false;
            this.groupBoxEmanetListele.Text = "Emanet Listele";
            // 
            // dataGridViewEmanet
            // 
            this.dataGridViewEmanet.AllowUserToAddRows = false;
            this.dataGridViewEmanet.AllowUserToDeleteRows = false;
            this.dataGridViewEmanet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmanet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEmanet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEmanet.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEmanet.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewEmanet.Name = "dataGridViewEmanet";
            this.dataGridViewEmanet.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmanet.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewEmanet.RowTemplate.Height = 24;
            this.dataGridViewEmanet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmanet.Size = new System.Drawing.Size(969, 344);
            this.dataGridViewEmanet.TabIndex = 15;
            this.dataGridViewEmanet.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmanet_CellEnter);
            // 
            // groupBoxEmanetFiltreleme
            // 
            this.groupBoxEmanetFiltreleme.Controls.Add(this.numericUpDownEmanetKitapNoFil);
            this.groupBoxEmanetFiltreleme.Controls.Add(this.maskedTextBoxEmanetUyeTcFil);
            this.groupBoxEmanetFiltreleme.Controls.Add(this.labelEmanetUyeTc);
            this.groupBoxEmanetFiltreleme.Controls.Add(this.labelEmanetKitapNo);
            this.groupBoxEmanetFiltreleme.Controls.Add(this.buttonEmanetFil);
            this.groupBoxEmanetFiltreleme.Location = new System.Drawing.Point(523, 29);
            this.groupBoxEmanetFiltreleme.Name = "groupBoxEmanetFiltreleme";
            this.groupBoxEmanetFiltreleme.Size = new System.Drawing.Size(470, 240);
            this.groupBoxEmanetFiltreleme.TabIndex = 6;
            this.groupBoxEmanetFiltreleme.TabStop = false;
            this.groupBoxEmanetFiltreleme.Text = "Filtreleme";
            // 
            // numericUpDownEmanetKitapNoFil
            // 
            this.numericUpDownEmanetKitapNoFil.Location = new System.Drawing.Point(144, 94);
            this.numericUpDownEmanetKitapNoFil.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownEmanetKitapNoFil.Name = "numericUpDownEmanetKitapNoFil";
            this.numericUpDownEmanetKitapNoFil.Size = new System.Drawing.Size(205, 22);
            this.numericUpDownEmanetKitapNoFil.TabIndex = 37;
            // 
            // maskedTextBoxEmanetUyeTcFil
            // 
            this.maskedTextBoxEmanetUyeTcFil.BeepOnError = true;
            this.maskedTextBoxEmanetUyeTcFil.Location = new System.Drawing.Point(144, 47);
            this.maskedTextBoxEmanetUyeTcFil.Mask = "00000000000";
            this.maskedTextBoxEmanetUyeTcFil.Name = "maskedTextBoxEmanetUyeTcFil";
            this.maskedTextBoxEmanetUyeTcFil.ResetOnSpace = false;
            this.maskedTextBoxEmanetUyeTcFil.Size = new System.Drawing.Size(205, 22);
            this.maskedTextBoxEmanetUyeTcFil.TabIndex = 36;
            this.maskedTextBoxEmanetUyeTcFil.Enter += new System.EventHandler(this.maskedTextBoxEmanetUyeTcFil_Enter);
            // 
            // labelEmanetUyeTc
            // 
            this.labelEmanetUyeTc.AutoSize = true;
            this.labelEmanetUyeTc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelEmanetUyeTc.Location = new System.Drawing.Point(218, 27);
            this.labelEmanetUyeTc.Name = "labelEmanetUyeTc";
            this.labelEmanetUyeTc.Size = new System.Drawing.Size(53, 17);
            this.labelEmanetUyeTc.TabIndex = 21;
            this.labelEmanetUyeTc.Text = "Üye Tc";
            // 
            // labelEmanetKitapNo
            // 
            this.labelEmanetKitapNo.AutoSize = true;
            this.labelEmanetKitapNo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelEmanetKitapNo.Location = new System.Drawing.Point(209, 74);
            this.labelEmanetKitapNo.Name = "labelEmanetKitapNo";
            this.labelEmanetKitapNo.Size = new System.Drawing.Size(62, 17);
            this.labelEmanetKitapNo.TabIndex = 19;
            this.labelEmanetKitapNo.Text = "Kitap No";
            // 
            // buttonEmanetFil
            // 
            this.buttonEmanetFil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonEmanetFil.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonEmanetFil.Location = new System.Drawing.Point(184, 130);
            this.buttonEmanetFil.Name = "buttonEmanetFil";
            this.buttonEmanetFil.Size = new System.Drawing.Size(120, 48);
            this.buttonEmanetFil.TabIndex = 13;
            this.buttonEmanetFil.Text = "Ara";
            this.buttonEmanetFil.UseVisualStyleBackColor = true;
            this.buttonEmanetFil.Click += new System.EventHandler(this.buttonEmanetFil_Click);
            // 
            // groupBoxEmanetIslem
            // 
            this.groupBoxEmanetIslem.Controls.Add(this.maskedTextBoxEmanetUyeTc);
            this.groupBoxEmanetIslem.Controls.Add(this.numericUpDownEmanetKitapNo);
            this.groupBoxEmanetIslem.Controls.Add(this.buttonEmanetSil);
            this.groupBoxEmanetIslem.Controls.Add(this.buttonEmanetAl);
            this.groupBoxEmanetIslem.Controls.Add(this.labelislemUyeTc);
            this.groupBoxEmanetIslem.Controls.Add(this.buttonTemizle);
            this.groupBoxEmanetIslem.Controls.Add(this.buttonEmanetVer);
            this.groupBoxEmanetIslem.Controls.Add(this.labelislemKitapNo);
            this.groupBoxEmanetIslem.Location = new System.Drawing.Point(12, 29);
            this.groupBoxEmanetIslem.Name = "groupBoxEmanetIslem";
            this.groupBoxEmanetIslem.Size = new System.Drawing.Size(505, 240);
            this.groupBoxEmanetIslem.TabIndex = 5;
            this.groupBoxEmanetIslem.TabStop = false;
            this.groupBoxEmanetIslem.Text = "Emanet İşlemleri";
            // 
            // maskedTextBoxEmanetUyeTc
            // 
            this.maskedTextBoxEmanetUyeTc.BeepOnError = true;
            this.maskedTextBoxEmanetUyeTc.Location = new System.Drawing.Point(192, 44);
            this.maskedTextBoxEmanetUyeTc.Mask = "00000000000";
            this.maskedTextBoxEmanetUyeTc.Name = "maskedTextBoxEmanetUyeTc";
            this.maskedTextBoxEmanetUyeTc.ResetOnSpace = false;
            this.maskedTextBoxEmanetUyeTc.Size = new System.Drawing.Size(239, 22);
            this.maskedTextBoxEmanetUyeTc.TabIndex = 35;
            this.maskedTextBoxEmanetUyeTc.Enter += new System.EventHandler(this.maskedTextBoxEmanetUyeTc_Enter);
            // 
            // numericUpDownEmanetKitapNo
            // 
            this.numericUpDownEmanetKitapNo.Location = new System.Drawing.Point(192, 72);
            this.numericUpDownEmanetKitapNo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownEmanetKitapNo.Name = "numericUpDownEmanetKitapNo";
            this.numericUpDownEmanetKitapNo.Size = new System.Drawing.Size(239, 22);
            this.numericUpDownEmanetKitapNo.TabIndex = 5;
            // 
            // buttonEmanetSil
            // 
            this.buttonEmanetSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonEmanetSil.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonEmanetSil.Location = new System.Drawing.Point(279, 132);
            this.buttonEmanetSil.Name = "buttonEmanetSil";
            this.buttonEmanetSil.Size = new System.Drawing.Size(72, 48);
            this.buttonEmanetSil.TabIndex = 9;
            this.buttonEmanetSil.Text = "Sil";
            this.buttonEmanetSil.UseVisualStyleBackColor = true;
            this.buttonEmanetSil.Click += new System.EventHandler(this.buttonEmanetSil_Click);
            // 
            // buttonEmanetAl
            // 
            this.buttonEmanetAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonEmanetAl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonEmanetAl.Location = new System.Drawing.Point(164, 132);
            this.buttonEmanetAl.Name = "buttonEmanetAl";
            this.buttonEmanetAl.Size = new System.Drawing.Size(109, 48);
            this.buttonEmanetAl.TabIndex = 8;
            this.buttonEmanetAl.Text = "Emanet Al";
            this.buttonEmanetAl.UseVisualStyleBackColor = true;
            this.buttonEmanetAl.Click += new System.EventHandler(this.buttonEmanetAl_Click);
            // 
            // labelislemUyeTc
            // 
            this.labelislemUyeTc.AutoSize = true;
            this.labelislemUyeTc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelislemUyeTc.Location = new System.Drawing.Point(68, 47);
            this.labelislemUyeTc.Name = "labelislemUyeTc";
            this.labelislemUyeTc.Size = new System.Drawing.Size(57, 17);
            this.labelislemUyeTc.TabIndex = 31;
            this.labelislemUyeTc.Text = "Üye Tc:";
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonTemizle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonTemizle.Location = new System.Drawing.Point(357, 132);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(99, 48);
            this.buttonTemizle.TabIndex = 10;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // buttonEmanetVer
            // 
            this.buttonEmanetVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonEmanetVer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonEmanetVer.Location = new System.Drawing.Point(38, 132);
            this.buttonEmanetVer.Name = "buttonEmanetVer";
            this.buttonEmanetVer.Size = new System.Drawing.Size(120, 48);
            this.buttonEmanetVer.TabIndex = 7;
            this.buttonEmanetVer.Text = "Emanet Ver";
            this.buttonEmanetVer.UseVisualStyleBackColor = true;
            this.buttonEmanetVer.Click += new System.EventHandler(this.buttonEmanetVer_Click);
            // 
            // labelislemKitapNo
            // 
            this.labelislemKitapNo.AutoSize = true;
            this.labelislemKitapNo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelislemKitapNo.Location = new System.Drawing.Point(68, 74);
            this.labelislemKitapNo.Name = "labelislemKitapNo";
            this.labelislemKitapNo.Size = new System.Drawing.Size(66, 17);
            this.labelislemKitapNo.TabIndex = 20;
            this.labelislemKitapNo.Text = "Kitap No:";
            // 
            // FormEmanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 708);
            this.Controls.Add(this.buttonGeriEmanet);
            this.Controls.Add(this.groupBoxEmanetListele);
            this.Controls.Add(this.groupBoxEmanetFiltreleme);
            this.Controls.Add(this.groupBoxEmanetIslem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEmanet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Kitap Takip Programı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEmanet_FormClosing);
            this.Load += new System.EventHandler(this.FormEmanet_Load);
            this.groupBoxEmanetListele.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmanet)).EndInit();
            this.groupBoxEmanetFiltreleme.ResumeLayout(false);
            this.groupBoxEmanetFiltreleme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEmanetKitapNoFil)).EndInit();
            this.groupBoxEmanetIslem.ResumeLayout(false);
            this.groupBoxEmanetIslem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEmanetKitapNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGeriEmanet;
        private System.Windows.Forms.GroupBox groupBoxEmanetListele;
        private System.Windows.Forms.DataGridView dataGridViewEmanet;
        private System.Windows.Forms.GroupBox groupBoxEmanetFiltreleme;
        private System.Windows.Forms.Label labelEmanetUyeTc;
        private System.Windows.Forms.Label labelEmanetKitapNo;
        private System.Windows.Forms.Button buttonEmanetFil;
        private System.Windows.Forms.GroupBox groupBoxEmanetIslem;
        private System.Windows.Forms.NumericUpDown numericUpDownEmanetKitapNo;
        private System.Windows.Forms.Button buttonEmanetSil;
        private System.Windows.Forms.Button buttonEmanetAl;
        private System.Windows.Forms.Label labelislemUyeTc;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.Button buttonEmanetVer;
        private System.Windows.Forms.Label labelislemKitapNo;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEmanetUyeTc;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEmanetUyeTcFil;
        private System.Windows.Forms.NumericUpDown numericUpDownEmanetKitapNoFil;
    }
}