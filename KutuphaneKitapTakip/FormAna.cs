using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneKitapTakip
{
    public partial class FormAna : Form
    {
        public FormAna()
        {
            InitializeComponent();
        }


        private void buttonEmanetIslem_Click(object sender, EventArgs e)
        {
            FormEmanet formEmanetI = new FormEmanet();
            formEmanetI.Show();
            this.Hide();
        }

        private void buttonKitapIslem_Click(object sender, EventArgs e)
        {
            FormKitap formKitapI = new FormKitap();
            formKitapI.Show();
            this.Hide();
        }

        private void buttonUyeIslem_Click(object sender, EventArgs e)
        {
            FormUye formUyeI = new FormUye();
            formUyeI.Show();
            this.Hide();
        }

        private void buttonGecikenKitaplar_Click(object sender, EventArgs e)
        {
            FormGecikme formGecikenKI = new FormGecikme();
            formGecikenKI.Show();
            this.Hide();
        }

    }
}
