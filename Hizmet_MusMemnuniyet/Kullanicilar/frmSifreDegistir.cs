using System;
using System.Linq;
using DevExpress.XtraEditors;
using Hizmet_MusMemnuniyet.Tools;
using NLog;

namespace Hizmet_MusMemnuniyet.Kullanıcılar
{
    public partial class frmSifreDegistir : XtraForm
    {
        public frmSifreDegistir()
        {
            InitializeComponent();
        }
        private Logger Lg = LogManager.GetCurrentClassLogger();
        HizmetCRMEntities h = new HizmetCRMEntities();
        private void KapatBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(EskiParaloTxt.Text))
                {
                    dxErrorProvider1.SetError(EskiParaloTxt, "Boş Geçilmez.");
                }
                else
                {
                    if (string.IsNullOrEmpty(YeniParolaTxt.Text))
                    {
                        dxErrorProvider2.SetError(YeniParolaTxt, "Boş Geçilmez.");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(YeniTekrarParola.Text))
                        {
                            dxErrorProvider3.SetError(YeniTekrarParola, "Boş Geçilmez.");
                        }
                        else
                        {
                            if (YeniParolaTxt.Text == YeniTekrarParola.Text)
                            {
                                HizmetCRM_Kullanicilar GelDogrulama = h.HizmetCRM_Kullanicilar.FirstOrDefault(z => z.Sifre == EskiParaloTxt.Text);
                                if (GelDogrulama.KullaniciID > 0)
                                {
                                    GelDogrulama.Sifre = YeniTekrarParola.Text;
                                    h.SaveChanges();
                                    cls_MesajBox.KayitMesaji("Şifre başara ile güncellendi.");
                                    Close();
                                }
                                else
                                {
                                    cls_MesajBox.UyariMesaji("Eski parola uyuşmuyor.");
                                }
                            }
                            else
                            {
                                cls_MesajBox.UyariMesaji("Yeni parola uyuşmuyor.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string M = string.Format("{0} Şifre Değiştirme", frmAnamenu.KullaniciID);
                Lg.Info(M);
                Lg.Error(ex);
                cls_MesajBox.HataMesaji(ex);
            }
        }
    }
}