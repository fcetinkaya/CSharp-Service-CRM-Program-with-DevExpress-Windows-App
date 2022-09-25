using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;

namespace Hizmet_MusMemnuniyet.Formlar
{
    partial class frmFormListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormListesi));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.TemizleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.AramaBtn = new DevExpress.XtraEditors.SimpleButton();
            this.cariAdiBtn = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.SubelerLookUp = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.personelLookUp = new DevExpress.XtraEditors.LookUpEdit();
            this.IkinciFormTarih = new DevExpress.XtraEditors.DateEdit();
            this.IlkFormTarih = new DevExpress.XtraEditors.DateEdit();
            this.comboUlasimSecenegi = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.comboGorusmeSonucu = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.IkinciAramaTarihi = new DevExpress.XtraEditors.DateEdit();
            this.IlkAramaTarihi = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.HizmetLookup = new DevExpress.XtraEditors.LookUpEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yeniKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriKartıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excel2007AktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excel2013AktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hTMLAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resimOlarakKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridAnketID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridNumara = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridAnketTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridAramaTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridAdSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridGorusmeSonucu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridUlasimSecenegi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSubeAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridPersonelAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridPID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cariAdiBtn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubelerLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IkinciFormTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IkinciFormTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IlkFormTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IlkFormTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboUlasimSecenegi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboGorusmeSonucu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IkinciAramaTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IkinciAramaTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IlkAramaTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IlkAramaTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HizmetLookup.Properties)).BeginInit();
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
            this.splitContainerControl1.Size = new System.Drawing.Size(812, 575);
            this.splitContainerControl1.SplitterPosition = 189;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(189, 575);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.TemizleBtn);
            this.xtraTabPage1.Controls.Add(this.AramaBtn);
            this.xtraTabPage1.Controls.Add(this.cariAdiBtn);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl8);
            this.xtraTabPage1.Controls.Add(this.SubelerLookUp);
            this.xtraTabPage1.Controls.Add(this.labelControl7);
            this.xtraTabPage1.Controls.Add(this.personelLookUp);
            this.xtraTabPage1.Controls.Add(this.IkinciFormTarih);
            this.xtraTabPage1.Controls.Add(this.IlkFormTarih);
            this.xtraTabPage1.Controls.Add(this.comboUlasimSecenegi);
            this.xtraTabPage1.Controls.Add(this.labelControl9);
            this.xtraTabPage1.Controls.Add(this.comboGorusmeSonucu);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.labelControl6);
            this.xtraTabPage1.Controls.Add(this.IkinciAramaTarihi);
            this.xtraTabPage1.Controls.Add(this.IlkAramaTarihi);
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.HizmetLookup);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(183, 547);
            this.xtraTabPage1.Text = "Arama";
            // 
            // TemizleBtn
            // 
            this.TemizleBtn.Image = ((System.Drawing.Image)(resources.GetObject("TemizleBtn.Image")));
            this.TemizleBtn.Location = new System.Drawing.Point(99, 397);
            this.TemizleBtn.Name = "TemizleBtn";
            this.TemizleBtn.Size = new System.Drawing.Size(75, 23);
            this.TemizleBtn.TabIndex = 0;
            this.TemizleBtn.Text = "Temizle";
            this.TemizleBtn.Click += new System.EventHandler(this.TemizleBtn_Click);
            // 
            // AramaBtn
            // 
            this.AramaBtn.Image = ((System.Drawing.Image)(resources.GetObject("AramaBtn.Image")));
            this.AramaBtn.Location = new System.Drawing.Point(10, 397);
            this.AramaBtn.Name = "AramaBtn";
            this.AramaBtn.Size = new System.Drawing.Size(75, 23);
            this.AramaBtn.TabIndex = 0;
            this.AramaBtn.Text = "Arama";
            this.AramaBtn.Click += new System.EventHandler(this.AramaBtn_Click);
            // 
            // cariAdiBtn
            // 
            this.cariAdiBtn.Location = new System.Drawing.Point(10, 350);
            this.cariAdiBtn.Name = "cariAdiBtn";
            this.cariAdiBtn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cariAdiBtn.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cariAdiBtn.Size = new System.Drawing.Size(164, 20);
            this.cariAdiBtn.TabIndex = 8;
            this.cariAdiBtn.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cariKodBtn_ButtonClick);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 331);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 13);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Müşteri Adı";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(11, 286);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(24, 13);
            this.labelControl8.TabIndex = 32;
            this.labelControl8.Text = "Şube";
            // 
            // SubelerLookUp
            // 
            this.SubelerLookUp.EditValue = "";
            this.SubelerLookUp.Location = new System.Drawing.Point(12, 305);
            this.SubelerLookUp.Name = "SubelerLookUp";
            this.SubelerLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SubelerLookUp.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubeAdi", "Şube Adı", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.SubelerLookUp.Properties.NullText = "";
            this.SubelerLookUp.Properties.PopupSizeable = false;
            this.SubelerLookUp.Size = new System.Drawing.Size(164, 20);
            this.SubelerLookUp.TabIndex = 7;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(11, 241);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(41, 13);
            this.labelControl7.TabIndex = 30;
            this.labelControl7.Text = "Personel";
            // 
            // personelLookUp
            // 
            this.personelLookUp.EditValue = "";
            this.personelLookUp.Location = new System.Drawing.Point(11, 260);
            this.personelLookUp.Name = "personelLookUp";
            this.personelLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.personelLookUp.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PersonelAdi", "Personel Adı", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.personelLookUp.Properties.NullText = "";
            this.personelLookUp.Properties.PopupSizeable = false;
            this.personelLookUp.Size = new System.Drawing.Size(164, 20);
            this.personelLookUp.TabIndex = 6;
            // 
            // IkinciFormTarih
            // 
            this.IkinciFormTarih.EditValue = null;
            this.IkinciFormTarih.Location = new System.Drawing.Point(96, 80);
            this.IkinciFormTarih.Name = "IkinciFormTarih";
            this.IkinciFormTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.IkinciFormTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.IkinciFormTarih.Properties.Mask.EditMask = "";
            this.IkinciFormTarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.IkinciFormTarih.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.IkinciFormTarih.Size = new System.Drawing.Size(79, 20);
            this.IkinciFormTarih.TabIndex = 1;
            // 
            // IlkFormTarih
            // 
            this.IlkFormTarih.EditValue = null;
            this.IlkFormTarih.Location = new System.Drawing.Point(11, 80);
            this.IlkFormTarih.Name = "IlkFormTarih";
            this.IlkFormTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.IlkFormTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.IlkFormTarih.Properties.Mask.EditMask = "";
            this.IlkFormTarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.IlkFormTarih.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.IlkFormTarih.Size = new System.Drawing.Size(79, 20);
            this.IlkFormTarih.TabIndex = 0;
            // 
            // comboUlasimSecenegi
            // 
            this.comboUlasimSecenegi.EditValue = "";
            this.comboUlasimSecenegi.Location = new System.Drawing.Point(11, 170);
            this.comboUlasimSecenegi.Name = "comboUlasimSecenegi";
            this.comboUlasimSecenegi.Properties.AutoComplete = false;
            this.comboUlasimSecenegi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboUlasimSecenegi.Properties.Items.AddRange(new object[] {
            "Reklam",
            "Tavsiye",
            "Yazılı Medya",
            "Broşür",
            "Seçilmedi",
            "Diğer"});
            this.comboUlasimSecenegi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboUlasimSecenegi.Size = new System.Drawing.Size(164, 20);
            this.comboUlasimSecenegi.TabIndex = 4;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(11, 196);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(80, 13);
            this.labelControl9.TabIndex = 22;
            this.labelControl9.Text = "Görüşme Sonucu";
            // 
            // comboGorusmeSonucu
            // 
            this.comboGorusmeSonucu.EditValue = "";
            this.comboGorusmeSonucu.Location = new System.Drawing.Point(11, 215);
            this.comboGorusmeSonucu.Name = "comboGorusmeSonucu";
            this.comboGorusmeSonucu.Properties.AutoComplete = false;
            this.comboGorusmeSonucu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboGorusmeSonucu.Properties.Items.AddRange(new object[] {
            "Olumlu",
            "Olumsuz",
            "Yorum Yok"});
            this.comboGorusmeSonucu.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboGorusmeSonucu.Size = new System.Drawing.Size(164, 20);
            this.comboGorusmeSonucu.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 13);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "Hizmet Türü";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(11, 151);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(76, 13);
            this.labelControl6.TabIndex = 23;
            this.labelControl6.Text = "Ulaşım Seçeneği";
            // 
            // IkinciAramaTarihi
            // 
            this.IkinciAramaTarihi.EditValue = null;
            this.IkinciAramaTarihi.Location = new System.Drawing.Point(96, 125);
            this.IkinciAramaTarihi.Name = "IkinciAramaTarihi";
            this.IkinciAramaTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.IkinciAramaTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.IkinciAramaTarihi.Properties.Mask.EditMask = "";
            this.IkinciAramaTarihi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.IkinciAramaTarihi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.IkinciAramaTarihi.Size = new System.Drawing.Size(79, 20);
            this.IkinciAramaTarihi.TabIndex = 3;
            // 
            // IlkAramaTarihi
            // 
            this.IlkAramaTarihi.EditValue = null;
            this.IlkAramaTarihi.Location = new System.Drawing.Point(11, 125);
            this.IlkAramaTarihi.Name = "IlkAramaTarihi";
            this.IlkAramaTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.IlkAramaTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.IlkAramaTarihi.Properties.Mask.EditMask = "";
            this.IlkAramaTarihi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.IlkAramaTarihi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.IlkAramaTarihi.Size = new System.Drawing.Size(79, 20);
            this.IlkAramaTarihi.TabIndex = 2;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(11, 106);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(98, 13);
            this.labelControl5.TabIndex = 24;
            this.labelControl5.Text = "Müşteri Arama Tarihi";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(11, 61);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(53, 13);
            this.labelControl4.TabIndex = 25;
            this.labelControl4.Text = "Form Tarihi";
            // 
            // HizmetLookup
            // 
            this.HizmetLookup.EditValue = "";
            this.HizmetLookup.Location = new System.Drawing.Point(11, 35);
            this.HizmetLookup.Name = "HizmetLookup";
            this.HizmetLookup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.HizmetLookup.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HizmetAdi", "Hizmet Adı", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.HizmetLookup.Properties.NullText = "";
            this.HizmetLookup.Properties.PopupSizeable = false;
            this.HizmetLookup.Size = new System.Drawing.Size(164, 20);
            this.HizmetLookup.TabIndex = 4;
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(618, 575);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniKayıtToolStripMenuItem,
            this.düzenleToolStripMenuItem,
            this.seçToolStripMenuItem,
            this.müşteriKartıToolStripMenuItem,
            this.excelAktarToolStripMenuItem,
            this.pDFAktarToolStripMenuItem,
            this.cSVAktarToolStripMenuItem,
            this.hTMLAktarToolStripMenuItem,
            this.resimOlarakKaydetToolStripMenuItem,
            this.yazdırToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(183, 224);
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
            // müşteriKartıToolStripMenuItem
            // 
            this.müşteriKartıToolStripMenuItem.Image = global::Hizmet_MusMemnuniyet.Properties.Resources.KullanıcıEkle;
            this.müşteriKartıToolStripMenuItem.Name = "müşteriKartıToolStripMenuItem";
            this.müşteriKartıToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.müşteriKartıToolStripMenuItem.Text = "Müşteri Kartı";
            this.müşteriKartıToolStripMenuItem.Click += new System.EventHandler(this.müşteriKartıToolStripMenuItem_Click);
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
            // yazdırToolStripMenuItem
            // 
            this.yazdırToolStripMenuItem.Image = global::Hizmet_MusMemnuniyet.Properties.Resources.indir;
            this.yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
            this.yazdırToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.yazdırToolStripMenuItem.Text = "Yazdır";
            this.yazdırToolStripMenuItem.Click += new System.EventHandler(this.yazdırToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridAnketID,
            this.gridNumara,
            this.gridAnketTarih,
            this.gridAramaTarih,
            this.gridAdSoyad,
            this.gridMID,
            this.gridGorusmeSonucu,
            this.gridUlasimSecenegi,
            this.gridSubeAdi,
            this.gridSID,
            this.gridPersonelAdi,
            this.gridPID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridAnketID
            // 
            this.gridAnketID.Caption = "AID";
            this.gridAnketID.FieldName = "AnketID";
            this.gridAnketID.Name = "gridAnketID";
            this.gridAnketID.Width = 30;
            // 
            // gridNumara
            // 
            this.gridNumara.Caption = "FORM NO";
            this.gridNumara.FieldName = "Numara";
            this.gridNumara.Name = "gridNumara";
            this.gridNumara.OptionsColumn.AllowEdit = false;
            this.gridNumara.OptionsColumn.AllowFocus = false;
            this.gridNumara.OptionsColumn.ReadOnly = true;
            this.gridNumara.Visible = true;
            this.gridNumara.VisibleIndex = 0;
            this.gridNumara.Width = 40;
            // 
            // gridAnketTarih
            // 
            this.gridAnketTarih.Caption = "ANKET TARİH";
            this.gridAnketTarih.FieldName = "AnketTarih";
            this.gridAnketTarih.Name = "gridAnketTarih";
            this.gridAnketTarih.OptionsColumn.AllowEdit = false;
            this.gridAnketTarih.OptionsColumn.AllowFocus = false;
            this.gridAnketTarih.OptionsColumn.ReadOnly = true;
            this.gridAnketTarih.Visible = true;
            this.gridAnketTarih.VisibleIndex = 1;
            // 
            // gridAramaTarih
            // 
            this.gridAramaTarih.Caption = "ARAMA TARİH";
            this.gridAramaTarih.FieldName = "AramaTarih";
            this.gridAramaTarih.Name = "gridAramaTarih";
            this.gridAramaTarih.OptionsColumn.AllowEdit = false;
            this.gridAramaTarih.OptionsColumn.AllowFocus = false;
            this.gridAramaTarih.OptionsColumn.ReadOnly = true;
            this.gridAramaTarih.Visible = true;
            this.gridAramaTarih.VisibleIndex = 2;
            // 
            // gridAdSoyad
            // 
            this.gridAdSoyad.Caption = "ADSOYAD";
            this.gridAdSoyad.FieldName = "AdSoyad";
            this.gridAdSoyad.Name = "gridAdSoyad";
            this.gridAdSoyad.OptionsColumn.AllowEdit = false;
            this.gridAdSoyad.OptionsColumn.AllowFocus = false;
            this.gridAdSoyad.OptionsColumn.ReadOnly = true;
            this.gridAdSoyad.Visible = true;
            this.gridAdSoyad.VisibleIndex = 3;
            this.gridAdSoyad.Width = 120;
            // 
            // gridMID
            // 
            this.gridMID.Caption = "MID";
            this.gridMID.FieldName = "MusteriID";
            this.gridMID.Name = "gridMID";
            this.gridMID.Width = 20;
            // 
            // gridGorusmeSonucu
            // 
            this.gridGorusmeSonucu.Caption = "GÖRÜŞME SONUCU";
            this.gridGorusmeSonucu.FieldName = "GorusmeSonucu";
            this.gridGorusmeSonucu.Name = "gridGorusmeSonucu";
            this.gridGorusmeSonucu.OptionsColumn.AllowEdit = false;
            this.gridGorusmeSonucu.OptionsColumn.AllowFocus = false;
            this.gridGorusmeSonucu.OptionsColumn.ReadOnly = true;
            this.gridGorusmeSonucu.Visible = true;
            this.gridGorusmeSonucu.VisibleIndex = 4;
            // 
            // gridUlasimSecenegi
            // 
            this.gridUlasimSecenegi.Caption = "ULAŞIM SEÇENEĞİ";
            this.gridUlasimSecenegi.FieldName = "UlasimSecenegi";
            this.gridUlasimSecenegi.Name = "gridUlasimSecenegi";
            this.gridUlasimSecenegi.OptionsColumn.AllowEdit = false;
            this.gridUlasimSecenegi.OptionsColumn.AllowFocus = false;
            this.gridUlasimSecenegi.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.gridUlasimSecenegi.OptionsColumn.ReadOnly = true;
            this.gridUlasimSecenegi.Visible = true;
            this.gridUlasimSecenegi.VisibleIndex = 5;
            // 
            // gridSubeAdi
            // 
            this.gridSubeAdi.Caption = "ŞUBE ADI";
            this.gridSubeAdi.FieldName = "SubeAdi";
            this.gridSubeAdi.Name = "gridSubeAdi";
            this.gridSubeAdi.OptionsColumn.AllowEdit = false;
            this.gridSubeAdi.OptionsColumn.AllowFocus = false;
            this.gridSubeAdi.OptionsColumn.ReadOnly = true;
            this.gridSubeAdi.Visible = true;
            this.gridSubeAdi.VisibleIndex = 6;
            this.gridSubeAdi.Width = 70;
            // 
            // gridSID
            // 
            this.gridSID.Caption = "SID";
            this.gridSID.FieldName = "SubeID";
            this.gridSID.Name = "gridSID";
            this.gridSID.Width = 20;
            // 
            // gridPersonelAdi
            // 
            this.gridPersonelAdi.Caption = "PERSONEL";
            this.gridPersonelAdi.FieldName = "PersonelAdi";
            this.gridPersonelAdi.Name = "gridPersonelAdi";
            this.gridPersonelAdi.OptionsColumn.AllowEdit = false;
            this.gridPersonelAdi.OptionsColumn.AllowFocus = false;
            this.gridPersonelAdi.OptionsColumn.ReadOnly = true;
            this.gridPersonelAdi.Visible = true;
            this.gridPersonelAdi.VisibleIndex = 7;
            this.gridPersonelAdi.Width = 70;
            // 
            // gridPID
            // 
            this.gridPID.Caption = "PID";
            this.gridPID.FieldName = "PersonID";
            this.gridPID.Name = "gridPID";
            this.gridPID.Width = 20;
            // 
            // frmFormListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 575);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmFormListesi";
            this.Text = "Form Listesi";
            this.Load += new System.EventHandler(this.frmFormListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cariAdiBtn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubelerLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IkinciFormTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IkinciFormTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IlkFormTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IlkFormTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboUlasimSecenegi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboGorusmeSonucu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IkinciAramaTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IkinciAramaTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IlkAramaTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IlkAramaTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HizmetLookup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainerControl splitContainerControl1;
        private XtraTabControl xtraTabControl1;
        private XtraTabPage xtraTabPage1;
        private DateEdit IkinciFormTarih;
        private DateEdit IlkFormTarih;
        private ComboBoxEdit comboUlasimSecenegi;
        private LabelControl labelControl9;
        private ComboBoxEdit comboGorusmeSonucu;
        private LabelControl labelControl6;
        private DateEdit IkinciAramaTarihi;
        private DateEdit IlkAramaTarihi;
        private LabelControl labelControl5;
        private LabelControl labelControl4;
        private LabelControl labelControl7;
        private LookUpEdit personelLookUp;
        private LabelControl labelControl8;
        private LookUpEdit SubelerLookUp;
        private ButtonEdit cariAdiBtn;
        private LabelControl labelControl2;
        private SimpleButton TemizleBtn;
        private SimpleButton AramaBtn;
        private GridControl gridControl1;
        private GridView gridView1;
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
        private ToolStripMenuItem müşteriKartıToolStripMenuItem;
        private GridColumn gridAnketID;
        private GridColumn gridNumara;
        private GridColumn gridAnketTarih;
        private GridColumn gridAramaTarih;
        private GridColumn gridAdSoyad;
        private GridColumn gridMID;
        private GridColumn gridGorusmeSonucu;
        private GridColumn gridUlasimSecenegi;
        private GridColumn gridSubeAdi;
        private GridColumn gridSID;
        private GridColumn gridPersonelAdi;
        private GridColumn gridPID;
        private ToolStripMenuItem seçToolStripMenuItem;
        private ToolStripMenuItem yazdırToolStripMenuItem;
        private LabelControl labelControl1;
        private LookUpEdit HizmetLookup;
    }
}