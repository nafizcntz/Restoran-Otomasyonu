using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASCI
{
    public partial class musteriEkranGiris : MetroFramework.Forms.MetroForm
    {
        public musteriEkranGiris()
        {
            InitializeComponent();
        }

        private void MusteriEkran_Load(object sender, EventArgs e)
        {

        }

        private void İsimTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            button1.Visible = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            musteriEkranAna.musteriAd = isimTXT.Text;

            musteriEkranAna ekran = new musteriEkranAna();
            ekran.Show();
            this.Hide();
        }
    }
}
