using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using Hizmet_MusMemnuniyet.Tools;
using NLog;

namespace Hizmet_MusMemnuniyet.Musteriler
{
    public partial class frmMusteriKayit : XtraForm
    {
        public frmMusteriKayit()
        {
            InitializeComponent();
        }
        bool Edit;
        int MusteriID;
        private Logger Lg = LogManager.GetCurrentClassLogger();
        HizmetCRMEntities H = new HizmetCRMEntities();
        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(MusteriAdiBox.Text))
                {
                    dxErrorProvider1.SetError(MusteriAdiBox, "Ad Soyad Yazınız", ErrorType.Information);
                }
                else
                {
                    bool Dogum = false;
                    short DogumAy = 0;
                    short DogumGun = 0;
                    bool Evlilik = false;
                    short EvlilikAy = 0;
                    short EvlilikGun = 0;
                    if (!string.IsNullOrEmpty(DogumTarihiDtime.Text))
                    {
                        DogumAy = (short)DogumTarihiDtime.DateTime.Month;
                        DogumGun = (short)DogumTarihiDtime.DateTime.Day;
                        Dogum = true;
                    }
                    if (!string.IsNullOrEmpty(EvlilikTarihiDtime.Text))
                    {
                        EvlilikAy = (short)EvlilikTarihiDtime.DateTime.Month;
                        EvlilikGun = (short)EvlilikTarihiDtime.DateTime.Day;
                        Evlilik = true;
                    }
                    if (Edit)
                    {
                        HizmetCRM_Musteriler M = H.HizmetCRM_Musteriler.FirstOrDefault(sw => sw.MusteriID == MusteriID);
                        M.AdSoyad = MusteriAdiBox.Text;
                        M.Meslek = MeslekBox.Text;
                        M.CepTlf = CepTlfBox.Text;
                        M.SabitTlf = TelefonBox.Text;
                        M.Adres = AdresBox.Text;
                        M.Eposta = EPostabox.Text;
                        M.DogumTarihi = DogumTarihiDtime.Text;
                        M.Dogum = Dogum;
                        M.DogumAy = DogumAy;
                        M.DogumGun = DogumGun;
                        M.EvlilikTarihi = EvlilikTarihiDtime.Text;
                        M.Evlilik = Evlilik;
                        M.EvlilikAy = EvlilikAy;
                        M.EvlilikGun = EvlilikGun;
                        H.SaveChanges();
                        cls_MesajBox.SilmeMesaji("Müşteri Kaydı Güncellenmiştir.");
                        cls_Log.LogKayit(MusteriAdiBox.Text + " Müşteri Güncellendi.", "Müşteri Kayıt");
                    }
                    else
                    {
                        HizmetCRM_Musteriler MEkle = new HizmetCRM_Musteriler();
                        MEkle.AdSoyad = MusteriAdiBox.Text;
                        MEkle.Meslek = MeslekBox.Text;
                        MEkle.CepTlf = CepTlfBox.Text;
                        MEkle.SabitTlf = TelefonBox.Text;
                        MEkle.Adres = AdresBox.Text;
                        MEkle.Eposta = EPostabox.Text;
                        MEkle.DogumTarihi = DogumTarihiDtime.Text;
                        MEkle.Dogum = Dogum;
                        MEkle.DogumAy = DogumAy;
                        MEkle.DogumGun = DogumGun;
                        MEkle.EvlilikTarihi = EvlilikTarihiDtime.Text;
                        MEkle.Evlilik = Evlilik;
                        MEkle.EvlilikAy = EvlilikAy;
                        MEkle.EvlilikGun = EvlilikGun;
                        MEkle.IsActive = true;
                        H.HizmetCRM_Musteriler.Add(MEkle);
                        H.SaveChanges();
                        cls_MesajBox.SilmeMesaji("Müşteri Kayıt Edilmiştir.");
                        cls_Log.LogKayit(MusteriAdiBox.Text + " Müşteri Eklendi.", "Müşteri Kayıt");
                    }
                    Close();
                }
            }
            catch (Exception ex)
            {
                string M = string.Format("{0} Müşteri Kayıt İşlemi", MusteriAdiBox.Text);
                Lg.Info(M);
                Lg.Error(ex);
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void SilBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (cls_MesajBox.Sor("Silmek istediğinize emin misiniz ?"))
                {
                    HizmetCRM_Musteriler M = H.HizmetCRM_Musteriler.FirstOrDefault(sw => sw.MusteriID == MusteriID);
                    M.IsActive = false;
                    H.SaveChanges();
                    cls_MesajBox.SilmeMesaji("Müşteri Kaydı Silinmiştir.");
                    cls_Log.LogKayit(MusteriAdiBox.Text + " Müşteri Silindi.", "Müşteri Kayıt");
                    Close();
                }
            }
            catch (Exception ex)
            {
                string M = string.Format("{0} Müşteri Silme İşlemi", MusteriID);
                Lg.Info(M);
                Lg.Error(ex);
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void KapatBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        void CelasunBilgiler()
        {
            var Mus = H.HizmetCRM_Musteriler.Where(w => w.MusteriID == MusteriID);
            foreach (var V in Mus)
            {
                MusteriAdiBox.Text = V.AdSoyad;
                MeslekBox.Text = V.Meslek;
                CepTlfBox.Text = V.CepTlf;
                TelefonBox.Text = V.SabitTlf;
                AdresBox.Text = V.Adres;
                EPostabox.Text = V.Eposta;
                DogumTarihiDtime.Text = V.DogumTarihi;
                EvlilikTarihiDtime.Text = V.EvlilikTarihi;
                SilBtn.Enabled = true;
                Edit = true;
            }
        }
        private void frmMusteriKayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAnamenu.CorbaID = -1;
        }
        private void frmMusteriKayit_Load(object sender, EventArgs e)
        {
            if (frmAnamenu.CorbaID > 0)
            {
                MusteriID = frmAnamenu.CorbaID;
                CelasunBilgiler();
            }
        }
    }
}