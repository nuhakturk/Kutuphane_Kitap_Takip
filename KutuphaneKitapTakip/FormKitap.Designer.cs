namespace KutuphaneKitapTakip
{
    partial class FormKitap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKitap));
            this.buttonGeriKitap = new System.Windows.Forms.Button();
            this.groupBoxKitapIslem = new System.Windows.Forms.GroupBox();
            this.comboBoxKitapYayinevi = new System.Windows.Forms.ComboBox();
            this.comboBoxKitapTur = new System.Windows.Forms.ComboBox();
            this.numericUpDownKtpStokAdedi = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownKtpSayfaSayisi = new System.Windows.Forms.NumericUpDown();
            this.comboBoxKitapYazar = new System.Windows.Forms.ComboBox();
            this.labelKitapTuru = new System.Windows.Forms.Label();
            this.labelKtpStokAdedi = new System.Windows.Forms.Label();
            this.buttonKitapSil = new System.Windows.Forms.Button();
            this.buttonKitapGuncelle = new System.Windows.Forms.Button();
            this.labelKitapAdi = new System.Windows.Forms.Label();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.buttonKitapEkle = new System.Windows.Forms.Button();
            this.dateTimePickerBasimYili = new System.Windows.Forms.DateTimePicker();
            this.textBoxKitapAdi = new System.Windows.Forms.TextBox();
            this.labelKitapYayinevi = new System.Windows.Forms.Label();
            this.labelKtpBasimYili = new System.Windows.Forms.Label();
            this.labelKtpSayfaSayisi = new System.Windows.Forms.Label();
            this.labelKitapYazari = new System.Windows.Forms.Label();
            this.groupBoxKitapFiltreleme = new System.Windows.Forms.GroupBox();
            this.comboBoxKitapYazarFil = new System.Windows.Forms.ComboBox();
            this.textBoxKitapAdiFil = new System.Windows.Forms.TextBox();
            this.labelKitapAdiFil = new System.Windows.Forms.Label();
            this.labelKitapYazarFil = new System.Windows.Forms.Label();
            this.buttonKitapFil = new System.Windows.Forms.Button();
            this.groupBoxKitapListele = new System.Windows.Forms.GroupBox();
            this.dataGridViewKitap = new System.Windows.Forms.DataGridView();
            this.kutuphaneDataSet1 = new KutuphaneKitapTakip.kutuphaneDataSet1();
            this.groupBoxKitapIslem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKtpStokAdedi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKtpSayfaSayisi)).BeginInit();
            this.groupBoxKitapFiltreleme.SuspendLayout();
            this.groupBoxKitapListele.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGeriKitap
            // 
            this.buttonGeriKitap.Location = new System.Drawing.Point(849, 730);
            this.buttonGeriKitap.Name = "buttonGeriKitap";
            this.buttonGeriKitap.Size = new System.Drawing.Size(100, 44);
            this.buttonGeriKitap.TabIndex = 1;
            this.buttonGeriKitap.Text = "Geri Dön";
            this.buttonGeriKitap.UseVisualStyleBackColor = true;
            this.buttonGeriKitap.Click += new System.EventHandler(this.buttonGeriKitap_Click);
            // 
            // groupBoxKitapIslem
            // 
            this.groupBoxKitapIslem.Controls.Add(this.comboBoxKitapYayinevi);
            this.groupBoxKitapIslem.Controls.Add(this.comboBoxKitapTur);
            this.groupBoxKitapIslem.Controls.Add(this.numericUpDownKtpStokAdedi);
            this.groupBoxKitapIslem.Controls.Add(this.numericUpDownKtpSayfaSayisi);
            this.groupBoxKitapIslem.Controls.Add(this.comboBoxKitapYazar);
            this.groupBoxKitapIslem.Controls.Add(this.labelKitapTuru);
            this.groupBoxKitapIslem.Controls.Add(this.labelKtpStokAdedi);
            this.groupBoxKitapIslem.Controls.Add(this.buttonKitapSil);
            this.groupBoxKitapIslem.Controls.Add(this.buttonKitapGuncelle);
            this.groupBoxKitapIslem.Controls.Add(this.labelKitapAdi);
            this.groupBoxKitapIslem.Controls.Add(this.buttonTemizle);
            this.groupBoxKitapIslem.Controls.Add(this.buttonKitapEkle);
            this.groupBoxKitapIslem.Controls.Add(this.dateTimePickerBasimYili);
            this.groupBoxKitapIslem.Controls.Add(this.textBoxKitapAdi);
            this.groupBoxKitapIslem.Controls.Add(this.labelKitapYayinevi);
            this.groupBoxKitapIslem.Controls.Add(this.labelKtpBasimYili);
            this.groupBoxKitapIslem.Controls.Add(this.labelKtpSayfaSayisi);
            this.groupBoxKitapIslem.Controls.Add(this.labelKitapYazari);
            this.groupBoxKitapIslem.Location = new System.Drawing.Point(12, 38);
            this.groupBoxKitapIslem.Name = "groupBoxKitapIslem";
            this.groupBoxKitapIslem.Size = new System.Drawing.Size(505, 331);
            this.groupBoxKitapIslem.TabIndex = 2;
            this.groupBoxKitapIslem.TabStop = false;
            this.groupBoxKitapIslem.Text = "Kitap İşlemleri";
            // 
            // comboBoxKitapYayinevi
            // 
            this.comboBoxKitapYayinevi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKitapYayinevi.FormattingEnabled = true;
            this.comboBoxKitapYayinevi.Location = new System.Drawing.Point(192, 132);
            this.comboBoxKitapYayinevi.Name = "comboBoxKitapYayinevi";
            this.comboBoxKitapYayinevi.Size = new System.Drawing.Size(239, 24);
            this.comboBoxKitapYayinevi.TabIndex = 3;
            // 
            // comboBoxKitapTur
            // 
            this.comboBoxKitapTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKitapTur.FormattingEnabled = true;
            this.comboBoxKitapTur.Location = new System.Drawing.Point(192, 102);
            this.comboBoxKitapTur.Name = "comboBoxKitapTur";
            this.comboBoxKitapTur.Size = new System.Drawing.Size(239, 24);
            this.comboBoxKitapTur.TabIndex = 2;
            // 
            // numericUpDownKtpStokAdedi
            // 
            this.numericUpDownKtpStokAdedi.Location = new System.Drawing.Point(192, 218);
            this.numericUpDownKtpStokAdedi.Name = "numericUpDownKtpStokAdedi";
            this.numericUpDownKtpStokAdedi.Size = new System.Drawing.Size(239, 22);
            this.numericUpDownKtpStokAdedi.TabIndex = 6;
            // 
            // numericUpDownKtpSayfaSayisi
            // 
            this.numericUpDownKtpSayfaSayisi.Location = new System.Drawing.Point(192, 190);
            this.numericUpDownKtpSayfaSayisi.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownKtpSayfaSayisi.Name = "numericUpDownKtpSayfaSayisi";
            this.numericUpDownKtpSayfaSayisi.Size = new System.Drawing.Size(239, 22);
            this.numericUpDownKtpSayfaSayisi.TabIndex = 5;
            // 
            // comboBoxKitapYazar
            // 
            this.comboBoxKitapYazar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKitapYazar.FormattingEnabled = true;
            this.comboBoxKitapYazar.Location = new System.Drawing.Point(192, 72);
            this.comboBoxKitapYazar.Name = "comboBoxKitapYazar";
            this.comboBoxKitapYazar.Size = new System.Drawing.Size(239, 24);
            this.comboBoxKitapYazar.TabIndex = 1;
            // 
            // labelKitapTuru
            // 
            this.labelKitapTuru.AutoSize = true;
            this.labelKitapTuru.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelKitapTuru.Location = new System.Drawing.Point(68, 105);
            this.labelKitapTuru.Name = "labelKitapTuru";
            this.labelKitapTuru.Size = new System.Drawing.Size(42, 17);
            this.labelKitapTuru.TabIndex = 34;
            this.labelKitapTuru.Text = "Türü:";
            // 
            // labelKtpStokAdedi
            // 
            this.labelKtpStokAdedi.AutoSize = true;
            this.labelKtpStokAdedi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelKtpStokAdedi.Location = new System.Drawing.Point(68, 220);
            this.labelKtpStokAdedi.Name = "labelKtpStokAdedi";
            this.labelKtpStokAdedi.Size = new System.Drawing.Size(80, 17);
            this.labelKtpStokAdedi.TabIndex = 32;
            this.labelKtpStokAdedi.Text = "Stok Adedi:";
            // 
            // buttonKitapSil
            // 
            this.buttonKitapSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonKitapSil.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonKitapSil.Location = new System.Drawing.Point(266, 260);
            this.buttonKitapSil.Name = "buttonKitapSil";
            this.buttonKitapSil.Size = new System.Drawing.Size(72, 48);
            this.buttonKitapSil.TabIndex = 9;
            this.buttonKitapSil.Text = "Sil";
            this.buttonKitapSil.UseVisualStyleBackColor = true;
            this.buttonKitapSil.Click += new System.EventHandler(this.buttonKitapSil_Click);
            // 
            // buttonKitapGuncelle
            // 
            this.buttonKitapGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonKitapGuncelle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonKitapGuncelle.Location = new System.Drawing.Point(151, 260);
            this.buttonKitapGuncelle.Name = "buttonKitapGuncelle";
            this.buttonKitapGuncelle.Size = new System.Drawing.Size(109, 48);
            this.buttonKitapGuncelle.TabIndex = 8;
            this.buttonKitapGuncelle.Text = "Güncelle";
            this.buttonKitapGuncelle.UseVisualStyleBackColor = true;
            this.buttonKitapGuncelle.Click += new System.EventHandler(this.buttonKitapGuncelle_Click);
            // 
            // labelKitapAdi
            // 
            this.labelKitapAdi.AutoSize = true;
            this.labelKitapAdi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelKitapAdi.Location = new System.Drawing.Point(68, 47);
            this.labelKitapAdi.Name = "labelKitapAdi";
            this.labelKitapAdi.Size = new System.Drawing.Size(68, 17);
            this.labelKitapAdi.TabIndex = 31;
            this.labelKitapAdi.Text = "Kitap Adı:";
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonTemizle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonTemizle.Location = new System.Drawing.Point(344, 260);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(99, 48);
            this.buttonTemizle.TabIndex = 10;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // buttonKitapEkle
            // 
            this.buttonKitapEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonKitapEkle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonKitapEkle.Location = new System.Drawing.Point(63, 260);
            this.buttonKitapEkle.Name = "buttonKitapEkle";
            this.buttonKitapEkle.Size = new System.Drawing.Size(82, 48);
            this.buttonKitapEkle.TabIndex = 7;
            this.buttonKitapEkle.Text = "Ekle";
            this.buttonKitapEkle.UseVisualStyleBackColor = true;
            this.buttonKitapEkle.Click += new System.EventHandler(this.buttonKitapEkle_Click);
            // 
            // dateTimePickerBasimYili
            // 
            this.dateTimePickerBasimYili.CustomFormat = "MMMM yyyy";
            this.dateTimePickerBasimYili.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerBasimYili.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBasimYili.Location = new System.Drawing.Point(192, 162);
            this.dateTimePickerBasimYili.Name = "dateTimePickerBasimYili";
            this.dateTimePickerBasimYili.Size = new System.Drawing.Size(239, 22);
            this.dateTimePickerBasimYili.TabIndex = 4;
            this.dateTimePickerBasimYili.Value = new System.DateTime(2003, 6, 18, 0, 0, 0, 0);
            // 
            // textBoxKitapAdi
            // 
            this.textBoxKitapAdi.Location = new System.Drawing.Point(192, 44);
            this.textBoxKitapAdi.Name = "textBoxKitapAdi";
            this.textBoxKitapAdi.Size = new System.Drawing.Size(239, 22);
            this.textBoxKitapAdi.TabIndex = 0;
            // 
            // labelKitapYayinevi
            // 
            this.labelKitapYayinevi.AutoSize = true;
            this.labelKitapYayinevi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelKitapYayinevi.Location = new System.Drawing.Point(68, 135);
            this.labelKitapYayinevi.Name = "labelKitapYayinevi";
            this.labelKitapYayinevi.Size = new System.Drawing.Size(65, 17);
            this.labelKitapYayinevi.TabIndex = 23;
            this.labelKitapYayinevi.Text = "Yayınevi:";
            // 
            // labelKtpBasimYili
            // 
            this.labelKtpBasimYili.AutoSize = true;
            this.labelKtpBasimYili.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelKtpBasimYili.Location = new System.Drawing.Point(68, 167);
            this.labelKtpBasimYili.Name = "labelKtpBasimYili";
            this.labelKtpBasimYili.Size = new System.Drawing.Size(72, 17);
            this.labelKtpBasimYili.TabIndex = 22;
            this.labelKtpBasimYili.Text = "Basım Yılı:";
            // 
            // labelKtpSayfaSayisi
            // 
            this.labelKtpSayfaSayisi.AutoSize = true;
            this.labelKtpSayfaSayisi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelKtpSayfaSayisi.Location = new System.Drawing.Point(68, 192);
            this.labelKtpSayfaSayisi.Name = "labelKtpSayfaSayisi";
            this.labelKtpSayfaSayisi.Size = new System.Drawing.Size(89, 17);
            this.labelKtpSayfaSayisi.TabIndex = 20;
            this.labelKtpSayfaSayisi.Text = "Sayfa Sayısı:";
            // 
            // labelKitapYazari
            // 
            this.labelKitapYazari.AutoSize = true;
            this.labelKitapYazari.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelKitapYazari.Location = new System.Drawing.Point(68, 75);
            this.labelKitapYazari.Name = "labelKitapYazari";
            this.labelKitapYazari.Size = new System.Drawing.Size(52, 17);
            this.labelKitapYazari.TabIndex = 16;
            this.labelKitapYazari.Text = "Yazarı:";
            // 
            // groupBoxKitapFiltreleme
            // 
            this.groupBoxKitapFiltreleme.Controls.Add(this.comboBoxKitapYazarFil);
            this.groupBoxKitapFiltreleme.Controls.Add(this.textBoxKitapAdiFil);
            this.groupBoxKitapFiltreleme.Controls.Add(this.labelKitapAdiFil);
            this.groupBoxKitapFiltreleme.Controls.Add(this.labelKitapYazarFil);
            this.groupBoxKitapFiltreleme.Controls.Add(this.buttonKitapFil);
            this.groupBoxKitapFiltreleme.Location = new System.Drawing.Point(523, 38);
            this.groupBoxKitapFiltreleme.Name = "groupBoxKitapFiltreleme";
            this.groupBoxKitapFiltreleme.Size = new System.Drawing.Size(426, 331);
            this.groupBoxKitapFiltreleme.TabIndex = 3;
            this.groupBoxKitapFiltreleme.TabStop = false;
            this.groupBoxKitapFiltreleme.Text = "Filtreleme";
            // 
            // comboBoxKitapYazarFil
            // 
            this.comboBoxKitapYazarFil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKitapYazarFil.FormattingEnabled = true;
            this.comboBoxKitapYazarFil.Location = new System.Drawing.Point(116, 156);
            this.comboBoxKitapYazarFil.Name = "comboBoxKitapYazarFil";
            this.comboBoxKitapYazarFil.Size = new System.Drawing.Size(205, 24);
            this.comboBoxKitapYazarFil.TabIndex = 12;
            // 
            // textBoxKitapAdiFil
            // 
            this.textBoxKitapAdiFil.Location = new System.Drawing.Point(116, 113);
            this.textBoxKitapAdiFil.Name = "textBoxKitapAdiFil";
            this.textBoxKitapAdiFil.Size = new System.Drawing.Size(205, 22);
            this.textBoxKitapAdiFil.TabIndex = 11;
            // 
            // labelKitapAdiFil
            // 
            this.labelKitapAdiFil.AutoSize = true;
            this.labelKitapAdiFil.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelKitapAdiFil.Location = new System.Drawing.Point(181, 93);
            this.labelKitapAdiFil.Name = "labelKitapAdiFil";
            this.labelKitapAdiFil.Size = new System.Drawing.Size(64, 17);
            this.labelKitapAdiFil.TabIndex = 21;
            this.labelKitapAdiFil.Text = "Kitap Adı";
            // 
            // labelKitapYazarFil
            // 
            this.labelKitapYazarFil.AutoSize = true;
            this.labelKitapYazarFil.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelKitapYazarFil.Location = new System.Drawing.Point(190, 138);
            this.labelKitapYazarFil.Name = "labelKitapYazarFil";
            this.labelKitapYazarFil.Size = new System.Drawing.Size(45, 17);
            this.labelKitapYazarFil.TabIndex = 19;
            this.labelKitapYazarFil.Text = "Yazar";
            // 
            // buttonKitapFil
            // 
            this.buttonKitapFil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonKitapFil.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonKitapFil.Location = new System.Drawing.Point(156, 192);
            this.buttonKitapFil.Name = "buttonKitapFil";
            this.buttonKitapFil.Size = new System.Drawing.Size(120, 48);
            this.buttonKitapFil.TabIndex = 13;
            this.buttonKitapFil.Text = "Ara";
            this.buttonKitapFil.UseVisualStyleBackColor = true;
            this.buttonKitapFil.Click += new System.EventHandler(this.buttonKitapFil_Click);
            // 
            // groupBoxKitapListele
            // 
            this.groupBoxKitapListele.Controls.Add(this.dataGridViewKitap);
            this.groupBoxKitapListele.Location = new System.Drawing.Point(12, 375);
            this.groupBoxKitapListele.Name = "groupBoxKitapListele";
            this.groupBoxKitapListele.Size = new System.Drawing.Size(937, 349);
            this.groupBoxKitapListele.TabIndex = 4;
            this.groupBoxKitapListele.TabStop = false;
            this.groupBoxKitapListele.Text = "Kitap Listele";
            // 
            // dataGridViewKitap
            // 
            this.dataGridViewKitap.AllowUserToAddRows = false;
            this.dataGridViewKitap.AllowUserToDeleteRows = false;
            this.dataGridViewKitap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewKitap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewKitap.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewKitap.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewKitap.Name = "dataGridViewKitap";
            this.dataGridViewKitap.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewKitap.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewKitap.RowTemplate.Height = 24;
            this.dataGridViewKitap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKitap.Size = new System.Drawing.Size(925, 322);
            this.dataGridViewKitap.TabIndex = 15;
            this.dataGridViewKitap.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKitap_CellEnter);
            // 
            // kutuphaneDataSet1
            // 
            this.kutuphaneDataSet1.DataSetName = "kutuphaneDataSet1";
            this.kutuphaneDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormKitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 786);
            this.Controls.Add(this.groupBoxKitapListele);
            this.Controls.Add(this.groupBoxKitapFiltreleme);
            this.Controls.Add(this.groupBoxKitapIslem);
            this.Controls.Add(this.buttonGeriKitap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormKitap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Kitap Takip Programı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormKitap_FormClosing);
            this.Load += new System.EventHandler(this.FormKitap_Load);
            this.groupBoxKitapIslem.ResumeLayout(false);
            this.groupBoxKitapIslem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKtpStokAdedi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKtpSayfaSayisi)).EndInit();
            this.groupBoxKitapFiltreleme.ResumeLayout(false);
            this.groupBoxKitapFiltreleme.PerformLayout();
            this.groupBoxKitapListele.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGeriKitap;
        private System.Windows.Forms.GroupBox groupBoxKitapIslem;
        private System.Windows.Forms.GroupBox groupBoxKitapFiltreleme;
        private System.Windows.Forms.Button buttonKitapSil;
        private System.Windows.Forms.Button buttonKitapGuncelle;
        private System.Windows.Forms.Label labelKitapAdi;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.Button buttonKitapEkle;
        private System.Windows.Forms.DateTimePicker dateTimePickerBasimYili;
        private System.Windows.Forms.TextBox textBoxKitapAdi;
        private System.Windows.Forms.Label labelKitapYayinevi;
        private System.Windows.Forms.Label labelKtpBasimYili;
        private System.Windows.Forms.Label labelKtpSayfaSayisi;
        private System.Windows.Forms.Label labelKitapYazari;
        private System.Windows.Forms.Label labelKitapTuru;
        private System.Windows.Forms.Label labelKtpStokAdedi;
        private System.Windows.Forms.NumericUpDown numericUpDownKtpStokAdedi;
        private System.Windows.Forms.NumericUpDown numericUpDownKtpSayfaSayisi;
        private System.Windows.Forms.ComboBox comboBoxKitapYazar;
        private System.Windows.Forms.ComboBox comboBoxKitapYayinevi;
        private System.Windows.Forms.ComboBox comboBoxKitapTur;
        private System.Windows.Forms.GroupBox groupBoxKitapListele;
        private System.Windows.Forms.DataGridView dataGridViewKitap;
        private System.Windows.Forms.ComboBox comboBoxKitapYazarFil;
        private System.Windows.Forms.TextBox textBoxKitapAdiFil;
        private System.Windows.Forms.Label labelKitapAdiFil;
        private System.Windows.Forms.Label labelKitapYazarFil;
        private System.Windows.Forms.Button buttonKitapFil;
        private kutuphaneDataSet1 kutuphaneDataSet1;
    }
}