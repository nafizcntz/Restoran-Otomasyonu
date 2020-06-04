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
    public partial class YöneticiEkrani : Form
    {
        public YöneticiEkrani()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            h ElemanEkrani = new h();
            this.Hide();
            ElemanEkrani.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FiyatDegistir fiyatekrani = new FiyatDegistir();
            this.Hide();
            fiyatekrani.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayac=0;
            int yemekaratutar;
            int anayemektoplami = 0;
            int corbatoplami = 0;
            int icecektoplami = 0;
            int salatatoplami = 0;
            int tatlitoplami = 0;
            Siparis sprs = new Siparis();
            sprs.Gun = dateTimePicker1.Value.Day.ToString();
            sprs.Ay = dateTimePicker1.Value.Month.ToString();
            sprs.Yil = dateTimePicker1.Value.Year.ToString();
            dgvAnayemekSatis.DataSource = sprs.satislariGoster(sprs.Gun, sprs.Ay, sprs.Yil, 0);
            dgvCorbaSatis.DataSource = sprs.satislariGoster(sprs.Gun,sprs.Ay,sprs.Yil, 1);
            dgvSalataSatis.DataSource = sprs.satislariGoster(sprs.Gun,sprs.Ay,sprs.Yil, 2);
            dgvTatliSatis.DataSource = sprs.satislariGoster(sprs.Gun,sprs.Ay,sprs.Yil, 3);
            dgvIcecekSatis.DataSource = sprs.satislariGoster(sprs.Gun,sprs.Ay,sprs.Yil, 4);
            while(dgvAnayemekSatis.Rows[sayac].Cells["ürünhasılatı"].Value != null)
            {
                yemekaratutar = Convert.ToInt32(dgvAnayemekSatis.Rows[sayac].Cells["ürünhasılatı"].FormattedValue);
                anayemektoplami += yemekaratutar;
                sayac++;
            }
            sayac = 0;
            while (dgvCorbaSatis.Rows[sayac].Cells["ürünhasılatı"].Value != null)
            {
                yemekaratutar = Convert.ToInt32(dgvCorbaSatis.Rows[sayac].Cells["ürünhasılatı"].FormattedValue);
                corbatoplami += yemekaratutar;
                sayac++;
            }
            sayac = 0;
            while (dgvIcecekSatis.Rows[sayac].Cells["ürünhasılatı"].Value != null)
            {
                yemekaratutar = Convert.ToInt32(dgvIcecekSatis.Rows[sayac].Cells["ürünhasılatı"].FormattedValue);
                icecektoplami += yemekaratutar;
                sayac++;
            }
            sayac = 0;
            while (dgvSalataSatis.Rows[sayac].Cells["ürünhasılatı"].Value != null)
            {
                yemekaratutar = Convert.ToInt32(dgvSalataSatis.Rows[sayac].Cells["ürünhasılatı"].FormattedValue);
                salatatoplami += yemekaratutar;
                sayac++;
            }
            sayac = 0;
            while (dgvTatliSatis.Rows[sayac].Cells["ürünhasılatı"].Value != null)
            {
                yemekaratutar = Convert.ToInt32(dgvTatliSatis.Rows[sayac].Cells["ürünhasılatı"].FormattedValue);
                tatlitoplami += yemekaratutar;
                sayac++;
            }
            lblAnayemekToplami.Text = anayemektoplami.ToString() + " lira";
            lblCorbaToplami.Text = corbatoplami.ToString() + " lira"; 
            lblIcecekToplami.Text = icecektoplami.ToString() + " lira";
            lblSalataToplami.Text = salatatoplami.ToString() + " lira";
            lblTatliToplami.Text = tatlitoplami.ToString() + " lira";
            int geneltoplam = anayemektoplami + corbatoplami + icecektoplami + salatatoplami + tatlitoplami;
            lblGenelToplam.Text = geneltoplam.ToString() + " lira";
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void YöneticiEkrani_Load(object sender, EventArgs e)
        {
            Siparis sprs = new Siparis();

            sprs.Gun = dateTimePicker1.Value.Day.ToString();
            sprs.Ay = dateTimePicker1.Value.Month.ToString();
            sprs.Yil = dateTimePicker1.Value.Year.ToString();
            dgvAnayemekSatis.DataSource = sprs.satislariGoster(sprs.Gun,sprs.Ay,sprs.Yil, 0);
            dgvCorbaSatis.DataSource = sprs.satislariGoster(sprs.Gun,sprs.Ay,sprs.Yil, 1);
            dgvSalataSatis.DataSource = sprs.satislariGoster(sprs.Gun,sprs.Ay,sprs.Yil, 2);
            dgvTatliSatis.DataSource = sprs.satislariGoster(sprs.Gun,sprs.Ay,sprs.Yil, 3);
            dgvIcecekSatis.DataSource = sprs.satislariGoster(sprs.Gun,sprs.Ay,sprs.Yil, 4);
        }

        private void YöneticiEkrani_Leave(object sender, EventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void lblSalata_Click(object sender, EventArgs e)
        {

        }
    }
}

