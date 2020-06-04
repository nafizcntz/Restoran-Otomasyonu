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
    public partial class h : Form
    {
        public h()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Eleman_Düzenleme_Ekrani_Load(object sender, EventArgs e)
        {
            eleman elm = new eleman();
            dataGridViewEleman.DataSource = elm.elemanBilgileriGoster();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBox1.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Show();
            groupBox3.Show();
            btnTamamla.Show();
            lblnasilsilinir.Hide();
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            eleman elm = new eleman();
            if (dataGridViewEleman.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                elm.ElemanID = Convert.ToInt32(dataGridViewEleman.Rows[e.RowIndex].Cells["elemanID"].FormattedValue);
                elm.ElemanAdi = dataGridViewEleman.Rows[e.RowIndex].Cells["elemanAdi"].FormattedValue.ToString();
                elm.ElemanSoyadi = dataGridViewEleman.Rows[e.RowIndex].Cells["elemanSoyadi"].FormattedValue.ToString();
                elm.ElemanSifre= dataGridViewEleman.Rows[e.RowIndex].Cells["elemanSifre"].FormattedValue.ToString();
                elm.ElemanMaasi = Convert.ToInt32(dataGridViewEleman.Rows[e.RowIndex].Cells["elemanMaasi"].FormattedValue);
                elm.ElemanVasif = dataGridViewEleman.Rows[e.RowIndex].Cells["elemanVasif"].FormattedValue.ToString();
            }
            DialogResult uyari = new DialogResult();
            uyari = MessageBox.Show(elm.ElemanAdi+" "+elm.ElemanSoyadi + " adlı elemanı silmek istiyor musunuz?", "UYARI", MessageBoxButtons.YesNo);
            if (uyari == DialogResult.Yes)
            {
                elm.elemanSil(elm.ElemanID);
                dataGridViewEleman.DataSource = elm.elemanBilgileriGoster();
            }
            else
            {
                return;
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Hide();
            groupBox3.Hide();
            btnTamamla.Show();
            lblnasilsilinir.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            btnTamamla.Show();
            groupBox2.Show();
            groupBox3.Hide();
            lblnasilsilinir.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            eleman elm = new eleman();


            if (rdbtnEkle.Checked)
            {
                bool bosEkleme = false;
                if (tbElemanAdi.Text == "")
                {
                    hata1.ForeColor = Color.Red;
                    hata1.Text = "*";
                    hata.Text = "BOŞ ALANLARI DOLDURUNUZ";
                    bosEkleme = true;
                }
                if (tbElemanSoyadi.Text == "")
                {
                    hata2.ForeColor = Color.Red;
                    hata2.Text = "*";
                    hata.Text = "BOŞ ALANLARI DOLDURUNUZ";
                    bosEkleme = true;
                }
                if (tbElemanSifresi.Text == "")
                {
                    hata3.ForeColor = Color.Red;
                    hata3.Text = "*";
                    hata.Text = "BOŞ ALANLARI DOLDURUNUZ";
                    bosEkleme = true;
                }
                if (tbElemanMaasi.Text == "")
                {
                    hata4.ForeColor = Color.Red;
                    hata4.Text = "*";
                    hata.Text = "BOŞ ALANLARI DOLDURUNUZ";
                    bosEkleme = true;
                }
                if (cbElemanVasfi.Text == "")
                {
                    hata5.ForeColor = Color.Red;
                    hata5.Text = "*";
                    hata.Text = "BOŞ ALANLARI DOLDURUNUZ";
                    bosEkleme = true;
                }
                if (bosEkleme == false)
                {
                    elm.ElemanAdi = tbElemanAdi.Text;
                    elm.ElemanSoyadi = tbElemanSoyadi.Text;
                    elm.ElemanSifre = tbElemanSifresi.Text;
                    elm.ElemanMaasi = Convert.ToInt32(tbElemanMaasi.Text);
                    elm.ElemanVasif = cbElemanVasfi.Text;
                    elm.elemanEkle(elm.ElemanAdi, elm.ElemanSoyadi, elm.ElemanSifre, elm.ElemanMaasi, elm.ElemanVasif);
                    tbElemanId.Text = "";
                    tbElemanAdi.Text = "";
                    tbElemanSoyadi.Text = "";
                    tbElemanSifresi.Text = "";
                    tbElemanMaasi.Text = "";
                    cbElemanVasfi.Text = "";
                }
                
            }
            if (rdbtnDuzenle.Checked)
            {
                bool bosDuzenleme = false;
                if (tbElemanId.Text == "")
                {
                    hata6.ForeColor = Color.Red;
                    hata6.Text = "*";
                    hata.Text = "BOŞ ALANLARI DOLDURUNUZ";
                    bosDuzenleme = true;
                }
                if (tbElemanAdi.Text == "")
                {
                    hata1.ForeColor = Color.Red;
                    hata1.Text = "*";
                    hata.Text = "BOŞ ALANLARI DOLDURUNUZ";
                    bosDuzenleme = true;
                }
                if (tbElemanSoyadi.Text == "")
                {
                    hata2.ForeColor = Color.Red;
                    hata2.Text = "*";
                    hata.Text = "BOŞ ALANLARI DOLDURUNUZ";
                    bosDuzenleme = true;
                }
                if (tbElemanSifresi.Text == "")
                {
                    hata3.ForeColor = Color.Red;
                    hata3.Text = "*";
                    hata.Text = "BOŞ ALANLARI DOLDURUNUZ";
                    bosDuzenleme = true;
                }
                if (tbElemanMaasi.Text == "")
                {
                    hata4.ForeColor = Color.Red;
                    hata4.Text = "*";
                    hata.Text = "BOŞ ALANLARI DOLDURUNUZ";
                    bosDuzenleme = true;
                }
                if (cbElemanVasfi.Text == "")
                {
                    hata5.ForeColor = Color.Red;
                    hata5.Text = "*";
                    hata.Text = "BOŞ ALANLARI DOLDURUNUZ";
                    bosDuzenleme = true;
                }
                if (bosDuzenleme == false)
                {
                    elm.ElemanID = Convert.ToInt32(tbElemanId.Text);
                    elm.ElemanAdi = tbElemanAdi.Text;
                    elm.ElemanSoyadi = tbElemanSoyadi.Text;
                    elm.ElemanSifre = tbElemanSifresi.Text;
                    elm.ElemanMaasi = Convert.ToInt32(tbElemanMaasi.Text);
                    elm.ElemanVasif = cbElemanVasfi.Text;
                    elm.elemanGuncelle(elm.ElemanAdi, elm.ElemanSoyadi, elm.ElemanSifre, elm.ElemanMaasi, elm.ElemanVasif, elm.ElemanID);
                    tbElemanId.Text = "";
                    tbElemanAdi.Text = "";
                    tbElemanSoyadi.Text = "";
                    tbElemanSifresi.Text = "";
                    tbElemanMaasi.Text = "";
                    cbElemanVasfi.Text = "";
                }

            }
            if (rdbtnSil.Checked)
            {
                
                if (tbElemanId.Text == "")
                {
                    hata6.ForeColor = Color.Red;
                    hata6.Text = "*";
                    hata.Text = "BOŞ ALANI DOLDURUNUZ";
                    return;
                }
                
                DialogResult uyari = new DialogResult();
                uyari = MessageBox.Show(tbElemanId.Text + " numaralı elemanı silmek istiyor musunuz?", "UYARI", MessageBoxButtons.YesNo);
                if (uyari == DialogResult.No)
                {
                    return;
                }
                else
                {
                    elm.ElemanID = Convert.ToInt32(tbElemanId.Text);
                    elm.elemanSil(elm.ElemanID);
                    tbElemanId.Text = "";
                    tbElemanAdi.Text = "";
                    tbElemanSoyadi.Text = "";
                    tbElemanSifresi.Text = "";
                    tbElemanMaasi.Text = "";
                    cbElemanVasfi.Text = "";
                }
                
            }
            dataGridViewEleman.DataSource = elm.elemanBilgileriGoster();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            eleman elm = new eleman();
            dataGridViewEleman.DataSource = elm.elemanBilgileriGoster();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            YöneticiEkrani yonekrani = new YöneticiEkrani();
            this.Close();
            yonekrani.Show();
        }
    }
}
