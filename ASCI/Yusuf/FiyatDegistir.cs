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
    public partial class FiyatDegistir : Form
    {
        public FiyatDegistir()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YemekBilgileri ymkBlg = new YemekBilgileri();
            bool kontrol= true;
            if (tbUrunismi_degistir.Text=="")
            {
                hata1.Text = "*";
                hata.Text = "ÜRÜN İSMİ GİRİNİZ";
                kontrol = false;
            }
            if (tbUrunyenifiyati.Text=="")
            {
                hata2.Text = "*";
                hata.Text = "ÜRÜN İÇİN YENİ FİYAT GİRİNİZ";
                kontrol = false;
            }
            if (kontrol==false)
            {
                return;
            }
            else
            {
                ymkBlg.YemekAdi = tbUrunismi_degistir.Text.Trim();
                ymkBlg.YemekFiyati =tbUrunyenifiyati.Text.Trim();
                ymkBlg.yemekDuzenle(ymkBlg.YemekAdi, ymkBlg.YemekFiyati);
                tbUrunismi_degistir.Text = "";
                tbUrunyenifiyati.Text = "";
                tbUrunid.Text = "";
                tburunismi_eklesil.Text = "";
                tbUrunfiyati.Text = "";
                hata.Text = "";
                hata1.Text = "";
                hata2.Text = "";
                hata3.Text = "";
                hata4.Text = "";
                hata5.Text = "";
                groupBox1.Hide();
                dataGridViewAnayemek.DataSource = ymkBlg.anaYemekGoster();
                dataGridViewCorba.DataSource = ymkBlg.corbaGoster();
                dataGridViewIcecek.DataSource = ymkBlg.icecekGoster();
                dataGridViewSalata.DataSource = ymkBlg.salataGoster();
                dataGridViewTatli.DataSource = ymkBlg.tatliGoster();
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FiyatDegistir_Load(object sender, EventArgs e)
        {
            YemekBilgileri ymk = new YemekBilgileri();
            dataGridViewAnayemek.DataSource = ymk.anaYemekGoster();
            dataGridViewCorba.DataSource = ymk.corbaGoster();
            dataGridViewIcecek.DataSource = ymk.icecekGoster();
            dataGridViewSalata.DataSource = ymk.salataGoster();
            dataGridViewTatli.DataSource = ymk.tatliGoster();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            groupBox2.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox2.Show();
            groupBox1.Hide();
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            YemekBilgileri ymk = new YemekBilgileri();
            dataGridViewAnayemek.DataSource = ymk.anaYemekGoster();
            dataGridViewCorba.DataSource = ymk.corbaGoster();
            dataGridViewIcecek.DataSource = ymk.icecekGoster();
            dataGridViewSalata.DataSource = ymk.salataGoster();
            dataGridViewTatli.DataSource = ymk.tatliGoster();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            YemekBilgileri ymk = new YemekBilgileri();
            bool kontrol = true;
            if (tbUrunid.Text == "")
            {
                hata3.Text = "*";
                hata.Text = "ÜRÜN ID'Yİ BOŞ BIRAKTINIZ";
                kontrol = false;
            }
            if (tburunismi_eklesil.Text == "")
            {
                hata4.Text = "*";
                hata.Text = "ÜRÜN İSMİ GİRİNİZ";
                kontrol = false;
            }
            if (tbUrunfiyati.Text == "")
            {
                hata5.Text = "*";
                hata.Text = "ÜRÜN FİYATI GİRİNİZ";
                kontrol = false;
            }
            if (!kontrol)
            {
                return;
            }
            else
            {
                ymk.YemekID = Convert.ToInt32(tbUrunid.Text.Trim());
                ymk.YemekAdi = tburunismi_eklesil.Text.Trim();
                ymk.YemekFiyati =tbUrunfiyati.Text.Trim();
                ymk.yemekEkle(ymk.YemekAdi, ymk.YemekID, ymk.YemekFiyati);
                tbUrunismi_degistir.Text = "";
                tbUrunyenifiyati.Text = "";
                tbUrunid.Text = "";
                tburunismi_eklesil.Text = "";
                tbUrunfiyati.Text = "";
                hata.Text = "";
                hata1.Text = "";
                hata2.Text = "";
                hata3.Text = "";
                hata4.Text = "";
                hata5.Text = "";
                groupBox2.Hide();
                dataGridViewAnayemek.DataSource = ymk.anaYemekGoster();
                dataGridViewCorba.DataSource = ymk.corbaGoster();
                dataGridViewIcecek.DataSource = ymk.icecekGoster();
                dataGridViewSalata.DataSource = ymk.salataGoster();
                dataGridViewTatli.DataSource = ymk.tatliGoster();
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewTatli_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            YemekBilgileri ymkblg = new YemekBilgileri();
            if (dataGridViewTatli.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                ymkblg.YemekID=Convert.ToInt32(dataGridViewTatli.Rows[e.RowIndex].Cells["id"].FormattedValue);
                ymkblg.YemekAdi = dataGridViewTatli.Rows[e.RowIndex].Cells["yemekAd"].FormattedValue.ToString();
                ymkblg.YemekFiyati = dataGridViewTatli.Rows[e.RowIndex].Cells["yemekFiyat"].FormattedValue.ToString();
            }
            DialogResult uyari = new DialogResult();
            uyari = MessageBox.Show(ymkblg.YemekAdi + " adlı ürünü silmek istiyor musunuz?", "UYARI", MessageBoxButtons.YesNo);
            if (uyari==DialogResult.Yes)
            {
                ymkblg.yemekSil(ymkblg.YemekAdi);
            }
            else
            {
                return;
            }
        }

        private void dataGridViewAnayemek_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewSalata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            YemekBilgileri ymkblg = new YemekBilgileri();
            if (dataGridViewSalata.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                ymkblg.YemekID = Convert.ToInt32(dataGridViewSalata.Rows[e.RowIndex].Cells["id"].FormattedValue);
                ymkblg.YemekAdi = dataGridViewSalata.Rows[e.RowIndex].Cells["yemekAd"].FormattedValue.ToString();
                ymkblg.YemekFiyati = dataGridViewSalata.Rows[e.RowIndex].Cells["yemekFiyat"].FormattedValue.ToString();
            }
            DialogResult uyari = new DialogResult();
            uyari = MessageBox.Show(ymkblg.YemekAdi + " adlı ürünü silmek istiyor musunuz?", "UYARI", MessageBoxButtons.YesNo);
            if (uyari == DialogResult.Yes)
            {
                ymkblg.yemekSil(ymkblg.YemekAdi);
            }
            else
            {
                return;
            }
        }

        private void dataGridViewIcecek_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridViewIcecek_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            YemekBilgileri ymkblg = new YemekBilgileri();
            if (dataGridViewIcecek.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                ymkblg.YemekID = Convert.ToInt32(dataGridViewIcecek.Rows[e.RowIndex].Cells["id"].FormattedValue);
                ymkblg.YemekAdi = dataGridViewIcecek.Rows[e.RowIndex].Cells["yemekAd"].FormattedValue.ToString();
                ymkblg.YemekFiyati = dataGridViewIcecek.Rows[e.RowIndex].Cells["yemekFiyat"].FormattedValue.ToString();
            }
            DialogResult uyari = new DialogResult();
            uyari = MessageBox.Show(ymkblg.YemekAdi + " adlı ürünü silmek istiyor musunuz?", "UYARI", MessageBoxButtons.YesNo);
            if (uyari == DialogResult.Yes)
            {
                ymkblg.yemekSil(ymkblg.YemekAdi);
            }
            else
            {
                return;
            }
        }

        private void dataGridViewCorba_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            YemekBilgileri ymkblg = new YemekBilgileri();
            if (dataGridViewCorba.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                ymkblg.YemekID = Convert.ToInt32(dataGridViewCorba.Rows[e.RowIndex].Cells["id"].FormattedValue);
                ymkblg.YemekAdi = dataGridViewCorba.Rows[e.RowIndex].Cells["yemekAd"].FormattedValue.ToString();
                ymkblg.YemekFiyati = dataGridViewCorba.Rows[e.RowIndex].Cells["yemekFiyat"].FormattedValue.ToString();
            }
            DialogResult uyari = new DialogResult();
            uyari = MessageBox.Show(ymkblg.YemekAdi + " adlı ürünü silmek istiyor musunuz?", "UYARI", MessageBoxButtons.YesNo);
            if (uyari == DialogResult.Yes)
            {
                ymkblg.yemekSil(ymkblg.YemekAdi);
            }
            else
            {
                return;
            }
        }

        private void dataGridViewAnayemek_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            YemekBilgileri ymkblg = new YemekBilgileri();
            if (dataGridViewAnayemek.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                ymkblg.YemekID = Convert.ToInt32(dataGridViewIcecek.Rows[e.RowIndex].Cells["id"].FormattedValue);
                ymkblg.YemekAdi = dataGridViewAnayemek.Rows[e.RowIndex].Cells["yemekAd"].FormattedValue.ToString();
                ymkblg.YemekFiyati = dataGridViewAnayemek.Rows[e.RowIndex].Cells["yemekFiyat"].FormattedValue.ToString();
            }
            DialogResult uyari = new DialogResult();
            uyari = MessageBox.Show(ymkblg.YemekAdi + " adlı ürünü silmek istiyor musunuz?", "UYARI", MessageBoxButtons.YesNo);
            if (uyari == DialogResult.Yes)
            {
                ymkblg.yemekSil(ymkblg.YemekAdi);
            }
            else
            {
                return;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            YöneticiEkrani yonekrani = new YöneticiEkrani();
            this.Close();
            yonekrani.Show();
        }
    }
}
