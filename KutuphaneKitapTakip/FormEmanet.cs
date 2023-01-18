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
    public partial class FormEmanet : Form
    {
        //Bağlantı stringi
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-U5FIOK2\\SQLEXPRESS;Initial Catalog=kutuphane;Integrated Security=True;");

        public FormEmanet()
        {
            InitializeComponent();
        }
        private void FormEmanet_Load(object sender, EventArgs e)
        {
            Verilerimi_göster();
            Temizle();
        }
        /***----------------------------------------------------------------------------------------***/
        
        /*** METODLAR ***/

        //dataGridView1'de islem tablosunu göstermek için bir metod.
        public void Verilerimi_göster()
        {
            baglanti.Open();
            string sorgu = "SELECT islem.islem_id AS 'İşlem No', uye.uye_tc AS 'Üye Tc', uye.uye_ad AS 'Üye Adı', kitap.kitap_id AS 'Kitap No', kitap.kitap_adi AS 'Kitap Adı', FORMAT(kitap.kitap_basimyili, 'MMMM yyyy', 'tr-TR') AS 'Basım Yılı', FORMAT(islem.alinan_tarih, 'dd.MM.yyyy', 'tr-TR') AS 'Alış Tarihi', FORMAT(islem.verilen_tarih, 'dd.MM.yyyy', 'tr-TR') AS 'Teslim Tarihi', FORMAT(islem.teslim_tarihi, 'dd.MM.yyyy', 'tr-TR') AS 'Son Tarih', islem.teslim_durum AS 'Teslim Durumu' " +
                           "FROM islem, uye, kitap "+
                           "WHERE islem.uye_no=uye.uye_id "+
                           "AND islem.kitap_no=kitap.kitap_id "+
                           "ORDER BY islem.teslim_durum DESC";
            SqlDataAdapter sqlda = new SqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            sqlda.Fill(ds);
            dataGridViewEmanet.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        //Kişileri Filtrelemek ve dataGridView1 de göstermek için.
        public void Verileri_filtrele(string sorgu)
        {
            baglanti.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            sqlda.Fill(ds);
            dataGridViewEmanet.DataSource = ds.Tables[0];
            baglanti.Close();
        }



        public void Verileri_kaydet()
        {
            string sorgu = "Insert into islem(uye_no, kitap_no, alinan_tarih, teslim_tarihi, teslim_durum) " +
                           "values " +
                           "(@uye_no, @kitap_no, @alinan_tarih, @teslim_tarihi, @teslim_durum)";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@uye_no", Convert.ToInt32(UyeIDcek(maskedTextBoxEmanetUyeTc.Text)));
            komut.Parameters.AddWithValue("@kitap_no", numericUpDownEmanetKitapNo.Value);
            komut.Parameters.AddWithValue("@alinan_tarih", DateTime.Today);
            komut.Parameters.AddWithValue("@teslim_tarihi", DateTime.Today.AddDays(14));
            komut.Parameters.AddWithValue("@teslim_durum", "Hayır");
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        
        public void Verileri_guncelle()
        {
            string sorgu = "Update islem Set verilen_tarih=@emanetgerial, teslim_durum=@tdurum WHERE islem_id=@islemid";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@emanetgerial", DateTime.Today);
            komut.Parameters.AddWithValue("@tdurum", "Evet");
            komut.Parameters.AddWithValue("@islemid", dataGridViewEmanet.CurrentRow.Cells[0].Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        //
        public void Verileri_sil()
        {
            string sorgu = "Delete From islem Where islem_id=@islemID";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@islemID", dataGridViewEmanet.CurrentRow.Cells[0].Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        //Tüm TextBoxları ve veri giriş yerlerini temizle.
        public void Temizle()
        {
            //İşlem bölümünü temizle
            maskedTextBoxEmanetUyeTc.Clear();
            numericUpDownEmanetKitapNo.Value = 0;
            //Filtreleme bölümünü temizle
            maskedTextBoxEmanetUyeTcFil.Clear();
            numericUpDownEmanetKitapNoFil.Value = 0;
        }

        //Parametre olarak kitap_id alıp kitabın stok adedini döndüren bir metod
        public int KitapStokSayisi(string kitapid)
        {
            string sorgu = "Select kitap_adet from kitap WHERE kitap_id=" + kitapid + "";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            baglanti.Open();
            int sonuc = Convert.ToInt32(komut.ExecuteScalar());
            baglanti.Close();
            return sonuc;
        }

        //Parametre olarak kitap_id si alıp teslim edilmemiş kitapların miktarını döndüren bir metod
        public int VerilenKitapSayisi(string aranan_kitap_no)
        {
            string sorgu = "Select COUNT(kitap_no) from islem WHERE teslim_durum='Hayır' AND kitap_no=" + aranan_kitap_no + "";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            baglanti.Open();
            int sonuc = Convert.ToInt32(komut.ExecuteScalar());
            baglanti.Close();
            return sonuc;
        }

        //Parametre olarak tc alıp üye_id'si döndüren bir metod
        public int UyeIDcek(string uyeTc)
        {
            string sorgu = "Select uye_id from uye WHERE uye_tc='" + uyeTc + "'";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            baglanti.Open();
            int sonuc = Convert.ToInt32(komut.ExecuteScalar());
            baglanti.Close();
            return sonuc;
        }

        //Kitap teslim durumunu döndüren bir metod
        public string Teslim_durum()
        {
            string durum = dataGridViewEmanet.CurrentRow.Cells[8].Value.ToString();
            return durum;
        }
        /*** METODLAR BİTİŞ ***/

        /***----------------------------------------------------------------------------------------***/

        /*** BUTONLAR ***/

        //Emanet Verme Butonu click eventi
        private void buttonEmanetVer_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxEmanetUyeTc.MaskFull == false || numericUpDownEmanetKitapNo.Value == 0)
            {
                DialogResult uyarı = MessageBox.Show("Lütfen tüm alanları doldurunuz!",
                                                      "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (VerilenKitapSayisi(Convert.ToString(numericUpDownEmanetKitapNo.Value.ToString())) >= KitapStokSayisi(Convert.ToString(numericUpDownEmanetKitapNo.Value.ToString())))
            {
                DialogResult uyarı = MessageBox.Show("Emanet veremezsiniz. Stokta şuanda bu kitaptan yok!",
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
                    MessageBox.Show("Emanet Verme Başarısız. Hata: " + errn.Message);
                }
            }
        }

        //Emanet Alma Butonu click eventi
        private void buttonEmanetAl_Click(object sender, EventArgs e)
        {
            if (Teslim_durum() == "Evet")
            {
                DialogResult uyarı = MessageBox.Show("Emanet alamazsınız. Bu kitap daha önceden iade alınmış!",
                                                      "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
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

        //Emanet Kaydı Silme Butonu click eventi
        private void buttonEmanetSil_Click(object sender, EventArgs e)
        {
            DialogResult uyarı = MessageBox.Show("Seçilen Emanet Bilgileri Silinecek Emin misiniz?",
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
                    MessageBox.Show("Emanet Bilgisi Silme Başarısız. Hata: " + errn.Message);
                }
            }
        }

        //Temizle Butonu click eventi.
        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        //Emanet Filtreleme Butonu click eventi
        private void buttonEmanetFil_Click(object sender, EventArgs e)
        {
            //İki bölüm de boşsa
            if (maskedTextBoxEmanetUyeTcFil.MaskFull == false && numericUpDownEmanetKitapNoFil.Value == 0)
            {
                Verilerimi_göster();
            }
            //Tc No bölümü doluysa
            else if (maskedTextBoxEmanetUyeTcFil.MaskFull == true && numericUpDownEmanetKitapNoFil.Value == 0)
            {
                Verileri_filtrele("SELECT islem.islem_id AS 'İşlem No', uye.uye_tc AS 'Üye Tc', uye.uye_ad AS 'Üye Adı', islem.kitap_no AS 'Kitap No', kitap.kitap_adi AS 'Kitap Adı', FORMAT(kitap.kitap_basimyili, 'MMMM yyyy', 'tr-TR') AS 'Basım Yılı', FORMAT(islem.alinan_tarih, 'dd.MM.yyyy', 'tr-TR') AS 'Alış Tarihi', FORMAT(islem.verilen_tarih, 'dd.MM.yyyy', 'tr-TR') AS 'Teslim Tarihi', FORMAT(islem.teslim_tarihi, 'dd.MM.yyyy', 'tr-TR') AS 'Son Tarih', islem.teslim_durum AS 'Teslim Durumu' " +
                                  "FROM islem, uye, kitap "+
                                  "WHERE islem.uye_no=uye.uye_id "+
                                  "AND islem.kitap_no=kitap.kitap_id "+
                                  "AND uye.uye_tc='" + maskedTextBoxEmanetUyeTcFil.Text + "' "+
                                  "ORDER BY teslim_durum DESC");
            }
            //Kitap No bölümü doluysa
            else if (maskedTextBoxEmanetUyeTcFil.MaskFull == false && numericUpDownEmanetKitapNoFil.Value != 0)
            {
                Verileri_filtrele("SELECT islem.islem_id AS 'İşlem No', uye.uye_tc AS 'Üye Tc', uye.uye_ad AS 'Üye Adı', islem.kitap_no AS 'Kitap No', kitap.kitap_adi AS 'Kitap Adı', FORMAT(kitap.kitap_basimyili, 'MMMM yyyy', 'tr-TR') AS 'Basım Yılı', FORMAT(islem.alinan_tarih, 'dd.MM.yyyy', 'tr-TR') AS 'Alış Tarihi', FORMAT(islem.verilen_tarih, 'dd.MM.yyyy', 'tr-TR') AS 'Teslim Tarihi', FORMAT(islem.teslim_tarihi, 'dd.MM.yyyy', 'tr-TR') AS 'Son Tarih', islem.teslim_durum AS 'Teslim Durumu' " +
                                  "FROM islem, uye, kitap " +
                                  "WHERE islem.uye_no=uye.uye_id " +
                                  "AND islem.kitap_no=kitap.kitap_id " +
                                  "AND islem.kitap_no='" + numericUpDownEmanetKitapNoFil.Text + "' "+
                                  "ORDER BY teslim_durum DESC");
            }
            //İki bölüm de doluysa
            else if (maskedTextBoxEmanetUyeTcFil.MaskFull == true && numericUpDownEmanetKitapNoFil.Value != 0)
            {
                Verileri_filtrele("SELECT islem.islem_id AS 'İşlem No', uye.uye_tc AS 'Üye Tc', uye.uye_ad AS 'Üye Adı', islem.kitap_no AS 'Kitap No', kitap.kitap_adi AS 'Kitap Adı', FORMAT(kitap.kitap_basimyili, 'MMMM yyyy', 'tr-TR') AS 'Basım Yılı', FORMAT(islem.alinan_tarih, 'dd.MM.yyyy', 'tr-TR') AS 'Alış Tarihi', FORMAT(islem.verilen_tarih, 'dd.MM.yyyy', 'tr-TR') AS 'Teslim Tarihi', FORMAT(islem.teslim_tarihi, 'dd.MM.yyyy', 'tr-TR') AS 'Son Tarih', islem.teslim_durum AS 'Teslim Durumu' " +
                                  "FROM islem, uye, kitap " +
                                  "WHERE islem.uye_no=uye.uye_id " +
                                  "AND islem.kitap_no=kitap.kitap_id " +
                                  "AND uye.uye_tc='" + maskedTextBoxEmanetUyeTcFil.Text + "' " +
                                  "AND islem.kitap_no='" + numericUpDownEmanetKitapNoFil.Text + "' " +
                                  "ORDER BY teslim_durum DESC");
            }
        }

        //Geri Butonu click eventi
        private void buttonGeriEmanet_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Application.OpenForms["FormAna"].Show();
        }

        
        /*** BUTONLAR BİTİŞ ***/

        /***----------------------------------------------------------------------------------***/

        //dataGridViewUye'de seçilen satırdaki bilgileri aktarmak için.
        private void dataGridViewEmanet_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            maskedTextBoxEmanetUyeTc.Text = dataGridViewEmanet.CurrentRow.Cells[1].Value.ToString();
            numericUpDownEmanetKitapNo.Value = Convert.ToInt32(dataGridViewEmanet.CurrentRow.Cells[3].Value);
        }

       

        //maskedTextBox'lara tıklandığında işaretçiyi en başa almak için Enter eventi tetiklendiğinde çalışacak kodlar.
        /**************-BAŞLANGIÇ-****************/
        private void maskedTextBoxEmanetUyeTc_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate()
            {
                maskedTextBoxEmanetUyeTc.Select(0, 0);
            });
        }

        private void maskedTextBoxEmanetUyeTcFil_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate()
            {
                maskedTextBoxEmanetUyeTcFil.Select(0, 0);
            });
        }
        /**************-BİTİŞ-****************/

        //Form kapanırken yapılacaklar.
        private void FormEmanet_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["FormAna"].Show();
        }
        
    }
}
