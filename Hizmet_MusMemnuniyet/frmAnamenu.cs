using System;
using System.Diagnostics;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using Hizmet_MusMemnuniyet.Formlar;
using Hizmet_MusMemnuniyet.Hizmet;
using Hizmet_MusMemnuniyet.Kategori;
using Hizmet_MusMemnuniyet.Kullanıcılar;
using Hizmet_MusMemnuniyet.Musteriler;
using Hizmet_MusMemnuniyet.Personel;
using Hizmet_MusMemnuniyet.Subeler;
using Hizmet_MusMemnuniyet.Tools;
using NLog;
using System.Xml.Linq;
using System.Linq;

namespace Hizmet_MusMemnuniyet
{

    public partial class frmAnamenu : RibbonForm
    {
        public static string AdSoyad;
        public static int KullaniciID = -1;
        public static int CorbaID = 0;
        public static int Giris = 0;
        public static bool Yonetici = false;
        private Logger Lg = LogManager.GetCurrentClassLogger();
        public frmAnamenu()
        {
            InitializeComponent();
        }
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start("www.gelisimsoft.com");
        }
        private void frmAnamenu_Load(object sender, EventArgs e)
        {
            try
            {

                Hide();
                GirisIslemi();
                TarihBtn.Caption = DateTime.Now.ToShortDateString();
                kullaniciBtn.Caption = AdSoyad;
                if (Yonetici)
                {
                    barYeniKullaniciEkleBtn.Enabled = true;
                    barKullaniciListesiBtn.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                string M = string.Format("{0} Anamenü Açılış", CorbaID);
                Lg.Info(M);
                Lg.Error(ex);
                cls_MesajBox.HataMesaji(ex);
            }
        }
        void GuncellemeKontrol()
        {

            string _strGuncelVer = "";
            string _strProgAdi = "";

            XDocument xDoc = XDocument.Load(Application.StartupPath + "//Guncelleme.xml");
            var ProjeD = from P0 in xDoc.Elements("PROGRAM").Elements("Proje")
                         where (string)P0.Element("ProgramID") == "1"
                         select new
                         {
                             ProgramAdi = P0.Element("ProgramAdi").Value,
                             ProgramVer = P0.Element("ProgramVer").Value,
                         };
            foreach (var Detay in ProjeD)
            {
                _strProgAdi = Detay.ProgramAdi;
                _strGuncelVer = Detay.ProgramVer;
            }

      //      string Yaver = OptimusPrime.OptimusGeliyorKacin(_strProgAdi);

            //if (Yaver != _strGuncelVer)
            //{
            //    Process.Start(Application.StartupPath + "//Hizmet_Guncelleme.exe");
            //    Application.Exit();
            //}
            //else
            //{
            //    cls_MesajBox.UyariMesaji("Güncel Versiyonu Kullanıyorsunuz.");
            //}
        }

        private void Menu_YeniFormKayitBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmFormGirisi F = new frmFormGirisi();
            F.ShowDialog();
        }
        private void Form_YeniFormKayitBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmFormGirisi F = new frmFormGirisi();
            F.ShowDialog();
        }
        void GirisIslemi()
        {
            frmGiris G = new frmGiris();
            G.ShowDialog();
            if (Giris == 1)
            {
                Show();
            }
            else if (Giris == 2)
            {
                G.ShowDialog();
                if (Giris == 1)
                {
                    Show();
                }
                else
                {
                    G.ShowDialog();
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void CikisBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (cls_MesajBox.Sor("Çıkmak istediğinize emin misiniz ?"))
            {
                Application.Exit();
            }
        }
        private void Hakkindabtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmHakkinda h = new frmHakkinda();
            h.ShowDialog();
        }

        private void Menu_YeniPerKayitBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPersonelKayit P = new frmPersonelKayit();
            P.ShowDialog();
        }

        private void Personel_YeniPerKayitBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPersonelKayit P = new frmPersonelKayit();
            P.ShowDialog();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPersonelListesi P = new frmPersonelListesi();
            P.Show();
        }

        private void Menu_YeniSubeKayitBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSubeKayit f = new frmSubeKayit();
            f.ShowDialog();
        }
        private void Form_YeniSubeKayitBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSubeKayit f = new frmSubeKayit();
            f.ShowDialog();
        }
        private void Sube_SubeListesiBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSubeListesi S = new frmSubeListesi();
            S.ShowDialog();
        }

        private void Menu_YeniMusteriKayitBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMusteriKayit M = new frmMusteriKayit();
            M.ShowDialog();
        }
        private void Musteri_YeniMusteriKayitBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMusteriKayit M = new frmMusteriKayit();
            M.ShowDialog();
        }
        private void Menu_MusteriListesiBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMusteriListesi M = new frmMusteriListesi();
            M.MdiParent = ActiveForm;
            M.Show();
        }

        private void Menu_YeniKatKayitBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKategoriKayit f = new frmKategoriKayit();
            f.ShowDialog();
        }
        private void Form_YeniKatKayitBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAnaKategoriKayit f = new frmAnaKategoriKayit();
            f.ShowDialog();
        }
        private void Form_AltYeniKatKayitBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKategoriKayit f = new frmKategoriKayit();
            f.ShowDialog();
        }
        private void Menu_KategoriListesiBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKategoriListesi fk = new frmKategoriListesi();
            fk.Show();
        }
        private void barSifreDegistirBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSifreDegistir s = new frmSifreDegistir();
            s.ShowDialog();
        }
        private void barYeniKullaniciEkleBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKullaniciEkle fk = new frmKullaniciEkle();
            fk.Show();
        }
        private void barKullaniciListesiBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKullaniciListesi k = new frmKullaniciListesi();
            k.Show();
        }
        private void barYeniHizmetBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmHizmetKayit hk = new frmHizmetKayit();
            hk.Show();
        }
        private void barHizmetlistesiBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmHizmetListesi hl = new frmHizmetListesi();
            hl.Show();
        }
        private void Menu_barYeniHizmetBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmHizmetKayit hk = new frmHizmetKayit();
            hk.Show();
        }
        private void barUzaktanBaglantiBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start(Application.StartupPath + "//GelisimSoft_Destek.exe");
        }
        private void barWebSitesiBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start("http://www.gelisimsoft.com");
        }
        private void barGuncellemeBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            GuncellemeKontrol();
        }
        private void Form_FormListesiBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmFormListesi FList = new frmFormListesi();
            FList.MdiParent = ActiveForm;
            FList.Show();
        }
    }
}