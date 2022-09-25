using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using Hizmet_MusMemnuniyet.Tools;
using NLog;

namespace Hizmet_MusMemnuniyet.Kategori
{
    public partial class frmKategoriKayit : XtraForm
    {
        public frmKategoriKayit()
        {
            InitializeComponent();
        }
          bool Edit;
          int KatID;
        private Logger Lg = LogManager.GetCurrentClassLogger();
        HizmetCRMEntities H = new HizmetCRMEntities();
        private void frmPersonelKayit_Load(object sender, EventArgs e)
        {
            if (frmAnamenu.CorbaID > 0)
            {
                KatID = frmAnamenu.CorbaID;
                AnaKategori(KatID);
                GelBilgiler(KatID);
            }
            else
            {
                AnaKategori(0);
            }
            KategoriListesi();
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
        void AnaKategori(int Value)
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
            if (Value != 0)
            {
                AnaKategoriLookUp.EditValue = Value;
            }
        }
        void GelBilgiler(int Aydimci)
        {
            var Gel = H.HizmetCRM_Kategori.Where(g => g.KategoriID == Aydimci).Select(sS =>
                new
                {
                    sS.Ad,
                    sS.AnaKategoriID
                });
            foreach (var Geldi in Gel)
            {
                KategoriAdBox.Text = Geldi.Ad;
                AnaKategoriLookUp.EditValue = Geldi.AnaKategoriID;
                Edit = true;
                SilBtn.Enabled = true;
            }
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
                    HizmetCRM_Kategori P = H.HizmetCRM_Kategori.FirstOrDefault(p => p.KategoriID == KatID);
                    P.IsActive = false;
                    H.SaveChanges();
                    cls_Log.LogKayit(KategoriAdBox.Text + " Kategori Silindi.", "Kategori Kayıt");
                    cls_MesajBox.SilmeMesaji("Kategori silindi.");
                    Close();
                }
            }
            catch (Exception ex)
            {
                string M = string.Format("{0} Kategori Silme İşlemi", KatID);
                Lg.Info(M);
                Lg.Error(ex);
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(KategoriAdBox.Text))
                {
                    dxErrorProvider1.SetError(KategoriAdBox, "Kategori Adı Yazınız", ErrorType.Information);
                }
                else
                {
                    if (string.IsNullOrEmpty(AnaKategoriLookUp.Text))
                    {
                        dxErrorProvider1.ClearErrors();
                        dxErrorProvider2.ClearErrors(); dxErrorProvider2.SetError(AnaKategoriLookUp, "Ana Kategori Seçiniz.", ErrorType.Information);
                    }
                    else
                    {
                        if (Edit)
                        {
                            HizmetCRM_Kategori pGun = H.HizmetCRM_Kategori.FirstOrDefault(w => w.KategoriID == KatID);
                            pGun.Ad = KategoriAdBox.Text;
                            pGun.AnaKategoriID = (int)AnaKategoriLookUp.EditValue;
                            H.SaveChanges();
                            cls_Log.LogKayit(KategoriAdBox.Text + " Kategori Güncellendi.", "Kategori Kayıt");
                            cls_MesajBox.GuncelleMesaji("Kategori Bilgileri Güncellendi");
                            Close();
                        }
                        else
                        {
                            HizmetCRM_Kategori Pe = new HizmetCRM_Kategori();
                            Pe.Ad = KategoriAdBox.Text;
                            Pe.IsActive = true;
                            Pe.AnaKategoriID = (int)AnaKategoriLookUp.EditValue;
                            H.HizmetCRM_Kategori.Add(Pe);
                            H.SaveChanges();
                            cls_Log.LogKayit(KategoriAdBox.Text + " Kategori Eklendi.", "Kategori Kayıt");
                            KategoriAdBox.Text = "";
                            AnaKategoriLookUp.EditValue = null;
                            AnaKategoriLookUp.Text = "";
                            cls_MesajBox.KayitMesaji("Kategori Kayıt Edildi.");
                            KategoriListesi();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string M = string.Format("{0} Kategori Ekleme İşlemi", KategoriAdBox.Text);
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
                KatID = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "KategoriID");
                KategoriAdBox.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Ad").ToString();
                string Aydim = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "AnaAd").ToString();
                AnaKategoriLookUp.EditValue = AnaKategoriLookUp.Properties.GetKeyValueByDisplayText(Aydim);
                Edit = true;
                SilBtn.Enabled = true;
            }
        }
    }
}