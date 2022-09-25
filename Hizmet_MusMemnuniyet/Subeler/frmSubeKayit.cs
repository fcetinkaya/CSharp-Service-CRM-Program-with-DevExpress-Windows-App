using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using Hizmet_MusMemnuniyet.Tools;
using NLog;

namespace Hizmet_MusMemnuniyet.Subeler
{
    public partial class frmSubeKayit : XtraForm
    {
        public frmSubeKayit()
        {
            InitializeComponent();
        }
          bool Edit;
          int SubeID;
        private Logger Lg = LogManager.GetCurrentClassLogger();
        HizmetCRMEntities H = new HizmetCRMEntities();
        private void frmPersonelKayit_Load(object sender, EventArgs e)
        {
            if (frmAnamenu.CorbaID > 0)
            {
                SubeID = frmAnamenu.CorbaID;
                GelBilgiler(SubeID);
            }
            SubeListesi();
        }
        private void SubeListesi()
        {
            var PerList = H.HizmetCRM_Subeler.Where(w => w.IsActive == true).OrderBy(o => o.SubeAdi).Select(s => new
            {
                s.SubeID, s.SubeAdi
            });
            gridControl1.DataSource = PerList.ToList();
        }
        void GelBilgiler(int Aydimci)
        {
            var Gel = H.HizmetCRM_Subeler.Where(g => g.SubeID == Aydimci).Select(sS =>
                new
                {
                    sS.SubeAdi
                });
            SubeBox.Text = Gel.Select(s => s.SubeAdi).FirstOrDefault();
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
                    HizmetCRM_Subeler P = H.HizmetCRM_Subeler.FirstOrDefault(p => p.SubeID == SubeID);
                    P.IsActive = false;
                    H.SaveChanges();
                    cls_Log.LogKayit(SubeBox.Text + " Şube Silindi.", "Şube Kayıt");
                    cls_MesajBox.SilmeMesaji("Şube silindi.");
                    Close();
                }
            }
            catch (Exception ex)
            {
                string M = string.Format("{0} Şube Silme İşlemi", SubeID);
                Lg.Info(M);
                Lg.Error(ex);
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(SubeBox.Text))
                {
                    dxErrorProvider1.SetError(SubeBox, "Şube Adını Yazınız", ErrorType.Information);
                }
                else
                {
                    if (Edit)
                    {
                        HizmetCRM_Subeler SGun = H.HizmetCRM_Subeler.FirstOrDefault(w => w.SubeID == SubeID);
                        SGun.SubeAdi = SubeBox.Text;
                        H.SaveChanges();
                        cls_Log.LogKayit(SubeBox.Text + " Şube Güncellendi.", "Şube Kayıt");
                        cls_MesajBox.GuncelleMesaji("Şube Bilgileri Güncellendi");
                        Close();
                    }
                    else
                    {
                        HizmetCRM_Subeler Su = new HizmetCRM_Subeler();
                        Su.SubeAdi = SubeBox.Text;
                        Su.IsActive = true;
                        H.HizmetCRM_Subeler.Add(Su);
                        H.SaveChanges();
                        cls_Log.LogKayit(SubeBox.Text + " Şube Eklendi.", "Şube Kayıt");
                        SubeBox.Text = "";
                        cls_MesajBox.KayitMesaji("Şube Kayıt Edildi.");
                        SubeListesi();
                    }
                }
            }
            catch (Exception ex)
            {
                string M = string.Format("{0} Şube Kayıt İşlemi", SubeBox.Text);
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
                SubeID = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SubeID");
                SubeBox.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SubeAdi").ToString();
                Edit = true;
                SilBtn.Enabled = true;
            }
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView1.ShowPrintPreview();
        }
    }
}