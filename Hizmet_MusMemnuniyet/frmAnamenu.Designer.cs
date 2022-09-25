using System.ComponentModel;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTabbedMdi;

namespace Hizmet_MusMemnuniyet
{
    partial class frmAnamenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnamenu));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.kullaniciBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.TarihBtn = new DevExpress.XtraBars.BarButtonItem();
            this.Menu_YeniFormKayitBtn = new DevExpress.XtraBars.BarButtonItem();
            this.Menu_YeniKatKayitBtn = new DevExpress.XtraBars.BarButtonItem();
            this.Menu_YeniSubeKayitBtn = new DevExpress.XtraBars.BarButtonItem();
            this.Menu_YeniPerKayitBtn = new DevExpress.XtraBars.BarButtonItem();
            this.CikisBtn = new DevExpress.XtraBars.BarButtonItem();
            this.Hakkindabtn = new DevExpress.XtraBars.BarButtonItem();
            this.Form_YeniFormKayitBtn = new DevExpress.XtraBars.BarButtonItem();
            this.Form_FormListesiBtn = new DevExpress.XtraBars.BarButtonItem();
            this.Form_YeniKatKayitBtn = new DevExpress.XtraBars.BarButtonItem();
            this.Form_AltYeniKatKayitBtn = new DevExpress.XtraBars.BarButtonItem();
            this.Menu_KategoriListesiBtn = new DevExpress.XtraBars.BarButtonItem();
            this.Form_YeniSubeKayitBtn = new DevExpress.XtraBars.BarButtonItem();
            this.Sube_SubeListesiBtn = new DevExpress.XtraBars.BarButtonItem();
            this.Personel_YeniPerKayitBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barYeniKullaniciEkleBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barKullaniciListesiBtn = new DevExpress.XtraBars.BarButtonItem();
            this.Musteri_YeniMusteriKayitBtn = new DevExpress.XtraBars.BarButtonItem();
            this.Menu_MusteriListesiBtn = new DevExpress.XtraBars.BarButtonItem();
            this.Menu_YeniMusteriKayitBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barSifreDegistirBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barUzaktanBaglantiBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barWebSitesiBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barYeniHizmetBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barHizmetlistesiBtn = new DevExpress.XtraBars.BarButtonItem();
            this.Menu_barYeniHizmetBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barGuncellemeBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage7 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage6 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage8 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.MdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.theme = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationIcon = global::Hizmet_MusMemnuniyet.Properties.Resources.Muhasebe;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonItem1,
            this.kullaniciBtn,
            this.barEditItem1,
            this.TarihBtn,
            this.Menu_YeniFormKayitBtn,
            this.Menu_YeniKatKayitBtn,
            this.Menu_YeniSubeKayitBtn,
            this.Menu_YeniPerKayitBtn,
            this.CikisBtn,
            this.Hakkindabtn,
            this.Form_YeniFormKayitBtn,
            this.Form_FormListesiBtn,
            this.Form_YeniKatKayitBtn,
            this.Form_AltYeniKatKayitBtn,
            this.Menu_KategoriListesiBtn,
            this.Form_YeniSubeKayitBtn,
            this.Sube_SubeListesiBtn,
            this.Personel_YeniPerKayitBtn,
            this.barButtonItem5,
            this.barYeniKullaniciEkleBtn,
            this.barKullaniciListesiBtn,
            this.Musteri_YeniMusteriKayitBtn,
            this.Menu_MusteriListesiBtn,
            this.Menu_YeniMusteriKayitBtn,
            this.barSifreDegistirBtn,
            this.barUzaktanBaglantiBtn,
            this.barWebSitesiBtn,
            this.barYeniHizmetBtn,
            this.barHizmetlistesiBtn,
            this.Menu_barYeniHizmetBtn,
            this.barGuncellemeBtn});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 33;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage7,
            this.ribbonPage3,
            this.ribbonPage4,
            this.ribbonPage5,
            this.ribbonPage6,
            this.ribbonPage8});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit1,
            this.repositoryItemTextEdit1});
            this.ribbon.ShowQatLocationSelector = false;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(988, 163);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItem1.Caption = "Gelişimsoft Yazılım";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // kullaniciBtn
            // 
            this.kullaniciBtn.Caption = "barButtonItem2";
            this.kullaniciBtn.Id = 3;
            this.kullaniciBtn.Name = "kullaniciBtn";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Edit = this.repositoryItemTextEdit1;
            this.barEditItem1.Id = 4;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // TarihBtn
            // 
            this.TarihBtn.Caption = "barButtonItem2";
            this.TarihBtn.Id = 5;
            this.TarihBtn.Name = "TarihBtn";
            // 
            // Menu_YeniFormKayitBtn
            // 
            this.Menu_YeniFormKayitBtn.Caption = "Yeni Form Kayıt";
            this.Menu_YeniFormKayitBtn.Id = 6;
            this.Menu_YeniFormKayitBtn.LargeGlyph = global::Hizmet_MusMemnuniyet.Properties.Resources.FormGirisi;
            this.Menu_YeniFormKayitBtn.LargeWidth = 100;
            this.Menu_YeniFormKayitBtn.Name = "Menu_YeniFormKayitBtn";
            this.Menu_YeniFormKayitBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Menu_YeniFormKayitBtn_ItemClick);
            // 
            // Menu_YeniKatKayitBtn
            // 
            this.Menu_YeniKatKayitBtn.Caption = "Yeni Kategori Kayıt";
            this.Menu_YeniKatKayitBtn.Id = 7;
            this.Menu_YeniKatKayitBtn.LargeGlyph = global::Hizmet_MusMemnuniyet.Properties.Resources.KategoriGirisi;
            this.Menu_YeniKatKayitBtn.LargeWidth = 100;
            this.Menu_YeniKatKayitBtn.Name = "Menu_YeniKatKayitBtn";
            this.Menu_YeniKatKayitBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Menu_YeniKatKayitBtn_ItemClick);
            // 
            // Menu_YeniSubeKayitBtn
            // 
            this.Menu_YeniSubeKayitBtn.Caption = "Yeni Şube Kayıt";
            this.Menu_YeniSubeKayitBtn.Id = 8;
            this.Menu_YeniSubeKayitBtn.LargeGlyph = global::Hizmet_MusMemnuniyet.Properties.Resources.SubeGiris;
            this.Menu_YeniSubeKayitBtn.LargeWidth = 100;
            this.Menu_YeniSubeKayitBtn.Name = "Menu_YeniSubeKayitBtn";
            this.Menu_YeniSubeKayitBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Menu_YeniSubeKayitBtn_ItemClick);
            // 
            // Menu_YeniPerKayitBtn
            // 
            this.Menu_YeniPerKayitBtn.Caption = "Yeni Personel Kayıt";
            this.Menu_YeniPerKayitBtn.Id = 9;
            this.Menu_YeniPerKayitBtn.LargeGlyph = global::Hizmet_MusMemnuniyet.Properties.Resources.PersonelGiris;
            this.Menu_YeniPerKayitBtn.LargeWidth = 100;
            this.Menu_YeniPerKayitBtn.Name = "Menu_YeniPerKayitBtn";
            this.Menu_YeniPerKayitBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Menu_YeniPerKayitBtn_ItemClick);
            // 
            // CikisBtn
            // 
            this.CikisBtn.Caption = "Güvenli Çıkış";
            this.CikisBtn.Id = 10;
            this.CikisBtn.LargeGlyph = global::Hizmet_MusMemnuniyet.Properties.Resources.GuvenliCikis;
            this.CikisBtn.LargeWidth = 100;
            this.CikisBtn.Name = "CikisBtn";
            this.CikisBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CikisBtn_ItemClick);
            // 
            // Hakkindabtn
            // 
            this.Hakkindabtn.Caption = "Program Hakkında";
            this.Hakkindabtn.Glyph = ((System.Drawing.Image)(resources.GetObject("Hakkindabtn.Glyph")));
            this.Hakkindabtn.Id = 11;
            this.Hakkindabtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Hakkindabtn.LargeGlyph")));
            this.Hakkindabtn.LargeWidth = 100;
            this.Hakkindabtn.Name = "Hakkindabtn";
            this.Hakkindabtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Hakkindabtn_ItemClick);
            // 
            // Form_YeniFormKayitBtn
            // 
            this.Form_YeniFormKayitBtn.Caption = "Yeni Form Kayıt";
            this.Form_YeniFormKayitBtn.Id = 12;
            this.Form_YeniFormKayitBtn.LargeGlyph = global::Hizmet_MusMemnuniyet.Properties.Resources.FormGirisi;
            this.Form_YeniFormKayitBtn.LargeWidth = 100;
            this.Form_YeniFormKayitBtn.Name = "Form_YeniFormKayitBtn";
            this.Form_YeniFormKayitBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Form_YeniFormKayitBtn_ItemClick);
            // 
            // Form_FormListesiBtn
            // 
            this.Form_FormListesiBtn.Caption = "Form Listesi";
            this.Form_FormListesiBtn.Id = 13;
            this.Form_FormListesiBtn.LargeGlyph = global::Hizmet_MusMemnuniyet.Properties.Resources.FormListesi;
            this.Form_FormListesiBtn.LargeWidth = 100;
            this.Form_FormListesiBtn.Name = "Form_FormListesiBtn";
            this.Form_FormListesiBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Form_FormListesiBtn_ItemClick);
            // 
            // Form_YeniKatKayitBtn
            // 
            this.Form_YeniKatKayitBtn.Caption = "Ana Kategori Kayıt";
            this.Form_YeniKatKayitBtn.Id = 14;
            this.Form_YeniKatKayitBtn.LargeGlyph = global::Hizmet_MusMemnuniyet.Properties.Resources.KategoriGirisi;
            this.Form_YeniKatKayitBtn.LargeWidth = 100;
            this.Form_YeniKatKayitBtn.Name = "Form_YeniKatKayitBtn";
            this.Form_YeniKatKayitBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Form_YeniKatKayitBtn_ItemClick);
            // 
            // Form_AltYeniKatKayitBtn
            // 
            this.Form_AltYeniKatKayitBtn.Caption = "Alt Kategori Kayıt";
            this.Form_AltYeniKatKayitBtn.Id = 15;
            this.Form_AltYeniKatKayitBtn.LargeGlyph = global::Hizmet_MusMemnuniyet.Properties.Resources.AltKategori;
            this.Form_AltYeniKatKayitBtn.LargeWidth = 100;
            this.Form_AltYeniKatKayitBtn.Name = "Form_AltYeniKatKayitBtn";
            this.Form_AltYeniKatKayitBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Form_AltYeniKatKayitBtn_ItemClick);
            // 
            // Menu_KategoriListesiBtn
            // 
            this.Menu_KategoriListesiBtn.Caption = "Kategori Listesi";
            this.Menu_KategoriListesiBtn.Id = 16;
            this.Menu_KategoriListesiBtn.LargeGlyph = global::Hizmet_MusMemnuniyet.Properties.Resources.KategoriListesi;
            this.Menu_KategoriListesiBtn.LargeWidth = 100;
            this.Menu_KategoriListesiBtn.Name = "Menu_KategoriListesiBtn";
            this.Menu_KategoriListesiBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Menu_KategoriListesiBtn_ItemClick);
            // 
            // Form_YeniSubeKayitBtn
            // 
            this.Form_YeniSubeKayitBtn.Caption = "Yeni Şube Kayıt";
            this.Form_YeniSubeKayitBtn.Id = 17;
            this.Form_YeniSubeKayitBtn.LargeGlyph = global::Hizmet_MusMemnuniyet.Properties.Resources.SubeGiris;
            this.Form_YeniSubeKayitBtn.LargeWidth = 100;
            this.Form_YeniSubeKayitBtn.Name = "Form_YeniSubeKayitBtn";
            this.Form_YeniSubeKayitBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Form_YeniSubeKayitBtn_ItemClick);
            // 
            // Sube_SubeListesiBtn
            // 
            this.Sube_SubeListesiBtn.Caption = "Şube Listesi";
            this.Sube_SubeListesiBtn.Id = 18;
            this.Sube_SubeListesiBtn.LargeGlyph = global::Hizmet_MusMemnuniyet.Properties.Resources.SubeListesi;
            this.Sube_SubeListesiBtn.LargeWidth = 100;
            this.Sube_SubeListesiBtn.Name = "Sube_SubeListesiBtn";
            this.Sube_SubeListesiBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Sube_SubeListesiBtn_ItemClick);
            // 
            // Personel_YeniPerKayitBtn
            // 
            this.Personel_YeniPerKayitBtn.Caption = "Yeni Personel Kayıt";
            this.Personel_YeniPerKayitBtn.Id = 19;
            this.Personel_YeniPerKayitBtn.LargeGlyph = global::Hizmet_MusMemnuniyet.Properties.Resources.PersonelGiris;
            this.Personel_YeniPerKayitBtn.LargeWidth = 100;
            this.Personel_YeniPerKayitBtn.Name = "Personel_YeniPerKayitBtn";
            this.Personel_YeniPerKayitBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Personel_YeniPerKayitBtn_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Personel Listesi";
            this.barButtonItem5.Id = 20;
            this.barButtonItem5.LargeGlyph = global::Hizmet_MusMemnuniyet.Properties.Resources.PersonelListesi;
            this.barButtonItem5.LargeWidth = 100;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barYeniKullaniciEkleBtn
            // 
            this.barYeniKullaniciEkleBtn.Caption = "Yeni Kullanıcı Ekle";
            this.barYeniKullaniciEkleBtn.Enabled = false;
            this.barYeniKullaniciEkleBtn.Id = 21;
            this.barYeniKullaniciEkleBtn.LargeGlyph = global::Hizmet_MusMemnuniyet.Properties.Resources.KullanıcıEkle;
            this.barYeniKullaniciEkleBtn.LargeWidth = 100;
            this.barYeniKullaniciEkleBtn.Name = "barYeniKullaniciEkleBtn";
            this.barYeniKullaniciEkleBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barYeniKullaniciEkleBtn_ItemClick);
            // 
            // barKullaniciListesiBtn
            // 
            this.barKullaniciListesiBtn.Caption = "Kullanıcı Listesi";
            this.barKullaniciListesiBtn.Enabled = false;
            this.barKullaniciListesiBtn.Id = 22;
            this.barKullaniciListesiBtn.LargeGlyph = global::Hizmet_MusMemnuniyet.Properties.Resources.KullanıcıListesi;
            this.barKullaniciListesiBtn.LargeWidth = 100;
            this.barKullaniciListesiBtn.Name = "barKullaniciListesiBtn";
            this.barKullaniciListesiBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barKullaniciListesiBtn_ItemClick);
            // 
            // Musteri_YeniMusteriKayitBtn
            // 
            this.Musteri_YeniMusteriKayitBtn.Caption = "Yeni Müşteri Kayıt";
            this.Musteri_YeniMusteriKayitBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("Musteri_YeniMusteriKayitBtn.Glyph")));
            this.Musteri_YeniMusteriKayitBtn.Id = 23;
            this.Musteri_YeniMusteriKayitBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Musteri_YeniMusteriKayitBtn.LargeGlyph")));
            this.Musteri_YeniMusteriKayitBtn.LargeWidth = 100;
            this.Musteri_YeniMusteriKayitBtn.Name = "Musteri_YeniMusteriKayitBtn";
            this.Musteri_YeniMusteriKayitBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Musteri_YeniMusteriKayitBtn_ItemClick);
            // 
            // Menu_MusteriListesiBtn
            // 
            this.Menu_MusteriListesiBtn.Caption = "Müşteri Listesi";
            this.Menu_MusteriListesiBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("Menu_MusteriListesiBtn.Glyph")));
            this.Menu_MusteriListesiBtn.Id = 24;
            this.Menu_MusteriListesiBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Menu_MusteriListesiBtn.LargeGlyph")));
            this.Menu_MusteriListesiBtn.LargeWidth = 100;
            this.Menu_MusteriListesiBtn.Name = "Menu_MusteriListesiBtn";
            this.Menu_MusteriListesiBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Menu_MusteriListesiBtn_ItemClick);
            // 
            // Menu_YeniMusteriKayitBtn
            // 
            this.Menu_YeniMusteriKayitBtn.Caption = "Yeni Müşteri Kayıt";
            this.Menu_YeniMusteriKayitBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("Menu_YeniMusteriKayitBtn.Glyph")));
            this.Menu_YeniMusteriKayitBtn.Id = 25;
            this.Menu_YeniMusteriKayitBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Menu_YeniMusteriKayitBtn.LargeGlyph")));
            this.Menu_YeniMusteriKayitBtn.LargeWidth = 100;
            this.Menu_YeniMusteriKayitBtn.Name = "Menu_YeniMusteriKayitBtn";
            this.Menu_YeniMusteriKayitBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Menu_YeniMusteriKayitBtn_ItemClick);
            // 
            // barSifreDegistirBtn
            // 
            this.barSifreDegistirBtn.Caption = "Şifre Değiştir";
            this.barSifreDegistirBtn.Id = 26;
            this.barSifreDegistirBtn.LargeGlyph = global::Hizmet_MusMemnuniyet.Properties.Resources._1435258776_lock;
            this.barSifreDegistirBtn.LargeWidth = 100;
            this.barSifreDegistirBtn.Name = "barSifreDegistirBtn";
            this.barSifreDegistirBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barSifreDegistirBtn_ItemClick);
            // 
            // barUzaktanBaglantiBtn
            // 
            this.barUzaktanBaglantiBtn.Caption = "Uzaktan Bağlantı";
            this.barUzaktanBaglantiBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("barUzaktanBaglantiBtn.Glyph")));
            this.barUzaktanBaglantiBtn.Id = 27;
            this.barUzaktanBaglantiBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barUzaktanBaglantiBtn.LargeGlyph")));
            this.barUzaktanBaglantiBtn.LargeWidth = 100;
            this.barUzaktanBaglantiBtn.Name = "barUzaktanBaglantiBtn";
            this.barUzaktanBaglantiBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barUzaktanBaglantiBtn_ItemClick);
            // 
            // barWebSitesiBtn
            // 
            this.barWebSitesiBtn.Caption = "Web Sitesi";
            this.barWebSitesiBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("barWebSitesiBtn.Glyph")));
            this.barWebSitesiBtn.Id = 28;
            this.barWebSitesiBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barWebSitesiBtn.LargeGlyph")));
            this.barWebSitesiBtn.LargeWidth = 100;
            this.barWebSitesiBtn.Name = "barWebSitesiBtn";
            this.barWebSitesiBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barWebSitesiBtn_ItemClick);
            // 
            // barYeniHizmetBtn
            // 
            this.barYeniHizmetBtn.Caption = "Yeni Hizmet Kayıt";
            this.barYeniHizmetBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("barYeniHizmetBtn.Glyph")));
            this.barYeniHizmetBtn.Id = 29;
            this.barYeniHizmetBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barYeniHizmetBtn.LargeGlyph")));
            this.barYeniHizmetBtn.LargeWidth = 100;
            this.barYeniHizmetBtn.Name = "barYeniHizmetBtn";
            this.barYeniHizmetBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barYeniHizmetBtn_ItemClick);
            // 
            // barHizmetlistesiBtn
            // 
            this.barHizmetlistesiBtn.Caption = "Hizmet Listesi";
            this.barHizmetlistesiBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("barHizmetlistesiBtn.Glyph")));
            this.barHizmetlistesiBtn.Id = 30;
            this.barHizmetlistesiBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barHizmetlistesiBtn.LargeGlyph")));
            this.barHizmetlistesiBtn.LargeWidth = 100;
            this.barHizmetlistesiBtn.Name = "barHizmetlistesiBtn";
            this.barHizmetlistesiBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barHizmetlistesiBtn_ItemClick);
            // 
            // Menu_barYeniHizmetBtn
            // 
            this.Menu_barYeniHizmetBtn.Caption = "Yeni Hizmet Kayıt";
            this.Menu_barYeniHizmetBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("Menu_barYeniHizmetBtn.Glyph")));
            this.Menu_barYeniHizmetBtn.Id = 31;
            this.Menu_barYeniHizmetBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Menu_barYeniHizmetBtn.LargeGlyph")));
            this.Menu_barYeniHizmetBtn.LargeWidth = 100;
            this.Menu_barYeniHizmetBtn.Name = "Menu_barYeniHizmetBtn";
            this.Menu_barYeniHizmetBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Menu_barYeniHizmetBtn_ItemClick);
            // 
            // barGuncellemeBtn
            // 
            this.barGuncellemeBtn.Caption = "Güncelleme";
            this.barGuncellemeBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("barGuncellemeBtn.Glyph")));
            this.barGuncellemeBtn.Id = 32;
            this.barGuncellemeBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barGuncellemeBtn.LargeGlyph")));
            this.barGuncellemeBtn.LargeWidth = 100;
            this.barGuncellemeBtn.Name = "barGuncellemeBtn";
            this.barGuncellemeBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barGuncellemeBtn_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup2});
            this.ribbonPage1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "MENÜ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.Menu_YeniFormKayitBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.Menu_barYeniHizmetBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.Menu_YeniMusteriKayitBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.Menu_YeniKatKayitBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.Menu_YeniSubeKayitBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.Menu_YeniPerKayitBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "İşlemler";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.Hakkindabtn);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Hakkında";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.CikisBtn);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Çıkış";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup11});
            this.ribbonPage2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage2.Image")));
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "FORM";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.Form_YeniFormKayitBtn);
            this.ribbonPageGroup4.ItemLinks.Add(this.Form_FormListesiBtn);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Form İşlemleri";
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.ItemLinks.Add(this.barYeniHizmetBtn);
            this.ribbonPageGroup11.ItemLinks.Add(this.barHizmetlistesiBtn);
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            this.ribbonPageGroup11.Text = "Hizmet Çeşitleri";
            // 
            // ribbonPage7
            // 
            this.ribbonPage7.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup9});
            this.ribbonPage7.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage7.Image")));
            this.ribbonPage7.Name = "ribbonPage7";
            this.ribbonPage7.Text = "MÜŞTERİLER";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.Musteri_YeniMusteriKayitBtn);
            this.ribbonPageGroup9.ItemLinks.Add(this.Menu_MusteriListesiBtn);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.Text = "Müşteri İşlemleri";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage3.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage3.Image")));
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "KATEGORİ";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.Form_YeniKatKayitBtn);
            this.ribbonPageGroup5.ItemLinks.Add(this.Form_AltYeniKatKayitBtn);
            this.ribbonPageGroup5.ItemLinks.Add(this.Menu_KategoriListesiBtn);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Kategori İşlemleri";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.ribbonPage4.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage4.Image")));
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "ŞUBE";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.Form_YeniSubeKayitBtn);
            this.ribbonPageGroup6.ItemLinks.Add(this.Sube_SubeListesiBtn);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Şube İşlemleri";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup7});
            this.ribbonPage5.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage5.Image")));
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "PERSONEL";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.Personel_YeniPerKayitBtn);
            this.ribbonPageGroup7.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Personel İşlemleri";
            // 
            // ribbonPage6
            // 
            this.ribbonPage6.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup8});
            this.ribbonPage6.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage6.Image")));
            this.ribbonPage6.Name = "ribbonPage6";
            this.ribbonPage6.Text = "KULLANICLAR";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.barYeniKullaniciEkleBtn);
            this.ribbonPageGroup8.ItemLinks.Add(this.barKullaniciListesiBtn);
            this.ribbonPageGroup8.ItemLinks.Add(this.barSifreDegistirBtn);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "Kullanıcı İşlemleri";
            // 
            // ribbonPage8
            // 
            this.ribbonPage8.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup10});
            this.ribbonPage8.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage8.Image")));
            this.ribbonPage8.Name = "ribbonPage8";
            this.ribbonPage8.Text = "DESTEK";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ItemLinks.Add(this.barUzaktanBaglantiBtn);
            this.ribbonPageGroup10.ItemLinks.Add(this.barWebSitesiBtn);
            this.ribbonPageGroup10.ItemLinks.Add(this.barGuncellemeBtn);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            this.ribbonPageGroup10.Text = "Gelişimsoft Yazılım Hizmetleri";
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barButtonItem1);
            this.ribbonStatusBar.ItemLinks.Add(this.kullaniciBtn);
            this.ribbonStatusBar.ItemLinks.Add(this.TarihBtn);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 519);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(988, 32);
            // 
            // MdiManager
            // 
            this.MdiManager.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPagesAndTabControlHeader;
            this.MdiManager.MdiParent = this;
            // 
            // theme
            // 
            this.theme.LookAndFeel.SkinName = "Office 2010 Blue";
            // 
            // frmAnamenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 551);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmAnamenu";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Müşteri Kalite Yönetim Süreci | Hoşgeldiniz!";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAnamenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MdiManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RibbonControl ribbon;
        private RibbonPage ribbonPage1;
        private RibbonPageGroup ribbonPageGroup1;
        private RibbonStatusBar ribbonStatusBar;
        private BarButtonItem barButtonItem1;
        private RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private BarButtonItem kullaniciBtn;
        private BarEditItem barEditItem1;
        private RepositoryItemTextEdit repositoryItemTextEdit1;
        private BarButtonItem TarihBtn;
        private XtraTabbedMdiManager MdiManager;
        private DefaultLookAndFeel theme;
        private BarButtonItem Menu_YeniFormKayitBtn;
        private BarButtonItem Menu_YeniKatKayitBtn;
        private BarButtonItem Menu_YeniSubeKayitBtn;
        private BarButtonItem Menu_YeniPerKayitBtn;
        private BarButtonItem CikisBtn;
        private RibbonPageGroup ribbonPageGroup2;
        private RibbonPage ribbonPage2;
        private RibbonPage ribbonPage3;
        private BarButtonItem Hakkindabtn;
        private BarButtonItem Form_YeniFormKayitBtn;
        private BarButtonItem Form_FormListesiBtn;
        private RibbonPageGroup ribbonPageGroup3;
        private RibbonPageGroup ribbonPageGroup4;
        private RibbonPage ribbonPage4;
        private RibbonPage ribbonPage5;
        private RibbonPage ribbonPage6;
        private BarButtonItem Form_YeniKatKayitBtn;
        private BarButtonItem Form_AltYeniKatKayitBtn;
        private BarButtonItem Menu_KategoriListesiBtn;
        private RibbonPageGroup ribbonPageGroup5;
        private BarButtonItem Form_YeniSubeKayitBtn;
        private BarButtonItem Sube_SubeListesiBtn;
        private RibbonPageGroup ribbonPageGroup6;
        private BarButtonItem Personel_YeniPerKayitBtn;
        private BarButtonItem barButtonItem5;
        private RibbonPageGroup ribbonPageGroup7;
        private BarButtonItem barYeniKullaniciEkleBtn;
        private BarButtonItem barKullaniciListesiBtn;
        private RibbonPageGroup ribbonPageGroup8;
        private RibbonPage ribbonPage7;
        private BarButtonItem Musteri_YeniMusteriKayitBtn;
        private BarButtonItem Menu_MusteriListesiBtn;
        private BarButtonItem Menu_YeniMusteriKayitBtn;
        private RibbonPageGroup ribbonPageGroup9;
        private BarButtonItem barSifreDegistirBtn;
        private BarButtonItem barUzaktanBaglantiBtn;
        private BarButtonItem barWebSitesiBtn;
        private BarButtonItem barYeniHizmetBtn;
        private BarButtonItem barHizmetlistesiBtn;
        private RibbonPageGroup ribbonPageGroup11;
        private RibbonPage ribbonPage8;
        private RibbonPageGroup ribbonPageGroup10;
        private BarButtonItem Menu_barYeniHizmetBtn;
        private BarButtonItem barGuncellemeBtn;
    }
}