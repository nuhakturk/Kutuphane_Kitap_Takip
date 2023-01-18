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
    public partial class FormGecikme : Form
    {
        //Bağlantı stringi
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-U5FIOK2\\SQLEXPRESS;Initial Catalog=kutuphane;Integrated Security=True;");

        public FormGecikme()
        {
            InitializeComponent();
        }

        //Form Yüklendiğinde Yapılacaklar
        private void FormGecikme_Load(object sender, EventArgs e)
        {
            Verilerimi_göster();
        }

        //dataGridViewGeciken'de son teslim tarihi geçen kitapları listelediğim bir metod.
        public void Verilerimi_göster()
        {
            baglanti.Open();
            string sorgu = "SELECT islem.islem_id AS 'İşlem No', uye.uye_tc AS 'Üye Tc', uye.uye_ad AS 'Üye Adı', kitap.kitap_id AS 'Kitap No', kitap.kitap_adi AS 'Kitap Adı', FORMAT(kitap.kitap_basimyili, 'MMMM yyyy', 'tr-TR') AS 'Basım Yılı', FORMAT(islem.alinan_tarih, 'dd.MM.yyyy', 'tr-TR') AS 'Alış Tarihi', FORMAT(islem.verilen_tarih, 'dd.MM.yyyy', 'tr-TR') AS 'Teslim Tarihi', FORMAT(islem.teslim_tarihi, 'dd.MM.yyyy', 'tr-TR') AS 'Son Tarih', islem.teslim_durum AS 'Teslim Durumu' "+
                           "FROM islem, uye, kitap "+
                           "WHERE islem.uye_no=uye.uye_id "+
                           "AND islem.kitap_no=kitap.kitap_id "+
						   "AND GETDATE() > islem.teslim_tarihi "+
						   "AND islem.teslim_durum='Hayır' "+
                           "ORDER BY islem.teslim_durum DESC";
            SqlDataAdapter sqlda = new SqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            sqlda.Fill(ds);
            dataGridViewGeciken.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        //Geri butonu click eventi
        private void buttonGeriGecikme_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Application.OpenForms["FormAna"].Show();
        }

        //Form kapanırken yapılacaklar.
        private void FormGecikme_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["FormAna"].Show();
        }

        
    }
}
