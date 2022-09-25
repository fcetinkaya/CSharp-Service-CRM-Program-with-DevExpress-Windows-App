using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
using Hizmet_MusMemnuniyet.Tools;
using NLog;

namespace Hizmet_MusMemnuniyet.Hizmet
{
    public partial class frmHizmetListesi : XtraForm
    {
        public frmHizmetListesi()
        {
            InitializeComponent();
        }
        int PerID;
        private Logger Lg = LogManager.GetCurrentClassLogger();
        HizmetCRMEntities H = new HizmetCRMEntities();
        private void frmSubeListesi_Load(object sender, EventArgs e)
        {
            HizmetlerListesi();
        }
        private void HizmetlerListesi()
        {
            var HizmetList = H.HizmetCRM_Hizmetler.Where(w => w.IsActive == true).OrderBy(o => o.HizmetAdi).Select(s => new
            {
                s.HizmetID, s.HizmetAdi
            });
            gridControl1.DataSource = HizmetList.ToList();
        }

        private void frmSubeListesi_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAnamenu.CorbaID = -1;
        }
        private void KapatBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void AraBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var HizmetList = H.HizmetCRM_Hizmetler.Where(w => w.IsActive == true).OrderBy(o => o.HizmetAdi).Select(s => new
                {
                    s.HizmetID, s.HizmetAdi
                });
                if (!string.IsNullOrEmpty(HizmetAdiBox.Text))
                {
                    HizmetList = HizmetList.Where(w => w.HizmetAdi.Contains(HizmetAdiBox.Text));
                }
                gridControl1.DataSource = HizmetList.ToList();
            }
            catch (Exception ex)
            {
                string M = string.Format("{0} Hizmet Arama İşlemi Yapıldı.", HizmetAdiBox.Text);
                Lg.Info(M);
                Lg.Error(ex);
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHizmetKayit P = new frmHizmetKayit();
            P.ShowDialog();
            HizmetlerListesi();
        }
        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAnamenu.CorbaID = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HizmetID");
            frmHizmetKayit P = new frmHizmetKayit();
            P.ShowDialog();
            HizmetlerListesi();
        }
        private void excel2007ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = ".xls (*.xls)|*.xls";
            sfd.FileName = "HizmetListesi.xls";
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
            sfd.FileName = "HizmetListesi.xlsx";
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
            sfd.FileName = "HizmetListesi.pdf";
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
            sfd.FileName = "HizmetListesi.csv";
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
            sfd.FileName = "HizmetListesi.html";
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
            sfd.FileName = "HizmetListesi.jpg";
            DialogResult res = sfd.ShowDialog();
            if (res == DialogResult.OK)
            {
                gridView1.OptionsPrint.ExpandAllDetails = true;
                CreateImage(gridControl1, sfd);
            }
        }
        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView1.ShowPrintPreview();
        }
    }
}