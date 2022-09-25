using System;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Hizmet_MusMemnuniyet.Tools;
//using Ionic.Zip;
using NLog;
using GuncellemeKontrol;
using System.Diagnostics;
using System.Threading;
using System.Linq;
using System.Xml.Linq;
using System.IO.Compression;

namespace Hizmet_MusMemnuniyet
{
    public partial class frmGuncelle : XtraForm
    {
        public frmGuncelle()
        {
            InitializeComponent();
        }
        cls_Checked C = new cls_Checked();
        private Logger Lg = LogManager.GetCurrentClassLogger();
        string _strGuncellenecekDosya;
        string _strProgramLink = "";
        WebClient webClient;
        //Stopwatch sw = new Stopwatch();

        private void frmGuncelle_Load(object sender, EventArgs e)
        {
            try
            {
                xmlVeriOku();
                Height = 390;
            }
            catch (Exception ex)
            {
                string M = string.Format("{0} Güncelleme Modül Açılış", -1);
                Lg.Info(M);
                Lg.Error(ex);
                cls_MesajBox.HataMesaji(ex);
            }
        }
        public void xmlVeriGuncelleme(string _strYeniVer)
        {
            XDocument xDoc = XDocument.Load(Application.StartupPath + "//Guncelleme.xml");
            XElement rootElement = xDoc.Root;
            foreach (XElement Proje in rootElement.Elements())
            {
                if (Proje.Element("ProgramID").Value == "1")
                {
                    Proje.Element("ProgramVer").Value = _strYeniVer;
                    break;
                }
            }
            xDoc.Save(Application.StartupPath + "//Guncelleme.xml");
        }
        public void xmlVeriOku()
        {
            string _strProgramAdi = "";
            string _strProgVer = "";
            XDocument xDoc = XDocument.Load(Application.StartupPath + "//Guncelleme.xml");
            var ProjeD = from P0 in xDoc.Elements("PROGRAM").Elements("Proje")
                         where (string)P0.Element("ProgramID") == "1"
                         select new
                         {
                             ProgramAdi = P0.Element("ProgramAdi").Value,
                             ProgramVer = P0.Element("ProgramVer").Value,
                             ProgramLink = P0.Element("ProgramLink").Value
                         };
            foreach (var Detay in ProjeD)
            {
                _strProgramAdi = Detay.ProgramAdi;
                ProgramVerLbl.Text = Detay.ProgramVer;
                _strProgramLink = Detay.ProgramLink;
            }

            GuncelProgLbl.Text = C.OptimusGeliyorKacin(_strProgramAdi);
            YuklenenVersiyonLbl.Text = GuncelProgLbl.Text;
            if (ProgramVerLbl.Text == GuncelProgLbl.Text)
            {
                cls_MesajBox.UyariMesaji("Güncel Versiyonu Kullanıyorsunuz.");
                Application.ExitThread();
                Application.Exit();
            }
            else
            {
                gridControl1.DataSource = C.OptimusGeliyorEkibiIle(_strProgramAdi, _strProgVer);
            }

        }
        private void DosyaIndirBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Height = 190;
                Versiyongroup.Visible = false;
                Guncellemegroup.Visible = false;
                GuncellemeStartgroup.Top = 0;
                DosyaIndirBtn.Visible = false;
                DownloadFile();
            }
            catch (Exception ex)
            {
                string M = string.Format("{0} Dosya İndirme İşlemi", -1);
                Lg.Info(M);
                Lg.Error(ex);
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void ProgramGuncelleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string ZipDosyasi = string.Format("{0}\\{1}", Application.StartupPath, _strGuncellenecekDosya);
             
                using (ZipArchive archive = ZipFile.Open(ZipDosyasi, ZipArchiveMode.Read))
                {
                    foreach (ZipArchiveEntry entry in archive.Entries)
                    {
                        entry.ExtractToFile(Application.StartupPath + entry.Name, true);
                    }
                }

                xmlVeriGuncelleme(YuklenenVersiyonLbl.Text);
                Process.Start(Application.StartupPath + "//Hizmet_MusMemnuniyet.exe");
                Application.Exit();
            }
            catch (Exception ex)
            {
                string M = string.Format("{0} Güncelleme İşlemi", -1);
                Lg.Info(M);
                Lg.Error(ex);
                cls_MesajBox.HataMesaji(ex);
            }
        }
        public void DownloadFile()
        {
            using (webClient = new WebClient())
            {
                string _strDosyaLinki = _strProgramLink;
                int karaktersayisi = _strDosyaLinki.LastIndexOf('/');
                _strGuncellenecekDosya = _strDosyaLinki.Remove(0, karaktersayisi + 1);

                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

                Uri URL = _strDosyaLinki.StartsWith("http://", StringComparison.OrdinalIgnoreCase) ? new Uri(_strDosyaLinki) : new Uri("http://" + _strDosyaLinki);
                webClient.DownloadFileAsync(URL, _strGuncellenecekDosya);
            }
        }
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            labelPerc.Text = e.ProgressPercentage.ToString() + "%";
            labelDownloaded.Text = string.Format("{0} MB / {1} MB", (e.BytesReceived / 1024d / 1024d).ToString("0.00"), (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00"));
        }
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            ProgramGuncelleBtn.Visible = true;
            labelPerc.Visible = false;
            ProgramGuncelleBtn.Visible = true;
        }
    }
}