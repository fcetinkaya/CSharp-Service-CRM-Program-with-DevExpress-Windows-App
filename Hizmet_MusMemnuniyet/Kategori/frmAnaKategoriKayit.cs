using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using Hizmet_MusMemnuniyet.Tools;
using NLog;

namespace Hizmet_MusMemnuniyet.Kategori
{
    public partial class frmAnaKategoriKayit : XtraForm
    {
        public frmAnaKategoriKayit()
        {
            InitializeComponent();
        }
        bool Edit;
        int KategoriID;
        private Logger Lg = LogManager.GetCurrentClassLogger();
        HizmetCRMEntities H = new HizmetCRMEntities();
        private void frmPersonelKayit_Load(object sender, EventArgs e)
        {
            if (frmAnamenu.CorbaID > 0)
            {
                KategoriID = frmAnamenu.CorbaID;
                GelBilgiler(KategoriID);
            }
            AnaKategoriListesi();
        }
        private void AnaKategoriListesi()
        {
            var PerList = H.HizmetCRM_AnaKategori.Where(w => w.IsActive == true).Select(s => new
            {
                s.AnaKategoriID,
                s.AnaAd
            });
            gridControl1.DataSource = PerList.ToList();
        }
        void GelBilgiler(int Aydimci)
        {
            var Gel = H.HizmetCRM_AnaKategori.Where(g => g.AnaKategoriID == Aydimci).Select(sS =>
                new
                {
                    sS.AnaAd
                });
            KategoriBox.Text = Gel.Select(s => s.AnaAd).FirstOrDefault();
            Edit = true;
            SilBtn.Enabled = true;
        }
        private void frmPersonelKayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAnamenu.CorbaID = 0;
            Edit = false;
        }
        private void SilBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (cls_MesajBox.Sor("Silmek istediğinize emin misiniz ?"))
                {
                    HizmetCRM_AnaKategori P = H.HizmetCRM_AnaKategori.FirstOrDefault(p => p.AnaKategoriID == KategoriID);
                    P.IsActive = false;
                    H.SaveChanges();
                    cls_Log.LogKayit(KategoriBox.Text + " Kategori Silindi.", "Kategori Kayıt");
                    cls_MesajBox.SilmeMesaji("Kategori silindi.");
                    Close();
                }
            }
            catch (Exception ex)
            {
                string M = string.Format("{0} Kategori Silme İşlemi", KategoriID);
                Lg.Info(M);
                Lg.Error(ex);
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(KategoriBox.Text))
                {
                    dxErrorProvider1.SetError(KategoriBox, "Kategori Adını Yazınız", ErrorType.Information);
                }
                else
                {
                    if (Edit)
                    {
                        HizmetCRM_AnaKategori SGun = H.HizmetCRM_AnaKategori.FirstOrDefault(w => w.AnaKategoriID == KategoriID);
                        SGun.AnaAd = KategoriBox.Text;
                        H.SaveChanges();
                        cls_Log.LogKayit(KategoriBox.Text + " Kategori Güncellendi.", "Kategori Kayıt");
                        cls_MesajBox.GuncelleMesaji("Kategori Bilgileri Güncellendi");
                        Close();
                    }
                    else
                    {
                        HizmetCRM_AnaKategori Su = new HizmetCRM_AnaKategori();
                        Su.AnaAd = KategoriBox.Text;
                        Su.IsActive = true;
                        H.HizmetCRM_AnaKategori.Add(Su);
                        H.SaveChanges();
                        cls_Log.LogKayit(KategoriBox.Text + " Kategori Eklendi.", "Kategori Kayıt");
                        KategoriBox.Text = "";
                        cls_MesajBox.KayitMesaji("Kategori Kayıt Edildi.");
                        AnaKategoriListesi();
                    }
                }
            }
            catch (Exception ex)
            {
                string M = string.Format("{0} Kategori Kayıt İşlemi", KategoriBox.Text);
                Lg.Info(M);
                Lg.Error(ex);
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void KapatBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                KategoriID = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "AnaKategoriID");
                KategoriBox.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "AnaAd").ToString();
                Edit = true;
                SilBtn.Enabled = true;
            }
        }
    }
}