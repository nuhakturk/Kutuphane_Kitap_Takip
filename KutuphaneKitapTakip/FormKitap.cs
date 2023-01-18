using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//SQL Bağlantısı için kütüphaneler.
using System.Data.Sql;
using System.Data.SqlClient;

namespace KutuphaneKitapTakip
{
    public partial class FormKitap : Form
    {
        //Bağlantı stringi
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-U5FIOK2\\SQLEXPRESS;Initial Catalog=kutuphane;Integrated Security=True;");
        public FormKitap()
        {
            InitializeComponent();
        }

        //Form yüklendiğinde yapılacaklar.
        private void FormKitap_Load(object sender, EventArgs e)
        {
            Verilerimi_göster();
            try
            {
                TurCek();
                YazarCek();
                YayineviCek();
            }
            catch (Exception er)
            {
                MessageBox.Show("Veri Çekme başarısız. Hata: " + er.Message);
            }
            Temizle();
        }
        /***----------------------------------------------------------------------------------------***/
        /*** METODLAR ***/

        //dataGridViewKitap'da kitap tablosunu göstermek için bir metod.
        public void Verilerimi_göster()
        {
            baglanti.Open();
            string sorgu = "SELECT kitap.kitap_id AS 'Kitap No', kitap.kitap_adi AS 'Kitap Adı', yazar.yazar_ad_soyad AS 'Yazar', tur.tur_adi AS 'Tür', kitap.kitap_sayfasayisi AS 'Sayfa Sayısı', kitap.kitap_adet AS 'Stok Adedi', yayinevi.yayinevi_ad AS 'Yayınevi', FORMAT(kitap.kitap_basimyili, 'MMMM yyyy', 'tr-TR') AS 'Basım Yılı' " +
                           "FROM kitap, yayinevi, yazar, tur "+
                           "WHERE kitap.yazar_no=yazar.yazar_id "+
                           "AND kitap.tur_no=tur.tur_id "+
                           "AND kitap.kitap_yayinevi_no=yayinevi.yayinevi_id";
            SqlDataAdapter sqlda = new SqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            sqlda.Fill(ds);
            dataGridViewKitap.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        //Kitapları Filtrelemek ve dataGridViewKitap da göstermek için.
        public void Verileri_filtrele(string sorgu)
        {
            baglanti.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            sqlda.Fill(ds);
            dataGridViewKitap.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        public void Verileri_kaydet()
        {
            string sorgu = "Insert into kitap(kitap_adi, yazar_no, tur_no, kitap_sayfasayisi, kitap_adet, kitap_yayinevi_no, kitap_basimyili) " +
                           "values " +
                           "(@kitapadi, @yazarno, @turno, @ktpsayfasayisi, @ktpadet, @ktpyayinevino, @ktpbasimyili)";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kitapadi", textBoxKitapAdi.Text);
            komut.Parameters.AddWithValue("@yazarno", comboBoxKitapYazar.SelectedValue);
            komut.Parameters.AddWithValue("@turno", comboBoxKitapTur.SelectedValue);
            komut.Parameters.AddWithValue("@ktpsayfasayisi", numericUpDownKtpSayfaSayisi.Value);
            komut.Parameters.AddWithValue("@ktpadet", numericUpDownKtpStokAdedi.Value);
            komut.Parameters.AddWithValue("@ktpyayinevino", comboBoxKitapYayinevi.SelectedValue);
            komut.Parameters.AddWithValue("@ktpbasimyili", dateTimePickerBasimYili.Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public void Verileri_guncelle()
        {
            string sorgu = "Update kitap Set kitap_adi=@kitapadi, yazar_no=@yazarno, tur_no=@turno, kitap_sayfasayisi=@ktpsayfasayisi, kitap_adet=@ktpadet, kitap_yayinevi_no=@ktpyayinevino, kitap_basimyili=@ktpbasimyili WHERE kitap_id=@kitapid";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kitapadi", textBoxKitapAdi.Text);
            komut.Parameters.AddWithValue("@yazarno", comboBoxKitapYazar.SelectedValue);
            komut.Parameters.AddWithValue("@turno", comboBoxKitapTur.SelectedValue);
            komut.Parameters.AddWithValue("@ktpsayfasayisi", numericUpDownKtpSayfaSayisi.Value);
            komut.Parameters.AddWithValue("@ktpadet", numericUpDownKtpStokAdedi.Value);
            komut.Parameters.AddWithValue("@ktpyayinevino", comboBoxKitapYayinevi.SelectedValue);
            komut.Parameters.AddWithValue("@ktpbasimyili", dateTimePickerBasimYili.Value);
            komut.Parameters.AddWithValue("@kitapid", dataGridViewKitap.CurrentRow.Cells[0].Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }


        public void Verileri_sil()
        {
            string sorgu = "Delete From kitap Where kitap_id=@kitapID";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kitapID", dataGridViewKitap.CurrentRow.Cells[0].Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        //Tüm TextBoxları ve veri giriş yerlerini temizle.
        public void Temizle()
        {
            //İşlem bölümünü temizle
            textBoxKitapAdi.Clear();
            comboBoxKitapYazar.SelectedIndex = -1;
            comboBoxKitapTur.SelectedIndex = -1;
            comboBoxKitapYayinevi.SelectedIndex = -1;
            dateTimePickerBasimYili.Value = DateTime.Now;
            numericUpDownKtpSayfaSayisi.Value = 0;
            numericUpDownKtpStokAdedi.Value = 0;
            //Filtreleme bölümünü temizle
            textBoxKitapAdiFil.Clear();
            comboBoxKitapYazarFil.SelectedIndex = -1;
        }

        //comboBoxKitapYazar ve comboBoxKitapYazarFil'e veri çekmek için metod.
        public void YazarCek()
        {
            DataTable yazarcek = new DataTable();
            DataTable yazarcekfil = new DataTable();
            SqlDataAdapter yazarcek_da = new SqlDataAdapter("SELECT * FROM yazar ORDER BY yazar_id ASC", baglanti);
            yazarcek_da.Fill(yazarcek);
            comboBoxKitapYazar.ValueMember = "yazar_id";
            comboBoxKitapYazar.DisplayMember = "yazar_ad_soyad";
            comboBoxKitapYazar.DataSource = yazarcek;
            yazarcek_da.Fill(yazarcekfil);
            comboBoxKitapYazarFil.ValueMember = "yazar_id";
            comboBoxKitapYazarFil.DisplayMember = "yazar_ad_soyad";
            comboBoxKitapYazarFil.DataSource = yazarcekfil;
            /*
            SqlCommand yazarcek = new SqlCommand("SELECT * FROM yazar ORDER BY yazar_ad_soyad ASC", baglanti);
            baglanti.Open();
            SqlDataReader dr = yazarcek.ExecuteReader();
            while (dr.Read())
            {
                comboBoxKitapYazar.Items.Add(dr["yazar_ad_soyad"]);
                comboBoxKitapYazarFil.Items.Add(dr["yazar_ad_soyad"]);
            }
            baglanti.Close();
            */
        }

        //comboBoxKitapTur'e veri çekmek için metod.
        public void TurCek()
        {
            
            DataTable turcek = new DataTable();
            SqlDataAdapter turcek_da = new SqlDataAdapter("SELECT * FROM tur ORDER BY tur_id ASC", baglanti);
            turcek_da.Fill(turcek);
            comboBoxKitapTur.ValueMember = "tur_id";
            comboBoxKitapTur.DisplayMember = "tur_adi";
            comboBoxKitapTur.DataSource = turcek;
            /*
            SqlCommand turcek = new SqlCommand("SELECT * FROM tur ORDER BY tur_adi ASC", baglanti);
            baglanti.Open();
            SqlDataReader dr = turcek.ExecuteReader();
            while (dr.Read())
            {
                comboBoxKitapTur.Items.Add(dr["tur_adi"]);
            }
            baglanti.Close();
            */
        }

        //comboBoxKitapYayinevi'ne veri çekmek için metod.
        public void YayineviCek()
        {
            DataTable yayinevicek = new DataTable();
            SqlDataAdapter yayinevicek_da = new SqlDataAdapter("SELECT * FROM yayinevi ORDER BY yayinevi_id ASC", baglanti);
            yayinevicek_da.Fill(yayinevicek);
            comboBoxKitapYayinevi.ValueMember = "yayinevi_id";
            comboBoxKitapYayinevi.DisplayMember = "yayinevi_ad";
            comboBoxKitapYayinevi.DataSource = yayinevicek;
            /*
            SqlCommand yayinevicek = new SqlCommand("SELECT * FROM yayinevi ORDER BY yayinevi_ad ASC", baglanti);
            baglanti.Open();
            SqlDataReader dr = yayinevicek.ExecuteReader();
            while (dr.Read())
            {
                comboBoxKitapYayinevi.Items.Add(dr["yayinevi_ad"]);
            }
            baglanti.Close();
            */
        }
        
        


        /*** METODLAR BİTİŞ ***/

        /***----------------------------------------------------------------------------------------***/

        /*** BUTONLAR ***/

        //Kitap ekleme butonu
        private void buttonKitapEkle_Click(object sender, EventArgs e)
        {
            //Veri giriş alanları boş ise tüm alanları doldurunuz uyarısı verir.
            if (textBoxKitapAdi.Text == "" || comboBoxKitapYazar.SelectedIndex == -1 ||
                comboBoxKitapTur.SelectedIndex == -1 || comboBoxKitapYayinevi.SelectedIndex == -1 ||
                numericUpDownKtpSayfaSayisi.Value == 0 || numericUpDownKtpStokAdedi.Value == 0)
            {
                DialogResult uyarı = MessageBox.Show("Lütfen tüm alanları doldurunuz!",
                                                      "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    Verileri_kaydet();
                    Verilerimi_göster();
                    Temizle();
                }
                catch (Exception errn)
                {
                    MessageBox.Show("Kitap Ekleme Başarısız. Hata: " + errn.Message);
                }
            }
        }

        //Kitap bilgilerini güncelleme butonu.
        private void buttonKitapGuncelle_Click(object sender, EventArgs e)
        {
            //Veri giriş alanları boş ise tüm alanları doldurunuz uyarısı verir.
            if (textBoxKitapAdi.Text == "" || comboBoxKitapYazar.SelectedIndex == -1 ||
                comboBoxKitapTur.SelectedIndex == -1 || comboBoxKitapYayinevi.SelectedIndex == -1 ||
                numericUpDownKtpSayfaSayisi.Value == 0 || numericUpDownKtpStokAdedi.Value == 0)
            {
                DialogResult uyarı = MessageBox.Show("Lütfen tüm alanları doldurunuz!",
                                                      "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                //Güncellemek istiyor musunuz diye sorar. Evet şıkkını seçerseniz güncelleme yapılır.
                DialogResult uyarı = MessageBox.Show("Seçilen Kitap Bilgileri Güncellenecek Emin misiniz?",
                                                 "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (uyarı == DialogResult.Yes)
                {
                    try
                    {
                        Verileri_guncelle();
                        Verilerimi_göster();
                        Temizle();
                    }
                    catch (Exception errn)
                    {
                        MessageBox.Show("Kitap Güncelleme Başarısız. Hata: " + errn.Message);
                    }
                }
            }
        }

        //Kitap silme butonu, datagridview'de seçilen kitabı siler.
        private void buttonKitapSil_Click(object sender, EventArgs e)
        {
            DialogResult uyarı = MessageBox.Show("Seçilen Kitap Silinecek Emin misiniz?",
                                                 "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (uyarı == DialogResult.Yes)
            {
                try
                {
                    Verileri_sil();
                    Verilerimi_göster();
                    Temizle();
                }
                catch (Exception errn)
                {
                    MessageBox.Show("Kitap Silme Başarısız. Hata: " + errn.Message);
                }
            }
        }

        //Temizleme Butonu 
        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            Verilerimi_göster();
            Temizle();
        }

        //Kitap Filtreleme butonu.
        private void buttonKitapFil_Click(object sender, EventArgs e)
        {
            //İki bölüm de boşsa
            if (textBoxKitapAdiFil.Text == "" && comboBoxKitapYazarFil.SelectedIndex == -1)
            {
                Verilerimi_göster();
            }
            //Kitap Adı bölümü doluysa
            else if (textBoxKitapAdiFil.Text != "" && comboBoxKitapYazarFil.SelectedIndex == -1)
            {
                Verileri_filtrele("SELECT kitap_id AS 'Kitap No', kitap_adi AS 'Kitap Adı', yazar.yazar_ad_soyad AS 'Yazar', tur.tur_adi AS 'Tür', kitap_sayfasayisi AS 'Sayfa Sayısı', kitap_adet AS 'Stok Adedi', yayinevi.yayinevi_ad AS 'Yayınevi', FORMAT(kitap.kitap_basimyili, 'MMMM yyyy', 'tr-TR') AS 'Basım Yılı' " +
                                  "FROM kitap, yayinevi, yazar, tur "+
                                  "WHERE kitap.yazar_no=yazar.yazar_id "+
                                  "AND kitap.tur_no=tur.tur_id " +
                                  "AND kitap.kitap_yayinevi_no=yayinevi.yayinevi_id " +
                                  "AND kitap.kitap_adi LIKE'%" + textBoxKitapAdiFil.Text + "%'");
            }
            //Yazar bölümü seçiliyse
            else if (textBoxKitapAdiFil.Text == "" && comboBoxKitapYazarFil.SelectedIndex != -1)
            {
                Verileri_filtrele("SELECT kitap_id AS 'Kitap No', kitap_adi AS 'Kitap Adı', yazar.yazar_ad_soyad AS 'Yazar', tur.tur_adi AS 'Tür', kitap_sayfasayisi AS 'Sayfa Sayısı', kitap_adet AS 'Stok Adedi', yayinevi.yayinevi_ad AS 'Yayınevi', FORMAT(kitap.kitap_basimyili, 'MMMM yyyy', 'tr-TR') AS 'Basım Yılı' " +
                                  "FROM kitap, yayinevi, yazar, tur " +
                                  "WHERE kitap.yazar_no=yazar.yazar_id " +
                                  "AND kitap.tur_no=tur.tur_id " +
                                  "AND kitap.kitap_yayinevi_no=yayinevi.yayinevi_id " +
                                  "AND yazar.yazar_id='" + comboBoxKitapYazarFil.SelectedValue + "'");
            }
            //İki bölüm de doluysa
            else if (textBoxKitapAdiFil.Text != "" && comboBoxKitapYazarFil.SelectedIndex != -1)
            {
                Verileri_filtrele("SELECT kitap_id AS 'Kitap No', kitap_adi AS 'Kitap Adı', yazar.yazar_ad_soyad AS 'Yazar', tur.tur_adi AS 'Tür', kitap_sayfasayisi AS 'Sayfa Sayısı', kitap_adet AS 'Stok Adedi', yayinevi.yayinevi_ad AS 'Yayınevi', FORMAT(kitap.kitap_basimyili, 'MMMM yyyy', 'tr-TR') AS 'Basım Yılı' " +
                                  "FROM kitap, yayinevi, yazar, tur " +
                                  "WHERE kitap.yazar_no=yazar.yazar_id " +
                                  "AND kitap.tur_no=tur.tur_id " +
                                  "AND kitap.kitap_yayinevi_no=yayinevi.yayinevi_id " +
                                  "AND kitap.kitap_adi LIKE'%" + textBoxKitapAdiFil.Text + "%' "+
                                  "AND yazar.yazar_id='" + comboBoxKitapYazarFil.SelectedValue + "'");
            }
        }

        //Geri butonu click eventi. Mevcut formu kapatır ana formun görünürlüğünü açar.
        private void buttonGeriKitap_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Application.OpenForms["FormAna"].Show();
        }

        
        /*** BUTONLAR BİTİŞ ***/
        /***----------------------------------------------------------------------------------***/

        //Form kapanırken yapıcalaklar. Ana formu tekrardan göster.
        private void FormKitap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["FormAna"].Show();
        }

        ///dataGridViewKitap'da seçilen satırdaki bilgileri veri giriş yerlerine aktarmak için.
        private void dataGridViewKitap_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxKitapAdi.Text = dataGridViewKitap.CurrentRow.Cells[1].Value.ToString();
            comboBoxKitapYazar.SelectedIndex = comboBoxKitapYazar.FindString(dataGridViewKitap.CurrentRow.Cells[2].Value.ToString());
            comboBoxKitapTur.SelectedIndex = comboBoxKitapTur.FindString(dataGridViewKitap.CurrentRow.Cells[3].Value.ToString());
            numericUpDownKtpSayfaSayisi.Value = Convert.ToInt32(dataGridViewKitap.CurrentRow.Cells[4].Value);
            numericUpDownKtpStokAdedi.Value = Convert.ToInt32(dataGridViewKitap.CurrentRow.Cells[5].Value);
            comboBoxKitapYayinevi.SelectedIndex = comboBoxKitapYayinevi.FindString(dataGridViewKitap.CurrentRow.Cells[6].Value.ToString());
            dateTimePickerBasimYili.Value = Convert.ToDateTime(dataGridViewKitap.CurrentRow.Cells[7].Value);
        }

        

        
    }
}
