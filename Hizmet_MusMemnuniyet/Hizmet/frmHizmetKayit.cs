using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using Hizmet_MusMemnuniyet.Tools;
using NLog;

namespace Hizmet_MusMemnuniyet.Hizmet
{
    public partial class frmHizmetKayit : XtraForm
    {
        public frmHizmetKayit()
        {
            InitializeComponent();
        }
        bool Edit;
        int HizmetID;
        private Logger Lg = LogManager.GetCurrentClassLogger();
        HizmetCRMEntities H = new HizmetCRMEntities();
        private void frmPersonelKayit_Load(object sender, EventArgs e)
        {
            if (frmAnamenu.CorbaID > 0)
            {
                HizmetID = frmAnamenu.CorbaID;
                GelBilgiler(HizmetID);
            }
            HizmetListesi();
        }
        private void HizmetListesi()
        {
            var HizmetList = H.HizmetCRM_Hizmetler.Where(w => w.IsActive == true).OrderBy(o => o.HizmetAdi).Select(s => new
            {
                s.HizmetID, s.HizmetAdi
            });
            gridControl1.DataSource = HizmetList.ToList();
        }
        void GelBilgiler(int Aydimci)
        {
            var Gel = H.HizmetCRM_Hizmetler.Where(g => g.HizmetID == Aydimci).Select(sS =>
                new
                {
                    sS.HizmetAdi
                });
            HizmetAdiBox.Text = Gel.Select(s => s.HizmetAdi).FirstOrDefault();
            Edit = true;
            SilBtn.Enabled = true;
        }
        private void frmPersonelKayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAnamenu.CorbaID = -1;
            Edit = false;
        }
        private void SilBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (cls_MesajBox.Sor("Silmek istediğinize emin misiniz ?"))
                {
                    HizmetCRM_Hizmetler P = H.HizmetCRM_Hizmetler.FirstOrDefault(p => p.HizmetID == HizmetID);
                    P.IsActive = false;
                    H.SaveChanges();
                    cls_Log.LogKayit(HizmetAdiBox.Text + " Hizmet Silindi.", "Hizmet Kayıt");
                    cls_MesajBox.SilmeMesaji("Hizmet silindi.");
                    Close();
                }
            }
            catch (Exception ex)
            {
                string M = string.Format("{0} Hizmet Silme İşlemi", HizmetID);
                Lg.Info(M);
                Lg.Error(ex);
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(HizmetAdiBox.Text))
                {
                    dxErrorProvider1.SetError(HizmetAdiBox, "Hizmet Adını Yazınız", ErrorType.Information);
                }
                else
                {
                    if (Edit)
                    {
                        HizmetCRM_Hizmetler SGun = H.HizmetCRM_Hizmetler.FirstOrDefault(w => w.HizmetID == HizmetID);
                        SGun.HizmetAdi = HizmetAdiBox.Text;
                        H.SaveChanges();
                        cls_Log.LogKayit(HizmetAdiBox.Text + " Hizmet Güncellendi.", "Hizmet Kayıt");
                        cls_MesajBox.GuncelleMesaji("Hizmet Bilgileri Güncellendi");
                        Close();
                    }
                    else
                    {
                        HizmetCRM_Hizmetler Su = new HizmetCRM_Hizmetler();
                        Su.HizmetAdi = HizmetAdiBox.Text;
                        Su.IsActive = true;
                        H.HizmetCRM_Hizmetler.Add(Su);
                        H.SaveChanges();
                        cls_Log.LogKayit(HizmetAdiBox.Text + " Hizmet Eklendi.", "Hizmet Kayıt");
                        HizmetAdiBox.Text = "";
                        cls_MesajBox.KayitMesaji("Hizmet Kayıt Edildi.");
                        HizmetListesi();
                    }
                }
            }
            catch (Exception ex)
            {
                string M = string.Format("{0} Hizmet Kayıt İşlemi", HizmetAdiBox.Text);
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
                HizmetID = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HizmetID");
                HizmetAdiBox.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HizmetAdi").ToString();
                Edit = true;
                SilBtn.Enabled = true;
            }
        }
    }
}