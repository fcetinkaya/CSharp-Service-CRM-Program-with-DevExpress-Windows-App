using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
using Hizmet_MusMemnuniyet.Tools;
using NLog;

namespace Hizmet_MusMemnuniyet.Musteriler
{
    public partial class frmMusteriListesi : XtraForm
    {
        public frmMusteriListesi()
        {
            InitializeComponent();
        }
        HizmetCRMEntities H = new HizmetCRMEntities();
        private Logger Lg = LogManager.GetCurrentClassLogger();
        private void AramaBtn_Click(object sender, EventArgs e)
        {
            using (var formo = new WaitDialogForm("Veriler Yükleniyor", "Lütfen Bekleyiniz"))
            {
                try
                {
                    var MListe =
                        H.HizmetCRM_Musteriler.Where(w => w.IsActive == true).OrderBy(o => o.AdSoyad).Select(s => new
                        {
                            s.MusteriID, s.AdSoyad, s.Meslek, s.CepTlf, s.SabitTlf, s.Eposta, s.Adres
                        });
                    if (!string.IsNullOrEmpty(AdsoyadBox.Text))
                    {
                        MListe = MListe.Where(w => w.AdSoyad.Contains(AdsoyadBox.Text));
                    }
                    if (!string.IsNullOrEmpty(MeslekBox.Text))
                    {
                        MListe = MListe.Where(w => w.Meslek.Contains(MeslekBox.Text));
                    }
                    if (!string.IsNullOrEmpty(AdresBox.Text))
                    {
                        MListe = MListe.Where(w => w.Adres.Contains(AdresBox.Text));
                    }
                    gridControl1.DataSource = MListe.ToList();
                }
                catch (Exception ex)
                {
                    string M = string.Format("{0} Müşteri Arama İşlemi Yapıldı.", AdsoyadBox.Text);
                    Lg.Info(M);
                    Lg.Error(ex);
                    cls_MesajBox.HataMesaji(ex);
                }
            }
        }
        private void TemizleBtn_Click(object sender, EventArgs e)
        {
            AdsoyadBox.Text = "";
            MeslekBox.Text = "";
            AdresBox.Text = "";
            gridControl1.DataSource = null;
        }
        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteriKayit M = new frmMusteriKayit();
            M.ShowDialog();
            var musteriList = H.HizmetCRM_Musteriler.Where(w => w.IsActive == true);
            gridControl1.DataSource = musteriList.ToList();
        }
        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAnamenu.CorbaID = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MusteriID");
            frmMusteriKayit M = new frmMusteriKayit();
            M.ShowDialog();
            var MListe =
                         H.HizmetCRM_Musteriler.Where(w => w.IsActive == true).OrderBy(o => o.AdSoyad).Select(s => new
                         {
                             s.MusteriID, s.AdSoyad, s.Meslek, s.CepTlf, s.SabitTlf, s.Eposta, s.Adres
                         });
            gridControl1.DataSource = MListe.ToList();
        }
        private void excel2007ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = ".xls (*.xls)|*.xls";
            sfd.FileName = "MusteriListesi.xls";
            DialogResult res = sfd.ShowDialog();
            if (res == DialogResult.OK)
            {
                gridView1.OptionsPrint.ExpandAllDetails = true;
                gridView1.ExportToXls(sfd.FileName);
            }
        }
        private void excel2013ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = ".xlsx (*.xlsx)|*.xlsx";
            sfd.FileName = "MusteriListesi.xlsx";
            DialogResult res = sfd.ShowDialog();
            if (res == DialogResult.OK)
            {
                gridView1.OptionsPrint.ExpandAllDetails = true;
                gridView1.ExportToXlsx(sfd.FileName);
            }
        }
        private void pdfAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = ".pdf (*.pdf)|*.pdf";
            sfd.FileName = "MusteriListesi.pdf";
            DialogResult res = sfd.ShowDialog();
            if (res == DialogResult.OK)
            {
                gridView1.OptionsPrint.ExpandAllDetails = true;
                CreatePDF(gridControl1, sfd);
            }
        }
        private void csvAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = ".csv (*.csv)|*.csv";
            sfd.FileName = "MusteriListesi.csv";
            DialogResult res = sfd.ShowDialog();
            if (res == DialogResult.OK)
            {
                gridView1.OptionsPrint.ExpandAllDetails = true;
                gridView1.ExportToCsv(sfd.FileName);
            }
        }
        private void hTMLAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = ".html (*.html)|*.html";
            sfd.FileName = "MusteriListesi.html";
            DialogResult res = sfd.ShowDialog();
            if (res == DialogResult.OK)
            {
                gridView1.OptionsPrint.ExpandAllDetails = true;
                CreateHTML(gridControl1, sfd);
            }
        }
        public void CreatePDF(GridControl gridControl, SaveFileDialog S)
        {
            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink(ps);
            link.Component = gridControl;
            link.Landscape = true;
            link.CreateDocument();
            link.PrintingSystemBase.ExportToPdf(S.FileName);
        }
        public void CreateHTML(GridControl gridControl, SaveFileDialog S)
        {
            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink(ps);
            link.Component = gridControl;
            link.Landscape = true;
            link.CreateDocument();
            link.PrintingSystemBase.ExportToHtml(S.FileName);
        }
        public void CreateImage(GridControl gridControl, SaveFileDialog S)
        {
            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink(ps);
            link.Component = gridControl;
            link.Landscape = true;
            link.CreateDocument();
            link.PrintingSystemBase.ExportToImage(S.FileName);
        }
        private void resimOlarakKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = ".jpg (*.jpg)|*.jpg";
            sfd.FileName = "MusteriListesi.jpg";
            DialogResult res = sfd.ShowDialog();
            if (res == DialogResult.OK)
            {
                gridView1.OptionsPrint.ExpandAllDetails = true;
                CreateImage(gridControl1, sfd);
            }
        }
        private void seçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAnamenu.CorbaID = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MusteriID");
            Close();
        }

        private void bugünDoğanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Gun = DateTime.Now.Day;
            int Ay = DateTime.Now.Month;
            var MListe =
                       H.HizmetCRM_Musteriler.Where(w => w.IsActive == true && w.Dogum == true && w.DogumAy == Ay && w.DogumGun == Gun).OrderBy(o => o.AdSoyad).Select(s => new
                       {
                           s.MusteriID, s.AdSoyad, s.Meslek, s.CepTlf, s.SabitTlf, s.Eposta, s.Adres
                       });
            gridControl1.DataSource = MListe.ToList();
        }

        private void bugünEvlenenlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Gun = DateTime.Now.Day;
            int Ay = DateTime.Now.Month;
            var MListe =
                       H.HizmetCRM_Musteriler.Where(w => w.IsActive == true && w.Evlilik == true && w.EvlilikAy == Ay && w.EvlilikGun == Gun).OrderBy(o => o.AdSoyad).Select(s => new
                       {
                           s.MusteriID, s.AdSoyad, s.Meslek, s.CepTlf, s.SabitTlf, s.Eposta, s.Adres
                       });
            gridControl1.DataSource = MListe.ToList();
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView1.ShowPrintPreview();
        }
    }
}