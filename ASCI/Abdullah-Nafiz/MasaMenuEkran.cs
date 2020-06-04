using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ASCI
{
    public partial class MasaMenuEkran : MetroFramework.Forms.MetroForm
    {

        int masaId;
        MasaSiparis masaSiparis;

        //SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-RILS1DJ\\SQLEXPRESS;Initial Catalog=Restoran;Integrated Security=True");

        /*
        ArrayList yemekId = new ArrayList();
        ArrayList yemekAdi = new ArrayList();
        ArrayList yemekTutari = new ArrayList();
        ArrayList yemekAdedi = new ArrayList();
        ArrayList araToplam = new ArrayList();

        ArrayList secilenYemekAd = new ArrayList();
        ArrayList secilenYemekAded = new ArrayList();
        ArrayList secilenYemekTutar = new ArrayList();
        ArrayList secilenYemekAraTutar = new ArrayList();
        */
        public MasaMenuEkran()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            masaAdLbl.Text = "MASA " + MasaSecimEkran.selectedTable.ToString();
            masaId = MasaSecimEkran.selectedTable;
            setLocation();
            masaSiparis = new MasaSiparis();

            classGonder();

            masaSiparis.listeYenile();
        }

        string basiliBTN="corbaBTN";
        int secilenIndis = 0, duzenlenecekListe = 0;
        public bool sil1 = false, duzenle1 = false, sil2 = false, duzenle2 = false;


        ////////////
        ////////////  FONKSİYONLAR
        ////////////

        public void setLocation()
        {
            anaPanel.Location = new Point(701, 74);
            anaYemekPanel.Location = new Point(701, 74);
            corbaPanel.Location = new Point(701, 74);
            tatliPanel.Location = new Point(701, 74);
            icecekPanel.Location = new Point(701, 74);
            salataPanel.Location = new Point(701, 74);
            yemekDuzenlePanel.Location = new Point(9, 266);
            anaYemekBox.Location = new Point(0, 10);
            corbaBox.Location = new Point(0, 10);
            tatliBox.Location = new Point(0, 10);
            icecekBox.Location = new Point(0, 10);
            salataBox.Location = new Point(0, 10);
        }

        public void classGonder()
        {
            masaSiparis.masaId = masaId;
            masaSiparis.listView1 = listView1;
            masaSiparis.listView2 = listView2;
            masaSiparis.toplamLBL = toplamLBL;
            masaSiparis.toplamLBL2 = toplamLBL2;
            masaSiparis.sepetBosLBL = sepetBosLbl;
            masaSiparis.duzenleAdetLBL = duzenleAdetLbl;
        }

        private void VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (basiliBTN == "anaYemek") { anaYemekBox.Location = new Point(0, -(e.NewValue * 11)); }
            else if (basiliBTN == "corba") { corbaBox.Location = new Point(0, -(e.NewValue * 4)); }
            else if (basiliBTN == "salata") { salataBox.Location = new Point(0, -(e.NewValue * 4)); }
            else if (basiliBTN == "tatli") { tatliBox.Location = new Point(0, -(e.NewValue * 4)); }
            else if (basiliBTN == "icecek") { icecekBox.Location = new Point(0, -(e.NewValue * 4)); } 
        }

        ////////////
        ////////////  ANA BUTONLAR
        ////////////
        private void AnaGeri_Click(object sender, EventArgs e)
        {
            if (masaSiparis.SecilenYemekAd.Count > 0)
            {
                secimPanel.Visible = true; anaPanel.Visible= false; anaGeri.Enabled = false;  butonBox.Enabled = false;
                secimPanel.Location = new Point(390, 265);
            }
            else
            {
                MasaSecimEkran form1 = new MasaSecimEkran();
                form1.Show();
                this.Hide();
            }
        }

        private void AnaYemekButon_Click(object sender, EventArgs e)
        {
            yemekGeriBtn.Visible = true;
            vScrollBar1.Visible = true;
            anaYemekPanel.Visible = true;
            anaPanel.Visible = false;
            basiliBTN = "anaYemek";
        }

        private void SalataButon_Click(object sender, EventArgs e)
        {
            yemekGeriBtn.Visible = true;
            vScrollBar1.Visible = true;
            salataPanel.Visible = true;
            anaPanel.Visible = false;
            basiliBTN = "salata";
        }

        private void CorbaButon_Click(object sender, EventArgs e)
        {
            yemekGeriBtn.Visible = true;
            vScrollBar1.Visible = true;
            corbaPanel.Visible = true;
            anaPanel.Visible = false;
            basiliBTN = "corba";
        }

        private void TatliButon_Click(object sender, EventArgs e)
        {
            yemekGeriBtn.Visible = true;
            vScrollBar1.Visible = true;
            tatliPanel.Visible = true;
            anaPanel.Visible = false;
            basiliBTN = "tatli";
        }

        private void İcecekButon_Click(object sender, EventArgs e)
        {
            yemekGeriBtn.Visible = true;
            vScrollBar1.Visible = true;
            icecekPanel.Visible = true;
            anaPanel.Visible = false;
            basiliBTN = "icecek";
        }
      
        private void YemekGeriBtn_Click(object sender, EventArgs e)
        {
            yemekGeriBtn.Visible = false;
            vScrollBar1.Visible = false; vScrollBar1.Value = 0;
            anaYemekPanel.Visible = false;
            corbaPanel.Visible = false;
            tatliPanel.Visible = false;
            icecekPanel.Visible = false;
            salataPanel.Visible = false;
            anaPanel.Visible = true;
            setLocation();
        }
       
        private void SepetiOnaylaBtn_Click(object sender, EventArgs e)
        {
            masaSiparis.sepetOnayla();
            masaSiparis.listView2 = listView1;
            masaSiparis.listeYenile();
            classGonder();
        }

        private void YemekSil1Btn_Click(object sender, EventArgs e)
        {
            if (!sil1) { sil1 = true; yemekSil1Btn.Text = "BİTİR"; anaPanel.Enabled = false; anaYemekPanel.Enabled = false; tatliPanel.Enabled = false; icecekPanel.Enabled = false; corbaPanel.Enabled = false; salataPanel.Enabled = false; yemekSil2Btn.Enabled = false; yemekDuzenle1Btn.Enabled = false; sepetiOnaylaBtn.Enabled = false; yemekDuzenle2Btn.Enabled = false; butonBox.BackColor = Color.MediumOrchid; }
            else { sil1 = false; yemekSil1Btn.Text = "YEMEK SİL"; anaPanel.Enabled = true; anaYemekPanel.Enabled = true; tatliPanel.Enabled = true; icecekPanel.Enabled = true; corbaPanel.Enabled = true; salataPanel.Enabled = true; yemekSil2Btn.Enabled = true; yemekDuzenle1Btn.Enabled = true; sepetiOnaylaBtn.Enabled = true; yemekDuzenle2Btn.Enabled = true; butonBox.BackColor = Color.White; }
        }

        private void YemekSil2Btn_Click(object sender, EventArgs e)
        {
            if (!sil2) { sil2 = true; yemekSil2Btn.Text = "BİTİR"; anaPanel.Enabled = false; anaYemekPanel.Enabled = false; tatliPanel.Enabled = false; icecekPanel.Enabled = false; corbaPanel.Enabled = false; salataPanel.Enabled = false; yemekSil1Btn.Enabled = false; yemekDuzenle1Btn.Enabled = false; sepetiOnaylaBtn.Enabled = false; yemekDuzenle2Btn.Enabled = false; butonBox.BackColor = Color.MediumOrchid; }
            else { sil2 = false; yemekSil2Btn.Text = "YEMEK SİL"; anaPanel.Enabled = true; anaYemekPanel.Enabled = true; tatliPanel.Enabled = true; icecekPanel.Enabled = true; corbaPanel.Enabled = true; salataPanel.Enabled = true; yemekSil1Btn.Enabled = true; yemekDuzenle1Btn.Enabled = true; sepetiOnaylaBtn.Enabled = true; yemekDuzenle2Btn.Enabled = true; butonBox.BackColor = Color.White; }
        }

        private void YemekDuzenle1Btn_Click(object sender, EventArgs e)
        {
            duzenlenecekListe = 1;
            if (!duzenle1) { duzenle1 = true; yemekDuzenle1Btn.Text = "BİTİR"; anaPanel.Enabled = false; anaYemekPanel.Enabled = false; tatliPanel.Enabled = false; icecekPanel.Enabled = false; corbaPanel.Enabled = false; salataPanel.Enabled = false; yemekSil1Btn.Enabled = false; yemekDuzenle2Btn.Enabled = false; sepetiOnaylaBtn.Enabled = false; yemekSil2Btn.Enabled = false; butonBox.BackColor = Color.Orange; }
            else { duzenle1 = false; yemekDuzenlePanel.Visible = false;  yemekDuzenle1Btn.Text = "YEMEK DÜZENLE"; anaPanel.Enabled = true; anaYemekPanel.Enabled = true; tatliPanel.Enabled = true; icecekPanel.Enabled = true; corbaPanel.Enabled = true; salataPanel.Enabled = true; yemekSil1Btn.Enabled = true; yemekDuzenle2Btn.Enabled = true; sepetiOnaylaBtn.Enabled = true; yemekSil2Btn.Enabled = true; butonBox.BackColor = Color.White; }
        }

        private void YemekDuzenle2Btn_Click(object sender, EventArgs e)
        {
            duzenlenecekListe = 2;
            if (!duzenle2) { duzenle2 = true; yemekDuzenle2Btn.Text = "BİTİR"; anaPanel.Enabled = false; anaYemekPanel.Enabled = false; tatliPanel.Enabled = false; icecekPanel.Enabled = false; corbaPanel.Enabled = false; salataPanel.Enabled = false; yemekSil1Btn.Enabled = false; yemekDuzenle1Btn.Enabled = false; sepetiOnaylaBtn.Enabled = false; yemekSil2Btn.Enabled = false; butonBox.BackColor = Color.Orange; }
            else { duzenle2 = false; yemekDuzenlePanel.Visible = false; yemekDuzenle2Btn.Text = "YEMEK DÜZENLE"; anaPanel.Enabled = true; anaYemekPanel.Enabled = true; tatliPanel.Enabled = true; icecekPanel.Enabled = true; corbaPanel.Enabled = true; salataPanel.Enabled = true; yemekSil1Btn.Enabled = true; yemekDuzenle1Btn.Enabled = true; sepetiOnaylaBtn.Enabled = true; yemekSil2Btn.Enabled = true; butonBox.BackColor = Color.White; }
        }


        ////////////
        ////////////  UYARI BUTONLARI
        ////////////

        private void DevamEtBtn_Click(object sender, EventArgs e)
        {
            MasaSecimEkran form1 = new MasaSecimEkran();
            form1.Show();
            this.Hide();
        }

        private void İptalBtn_Click(object sender, EventArgs e)
        {
            secimPanel.Visible = false; anaPanel.Visible = true; anaGeri.Enabled = true; butonBox.Enabled = true;
        }

        ////////////
        ////////////  DÜZENLE BUTONLARI
        ////////////

        private void DuzenleEkleBtn_Click(object sender, EventArgs e)
        {
            duzenleAdetLbl.Text = (int.Parse(duzenleAdetLbl.Text) + 1).ToString();
        }

        private void DuzenleCıkarBtn_Click(object sender, EventArgs e)
        {
            int aded = int.Parse(duzenleAdetLbl.Text);
            if (aded > 0)
            {
                duzenleAdetLbl.Text = (int.Parse(duzenleAdetLbl.Text) - 1).ToString();
            }
        }

        public void yemekFiyatGuncelle()
        {
            /*
            fiyat1.Text = masaSiparis.YemekMenuFiyat[0].ToString();
            fiyat2.Text = masaSiparis.YemekMenuFiyat[1].ToString();
            fiyat3.Text = masaSiparis.YemekMenuFiyat[2].ToString();
            fiyat4.Text = masaSiparis.YemekMenuFiyat[3].ToString();
            fiyat5.Text = masaSiparis.YemekMenuFiyat[4].ToString();
            fiyat6.Text = masaSiparis.YemekMenuFiyat[5].ToString();
            fiyat7.Text = masaSiparis.YemekMenuFiyat[6].ToString();
            fiyat8.Text = masaSiparis.YemekMenuFiyat[7].ToString();
            fiyat9.Text = masaSiparis.YemekMenuFiyat[8].ToString();
            fiyat10.Text = masaSiparis.YemekMenuFiyat[9].ToString();
            fiyat11.Text = masaSiparis.YemekMenuFiyat[10].ToString();
            fiyat12.Text = masaSiparis.YemekMenuFiyat[11].ToString();
            fiyat13.Text = masaSiparis.YemekMenuFiyat[12].ToString();
            fiyat14.Text = masaSiparis.YemekMenuFiyat[13].ToString();
            fiyat15.Text = masaSiparis.YemekMenuFiyat[14].ToString();
            fiyat16.Text = masaSiparis.YemekMenuFiyat[15].ToString();
            fiyat17.Text = masaSiparis.YemekMenuFiyat[16].ToString();
            fiyat18.Text = masaSiparis.YemekMenuFiyat[17].ToString();
            fiyat19.Text = masaSiparis.YemekMenuFiyat[18].ToString();
            fiyat20.Text = masaSiparis.YemekMenuFiyat[19].ToString();
            fiyat21.Text = masaSiparis.YemekMenuFiyat[20].ToString();
            fiyat22.Text = masaSiparis.YemekMenuFiyat[21].ToString();
            fiyat23.Text = masaSiparis.YemekMenuFiyat[22].ToString();
            fiyat24.Text = masaSiparis.YemekMenuFiyat[23].ToString();
            fiyat25.Text = masaSiparis.YemekMenuFiyat[24].ToString();
            fiyat26.Text = masaSiparis.YemekMenuFiyat[25].ToString();
            fiyat27.Text = masaSiparis.YemekMenuFiyat[26].ToString();
            fiyat28.Text = masaSiparis.YemekMenuFiyat[27].ToString();
            fiyat29.Text = masaSiparis.YemekMenuFiyat[28].ToString();
            */

        }
        private void SteakhousebonfileBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("steakhousebonfile"); }
        private void DanabonfilesisBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("danabonfilesis"); }
        private void KarisiksisBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("karisiksis"); }
        private void CigertavaBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("cigertava"); }
        private void AntepfistiklikofteBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("antepfistiklikofte"); }
        private void SiskofteBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("siskofte"); }
        private void PeynirlifirinkofteBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("peynirlifirinkofte"); }
        private void TavukschnitzelBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("tavukschnitzel"); }
        private void İzgaratavukpirzolaBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("izgaratavukpirzola"); }
        private void TavuksisBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("tavuksis"); }
        private void TavukkulbastiBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("tavukkulbasti"); }
        private void PatatestavaBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("patatestava"); }
        private void MantarfirinBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("mantarfirin"); }
        private void PilicızgaraBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("pilicizgara"); }
        private void EtiskenderBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("etiskender"); }
        private void PilavustudonerBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("pilavustudoner"); }
        private void SebzelipirincpilaviBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("sebzelipirincpilavi"); }
        private void TavuksoteBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("tavuksote"); }
        private void SpagettiBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("spagetti"); }
        private void FirindamakarnaBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("firindamakarna"); }
        private void KellepacacorbasiBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("kellepacacorbasi"); }
        private void İskembecorbasiBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("iskembecorbasi"); }
        private void LahanacorbasiBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("lahanacorbasi"); }
        private void MercimercorbasiBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("mercimekcorbasi"); }
        private void TavuksuyucorbasiBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("tavuksuyucorbasi"); }
        private void TarhanacorbasiBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("tarhanacorbasi"); }
        private void YaylacorbasiBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("yaylacorbasi"); }
        private void DomatescorbasiBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("domatescorbasi"); }
        private void SehriyecorbasiBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("sehriyecorbasi"); }
        private void SebzecorbasiBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("spagetti"); }
        private void CobansalataBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("cobansalata"); }
        private void CapresesalataBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("capresesalata"); }
        private void CaesersalataBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("caesersalata"); }
        private void BalkansalataBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("balkansalata"); }
        private void YesilsalataBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("yesilsalata"); }
        private void TonbalikliyyesilsalataBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("tonbaliklisalata"); }
        private void KopoglusalataBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("kopoglusalata"); }
        private void PantzanelasalataBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("pantzanelasalata"); }
        private void AsortisalataBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("asortisalata"); }
        private void TrileceBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("trilece"); }
        private void FirinsutlacBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("firindasutlac"); }
        private void İncirlimuhallebiBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("incirlimuhallebi"); }
        private void FistiklisobiyetBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("fistiklisobiyet"); }
        private void FistiklidolamaBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("fistiklidolama"); }
        private void BalborekBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("balborek"); }
        private void FistiklikadayifBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("fistiklikadayif"); }
        private void KunefeBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("kunefe"); }
        private void KavanozdatiramisuBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("kavanozdatiramisu"); }
        private void FirincheesecakeBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("firincheesecake"); }
        private void CileklipastaBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("cileklipasta"); }
        private void SogukcikolataBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("sogukcikolata"); }
        private void SicakcikolataBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("sicakcikolata"); }
        private void LimonataBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("limonata"); }
        private void MilkshakeBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("milkshake"); }
        private void İcecafemochaBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("icecafemocha"); }
        private void FrappeBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("frappe"); }
        private void EspressoBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("espresso"); }
        private void CaffemochaBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("caffemocha"); }
        private void CappucinoBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("cappuccino"); }
        private void SalepBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("salep"); }
        private void CayBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("cay"); }
        private void YesilcayBTN_Click(object sender, EventArgs e) { masaSiparis.yemekSec("yesilcay"); }

       

       


        private void DuzenleOnayBtn_Click(object sender, EventArgs e)
        {
            yemekDuzenlePanel.Visible = false; duzenle2 = false; yemekDuzenle1Btn.Text = "YEMEK DÜZENLE"; yemekDuzenle2Btn.Text = "YEMEK DÜZENLE"; anaPanel.Enabled = true; anaYemekPanel.Enabled = true; tatliPanel.Enabled = true; corbaPanel.Enabled = true; salataPanel.Enabled = true; yemekSil1Btn.Enabled = true; yemekDuzenle1Btn.Enabled = true; sepetiOnaylaBtn.Enabled = true; yemekSil2Btn.Enabled = true; yemekDuzenle2Btn.Enabled = true; butonBox.BackColor = Color.White;
            duzenle1 = false;
            if (duzenlenecekListe == 1) masaSiparis.listeDuzenle(secilenIndis);
            else if (duzenlenecekListe == 2) masaSiparis.sepetDuzenle(secilenIndis);
        }


        ////////////
        ////////////  YEMEK BUTONLARI
        ////////////



        ////////////
        ////////////  LISTVIEW EYLEMLER
        ////////////

        private void ListView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (sil1)
            {
                duzenlenecekListe = 1;
                secilenIndis = listView1.SelectedItems[0].Index;

                masaSiparis.listedenSil(secilenIndis);
                masaSiparis.listeYenile();

            }

            else if (duzenle1)
            {
                duzenlenecekListe = 1;
                secilenIndis = listView1.SelectedItems[0].Index;
                yemekDuzenlePanel.Visible = true;
                duzenleYazıLbl.Text = masaSiparis.YemekAdi[listView1.SelectedItems[0].Index].ToString();
                duzenleYazıLbl.Location = new Point(200 - (duzenleYazıLbl.Text.Length*5), 30);
                duzenleAdetLbl.Text = masaSiparis.YemekAdedi[listView1.SelectedItems[0].Index].ToString();
            }
        }

        private void ListView2_MouseClick(object sender, MouseEventArgs e)
        {
           

            if (duzenle2)
            {
                duzenlenecekListe = 2;
                secilenIndis = listView2.SelectedItems[0].Index;
                yemekDuzenlePanel.Visible = true;
                duzenleYazıLbl.Text = masaSiparis.SecilenYemekAd[listView2.SelectedItems[0].Index].ToString();
                duzenleYazıLbl.Location = new Point(200 - ((duzenleYazıLbl.Text.Length-5) * 5), 30);
                duzenleAdetLbl.Text = masaSiparis.SecilenYemekAded[listView2.SelectedItems[0].Index].ToString();
            }

            else if (sil2)
            {
                duzenlenecekListe = 2;
                secilenIndis = listView2.SelectedItems[0].Index;
             
                masaSiparis.sepettenSil(secilenIndis);
                

            }

        }



    }
}
