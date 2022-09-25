using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
using Hizmet_MusMemnuniyet.Tools;
using NLog;

namespace Hizmet_MusMemnuniyet.Kategori
{
    public partial class frmKategoriListesi : XtraForm
    {
        public frmKategoriListesi()
        {
            InitializeComponent();
        }
        int PerID;
        private Logger Lg = LogManager.GetCurrentClassLogger();
        HizmetCRMEntities H = new HizmetCRMEntities();
        private void frmKategoriListesi_Load(object sender, EventArgs e)
        {
            if (frmAnamenu.CorbaID > 0)
            {
                KategoriListesi_AnaKategoriyeGore(frmAnamenu.CorbaID);
            }
            else
            {
                KategoriListesi();
                Kategoriler();
            }
        }
        private void KategoriListesi_AnaKategoriyeGore(int _AnaID)
        {
            var PerList = H.HizmetCRM_Kategori.Join(H.HizmetCRM_AnaKategori,
                pj => pj.AnaKategoriID,
                sj => sj.AnaKategoriID,
                (alt, ana) => new
                {
                    alt.KategoriID,
                    alt.Ad,
                    alt.IsActive,
                    ana.AnaKategoriID,
                    ana.AnaAd
                }).ToList();
            gridControl1.DataSource = PerList.ToList();
        }
        private void KategoriListesi()
        {
            var PerList = H.HizmetCRM_Kategori.Join(H.HizmetCRM_AnaKategori,
                 pj => pj.AnaKategoriID,
                 sj => sj.AnaKategoriID,
                 (alt, ana) => new
                 {
                     alt.KategoriID,
                     alt.Ad,
                     alt.IsActive,
                     ana.AnaKategoriID,
                     ana.AnaAd
                 }).Where(w => w.IsActive == true);
            gridControl1.DataSource = PerList.ToList();
        }
        private void KategoriListesi_Arama()
        {
            var PList = H.HizmetCRM_Kategori.Join(H.HizmetCRM_AnaKategori,
                 pj => pj.AnaKategoriID,
                 sj => sj.AnaKategoriID,
                 (alt, ana) => new
                 {
                     alt.KategoriID,
                     alt.Ad,
                     alt.IsActive,
                     ana.AnaKategoriID,
                     ana.AnaAd
                 }).Where(w => w.IsActive == true);

            if (!string.IsNullOrEmpty(KategoriBox.Text))
            {
                PList = PList.Where(w => w.Ad.Contains(KategoriBox.Text));
            }
            if (!string.IsNullOrEmpty(AnaKategoriLookUp.Text))
            {
                PList = PList.Where(w => w.AnaKategoriID == (int)AnaKategoriLookUp.EditValue);
            }
            gridControl1.DataSource = PList.ToList();
        }
        void Kategoriler()
        {
            var Sub = from s in H.HizmetCRM_AnaKategori
                      where s.IsActive == true
                      orderby s.AnaAd descending
                      select new
                      {
                          s.AnaKategoriID,
                          s.AnaAd
                      };
            AnaKategoriLookUp.Properties.DataSource = Sub.ToList();
            AnaKategoriLookUp.Properties.ValueMember = "AnaKategoriID";
            AnaKategoriLookUp.Properties.DisplayMember = "AnaAd";
        }
        private void KapatBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void AraBtn_Click(object sender, EventArgs e)
        {
            using (var formo = new WaitDialogForm("Veriler Yükleniyor", "Lütfen Bekleyiniz"))
            {
                try
                {
                    KategoriListesi_Arama();
                }
                catch (Exception ex)
                {
                    string M = string.Format("{0} Personel Arama İşlemi Yapıldı.", PerID);
                    Lg.Info(M);
                    Lg.Error(ex);
                    cls_MesajBox.HataMesaji(ex);
                }
            }
        }
        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKategoriKayit P = new frmKategoriKayit();
            P.ShowDialog();
            KategoriListesi();
        }
        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAnamenu.CorbaID = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "KategoriID");
            frmKategoriKayit P = new frmKategoriKayit();
            P.ShowDialog();
            KategoriListesi();
        }
        private void excel2007ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = ".xls (*.xls)|*.xls";
            sfd.FileName = "KategoriListesi.xls";
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
            sfd.FileName = "KategoriListesi.xlsx";
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
            sfd.FileName = "KategoriListesi.pdf";
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
            sfd.FileName = "KategoriListesi.csv";
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
            sfd.FileName = "KategoriListesi.html";
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
            sfd.FileName = "KategoriListesi.jpg";
            DialogResult res = sfd.ShowDialog();
            if (res == DialogResult.OK)
            {
                gridView1.OptionsPrint.ExpandAllDetails = true;
                CreateImage(gridControl1, sfd);
            }
        }
        private void seçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAnamenu.CorbaID = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "KategoriID");
            Close();
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView1.ShowPrintPreview();
        }

        private void TemizleBtn_Click(object sender, EventArgs e)
        {
            KategoriBox.Text = "";
            AnaKategoriLookUp.EditValue = "";
        }
    }
}