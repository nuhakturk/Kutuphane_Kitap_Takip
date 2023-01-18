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
    public partial class FormUye : Form
    {
        //Bağlantı stringi
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-U5FIOK2\\SQLEXPRESS;Initial Catalog=kutuphane;Integrated Security=True;");
        public FormUye()
        {
            InitializeComponent();
        }

        private void FormUye_Load(object sender, EventArgs e)
        {
            Verilerimi_göster();
            Temizle();
            dateTimePicker1.Value = DateTime.Now.AddYears(-7);
            dateTimePicker1.MaxDate = dateTimePicker1.Value;
        }
        /***----------------------------------------------------------------------------------------***/
        /*** METODLAR ***/
        //dataGridViewUye'de üye tablosunu göstermek için Sql query gönderebildiğim bir metod.
        public void Verilerimi_göster()
        {
            baglanti.Open();
            string sorgu = "SELECT uye_id AS 'Üye No', uye_tc AS 'Tc No', uye_ad AS 'Ad', uye_soyad AS 'Soyad', uye_cinsiyet AS 'Cinsiyet', uye_dtarih AS 'Doğum Tarihi', uye_tel AS 'Telefon' FROM uye";
            SqlDataAdapter sqlda = new SqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            sqlda.Fill(ds);
            dataGridViewUye.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        //Kişileri Filtrelemek ve dataGridView1 de göstermek için.
        public void Verileri_filtrele(string sorgu)
        {
            baglanti.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            sqlda.Fill(ds);
            dataGridViewUye.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        public void Verileri_kaydet()
        {
            string sorgu = "Insert into uye (uye_tc, uye_ad, uye_soyad, uye_cinsiyet, uye_dtarih, uye_tel) values (@tc, @ad, @soyad, @cinsiyet, @dtarih, @tel)";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@tc", maskedTextBoxUyeTc.Text);
            komut.Parameters.AddWithValue("@ad", textBoxUyeAd.Text);
            komut.Parameters.AddWithValue("@soyad", textBoxUyeSoyad.Text);
            if (radioButtonCinsiyetE.Checked == true)
                komut.Parameters.AddWithValue("@cinsiyet", 'E');
            else if(radioButtonCinsiyetK.Checked == true)
                komut.Parameters.AddWithValue("@cinsiyet", 'K');
            komut.Parameters.AddWithValue("@dtarih", dateTimePicker1.Value.Date);
            komut.Parameters.AddWithValue("@tel", maskedTextBoxUyeTel.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }


        public void Verileri_guncelle()
        {
            string sorgu = "Update uye Set uye_tc=@tc, uye_ad=@ad, uye_soyad=@soyad, uye_cinsiyet=@cinsiyet, uye_dtarih=@dtarih, uye_tel=@tel WHERE uye_id=@uyeid and uye_tc=@uyetc";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@tc", maskedTextBoxUyeTc.Text);
            komut.Parameters.AddWithValue("@ad", textBoxUyeAd.Text);
            komut.Parameters.AddWithValue("@soyad", textBoxUyeSoyad.Text);
            if (radioButtonCinsiyetE.Checked == true)
                komut.Parameters.AddWithValue("@cinsiyet", 'E');
            else if (radioButtonCinsiyetK.Checked == true)
                komut.Parameters.AddWithValue("@cinsiyet", 'K');
            komut.Parameters.AddWithValue("@dtarih", dateTimePicker1.Value.Date);
            komut.Parameters.AddWithValue("@tel", maskedTextBoxUyeTel.Text);
            komut.Parameters.AddWithValue("@uyeid", dataGridViewUye.CurrentRow.Cells[0].Value);
            komut.Parameters.AddWithValue("@uyetc", dataGridViewUye.CurrentRow.Cells[1].Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public void Verileri_sil()
        {
            string sorgu = "Delete From uye Where uye_id=@uyeno and uye_tc=@tc";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@uyeno", dataGridViewUye.CurrentRow.Cells[0].Value);
            komut.Parameters.AddWithValue("@tc", dataGridViewUye.CurrentRow.Cells[1].Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        //Tüm TextBoxları temizle.
        public void Temizle()
        {
            
            maskedTextBoxUyeTc.Clear();
            textBoxUyeAd.Clear();
            textBoxUyeSoyad.Clear();
            radioButtonCinsiyetE.Checked = true;
            radioButtonCinsiyetK.Checked = false;
            dateTimePicker1.Value = dateTimePicker1.MaxDate;
            maskedTextBoxUyeTel.Clear();
            maskedTextBoxTcNoFil.Clear();
            textBoxUyeAdFil.Clear();
        }


        public int TcVarmi(string aranan_tc)
        {
            string sorgu = "Select COUNT(uye_tc) from uye WHERE uye_tc='"+aranan_tc+"'";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            baglanti.Open();
            int sonuc = Convert.ToInt32(komut.ExecuteNonQuery());
            baglanti.Close();
            return sonuc;
        }

        /*** METODLAR BİTİŞ ***/

        /***----------------------------------------------------------------------------------------***/
        
        /*** BUTONLAR ***/

        //Üye Ekleme Butonu click eventi
        private void buttonUyeEkle_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxUyeTc.MaskFull == false || textBoxUyeAd.Text == "" ||
                textBoxUyeSoyad.Text == "" || maskedTextBoxUyeTel.MaskFull == false)
            {
                DialogResult uyarı = MessageBox.Show("Lütfen tüm alanları doldurunuz!",
                                                      "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (TcVarmi(maskedTextBoxUyeTc.Text) != 0)
            {
                DialogResult tc_uyari = MessageBox.Show("Bu TC Numarası ile daha önce kayıt yapılmış!",
                                                        "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                    MessageBox.Show("Üye Ekleme Başarısız. Hata: " + errn.Message);
                }
            }
        }

        //Üye Güncelleme Butonu click eventi
        private void buttonUyeGuncelle_Click(object sender, EventArgs e)
        {
            //Üye verilerinin olduğu satırlar boş ise hata mesajı ver.
            if (maskedTextBoxUyeTc.MaskFull == false || textBoxUyeAd.Text == "" ||
                textBoxUyeSoyad.Text == "" || maskedTextBoxUyeTel.MaskFull == false)
            {
                DialogResult uyarı = MessageBox.Show("Lütfen tüm alanları doldurunuz!",
                                                      "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                DialogResult uyarı = MessageBox.Show("Seçilen Üye Bilgileri Güncellenecek Emin misiniz?",
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
                        MessageBox.Show("Güncelleme Başarısız. Hata: " + errn.Message);
                    }
                }
            }
        }

        //Üye Silme Butonu click eventi
        private void buttonUyeSil_Click(object sender, EventArgs e)
        {
            DialogResult uyarı = MessageBox.Show("Seçilen Üye Silinecek Emin misiniz?",
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
                    MessageBox.Show("Üye Silme Başarısız. Hata: " + errn.Message);
                }
            }
        }

        //Temizleme Butonu click eventi
        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        //Üye Filtreleme Butonu click eventi
        private void buttonUyeFil_Click(object sender, EventArgs e)
        {
            //İki bölüm de boşsa
            if (maskedTextBoxTcNoFil.MaskFull == false && textBoxUyeAdFil.Text == "")
            {
                Verilerimi_göster();
            }
            //Tc No bölümü doluysa
            else if (maskedTextBoxTcNoFil.MaskFull == true && textBoxUyeAdFil.Text == "")
            {
                Verileri_filtrele("SELECT uye_id AS 'Üye No', uye_tc AS 'Tc No', uye_ad AS 'Ad', uye_soyad AS 'Soyad', uye_cinsiyet AS 'Cinsiyet', uye_dtarih AS 'Doğum Tarihi', uye_tel AS 'Telefon' FROM uye WHERE uye_tc='"+maskedTextBoxTcNoFil.Text+"'");
            }
            //Ad bölümü doluysa
            else if (maskedTextBoxTcNoFil.MaskFull == false && textBoxUyeAdFil.Text != "")
            {
                Verileri_filtrele("SELECT uye_id AS 'Üye No', uye_tc AS 'Tc No', uye_ad AS 'Ad', uye_soyad AS 'Soyad', uye_cinsiyet AS 'Cinsiyet', uye_dtarih AS 'Doğum Tarihi', uye_tel AS 'Telefon' FROM uye WHERE uye_ad LIKE '%"+textBoxUyeAdFil.Text+"%'");
            }
            //İki bölüm de doluysa
            else if (maskedTextBoxTcNoFil.MaskFull == true && textBoxUyeAdFil.Text != "")
            {
                Verileri_filtrele("SELECT uye_id AS 'Üye No', uye_tc AS 'Tc No', uye_ad AS 'Ad', uye_soyad AS 'Soyad', uye_cinsiyet AS 'Cinsiyet', uye_dtarih AS 'Doğum Tarihi', uye_tel AS 'Telefon' FROM uye WHERE uye_tc="+maskedTextBoxTcNoFil.Text+" and uye_ad='"+textBoxUyeAdFil.Text+"'");
            }
        }

        //Geri Butonu click eventi
        private void buttonGeriUye_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Application.OpenForms["FormAna"].Show();
        }
        /*** BUTONLAR BİTİŞ ***/
        /***----------------------------------------------------------------------------------***/

        //dataGridViewUye'de seçilen satırdaki kişinin bilgilerini textBox, radioButton ve datetimepicker'e aktarmak için
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            maskedTextBoxUyeTc.Text = dataGridViewUye.CurrentRow.Cells[1].Value.ToString();
            textBoxUyeAd.Text = dataGridViewUye.CurrentRow.Cells[2].Value.ToString();
            textBoxUyeSoyad.Text = dataGridViewUye.CurrentRow.Cells[3].Value.ToString();
            if ("E" == dataGridViewUye.CurrentRow.Cells[4].Value.ToString())
            {
                radioButtonCinsiyetE.Checked = true;
            }
            else if ("K" == dataGridViewUye.CurrentRow.Cells[4].Value.ToString())
            {
                radioButtonCinsiyetK.Checked = true;
            }
            dateTimePicker1.Value = Convert.ToDateTime(dataGridViewUye.CurrentRow.Cells[5].Value);
            maskedTextBoxUyeTel.Text = dataGridViewUye.CurrentRow.Cells[6].Value.ToString();
        }
        
        //maskedTextBox'lara tıklandığında işaretçiyi en başa almak için Enter eventi tetiklendiğinde çalışacak kodlar.
        /**************-BAŞLANGIÇ-****************/
        private void maskedTextBoxUyeTc_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate()
            {
                maskedTextBoxUyeTc.Select(0, 0);
            });
        }

        private void maskedTextBoxUyeTel_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate()
            {
                maskedTextBoxUyeTel.Select(0, 0);
            });
        }

        private void maskedTextBoxTcNoFil_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate()
            {
                maskedTextBoxTcNoFil.Select(0, 0);
            });
        }
        /**************-BİTİŞ-****************/

        //Form kapanırken
        private void FormUye_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["FormAna"].Show();
        }
    }
}
