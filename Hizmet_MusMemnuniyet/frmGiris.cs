
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Hizmet_MusMemnuniyet.Properties;
using Hizmet_MusMemnuniyet.Tools;
using NLog;
using System.Diagnostics;
using System.Xml.Linq;

namespace Hizmet_MusMemnuniyet
{
    public partial class frmGiris : XtraForm
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        private Logger Lg = LogManager.GetCurrentClassLogger();
        HizmetCRMEntities H = new HizmetCRMEntities();
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
        }

        private void GirisBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(KulAdiBox.Text) && string.IsNullOrEmpty(Sifrebox.Text))
                {
                    cls_MesajBox.UyariMesaji("Kullanıcı adı ve şifre yazınız.");
                    frmAnamenu.Giris = 2;
                }
                else
                {
                    var GirisQyery = from kul in H.HizmetCRM_Kullanicilar
                                     where kul.KullaniciAdi == KulAdiBox.Text && kul.Sifre == Sifrebox.Text && kul.IsActive == true
                                     select new
                                     {
                                         kul.KullaniciID,
                                         kul.AdSoyad,
                                         durum = kul.AnaKullanici
                                     }; if (GirisQyery.Count() > 0)
                    {
                        if (SifreCheck.Checked)
                        {
                            Settings.Default.Animsa = true;
                            Settings.Default.KullaniciAdi = KulAdiBox.Text;
                            Settings.Default.Parola = Sifrebox.Text;
                            Settings.Default.Save();
                        }
                        else
                        {
                            Settings.Default.Animsa = false;
                            Settings.Default.KullaniciAdi = null;
                            Settings.Default.Parola = null;
                            Settings.Default.Save();
                        }
                        foreach (var Gq in GirisQyery)
                        {
                            frmAnamenu.KullaniciID = Gq.KullaniciID;
                            frmAnamenu.AdSoyad = Gq.AdSoyad;
                            frmAnamenu.Yonetici = (bool)Gq.durum;
                            frmAnamenu.Giris = 1;
                            Close();
                        }
                    }
                    else
                    {
                        cls_MesajBox.UyariMesaji("Kullanıcı adı yada şifre hatalı !!");
                        frmAnamenu.Giris = 2;
                    }
                }
            }
            catch (Exception ex)
            {
                string M = string.Format("{0} Form Girişi", frmAnamenu.CorbaID);
                Lg.Info(M);
                Lg.Error(ex);
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void frmGiris_Load(object sender, EventArgs e)
        {
            GuncellemeKontrol();

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Gray;
            TransparencyKey = BackColor;
            if (Settings.Default.Animsa)
            {
                KulAdiBox.Text = Settings.Default.KullaniciAdi;
                Sifrebox.Text = Settings.Default.Parola;
                SifreCheck.Checked = true;
            }
        }
        private void frmGiris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }
    }
}