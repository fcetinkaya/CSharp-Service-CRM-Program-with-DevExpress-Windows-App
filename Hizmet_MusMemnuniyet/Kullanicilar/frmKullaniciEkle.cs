using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Hizmet_MusMemnuniyet.Tools;
using NLog;

namespace Hizmet_MusMemnuniyet.Kullanıcılar
{
    public partial class frmKullaniciEkle : XtraForm
    {
        public frmKullaniciEkle()
        {
            InitializeComponent();
        }
        bool Edit;
        HizmetCRMEntities h = new HizmetCRMEntities();
        private Logger Lg = LogManager.GetCurrentClassLogger();

        private void frmKullaniciEkle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
        private void KapatBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void YeniBtn_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        public void Temizle()
        {
            adSoyadbox.Text = string.Empty;
            KullaniciAdiBox.Text = string.Empty;
            Sifrebox.Text = string.Empty;
            comboYetki.Text = "Seçiniz";
            comboDurum.Text = "Seçiniz";
            frmAnamenu.CorbaID = -1;
            Edit = false;
        }
        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(adSoyadbox.Text) && !string.IsNullOrEmpty(KullaniciAdiBox.Text) && !string.IsNullOrEmpty(Sifrebox.Text) && comboYetki.SelectedItem != "Seçiniz")
                {
                    bool Yonetici = false;
                    bool Giris = false;
                    if (comboYetki.SelectedItem == "Yönetici")
                    {
                        Yonetici = true;
                    }
                    if (comboDurum.SelectedItem == "Aktif")
                    {
                        Giris = true;
                    }
                    if (Edit == false)
                    {
                        if (cls_MesajBox.Sor("Kullanıcı Eklemek İstediğinize Emin misiniz ?"))
                        {
                            HizmetCRM_Kullanicilar K = new HizmetCRM_Kullanicilar();
                            K.AdSoyad = adSoyadbox.Text;
                            K.KullaniciAdi = KullaniciAdiBox.Text;
                            K.Sifre = Sifrebox.Text;
                            K.AnaKullanici = Yonetici;
                            K.IsActive = true;
                            h.HizmetCRM_Kullanicilar.Add(K);
                            h.SaveChanges();
                            Temizle();
                            cls_Log.LogKayit(adSoyadbox.Text + " Kullanıcı Eklendi.", "Kullanıcı Kayıt");
                            cls_MesajBox.KayitMesaji("Kullanıcı eklendi.");
                            Close();
                        }
                    }
                    else
                    {
                        if (cls_MesajBox.Sor("Kullanıcı Güncellemek İstediğinize Emin misiniz ?"))
                        {
                            HizmetCRM_Kullanicilar K =
                                h.HizmetCRM_Kullanicilar.FirstOrDefault(w => w.KullaniciID == frmAnamenu.CorbaID);
                            K.AdSoyad = adSoyadbox.Text;
                            K.KullaniciAdi = KullaniciAdiBox.Text;
                            K.Sifre = Sifrebox.Text;
                            K.AnaKullanici = Yonetici;
                            K.IsActive = Giris;
                            h.SaveChanges();
                            Temizle();
                            cls_Log.LogKayit(adSoyadbox.Text + " Kullanıcı Güncellendi.", "Kullanıcı Kayıt");
                            cls_MesajBox.GuncelleMesaji("Kullanıcı güncellendi.");
                            Close();
                        }
                    }
                }
                else
                {
                    cls_MesajBox.UyariMesaji("Tüm alanları doldurunuz.");
                }
            }
            catch (Exception ex)
            {
                string M = string.Format("{0} Yeni Kullanıcı Ekleme", adSoyadbox.Text);
                Lg.Info(M);
                Lg.Error(ex);
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void ListeBtn_Click(object sender, EventArgs e)
        {
            frmKullaniciListesi KL = new frmKullaniciListesi();
            KL.ShowDialog();
            var GelKul = h.HizmetCRM_Kullanicilar.Where(s => s.KullaniciID == frmAnamenu.CorbaID);
            foreach (var kul in GelKul)
            {
                adSoyadbox.Text = kul.AdSoyad;
                KullaniciAdiBox.Text = kul.KullaniciAdi;
                Sifrebox.Text = kul.Sifre;
                if (kul.AnaKullanici == true)
                {
                    comboYetki.Text = "Yönetici";
                }
                else
                {
                    comboYetki.Text = "Giriş";
                }
                if (kul.IsActive == true)
                {
                    comboDurum.Text = "Aktif";
                }
                else
                {
                    comboDurum.Text = "Pasif";
                }
                Edit = true;
            }
        }
    }
}