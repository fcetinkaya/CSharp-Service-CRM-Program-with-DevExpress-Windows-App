using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using Hizmet_MusMemnuniyet.Tools;
using NLog;

namespace Hizmet_MusMemnuniyet.Personel
{
    public partial class frmPersonelKayit : XtraForm
    {
        public frmPersonelKayit()
        {
            InitializeComponent();
        }
        bool Edit;
        int PerID;
        private Logger Lg = LogManager.GetCurrentClassLogger();
        HizmetCRMEntities H = new HizmetCRMEntities();
        private void frmPersonelKayit_Load(object sender, EventArgs e)
        {
            if (frmAnamenu.CorbaID > 0)
            {
                PerID = frmAnamenu.CorbaID;
                Subeler(PerID);
                GelBilgiler(PerID);
            }
            else
            {
                Subeler(0);
            }
            PersonelListesi();
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
                }).Where(w => w.IsActive == true);
            gridControl1.DataSource = PerList.ToList();
        }
        void Subeler(int Value)
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
            if (Value != 0)
            {
                SubeLookUp.EditValue = Value;
            }
        }
        void GelBilgiler(int Aydimci)
        {
            var Gel = H.HizmetCRM_Personel.Where(g => g.PersonID == Aydimci).Select(sS =>
                new
                {
                    sS.PersonelAdi,
                    sS.SubeID
                });
            foreach (var Geldi in Gel)
            {
                AdSoyadBox.Text = Geldi.PersonelAdi;
                SubeLookUp.EditValue = Geldi.SubeID;
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
                    HizmetCRM_Personel P = H.HizmetCRM_Personel.FirstOrDefault(p => p.PersonID == PerID);
                    P.IsActive = false;
                    H.SaveChanges();
                    cls_Log.LogKayit(AdSoyadBox.Text + " Personel Silindi.", "Personel Kayıt");
                    cls_MesajBox.SilmeMesaji("Personel silindi.");
                    Close();
                }
            }
            catch (Exception ex)
            {
                string M = string.Format("{0} Personel Silme İşlemi", PerID);
                Lg.Info(M);
                Lg.Error(ex);
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(AdSoyadBox.Text))
                {
                    dxErrorProvider1.SetError(AdSoyadBox, "Ad Soyad Yazınız", ErrorType.Information);
                }
                else
                {
                    if (string.IsNullOrEmpty(SubeLookUp.Text))
                    {
                        dxErrorProvider1.ClearErrors();
                        dxErrorProvider2.ClearErrors();
                        dxErrorProvider2.SetError(SubeLookUp, "Şube Seçiniz.", ErrorType.Information);
                    }
                    else
                    {
                        if (Edit)
                        {
                            HizmetCRM_Personel pGun = H.HizmetCRM_Personel.FirstOrDefault(w => w.PersonID == PerID);
                            pGun.PersonelAdi = AdSoyadBox.Text;
                            pGun.SubeID = (int)SubeLookUp.EditValue;
                            H.SaveChanges();
                            cls_Log.LogKayit(AdSoyadBox.Text + " Personel Güncellendi.", "Personel Kayıt");
                            cls_MesajBox.GuncelleMesaji("Personel Bilgileri Güncellendi");
                            Close();
                        }
                        else
                        {
                            HizmetCRM_Personel Pe = new HizmetCRM_Personel();
                            Pe.PersonelAdi = AdSoyadBox.Text;
                            Pe.IsActive = true;
                            Pe.SubeID = (int)SubeLookUp.EditValue;
                            H.HizmetCRM_Personel.Add(Pe);
                            H.SaveChanges();
                            cls_Log.LogKayit(AdSoyadBox.Text + " Personel Eklendi.", "Personel Kayıt");
                            AdSoyadBox.Text = "";
                            SubeLookUp.EditValue = null;
                            SubeLookUp.Text = "";
                            cls_MesajBox.KayitMesaji("Personel Kayıt Edildi.");
                            PersonelListesi();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string M = string.Format("{0} Personel Ekleme İşlemi", AdSoyadBox.Text);
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
                PerID = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "PersonelID");
                AdSoyadBox.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "AdSoyad").ToString();
                string Aydim = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SubeAdi").ToString();
                SubeLookUp.EditValue = SubeLookUp.Properties.GetKeyValueByDisplayText(Aydim);
                Edit = true;
                SilBtn.Enabled = true;
            }
        }
    }
}