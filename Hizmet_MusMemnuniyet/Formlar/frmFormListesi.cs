using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
using Hizmet_MusMemnuniyet.Musteriler;
using Hizmet_MusMemnuniyet.Tools;
using NLog;

namespace Hizmet_MusMemnuniyet.Formlar
{
    public partial class frmFormListesi : XtraForm
    {
        public frmFormListesi()
        {
            InitializeComponent();
        }
        private Logger Lg = LogManager.GetCurrentClassLogger();
        HizmetCRMEntities H = new HizmetCRMEntities();

        private void TemizleBtn_Click(object sender, EventArgs e)
        {
            IlkFormTarih.EditValue = null;
            IkinciFormTarih.EditValue = null;
            IlkAramaTarihi.EditValue = null;
            IkinciAramaTarihi.EditValue = null;
            comboUlasimSecenegi.SelectedIndex = -1;
            comboGorusmeSonucu.SelectedIndex = -1;
            personelLookUp.EditValue = null;
            SubelerLookUp.EditValue = null;
            HizmetLookup.EditValue = null;
            cariAdiBtn.EditValue = null;
            cariAdiBtn.Text = null;
            gridControl1.DataSource = null;
        }
        private void AramaBtn_Click(object sender, EventArgs e)
        {
            using (var formo = new WaitDialogForm("Veriler Yükleniyor", "Lütfen Bekleyiniz"))
            {
                try
                {
                    var FormList = from anket in H.HizmetCRM_YeniAnket
                                   join sub in H.HizmetCRM_Subeler on anket.SubeID equals sub.SubeID
                                   join per in H.HizmetCRM_Personel on anket.PersonID equals per.PersonID
                                   join mus in H.HizmetCRM_Musteriler on anket.MusteriID equals mus.MusteriID
                                   where anket.IsActive == true
                                   orderby anket.AnketID descending
                                   select new
                                   //H.HizmetCRM_YeniAnket.Where(w => w.IsActive).OrderByDescending(o => o.AnketID).Select(
                                   //s => new
                                   {
                                       anket.AnketID,
                                       anket.AnketTarih,
                                       anket.AramaTarih,
                                       anket.Numara,
                                       anket.GorusmeSonucu,
                                       anket.UlasimSecenegi,
                                       anket.HizmetID,
                                       sub.SubeAdi,
                                       sub.SubeID,
                                       per.PersonelAdi,
                                       per.PersonID,
                                       mus.AdSoyad,
                                       mus.MusteriID

                                   };
                    if (HizmetLookup.Text != "")
                    {
                        FormList = FormList.Where(p => p.HizmetID == (int)HizmetLookup.EditValue);
                    }
                    if (IlkFormTarih.EditValue != null)
                    {
                        FormList = FormList.Where(ilk => ilk.AnketTarih > IlkFormTarih.DateTime.Date);
                    }
                    if (IkinciFormTarih.EditValue != null)
                    {
                        FormList = FormList.Where(ilk => ilk.AnketTarih < IkinciFormTarih.DateTime.Date);
                    }
                    if (IlkAramaTarihi.EditValue != null)
                    {
                        FormList = FormList.Where(ilk => ilk.AramaTarih > IlkAramaTarihi.DateTime.Date);
                    }
                    if (IkinciAramaTarihi.EditValue != null)
                    {
                        FormList = FormList.Where(ilk => ilk.AramaTarih < IkinciAramaTarihi.DateTime.Date);
                    }
                    if (comboUlasimSecenegi.SelectedIndex > 0)
                    {
                        FormList = FormList.Where(c => c.UlasimSecenegi == comboUlasimSecenegi.SelectedText);
                    }
                    if (comboGorusmeSonucu.SelectedIndex > 0)
                    {
                        FormList = FormList.Where(g => g.GorusmeSonucu == comboGorusmeSonucu.SelectedText);
                    }
                    if (personelLookUp.Text != "")
                    {
                        FormList = FormList.Where(p => p.PersonID == (int)personelLookUp.EditValue);
                    }
                    if (SubelerLookUp.Text != "")
                    {
                        FormList = FormList.Where(p => p.SubeID == (int)SubelerLookUp.EditValue);
                    }
                    if (cariAdiBtn.EditValue != null)
                    {
                        FormList = FormList.Where(c => c.AdSoyad.Contains(cariAdiBtn.Text));
                    }
                    gridControl1.DataSource = FormList.ToList();
                }
                catch (Exception ex)
                {
                    string M = string.Format("{0} Form Listeleme, Arama İşlemi", frmAnamenu.CorbaID);
                    Lg.Info(M);
                    Lg.Error(ex);
                    cls_MesajBox.HataMesaji(ex);
                }
            }
        }
        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFormGirisi fg = new frmFormGirisi();
            fg.ShowDialog();
            gridControl1.RefreshDataSource();
        }
        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAnamenu.CorbaID = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "AnketID");
            frmFormGirisi fg = new frmFormGirisi();
            fg.ShowDialog();
            gridControl1.RefreshDataSource();
        }
        private void cariKodBtn_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            try
            {
                frmMusteriListesi M = new frmMusteriListesi();
                M.ShowDialog();
                if (frmAnamenu.CorbaID > 0)
                {
                    var PerCari = H.HizmetCRM_Musteriler.Where(w => w.MusteriID == frmAnamenu.CorbaID).Select(s => new
                    {
                        s.AdSoyad
                    });
                    foreach (var Geldi in PerCari)
                    {
                        cariAdiBtn.Text = Geldi.AdSoyad;
                        frmAnamenu.CorbaID = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                string M = string.Format("{0} Form Arama İşlemi, Cari Seçme İşlemi", frmAnamenu.CorbaID);
                Lg.Info(M);
                Lg.Error(ex);
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void excel2007ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = ".xls (*.xls)|*.xls";
            sfd.FileName = "FormListesi.xls";
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
            sfd.FileName = "FormListesi.xlsx";
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
            sfd.FileName = "FormListesi.pdf";
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
            sfd.FileName = "FormListesi.csv";
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
            sfd.FileName = "FormListesi.html";
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
            sfd.FileName = "FormListesi.jpg";
            DialogResult res = sfd.ShowDialog();
            if (res == DialogResult.OK)
            {
                gridView1.OptionsPrint.ExpandAllDetails = true;
                CreateImage(gridControl1, sfd);
            }
        }
        private void müşteriKartıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAnamenu.CorbaID = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MusteriID");
            frmMusteriKayit mL = new frmMusteriKayit();
            mL.Show();
        }
        void Personel_Subeler_Hizmetler()
        {
            var Per = from per in H.HizmetCRM_Personel
                      where per.IsActive == true
                      select new
                      {
                          per.PersonID,
                          per.PersonelAdi
                      };

            personelLookUp.Properties.DataSource = Per.ToList();
            personelLookUp.Properties.DisplayMember = "PersonelAdi";
            personelLookUp.Properties.ValueMember = "PersonID";

            // Lambda Expression ile...

            var Subeler = H.HizmetCRM_Subeler.Where(w => w.IsActive == true).Select(ws => new
            {
                ws.SubeID,
                ws.SubeAdi
            });

            SubelerLookUp.Properties.DataSource = Subeler.ToList();
            SubelerLookUp.Properties.DisplayMember = "SubeAdi";
            SubelerLookUp.Properties.ValueMember = "SubeID";

            // Hizmetler...
            var hizmetler = from h in H.HizmetCRM_Hizmetler
                            where h.IsActive == true
                            select new
                            {
                                h.HizmetID,
                                h.HizmetAdi
                            };


            //H.HizmetCRM_Hizmetler.Where(w => w.IsActive == true).Select(ws => new
            //{
            //    ws.HizmetID,
            //    ws.HizmetAdi
            //});

            HizmetLookup.Properties.DataSource = hizmetler.ToList();
            HizmetLookup.Properties.DisplayMember = "HizmetAdi";
            HizmetLookup.Properties.ValueMember = "HizmetID";

        }
        private void frmFormListesi_Load(object sender, EventArgs e)
        {
            Personel_Subeler_Hizmetler();
        }
        private void seçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAnamenu.CorbaID = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "AnketID");
            Close();

        }
        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView1.ShowPrintPreview();
        }
    }
}