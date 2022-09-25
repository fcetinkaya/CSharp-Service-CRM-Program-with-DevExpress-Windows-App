using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;

namespace Hizmet_MusMemnuniyet.Musteriler
{
    partial class frmMusteriListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriListesi));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.IkinciDogumTarih = new DevExpress.XtraEditors.DateEdit();
            this.IlkDogumTarih = new DevExpress.XtraEditors.DateEdit();
            this.IkinciEvlilikTarihi = new DevExpress.XtraEditors.DateEdit();
            this.IlkEvlilikTarihi = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.AramaBtn = new DevExpress.XtraEditors.SimpleButton();
            this.TemizleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.AdresBox = new DevExpress.XtraEditors.TextEdit();
            this.MeslekBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.AdsoyadBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yeniKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excel2007AktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excel2013AktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hTMLAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resimOlarakKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bugünDoğanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bugünEvlenenlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ADSOYAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MESLEK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CEP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SABIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EPOSTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ADRES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IkinciDogumTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IkinciDogumTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IlkDogumTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IlkDogumTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IkinciEvlilikTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IkinciEvlilikTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IlkEvlilikTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IlkEvlilikTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdresBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeslekBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdsoyadBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1;
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1045, 578);
            this.splitContainerControl1.SplitterPosition = 196;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(196, 578);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.IkinciDogumTarih);
            this.xtraTabPage1.Controls.Add(this.IlkDogumTarih);
            this.xtraTabPage1.Controls.Add(this.IkinciEvlilikTarihi);
            this.xtraTabPage1.Controls.Add(this.IlkEvlilikTarihi);
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.AramaBtn);
            this.xtraTabPage1.Controls.Add(this.TemizleBtn);
            this.xtraTabPage1.Controls.Add(this.AdresBox);
            this.xtraTabPage1.Controls.Add(this.MeslekBox);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.AdsoyadBox);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(190, 550);
            this.xtraTabPage1.Text = "Arama";
            // 
            // IkinciDogumTarih
            // 
            this.IkinciDogumTarih.EditValue = null;
            this.IkinciDogumTarih.Location = new System.Drawing.Point(98, 213);
            this.IkinciDogumTarih.Name = "IkinciDogumTarih";
            this.IkinciDogumTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.IkinciDogumTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.IkinciDogumTarih.Properties.Mask.EditMask = "";
            this.IkinciDogumTarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.IkinciDogumTarih.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.IkinciDogumTarih.Size = new System.Drawing.Size(79, 20);
            this.IkinciDogumTarih.TabIndex = 27;
            // 
            // IlkDogumTarih
            // 
            this.IlkDogumTarih.EditValue = null;
            this.IlkDogumTarih.Location = new System.Drawing.Point(11, 213);
            this.IlkDogumTarih.Name = "IlkDogumTarih";
            this.IlkDogumTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.IlkDogumTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.IlkDogumTarih.Properties.Mask.EditMask = "";
            this.IlkDogumTarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.IlkDogumTarih.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.IlkDogumTarih.Size = new System.Drawing.Size(79, 20);
            this.IlkDogumTarih.TabIndex = 26;
            // 
            // IkinciEvlilikTarihi
            // 
            this.IkinciEvlilikTarihi.EditValue = null;
            this.IkinciEvlilikTarihi.Location = new System.Drawing.Point(98, 268);
            this.IkinciEvlilikTarihi.Name = "IkinciEvlilikTarihi";
            this.IkinciEvlilikTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.IkinciEvlilikTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.IkinciEvlilikTarihi.Properties.Mask.EditMask = "";
            this.IkinciEvlilikTarihi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.IkinciEvlilikTarihi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.IkinciEvlilikTarihi.Size = new System.Drawing.Size(79, 20);
            this.IkinciEvlilikTarihi.TabIndex = 29;
            // 
            // IlkEvlilikTarihi
            // 
            this.IlkEvlilikTarihi.EditValue = null;
            this.IlkEvlilikTarihi.Location = new System.Drawing.Point(11, 268);
            this.IlkEvlilikTarihi.Name = "IlkEvlilikTarihi";
            this.IlkEvlilikTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.IlkEvlilikTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.IlkEvlilikTarihi.Properties.Mask.EditMask = "";
            this.IlkEvlilikTarihi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.IlkEvlilikTarihi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.IlkEvlilikTarihi.Size = new System.Drawing.Size(79, 20);
            this.IlkEvlilikTarihi.TabIndex = 28;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(11, 249);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(54, 13);
            this.labelControl5.TabIndex = 30;
            this.labelControl5.Text = "Evlilik Tarihi";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(11, 194);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 13);
            this.labelControl4.TabIndex = 31;
            this.labelControl4.Text = "Doğum Tarihi";
            // 
            // AramaBtn
            // 
            this.AramaBtn.Image = ((System.Drawing.Image)(resources.GetObject("AramaBtn.Image")));
            this.AramaBtn.Location = new System.Drawing.Point(11, 304);
            this.AramaBtn.Name = "AramaBtn";
            this.AramaBtn.Size = new System.Drawing.Size(63, 23);
            this.AramaBtn.TabIndex = 2;
            this.AramaBtn.Text = "Arama";
            this.AramaBtn.Click += new System.EventHandler(this.AramaBtn_Click);
            // 
            // TemizleBtn
            // 
            this.TemizleBtn.Image = ((System.Drawing.Image)(resources.GetObject("TemizleBtn.Image")));
            this.TemizleBtn.Location = new System.Drawing.Point(80, 304);
            this.TemizleBtn.Name = "TemizleBtn";
            this.TemizleBtn.Size = new System.Drawing.Size(70, 23);
            this.TemizleBtn.TabIndex = 2;
            this.TemizleBtn.Text = "Temizle";
            this.TemizleBtn.Click += new System.EventHandler(this.TemizleBtn_Click);
            // 
            // AdresBox
            // 
            this.AdresBox.Location = new System.Drawing.Point(11, 156);
            this.AdresBox.Name = "AdresBox";
            this.AdresBox.Size = new System.Drawing.Size(166, 20);
            this.AdresBox.TabIndex = 1;
            // 
            // MeslekBox
            // 
            this.MeslekBox.Location = new System.Drawing.Point(11, 99);
            this.MeslekBox.Name = "MeslekBox";
            this.MeslekBox.Size = new System.Drawing.Size(166, 20);
            this.MeslekBox.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 137);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Adres";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 80);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Meslek";
            // 
            // AdsoyadBox
            // 
            this.AdsoyadBox.Location = new System.Drawing.Point(11, 45);
            this.AdsoyadBox.Name = "AdsoyadBox";
            this.AdsoyadBox.Size = new System.Drawing.Size(166, 20);
            this.AdsoyadBox.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ad Soyad";
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(844, 578);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniKayıtToolStripMenuItem,
            this.düzenleToolStripMenuItem,
            this.seçToolStripMenuItem,
            this.excelAktarToolStripMenuItem,
            this.pDFAktarToolStripMenuItem,
            this.cSVAktarToolStripMenuItem,
            this.hTMLAktarToolStripMenuItem,
            this.resimOlarakKaydetToolStripMenuItem,
            this.bugünDoğanlarToolStripMenuItem,
            this.bugünEvlenenlerToolStripMenuItem,
            this.yazdırToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(183, 268);
            // 
            // yeniKayıtToolStripMenuItem
            // 
            this.yeniKayıtToolStripMenuItem.Image = global::Hizmet_MusMemnuniyet.Properties.Resources._0009_Add;
            this.yeniKayıtToolStripMenuItem.Name = "yeniKayıtToolStripMenuItem";
            this.yeniKayıtToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.yeniKayıtToolStripMenuItem.Text = "Yeni Kayıt";
            this.yeniKayıtToolStripMenuItem.Click += new System.EventHandler(this.yeniKayıtToolStripMenuItem_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Image = global::Hizmet_MusMemnuniyet.Properties.Resources.edit;
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // seçToolStripMenuItem
            // 
            this.seçToolStripMenuItem.Image = global::Hizmet_MusMemnuniyet.Properties.Resources._0007_Tick;
            this.seçToolStripMenuItem.Name = "seçToolStripMenuItem";
            this.seçToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.seçToolStripMenuItem.Text = "Seç";
            this.seçToolStripMenuItem.Click += new System.EventHandler(this.seçToolStripMenuItem_Click);
            // 
            // excelAktarToolStripMenuItem
            // 
            this.excelAktarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excel2007AktarToolStripMenuItem,
            this.excel2013AktarToolStripMenuItem});
            this.excelAktarToolStripMenuItem.Image = global::Hizmet_MusMemnuniyet.Properties.Resources.excel_viewer;
            this.excelAktarToolStripMenuItem.Name = "excelAktarToolStripMenuItem";
            this.excelAktarToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.excelAktarToolStripMenuItem.Text = "Excel Aktar";
            // 
            // excel2007AktarToolStripMenuItem
            // 
            this.excel2007AktarToolStripMenuItem.Image = global::Hizmet_MusMemnuniyet.Properties.Resources.excel_viewer;
            this.excel2007AktarToolStripMenuItem.Name = "excel2007AktarToolStripMenuItem";
            this.excel2007AktarToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.excel2007AktarToolStripMenuItem.Text = "Excel 2007 Aktar";
            this.excel2007AktarToolStripMenuItem.Click += new System.EventHandler(this.excel2007ToolStripMenuItem_Click);
            // 
            // excel2013AktarToolStripMenuItem
            // 
            this.excel2013AktarToolStripMenuItem.Image = global::Hizmet_MusMemnuniyet.Properties.Resources.excel_viewer;
            this.excel2013AktarToolStripMenuItem.Name = "excel2013AktarToolStripMenuItem";
            this.excel2013AktarToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.excel2013AktarToolStripMenuItem.Text = "Excel 2013 Aktar";
            this.excel2013AktarToolStripMenuItem.Click += new System.EventHandler(this.excel2013ToolStripMenuItem_Click);
            // 
            // pDFAktarToolStripMenuItem
            // 
            this.pDFAktarToolStripMenuItem.Image = global::Hizmet_MusMemnuniyet.Properties.Resources.pdfIcon;
            this.pDFAktarToolStripMenuItem.Name = "pDFAktarToolStripMenuItem";
            this.pDFAktarToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.pDFAktarToolStripMenuItem.Text = "PDF Aktar";
            this.pDFAktarToolStripMenuItem.Click += new System.EventHandler(this.pdfAktarToolStripMenuItem_Click);
            // 
            // cSVAktarToolStripMenuItem
            // 
            this.cSVAktarToolStripMenuItem.Image = global::Hizmet_MusMemnuniyet.Properties.Resources.csv_icon;
            this.cSVAktarToolStripMenuItem.Name = "cSVAktarToolStripMenuItem";
            this.cSVAktarToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cSVAktarToolStripMenuItem.Text = "CSV Aktar";
            this.cSVAktarToolStripMenuItem.Click += new System.EventHandler(this.csvAktarToolStripMenuItem_Click);
            // 
            // hTMLAktarToolStripMenuItem
            // 
            this.hTMLAktarToolStripMenuItem.Image = global::Hizmet_MusMemnuniyet.Properties.Resources.html_icon;
            this.hTMLAktarToolStripMenuItem.Name = "hTMLAktarToolStripMenuItem";
            this.hTMLAktarToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.hTMLAktarToolStripMenuItem.Text = "HTML Aktar";
            this.hTMLAktarToolStripMenuItem.Click += new System.EventHandler(this.hTMLAktarToolStripMenuItem_Click);
            // 
            // resimOlarakKaydetToolStripMenuItem
            // 
            this.resimOlarakKaydetToolStripMenuItem.Image = global::Hizmet_MusMemnuniyet.Properties.Resources.jpg;
            this.resimOlarakKaydetToolStripMenuItem.Name = "resimOlarakKaydetToolStripMenuItem";
            this.resimOlarakKaydetToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.resimOlarakKaydetToolStripMenuItem.Text = "Resim Olarak Kaydet";
            this.resimOlarakKaydetToolStripMenuItem.Click += new System.EventHandler(this.resimOlarakKaydetToolStripMenuItem_Click);
            // 
            // bugünDoğanlarToolStripMenuItem
            // 
            this.bugünDoğanlarToolStripMenuItem.Image = global::Hizmet_MusMemnuniyet.Properties.Resources.DogumGunu;
            this.bugünDoğanlarToolStripMenuItem.Name = "bugünDoğanlarToolStripMenuItem";
            this.bugünDoğanlarToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.bugünDoğanlarToolStripMenuItem.Text = "Bugün Doğanlar";
            this.bugünDoğanlarToolStripMenuItem.Click += new System.EventHandler(this.bugünDoğanlarToolStripMenuItem_Click);
            // 
            // bugünEvlenenlerToolStripMenuItem
            // 
            this.bugünEvlenenlerToolStripMenuItem.Image = global::Hizmet_MusMemnuniyet.Properties.Resources.EvlilikGunu;
            this.bugünEvlenenlerToolStripMenuItem.Name = "bugünEvlenenlerToolStripMenuItem";
            this.bugünEvlenenlerToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.bugünEvlenenlerToolStripMenuItem.Text = "Bugün Evlenenler";
            this.bugünEvlenenlerToolStripMenuItem.Click += new System.EventHandler(this.bugünEvlenenlerToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.ADSOYAD,
            this.MESLEK,
            this.CEP,
            this.SABIT,
            this.EPOSTA,
            this.ADRES});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "MusID";
            this.ID.FieldName = "MusteriID";
            this.ID.Name = "ID";
            this.ID.Width = 25;
            // 
            // ADSOYAD
            // 
            this.ADSOYAD.Caption = "AD SOYAD";
            this.ADSOYAD.FieldName = "AdSoyad";
            this.ADSOYAD.Name = "ADSOYAD";
            this.ADSOYAD.OptionsColumn.AllowEdit = false;
            this.ADSOYAD.OptionsColumn.AllowFocus = false;
            this.ADSOYAD.OptionsColumn.FixedWidth = true;
            this.ADSOYAD.OptionsColumn.ReadOnly = true;
            this.ADSOYAD.Visible = true;
            this.ADSOYAD.VisibleIndex = 0;
            this.ADSOYAD.Width = 125;
            // 
            // MESLEK
            // 
            this.MESLEK.Caption = "MESLEK";
            this.MESLEK.FieldName = "Meslek";
            this.MESLEK.Name = "MESLEK";
            this.MESLEK.OptionsColumn.AllowEdit = false;
            this.MESLEK.OptionsColumn.AllowFocus = false;
            this.MESLEK.OptionsColumn.FixedWidth = true;
            this.MESLEK.OptionsColumn.ReadOnly = true;
            this.MESLEK.Visible = true;
            this.MESLEK.VisibleIndex = 1;
            this.MESLEK.Width = 135;
            // 
            // CEP
            // 
            this.CEP.Caption = "CEP TELEFONU";
            this.CEP.FieldName = "CepTlf";
            this.CEP.Name = "CEP";
            this.CEP.OptionsColumn.AllowEdit = false;
            this.CEP.OptionsColumn.AllowFocus = false;
            this.CEP.OptionsColumn.FixedWidth = true;
            this.CEP.OptionsColumn.ReadOnly = true;
            this.CEP.Visible = true;
            this.CEP.VisibleIndex = 2;
            this.CEP.Width = 90;
            // 
            // SABIT
            // 
            this.SABIT.Caption = "TELEFON";
            this.SABIT.FieldName = "SabitTlf";
            this.SABIT.Name = "SABIT";
            this.SABIT.OptionsColumn.AllowEdit = false;
            this.SABIT.OptionsColumn.AllowFocus = false;
            this.SABIT.OptionsColumn.FixedWidth = true;
            this.SABIT.OptionsColumn.ReadOnly = true;
            this.SABIT.Visible = true;
            this.SABIT.VisibleIndex = 3;
            this.SABIT.Width = 90;
            // 
            // EPOSTA
            // 
            this.EPOSTA.FieldName = "Eposta";
            this.EPOSTA.Name = "EPOSTA";
            this.EPOSTA.OptionsColumn.AllowEdit = false;
            this.EPOSTA.OptionsColumn.AllowFocus = false;
            this.EPOSTA.OptionsColumn.FixedWidth = true;
            this.EPOSTA.OptionsColumn.ReadOnly = true;
            this.EPOSTA.Visible = true;
            this.EPOSTA.VisibleIndex = 4;
            this.EPOSTA.Width = 100;
            // 
            // ADRES
            // 
            this.ADRES.Caption = "ADRES";
            this.ADRES.FieldName = "Adres";
            this.ADRES.Name = "ADRES";
            this.ADRES.OptionsColumn.AllowEdit = false;
            this.ADRES.OptionsColumn.AllowFocus = false;
            this.ADRES.OptionsColumn.FixedWidth = true;
            this.ADRES.OptionsColumn.ReadOnly = true;
            this.ADRES.Visible = true;
            this.ADRES.VisibleIndex = 5;
            this.ADRES.Width = 250;
            // 
            // yazdırToolStripMenuItem
            // 
            this.yazdırToolStripMenuItem.Image = global::Hizmet_MusMemnuniyet.Properties.Resources.indir;
            this.yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
            this.yazdırToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.yazdırToolStripMenuItem.Text = "Yazdır";
            this.yazdırToolStripMenuItem.Click += new System.EventHandler(this.yazdırToolStripMenuItem_Click);
            // 
            // frmMusteriListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 578);
            this.Controls.Add(this.splitContainerControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMusteriListesi";
            this.Text = "Müşteri Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IkinciDogumTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IkinciDogumTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IlkDogumTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IlkDogumTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IkinciEvlilikTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IkinciEvlilikTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IlkEvlilikTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IlkEvlilikTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdresBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeslekBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdsoyadBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainerControl splitContainerControl1;
        private XtraTabControl xtraTabControl1;
        private XtraTabPage xtraTabPage1;
        private SimpleButton AramaBtn;
        private SimpleButton TemizleBtn;
        private TextEdit AdresBox;
        private TextEdit MeslekBox;
        private LabelControl labelControl3;
        private LabelControl labelControl2;
        private TextEdit AdsoyadBox;
        private LabelControl labelControl1;
        private GridControl gridControl1;
        private GridView gridView1;
        private GridColumn ID;
        private GridColumn ADSOYAD;
        private GridColumn MESLEK;
        private GridColumn CEP;
        private GridColumn SABIT;
        private GridColumn EPOSTA;
        private GridColumn ADRES;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem yeniKayıtToolStripMenuItem;
        private ToolStripMenuItem düzenleToolStripMenuItem;
        private ToolStripMenuItem excelAktarToolStripMenuItem;
        private ToolStripMenuItem excel2007AktarToolStripMenuItem;
        private ToolStripMenuItem excel2013AktarToolStripMenuItem;
        private ToolStripMenuItem pDFAktarToolStripMenuItem;
        private ToolStripMenuItem cSVAktarToolStripMenuItem;
        private ToolStripMenuItem hTMLAktarToolStripMenuItem;
        private ToolStripMenuItem resimOlarakKaydetToolStripMenuItem;
        private ToolStripMenuItem seçToolStripMenuItem;
        private DateEdit IkinciDogumTarih;
        private DateEdit IlkDogumTarih;
        private DateEdit IkinciEvlilikTarihi;
        private DateEdit IlkEvlilikTarihi;
        private LabelControl labelControl5;
        private LabelControl labelControl4;
        private ToolStripMenuItem bugünDoğanlarToolStripMenuItem;
        private ToolStripMenuItem bugünEvlenenlerToolStripMenuItem;
        private ToolStripMenuItem yazdırToolStripMenuItem;
    }
}