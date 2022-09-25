using System;
using System.Linq;
using DevExpress.XtraEditors;

namespace Hizmet_MusMemnuniyet.Kullanıcılar
{
    public partial class frmKullaniciListesi : XtraForm
    {
        public frmKullaniciListesi()
        {
            InitializeComponent();
        }
        HizmetCRMEntities h = new HizmetCRMEntities();
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmAnamenu.CorbaID = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "KullaniciID").ToString());
            Close();
        }
        private void frmKullaniciListesi_Load(object sender, EventArgs e)
        {
            var Liste = h.HizmetCRM_Kullanicilar.Where(a => a.IsActive == true).OrderBy(o => o.AdSoyad).Select(s => new
            {
                s.KullaniciID, s.AdSoyad, s.KullaniciAdi,
                s.Sifre,
                Yetki = s.AnaKullanici == true ? "Yönetici" : "Giriş",
                Durum = s.IsActive == true ? "Aktif" : "Pasif"
            }).ToList();
            gridControl1.DataSource = Liste.ToList();
        }
    }
}