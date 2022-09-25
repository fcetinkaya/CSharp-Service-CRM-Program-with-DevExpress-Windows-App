using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
using Hizmet_MusMemnuniyet.Tools;
using NLog;

namespace Hizmet_MusMemnuniyet.Personel
{
    public partial class frmPersonelListesi : XtraForm
    {
        public frmPersonelListesi()
        {
            InitializeComponent();
        }
        int PerID;
        private Logger Lg = LogManager.GetCurrentClassLogger();
        HizmetCRMEntities H = new HizmetCRMEntities();
        private void frmPersonelListesi_Load(object sender, EventArgs e)
        {
            if (frmAnamenu.CorbaID > 0)
            {
                PersonelListesi_SubeyeGore(frmAnamenu.CorbaID);
            }
            else
            {
                PersonelListesi();
                Subeler();
            }
        }
        private void PersonelListesi_SubeyeGore(int _SubeID)
        {
            var PerList = H.HizmetCRM_Personel.Join(
                H.HizmetCRM_Subeler, pj => pj.SubeID,
                sj => sj.SubeID,
                (person, sube) => new
                {
                    PersonelID = person.PersonID,
                    AdSoyad = person.PersonelAdi,
                    person.IsActive,
                    person.SubeID,
                    sube.SubeAdi
                }).Where(w => w.IsActive == true && w.SubeID == _SubeID).OrderBy(o => o.AdSoyad);
            gridControl1.DataSource = PerList.ToList();
        }
        private void PersonelListesi()
        {
            var PerList = H.HizmetCRM_Personel.Join(
                H.HizmetCRM_Subeler, pj => pj.SubeID,
                sj => sj.SubeID,
                (person, sube) => new
                {
                    PersonelID = person.PersonID,
                    AdSoyad = person.PersonelAdi,
                    person.IsActive,
                    person.SubeID,
                    sube.SubeAdi
                }).Where(w => w.IsActive == true).OrderBy(o => o.AdSoyad);
            gridControl1.DataSource = PerList.ToList();
        }
        private void PersonelListesi_Arama()
        {
            var PList = H.HizmetCRM_Personel.Join(
                H.HizmetCRM_Subeler, pj => pj.SubeID,
                sj => sj.SubeID,
                (person, sube) => new
                {
                    PersonelID = person.PersonID,
                    AdSoyad = person.PersonelAdi,
                    person.IsActive,
                    person.SubeID,
                    sube.SubeAdi
                }).Where(w => w.IsActive == true);

            if (!string.IsNullOrEmpty(AdSoyadBox.Text))
            {
                PList = PList.Where(w => w.AdSoyad.Contains(AdSoyadBox.Text));
            }
            if (!string.IsNullOrEmpty(SubeLookUp.Text))
            {
                PList = PList.Where(w => w.SubeID == (int)SubeLookUp.EditValue);
            }
            gridControl1.DataSource = PList.ToList();
        }
        void Subeler()
        {
            var Sub = from s in H.HizmetCRM_Subeler
                      where s.IsActive == true
                      orderby s.SubeAdi descending
                      select new
                      {
                          s.SubeID,
                          s.SubeAdi
                      };
            SubeLookUp.Properties.DataSource = Sub.ToList();
            SubeLookUp.Properties.ValueMember = "SubeID";
            SubeLookUp.Properties.DisplayMember = "SubeAdi";
        }
        private void frmPersonelListesi_FormClosed(object sender, FormClosedEventArgs e)
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
                PersonelListesi_Arama();
            }
            catch (Exception ex)
            {
                string M = string.Format("{0} Personel Arama İşlemi Yapıldı.", PerID);
                Lg.Info(M);
                Lg.Error(ex);
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonelKayit P = new frmPersonelKayit();
            P.ShowDialog();
            PersonelListesi();
        }
        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAnamenu.CorbaID = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "PersonelID");
            frmPersonelKayit P = new frmPersonelKayit();
            P.ShowDialog();
            PersonelListesi();
        }
        private void excel2007ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = ".xls (*.xls)|*.xls";
            sfd.FileName = "PersonelListesi.xls";
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
            sfd.FileName = "PersonelListesi.xlsx";
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
            sfd.FileName = "PersonelListesi.pdf";
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
            sfd.FileName = "PersonelListesi.csv";
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
            sfd.FileName = "PersonelListesi.html";
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
            sfd.FileName = "PersonelListesi.jpg";
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