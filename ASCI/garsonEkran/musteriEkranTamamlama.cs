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
    public partial class musteriEkranTamamlama : MetroFramework.Forms.MetroForm
    {
        musteriEkranAna musteriEkran;
        public ListView list;
        string toplamYazi;
        public musteriEkranTamamlama(musteriEkranAna musteriEkran1,string toplam)
        {
            musteriEkran = musteriEkran1;
            toplamYazi= toplam;
            InitializeComponent();
        }

        private void MusteriEkranTamamlama_Load(object sender, EventArgs e)
        {
            yaziLbl.Text += toplamYazi + " TL DEĞERİNDEKİ SİPARİŞİ ONAYLIYOR MUSUNUZ ?";

        }

        private void GeriyeDon_Click(object sender, EventArgs e)
        {
            musteriEkran.Show();
            this.Hide();
        }

        private void SiparisiOnayla_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
