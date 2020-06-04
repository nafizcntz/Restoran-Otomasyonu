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
    public partial class musteriEkranAna : MetroFramework.Forms.MetroForm

    {
        PaketSiparis paketSiparis;
        string basiliBTN;
        public musteriEkranAna()
        {
            InitializeComponent();
        }

        static public string musteriAd;
        public bool sil = false, duzenle = false;
        public int secilenIndis = 0;
        private void MusteriEkranAna_Load(object sender, EventArgs e)
        {
            paketSiparis = new PaketSiparis();
            paketSiparis.toplamLBL2 = toplamLBL;
            paketSiparis.listView2 = listView1;

            paketSiparis.duzenleAdetLBL = duzenleAdetLbl;
            paketSiparis.fiyatCek();
            label1.Text = "MERHABA" + " , " + musteriAd;
            butonSec("anaYemekBTN"); basiliBTN = "anaYemekBTN";
            setLocation();
            
        }

        public void setLocation()
        {
            yemekDuzenlePanel.Location = new Point(466, 242);
            anaYemekBoxDıs.Location = new Point(250, 0); anaYemekBox.Location = new Point(0, 18);
            corbaBoxDıs.Location = new Point(250, 0); corbaBox.Location = new Point(0, 18);
            salataBoxDıs.Location = new Point(250, 0); salataBox.Location = new Point(0, 18);
            tatliBoxDıs.Location = new Point(250, 0); tatliBox.Location = new Point(0, 18);
            icecekBoxDıs.Location = new Point(250, 0); icecekBox.Location = new Point(0, 18);
            geriyeDon.Location = new Point(8, 85);
            siparisiOnayla.Location = new Point(566, 420);
            yaziLbl.Location = new Point(60, 278);
        }
        public void butonSec(String name)
        {
            anaYemekBTN.BackColor = Color.DeepPink; anaYemekBTN.Size = new Size(161, 58); anaYemekBTN.Location = new Point(73, 100);
            corbaBTN.BackColor = Color.DeepPink; corbaBTN.Size = new Size(161, 58); corbaBTN.Location = new Point(73, 183);
            salataBTN.BackColor = Color.DeepPink; salataBTN.Size = new Size(161, 58); salataBTN.Location = new Point(73, 266);
            tatliBTN.BackColor = Color.DeepPink; tatliBTN.Size = new Size(161, 58); tatliBTN.Location = new Point(73, 349);
            icecekBTN.BackColor = Color.DeepPink; icecekBTN.Size = new Size(161, 58); icecekBTN.Location = new Point(73, 432);

            setLocation();
            vScrollBar1.Value = 0;

            if (name == "anaYemekBTN")
            {
                anaYemekBTN.BackColor = Color.MediumSlateBlue;
                anaYemekBTN.Location = new Point(73, 90);
                anaYemekBTN.Size = new Size(161, 78);
                anaYemekBoxDıs.Visible = true; corbaBoxDıs.Visible = false; salataBoxDıs.Visible = false; tatliBoxDıs.Visible = false; icecekBoxDıs.Visible = false;
            }

            else if (name == "corbaBTN")
            {
                corbaBTN.BackColor = Color.MediumSlateBlue;
                corbaBTN.Location = new Point(73, 173);
                corbaBTN.Size = new Size(161, 78);
                anaYemekBoxDıs.Visible = false; corbaBoxDıs.Visible = true; salataBoxDıs.Visible = false; tatliBoxDıs.Visible = false; icecekBoxDıs.Visible = false;
            }

            else if (name == "salataBTN")
            {
                salataBTN.BackColor = Color.MediumSlateBlue;
                salataBTN.Location = new Point(73, 256);
                salataBTN.Size = new Size(161, 78);
                anaYemekBoxDıs.Visible = false; corbaBoxDıs.Visible = false; salataBoxDıs.Visible = true; tatliBoxDıs.Visible = false; icecekBoxDıs.Visible = false;
            }

            else if (name == "tatliBTN")
            {
                tatliBTN.BackColor = Color.MediumSlateBlue;
                tatliBTN.Location = new Point(73, 339);
                tatliBTN.Size = new Size(161, 78);
                anaYemekBoxDıs.Visible = false; corbaBoxDıs.Visible = false; salataBoxDıs.Visible = false; tatliBoxDıs.Visible = true; icecekBoxDıs.Visible = false;
            }

            else if (name == "icecekBTN")
            {
                icecekBTN.BackColor = Color.MediumSlateBlue;
                icecekBTN.Location = new Point(73, 422);
                icecekBTN.Size = new Size(161, 78);
                anaYemekBoxDıs.Visible = false; corbaBoxDıs.Visible = false; salataBoxDıs.Visible = false; tatliBoxDıs.Visible = false; icecekBoxDıs.Visible = true;
            }

        }

        private void AnaYemekBTN_Click(object sender, EventArgs e)
        {
            if (basiliBTN != "anaYemekBTN") { basiliBTN = "anaYemekBTN"; butonSec("anaYemekBTN"); }
        }

        private void CorbaBTN_Click(object sender, EventArgs e)
        {
            if (basiliBTN != "corbaBTN") { basiliBTN = "corbaBTN"; butonSec("corbaBTN"); }
        }

        private void SalataBTN_Click(object sender, EventArgs e)
        {
            if (basiliBTN != "salataBTN") { basiliBTN = "salataBTN"; butonSec("salataBTN"); }
        }

        private void TatliBTN_Click(object sender, EventArgs e)
        {
            if (basiliBTN != "tatliBTN") { basiliBTN = "tatliBTN"; butonSec("tatliBTN"); }
        }

        private void İcecekBTN_Click(object sender, EventArgs e)
        {
            if (basiliBTN != "icecekBTN") { basiliBTN = "icecekBTN"; butonSec("icecekBTN"); }
        }

        private void YemekDuzenleBtn_Click(object sender, EventArgs e)
        {

            if (duzenle)
            {
                yemekDuzenleBtn.Text = "YEMEK DÜZENLE";
                duzenle = false; yemekSilBtn.Enabled = true; siparisTamamlaBtn.Enabled = true;
                anaYemekBoxDıs.Enabled = true; corbaBoxDıs.Enabled = true; salataBoxDıs.Enabled = true; tatliBoxDıs.Enabled = true; icecekBoxDıs.Enabled = true; panelAna2.Enabled = true;

            }
            else
            {
                yemekDuzenleBtn.Text = "BİTİR";
                duzenle = true; yemekSilBtn.Enabled = false; siparisTamamlaBtn.Enabled = false;
                anaYemekBoxDıs.Enabled = false; corbaBoxDıs.Enabled = false; salataBoxDıs.Enabled = false; tatliBoxDıs.Enabled = false; icecekBoxDıs.Enabled = false; panelAna2.Enabled = false;
            }
        }

        private void YemekSilBtn_Click(object sender, EventArgs e)
        {
            if (sil)
            {
                yemekSilBtn.Text = "YEMEK SİL";
                sil = false; yemekDuzenleBtn.Enabled = true; siparisTamamlaBtn.Enabled = true;
                anaYemekBoxDıs.Enabled = true; corbaBoxDıs.Enabled = true; salataBoxDıs.Enabled = true; tatliBoxDıs.Enabled = true; icecekBoxDıs.Enabled = true; panelAna2.Enabled = true;

            }
            else
            {
                yemekSilBtn.Text = "BİTİR";
                sil = true; yemekDuzenleBtn.Enabled = false; siparisTamamlaBtn.Enabled = false;
                anaYemekBoxDıs.Enabled = false; corbaBoxDıs.Enabled = false; salataBoxDıs.Enabled = false; tatliBoxDıs.Enabled = false; icecekBoxDıs.Enabled = false; panelAna2.Enabled = false;
            }
        }

        private void SiparisTamamlaBtn_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                panelAna2.Visible = false;
                anaPanel2.Visible = false;
                siparisiOnayla.Visible = true;
                geriyeDon.Visible = true;
                cikisBtn.Visible = false;
                yaziLbl.Visible = true;

                yaziLbl.Text = toplamLBL.Text + " TL DEĞERİNDEKİ SİPARİSİ ONAYLIYOR MUSUNUZ ?";
            }

            else
            {
                MessageBox.Show("LUTFEN URUN EKLEYINIZ .. !");
            }
        }


        private void GeriyeDon_Click(object sender, EventArgs e)
        {
            panelAna2.Visible = true;
            anaPanel2.Visible = true;
            cikisBtn.Visible = true;
            geriyeDon.Visible = false;
            siparisiOnayla.Visible = false;
            yaziLbl.Visible = false;
        }

        private void SiparisiOnayla_Click(object sender, EventArgs e)
        {

            string siparisId =  DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            int masaId = int.Parse(DateTime.Now.Year.ToString().Substring(2, 2) + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString());
            paketSiparis.SiparisId = siparisId;
            //paketSiparis.paketOnayla();
            geriyeDon.Visible = false;
            siparisiOnayla.Visible = false;
            yaziLbl.Location = new Point(150, 278);
            yaziLbl.Text = "SİPARİŞİNİZ BAŞARIYLA TAMAMLANDI ( Siparis No : " + siparisId + ")";
            timer1.Start();
        }

        int a = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            a++;
            if (a == 5)
            {
                musteriEkranGiris ekran = new musteriEkranGiris();
                ekran.Show();
                this.Hide();
            }
        }

        private void ListView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (sil)
            {
                secilenIndis = listView1.SelectedItems[0].Index;

                paketSiparis.sepettenSil(secilenIndis);
                paketSiparis.sepetYenile();

            }

            else if (duzenle)
            {
                secilenIndis = listView1.SelectedItems[0].Index;
                yemekDuzenlePanel.Visible = true;
                duzenleYazıLbl.Text = paketSiparis.SecilenYemekAd[listView1.SelectedItems[0].Index].ToString();
                duzenleAdetLbl.Text = paketSiparis.SecilenYemekAded[listView1.SelectedItems[0].Index].ToString();

                yemekDuzenlePanel.Visible = true; duzenle = true; yemekSilBtn.Enabled = false; siparisTamamlaBtn.Enabled = false;
                anaYemekBoxDıs.Enabled = false; corbaBoxDıs.Enabled = false; salataBoxDıs.Enabled = false; tatliBoxDıs.Enabled = false; icecekBoxDıs.Enabled = false;
            }
        }

        private void VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (basiliBTN == "anaYemekBTN") { anaYemekBox.Location = new Point(0, -(e.NewValue * 11)); }
            else if (basiliBTN == "corbaBTN") { corbaBox.Location = new Point(0, -(e.NewValue * 4)); }
            else if (basiliBTN == "salataBTN") { salataBox.Location = new Point(0, -(e.NewValue * 4)); }
            else if (basiliBTN == "tatliBTN") { tatliBox.Location = new Point(0, -(e.NewValue * 4)); }
            else if (basiliBTN == "icecekBTN") { icecekBox.Location = new Point(0, -(e.NewValue * 4)); }
        }

        ////
        ////DUZENLE BUTONLAR
        ////
        ///

        private void DuzenleOnayBtn_Click(object sender, EventArgs e)
        {
            yemekDuzenlePanel.Visible = false; duzenle = false; yemekDuzenleBtn.Text = "YEMEK DÜZENLE"; yemekSilBtn.Enabled = true; siparisTamamlaBtn.Enabled = true;
            anaYemekBoxDıs.Enabled = true; corbaBoxDıs.Enabled = true; salataBoxDıs.Enabled = true; tatliBoxDıs.Enabled = true; icecekBoxDıs.Enabled = true; panelAna2.Enabled = true;
            duzenle = false;
            paketSiparis.sepetDuzenle(secilenIndis);
        }

        private void DuzenleCıkarBtn_Click(object sender, EventArgs e)
        {
            int aded = int.Parse(duzenleAdetLbl.Text);
            if (aded > 0)
            {
                duzenleAdetLbl.Text = (int.Parse(duzenleAdetLbl.Text) - 1).ToString();
            }
        }

        private void DuzenleEkleBtn_Click(object sender, EventArgs e)
        {
            duzenleAdetLbl.Text = (int.Parse(duzenleAdetLbl.Text) + 1).ToString();
        }

        //
        ///// YEMEK BUTONLARI
        //
        private void SteakhousebonfileBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("steakhousebonfile"); }
        private void DanabonfilesisBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("danabonfilesis"); }
        private void KarisiksisBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("karisiksis"); }
        private void CigertavaBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("cigertava"); }
        private void AntepfistiklikofteBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("antepfistiklikofte"); }
        private void SiskofteBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("siskofte"); }
        private void PeynirlifirinkofteBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("peynirlifirinkofte"); }
        private void TavukschnitzelBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("tavukschnitzel"); }
        private void İzgaratavukpirzolaBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("izgaratavukpirzola"); }
        private void TavuksisBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("tavuksis"); }
        private void TavukkulbastiBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("tavukkulbasti"); }
        private void PatatestavaBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("patatestava"); }
        private void MantarfirinBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("mantarfirin"); }
        private void PilicızgaraBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("pilicizgara"); }
        private void EtiskenderBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("etiskender"); }
        private void PilavustudonerBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("pilavustudoner"); }
        private void SebzelipirincpilaviBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("sebzelipirincpilavi"); }
        private void TavuksoteBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("tavuksote"); }
        private void SpagettiBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("spagetti"); }
        private void FirindamakarnaBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("firindamakarna"); }
        private void KellepacacorbasiBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("kellepacacorbasi"); }
        private void İskembecorbasiBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("iskembecorbasi"); }
        private void LahanacorbasiBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("lahanacorbasi"); }
        private void MercimercorbasiBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("mercimekcorbasi"); }
        private void TavuksuyucorbasiBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("tavuksuyucorbasi"); }
        private void TarhanacorbasiBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("tarhanacorbasi"); }
        private void YaylacorbasiBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("yaylacorbasi"); }
        private void DomatescorbasiBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("domatescorbasi"); }
        private void SehriyecorbasiBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("sehriyecorbasi"); }
        private void SebzecorbasiBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("spagetti"); }
        private void CobansalataBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("cobansalata"); }
        private void CapresesalataBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("capresesalata"); }
        private void CaesersalataBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("caesersalata"); }
        private void BalkansalataBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("balkansalata"); }
        private void YesilsalataBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("yesilsalata"); }
        private void TonbalikliyyesilsalataBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("tonbaliklisalata"); }
        private void KopoglusalataBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("kopoglusalata"); }
        private void PantzanelasalataBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("pantzanelasalata"); }
        private void AsortisalataBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("asortisalata"); }
        private void TrileceBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("trilece"); }
        private void FirinsutlacBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("firindasutlac"); }
        private void İncirlimuhallebiBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("incirlimuhallebi"); }
        private void FistiklisobiyetBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("fistiklisobiyet"); }
        private void FistiklidolamaBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("fistiklidolama"); }
        private void BalborekBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("balborek"); }
        private void FistiklikadayifBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("fistiklikadayif"); }
        private void KunefeBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("kunefe"); }
        private void KavanozdatiramisuBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("kavanozdatiramisu"); }
        private void FirincheesecakeBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("firincheesecake"); }
        private void CileklipastaBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("cileklipasta"); }
        private void SogukcikolataBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("sogukcikolata"); }
        private void SicakcikolataBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("sicakcikolata"); }
        private void LimonataBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("limonata"); }
        private void MilkshakeBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("milkshake"); }
        private void İcecafemochaBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("icecafemocha"); }
        private void FrappeBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("frappe"); }
        private void EspressoBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("espresso"); }
        private void CaffemochaBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("caffemocha"); }
        private void CappucinoBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("cappuccino"); }
        private void SalepBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("salep"); }
        private void CayBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("cay"); }

        private void CikisBtn_Click(object sender, EventArgs e)
        {
            musteriEkranGiris form = new musteriEkranGiris();
            form.Show();
            this.Close();
        }

        private void YesilcayBTN_Click(object sender, EventArgs e) { paketSiparis.yemekSec("yesilcay"); }



        //
        /////////
        //
    }
}
