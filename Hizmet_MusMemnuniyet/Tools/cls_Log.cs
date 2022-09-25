using System;

namespace Hizmet_MusMemnuniyet.Tools
{
    class cls_Log : IDisposable
    {
        public static void LogKayit(string _Aciklama, string _Modul)
        {
            HizmetCRMEntities h = new HizmetCRMEntities();
            HizmetCRM_Loglar L = new HizmetCRM_Loglar();
            L.Aciklama = _Aciklama;
            L.Modul = _Modul;
            L.KullaniciID = frmAnamenu.KullaniciID;
            L.Tarih = DateTime.Now;
            h.HizmetCRM_Loglar.Add(L);
            h.SaveChanges();
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
