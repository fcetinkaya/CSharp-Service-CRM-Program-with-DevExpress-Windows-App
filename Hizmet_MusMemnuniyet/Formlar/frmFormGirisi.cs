using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid.Views.Grid;
using Hizmet_MusMemnuniyet.Kategori;
using Hizmet_MusMemnuniyet.Musteriler;
using Hizmet_MusMemnuniyet.Tools;
using NLog;
using System.Data;

namespace Hizmet_MusMemnuniyet.Formlar
{
    public partial class frmFormGirisi : XtraForm
    {
        public frmFormGirisi()
        {
            InitializeComponent();
        }
        bool Edit; /*,OlumluSecim, OlumsuzSecim*/
        int MusterimID, _AnketID;
        int _intOlumluID, _intOlumsuzID;
        private Logger Lg = LogManager.GetCurrentClassLogger();
        HizmetCRMEntities H = new HizmetCRMEntities();
        cls_Converter c = new cls_Converter();
        DataTable dtOlumlu = new DataTable();
        DataTable dtOlumsuz = new DataTable();
        public void Personel_Subeler_Hizmetler()
        {
            var Per = from per in H.HizmetCRM_Personel
                      where per.IsActive == true
                      select new
                      {
                          per.PersonID,
                          per.PersonelAdi
                      };

            personelLookUp.Properties.DataSource = Per.ToList();
            personelLookUp.Properties.DisplayMember = "PersonelAdi";
            personelLookUp.Properties.ValueMember = "PersonID";

            // Lambda Expression ile...

            var Subeler = H.HizmetCRM_Subeler.Where(w => w.IsActive == true).Select(ws => new
            {
                ws.SubeID,
                ws.SubeAdi
            });

            SubelerLookUp.Properties.DataSource = Subeler.ToList();
            SubelerLookUp.Properties.DisplayMember = "SubeAdi";
            SubelerLookUp.Properties.ValueMember = "SubeID";

            //
            var Hizmetler = H.HizmetCRM_Hizmetler.Where(w => w.IsActive == true).Select(ws => new
            {
                ws.HizmetID,
                ws.HizmetAdi
            });

            HizmetlookUp.Properties.DataSource = Hizmetler.ToList();
            HizmetlookUp.Properties.DisplayMember = "HizmetAdi";
            HizmetlookUp.Properties.ValueMember = "HizmetID";
        }
        private void frmFormGirisi_Load(object sender, EventArgs e)
        {
            if (frmAnamenu.CorbaID > 0)
            {
                GelBilgiler(frmAnamenu.CorbaID);
            }
            Personel_Subeler_Hizmetler();
            olumluDtOlustur();
            olumsuzDtOlustur();

        }
        private void FormListesiBtn_Click(object sender, EventArgs e)
        {
            frmFormListesi fList = new frmFormListesi();
            fList.ShowDialog();
            GelBilgiler(frmAnamenu.CorbaID);
            frmAnamenu.CorbaID = -1;
        }
        public void GelBilgiler(int _formID)
        {
            var FormBilgi = (from anket in H.HizmetCRM_YeniAnket
                             join sub in H.HizmetCRM_Subeler on anket.SubeID equals sub.SubeID
                             join per in H.HizmetCRM_Personel on anket.PersonID equals per.PersonID
                             join mus in H.HizmetCRM_Musteriler on anket.MusteriID equals mus.MusteriID
                             where anket.AnketID == _formID
                             select new
                             {
                                 anket.Numara,
                                 anket.MusteriID,
                                 anket.HizmetID,
                                 mus.AdSoyad,
                                 mus.CepTlf,
                                 mus.SabitTlf,
                                 per.PersonID,
                                 sub.SubeID,
                                 anket.AnketTarih,
                                 anket.UlasimSecenegi,
                                 anket.AramaTarih,
                                 anket.GorusmeSonucu,
                                 anket.AnketYorumu,
                                 anket.AnketRaporu


                             }).FirstOrDefault();



            txtFormNo.Text = FormBilgi.Numara;
            MusterimID = (int)FormBilgi.MusteriID;
            cariAdiBtn.Text = FormBilgi.AdSoyad;
            HizmetlookUp.EditValue = FormBilgi.HizmetID;
            txtcepTlf.Text = FormBilgi.CepTlf;
            txtTlf.Text = FormBilgi.SabitTlf;
            personelLookUp.EditValue = FormBilgi.PersonID;
            SubelerLookUp.EditValue = FormBilgi.SubeID;
            txtTarih.EditValue = FormBilgi.AnketTarih;
            txtAramaTarihi.EditValue = FormBilgi.AramaTarih;
            comboUlasimSecenegi.Text = FormBilgi.UlasimSecenegi;
            comboGorusmeSonucu.Text = FormBilgi.GorusmeSonucu;
            txtmusteriyorumu.Text = FormBilgi.AnketYorumu;
            txtAnketRaporu.Text = FormBilgi.AnketRaporu;
            olumluKategori(_formID);
            olumsuzKategori(_formID);
            _AnketID = _formID;
            Edit = true;
            SilBtn.Enabled = true;
        }
        private void cariKodBtn_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            try
            {
                frmMusteriListesi M = new frmMusteriListesi();
                M.ShowDialog();
                if (frmAnamenu.CorbaID > 0)
                {
                    MusterimID = frmAnamenu.CorbaID;
                    var PerCari = H.HizmetCRM_Musteriler.Where(w => w.MusteriID == frmAnamenu.CorbaID).Select(s => new
                    {
                        s.AdSoyad,
                        s.CepTlf,
                        s.SabitTlf
                    });
                    foreach (var Geldi in PerCari)
                    {
                        cariAdiBtn.Text = Geldi.AdSoyad;
                        txtcepTlf.Text = Geldi.CepTlf;
                        txtTlf.Text = Geldi.SabitTlf;
                        frmAnamenu.CorbaID = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                string M = string.Format("{0} Form İşlemi, Cari Seçme İşlemi", frmAnamenu.CorbaID);
                Lg.Info(M);
                Lg.Error(ex);
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtFormNo.Text))
                {
                    dx1.SetError(txtFormNo, "Form Numarasını Yazınız", ErrorType.Information);
                }
                else
                {
                    if (string.IsNullOrEmpty(cariAdiBtn.Text))
                    {
                        dx2.SetError(cariAdiBtn, "Müşteri Seçiniz.", ErrorType.Information);
                    }
                    else
                    {
                        if (personelLookUp.EditValue == null)
                        {
                            dx3.SetError(personelLookUp, "Personel Seçiniz.", ErrorType.Information);
                        }
                        else
                        {
                            if (SubelerLookUp.EditValue == null)
                            {
                                dx4.SetError(SubelerLookUp, "Şube Seçiniz.", ErrorType.Information);
                            }
                            else
                            {
                                if (txtTarih.EditValue == null)
                                {
                                    dx5.SetError(txtTarih, "Tarih Seçiniz.", ErrorType.Information);
                                }
                                else
                                {
                                    if (Edit)
                                    {
                                        if (cls_MesajBox.Sor("Güncellemek istediğinize emisin misiniz ?"))
                                        {
                                            HizmetCRM_YeniAnket ad =
                                                H.HizmetCRM_YeniAnket.FirstOrDefault(d => d.AnketID == _AnketID);
                                            ad.AnketTarih = Convert.ToDateTime(txtTarih.Text);
                                            ad.AramaTarih = Convert.ToDateTime(txtAramaTarihi.Text);
                                            ad.Numara = txtFormNo.Text;
                                            ad.AnketYorumu = txtmusteriyorumu.Text;
                                            ad.AnketRaporu = txtAnketRaporu.Text;
                                            ad.GorusmeSonucu = comboGorusmeSonucu.Text;
                                            ad.UlasimSecenegi = comboUlasimSecenegi.Text;
                                            ad.SubeID = (int)SubelerLookUp.EditValue;
                                            ad.PersonID = (int)personelLookUp.EditValue;
                                            ad.MusteriID = MusterimID;
                                            ad.HizmetID = (int)HizmetlookUp.EditValue;
                                            H.SaveChanges();
                                            KategorSecimKayit(OlumluGridView, "Olumlu", "Update", _AnketID);
                                            KategorSecimKayit(OlumsuzgridView, "Olumsuz", "Update", _AnketID);

                                            cls_Log.LogKayit(txtFormNo.Text + " Form Güncellendi.", "Form Kayıt");
                                            cls_MesajBox.KayitMesaji("Form Güncellendi.");
                                            Close();
                                        }
                                    }
                                    else
                                    {
                                        if (cls_MesajBox.Sor("Kayıt etmek istediğinize emisin misiniz ?"))
                                        {
                                            HizmetCRM_YeniAnket A = new HizmetCRM_YeniAnket();
                                            A.AnketTarih = Convert.ToDateTime(txtTarih.Text);
                                            A.AramaTarih = Convert.ToDateTime(txtAramaTarihi.Text);
                                            A.Numara = txtFormNo.Text;
                                            A.AnketYorumu = txtmusteriyorumu.Text;
                                            A.AnketRaporu = txtAnketRaporu.Text;
                                            A.GorusmeSonucu = comboGorusmeSonucu.Text;
                                            A.UlasimSecenegi = comboUlasimSecenegi.Text;
                                            A.SubeID = (int)SubelerLookUp.EditValue;
                                            A.PersonID = (int)personelLookUp.EditValue;
                                            A.MusteriID = MusterimID;
                                            A.HizmetID = (int)HizmetlookUp.EditValue;
                                            A.IsActive = true;
                                            H.HizmetCRM_YeniAnket.Add(A);
                                            H.SaveChanges();
                                            KategorSecimKayit(OlumluGridView, "Olumlu", "Insert", A.AnketID);
                                            KategorSecimKayit(OlumsuzgridView, "Olumsuz", "Insert", A.AnketID);
                                            cls_Log.LogKayit(txtFormNo.Text + " Form Eklendi.", "Form Kayıt");
                                            cls_MesajBox.KayitMesaji("Form Kayıt Edildi.");
                                            Close();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string M = string.Format("{0} Form Girişi", frmAnamenu.CorbaID);
                Lg.Info(M);
                Lg.Error(ex);
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void SilBtn_Click(object sender, EventArgs e)
        {
            try
            {
                HizmetCRM_YeniAnket Ya = H.HizmetCRM_YeniAnket.FirstOrDefault(s => s.AnketID == _AnketID);
                Ya.IsActive = false;
                H.SaveChanges();
                cls_Log.LogKayit(txtFormNo.Text + " Form Güncellendi.", "Form Kayıt");
                cls_MesajBox.GuncelleMesaji("Form Kayıtlardan Kaldırıldı.");
                Close();
            }
            catch (Exception ex)
            {
                string M = string.Format("{0} Silme İşlemi, Form Giriş İşlemi", _AnketID);
                Lg.Info(M);
                Lg.Error(ex);
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void KapatBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frmFormGirisi_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAnamenu.CorbaID = -1;
        }
        public void KategorSecimKayit(GridView IslemGrid, string Secenek, string Islem, int _anketID)
        {
            if (Secenek == "Olumlu")
            {
                if (Islem == "Insert")
                {
                    List<HizmetCRM_ServisOlumlu> OlumList = new List<HizmetCRM_ServisOlumlu>();
                    for (int i = 0; i < IslemGrid.RowCount; i++)
                    {
                        HizmetCRM_ServisOlumlu Holum = new HizmetCRM_ServisOlumlu();
                        Holum.AnketID = _anketID;
                        Holum.KategoriID = Convert.ToInt32(IslemGrid.GetRowCellValue(i, "KategoriID"));
                        OlumList.Add(Holum);
                    }
                    H.HizmetCRM_ServisOlumlu.AddRange(OlumList);
                    H.SaveChanges();
                }
                else
                {
                    // Önce silme işlemi yapıyoruz...
                    var Toplusil = (from olum in H.HizmetCRM_ServisOlumlu
                                    where olum.AnketID == _anketID
                                    select olum).ToList();
                    H.HizmetCRM_ServisOlumlu.RemoveRange(Toplusil);
                    H.SaveChanges();

                    // Seçilen kategorileri yeniden kayıt ediyoruz..
                    List<HizmetCRM_ServisOlumlu> OlumList = new List<HizmetCRM_ServisOlumlu>();
                    for (int i = 0; i < IslemGrid.RowCount; i++)
                    {
                        HizmetCRM_ServisOlumlu Holum = new HizmetCRM_ServisOlumlu();
                        Holum.AnketID = _anketID;
                        Holum.KategoriID = Convert.ToInt32(IslemGrid.GetRowCellValue(i, "KategoriID"));
                        OlumList.Add(Holum);
                    }
                    H.HizmetCRM_ServisOlumlu.AddRange(OlumList);
                    H.SaveChanges();
                }
            }
            else
            {
                if (Islem == "Insert")
                {
                    List<HizmetCRM_ServisOlumsuz> OlumsuzList = new List<HizmetCRM_ServisOlumsuz>();
                    for (int i = 0; i < IslemGrid.RowCount; i++)
                    {
                        HizmetCRM_ServisOlumsuz Holumsuz = new HizmetCRM_ServisOlumsuz();
                        Holumsuz.AnketID = _anketID;
                        Holumsuz.KategoriID = Convert.ToInt32(IslemGrid.GetRowCellValue(i, "KategoriID"));
                        OlumsuzList.Add(Holumsuz);
                    }
                    H.HizmetCRM_ServisOlumsuz.AddRange(OlumsuzList);
                    H.SaveChanges();
                }
                else
                {
                    // Önce silme işlemi yapıyoruz...
                    var Toplusil = (from olum in H.HizmetCRM_ServisOlumsuz
                                    where olum.AnketID == _anketID
                                    select olum).ToList();
                    H.HizmetCRM_ServisOlumsuz.RemoveRange(Toplusil);
                    H.SaveChanges();

                    // Sonra kayıt işlemi..
                    List<HizmetCRM_ServisOlumsuz> OlumsuzList = new List<HizmetCRM_ServisOlumsuz>();
                    for (int i = 0; i < IslemGrid.RowCount; i++)
                    {
                        HizmetCRM_ServisOlumsuz Holumsuz = new HizmetCRM_ServisOlumsuz();
                        Holumsuz.AnketID = _anketID;
                        Holumsuz.KategoriID = Convert.ToInt32(IslemGrid.GetRowCellValue(i, "KategoriID"));
                        OlumsuzList.Add(Holumsuz);
                    }
                    H.HizmetCRM_ServisOlumsuz.AddRange(OlumsuzList);
                    H.SaveChanges();
                }
            }
        }

        #region OlumluGridView İşlemleri...
        public void olumluDtOlustur()
        {
            dtOlumlu.Columns.Add("KategoriID", typeof(int));
            dtOlumlu.Columns.Add("Ad", typeof(string));
            dtOlumlu.Columns.Add("AnaAd", typeof(string));
            dtOlumlu.Columns.Add("IsActive", typeof(Boolean));
            // Doldur

            if (Edit)
            {
                dtOlumlu = null;
                var _vrList = H.HizmetCRM_ServisOlumlu.Where(w => w.AnketID == _AnketID).ToList();
                if (_vrList.FirstOrDefault() != null)
                {
                    dtOlumlu = c.ToDataTable(_vrList);
                }
            }
        }
        public void olumluKategori(int _formID)
        {

            var olumList = H.HizmetCRM_YeniAnket
             .Join(H.HizmetCRM_ServisOlumlu, anket => anket.AnketID, ara => ara.AnketID, (anket, ara) => new { Anket = anket, Ara = ara })
             .Join(H.HizmetCRM_Kategori, ara => ara.Ara.KategoriID, kat => kat.KategoriID, (ara, kat) => new { Ara = ara, Kat = kat })
             .Join(H.HizmetCRM_AnaKategori, kat => kat.Kat.AnaKategoriID, anakat => anakat.AnaKategoriID, (kat, anakat) => new
             {
                 anakat.AnaAd,
                 kat.Kat.Ad,
                 kat.Kat.KategoriID,
                 kat.Kat.IsActive,
                 kat.Ara.Ara.AnketID
             }).Where(w => w.IsActive == true && w.AnketID == _formID);

            OlumlugridControl.DataSource = olumList.ToList();
        }
        private void OlumluGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (OlumluGridView.RowCount > 0)
            {
                bool Bitti_Ade = Convert.ToBoolean(OlumluGridView.GetRowCellValue(OlumluGridView.FocusedRowHandle, "IsActive"));
                if (Bitti_Ade)
                {
                    e.Cancel = true;
                }
            }
        }
        private void OlumluGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            OlumluGridView.SetRowCellValue(OlumluGridView.FocusedRowHandle, "IsActive", false);
        }
        private void OlumluKategoriSecBtn_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            try
            {
                frmKategoriListesi frm = new frmKategoriListesi();
                frm.ShowDialog();
                if (frmAnamenu.CorbaID > 0)
                {
                    var olmlu = H.HizmetCRM_Kategori.FirstOrDefault(w => w.KategoriID == frmAnamenu.CorbaID);
                    olumluKatEditBtn.EditValue = olmlu.Ad;
                    _intOlumluID = olmlu.KategoriID;
                    frmAnamenu.CorbaID = -1;
                }
            }
            catch (Exception ex)
            {
                string M = string.Format("{0} Form Girişi, Olumlu Kategori Seçimi", frmAnamenu.CorbaID);
                Lg.Info(M);
                Lg.Error(ex);
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void olumlukatEkleBtn_Click(object sender, EventArgs e)
        {
            var PerList = H.HizmetCRM_Kategori.Join(H.HizmetCRM_AnaKategori,
                    pj => pj.AnaKategoriID,
                    sj => sj.AnaKategoriID,
                    (alt, ana) => new
                    {
                        alt.KategoriID,
                        alt.Ad,
                        alt.IsActive,
                        ana.AnaAd
                    }).FirstOrDefault(w => w.IsActive == true && w.KategoriID == _intOlumluID);

            dtOlumlu.Rows.Add(PerList.KategoriID, PerList.Ad, PerList.AnaAd, true);

            OlumlugridControl.DataSource = dtOlumlu;
            olumluKatEditBtn.EditValue = null;
        }
        private void OlumluGridView_RowCountChanged(object sender, EventArgs e)
        {
            OlumluGridView.SetRowCellValue(OlumluGridView.FocusedRowHandle, "IsActive", true);
        }

        #endregion

        #region OlumsuzGridView İşlemleri...
        public void olumsuzDtOlustur()
        {
            dtOlumsuz.Columns.Add("KategoriID", typeof(int));
            dtOlumsuz.Columns.Add("Ad", typeof(string));
            dtOlumsuz.Columns.Add("AnaAd", typeof(string));
            dtOlumsuz.Columns.Add("IsActive", typeof(Boolean));
            // Doldur

            if (Edit)
            {
                dtOlumsuz = null;
                var _vrList = H.HizmetCRM_ServisOlumsuz.Where(w => w.AnketID == _AnketID).ToList();
                if (_vrList.FirstOrDefault() != null)
                {
                    dtOlumsuz = c.ToDataTable(_vrList);
                }
            }
        }
        public void olumsuzKategori(int _formID)
        {

            var olumsuzList = H.HizmetCRM_YeniAnket
             .Join(H.HizmetCRM_ServisOlumsuz, anket => anket.AnketID, ara => ara.AnketID, (anket, ara) => new { Anket = anket, Ara = ara })
             .Join(H.HizmetCRM_Kategori, ara => ara.Ara.KategoriID, kat => kat.KategoriID, (ara, kat) => new { Ara = ara, Kat = kat })
             .Join(H.HizmetCRM_AnaKategori, kat => kat.Kat.AnaKategoriID, anakat => anakat.AnaKategoriID, (kat, anakat) => new
             {
                 anakat.AnaAd,
                 kat.Kat.Ad,
                 kat.Kat.KategoriID,
                 kat.Kat.IsActive,
                 kat.Ara.Ara.AnketID
             }).Where(w => w.IsActive == true && w.AnketID == _formID);
            OlumsuzgridControl.DataSource = olumsuzList.ToList();
        }
        private void OlumsuzgridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (OlumsuzgridView.RowCount > 0)
            {
                bool Bitti_Ade = Convert.ToBoolean(OlumsuzgridView.GetRowCellValue(OlumsuzgridView.FocusedRowHandle, "IsActive"));
                if (Bitti_Ade)
                {
                    e.Cancel = true;
                }
            }
        }
        private void OlumsuzgridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            OlumsuzgridView.SetRowCellValue(OlumsuzgridView.FocusedRowHandle, "IsActive", false);
        }
        private void OlumsuzKategoriSecBtn_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            try
            {
                frmKategoriListesi frm = new frmKategoriListesi();
                frm.ShowDialog();
                if (frmAnamenu.CorbaID > 0)
                {
                    var olmsuz = H.HizmetCRM_Kategori.FirstOrDefault(w => w.KategoriID == frmAnamenu.CorbaID);
                    olumsuzKatEditBtn.EditValue = olmsuz.Ad;
                    _intOlumsuzID = olmsuz.KategoriID;
                    frmAnamenu.CorbaID = -1;
                }
            }
            catch (Exception ex)
            {
                string M = string.Format("{0} Form Girişi, Olumsuz Kategori Seçimi", frmAnamenu.CorbaID);
                Lg.Info(M);
                Lg.Error(ex);
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void olumsuzkatEkleBtn_Click(object sender, EventArgs e)
        {
            var PerList = H.HizmetCRM_Kategori.Join(H.HizmetCRM_AnaKategori,
                               pj => pj.AnaKategoriID,
                               sj => sj.AnaKategoriID,
                               (alt, ana) => new
                               {
                                   alt.KategoriID,
                                   alt.Ad,
                                   alt.IsActive,
                                   ana.AnaAd
                               }).FirstOrDefault(w => w.IsActive == true && w.KategoriID == _intOlumsuzID);

            //
            dtOlumsuz.Rows.Add(PerList.KategoriID, PerList.Ad, PerList.AnaAd, true);

            OlumsuzgridControl.DataSource = dtOlumsuz;
            olumsuzKatEditBtn.EditValue = null;

        }
        private void OlumsuzgridView_RowCountChanged(object sender, EventArgs e)
        {
            OlumsuzgridView.SetRowCellValue(OlumsuzgridView.FocusedRowHandle, "IsActive", true);
        }
        #endregion
    }
}