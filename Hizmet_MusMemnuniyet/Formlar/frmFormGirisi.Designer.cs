using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace Hizmet_MusMemnuniyet.Formlar
{
    partial class frmFormGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormGirisi));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.FormListesiBtn = new DevExpress.XtraEditors.SimpleButton();
            this.cariAdiBtn = new DevExpress.XtraEditors.ButtonEdit();
            this.txtTarih = new DevExpress.XtraEditors.DateEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.comboUlasimSecenegi = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtTlf = new DevExpress.XtraEditors.TextEdit();
            this.txtcepTlf = new DevExpress.XtraEditors.TextEdit();
            this.comboGorusmeSonucu = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtFormNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtAramaTarihi = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.HizmetlookUp = new DevExpress.XtraEditors.LookUpEdit();
            this.SubelerLookUp = new DevExpress.XtraEditors.LookUpEdit();
            this.personelLookUp = new DevExpress.XtraEditors.LookUpEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.OlumlugridControl = new DevExpress.XtraGrid.GridControl();
            this.OlumluGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Olumlu_KatID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Olumlu_KatAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Olumlu_AnaKatAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Olumlu_Aktif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.olumluKatEditBtn = new DevExpress.XtraEditors.ButtonEdit();
            this.olumlukatEkleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.OlumsuzgridControl = new DevExpress.XtraGrid.GridControl();
            this.OlumsuzgridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID_Olumsuz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ad_Olumsuz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AnaAd_Olumsuz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Olumsuz_aktif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.olumsuzKatEditBtn = new DevExpress.XtraEditors.ButtonEdit();
            this.olumsuzkatEkleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.KapatBtn = new DevExpress.XtraEditors.SimpleButton();
            this.SilBtn = new DevExpress.XtraEditors.SimpleButton();
            this.KaydetBtn = new DevExpress.XtraEditors.SimpleButton();
            this.dx1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.dx2 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.dx3 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.dx4 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.dx5 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtmusteriyorumu = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtAnketRaporu = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cariAdiBtn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboUlasimSecenegi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTlf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcepTlf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboGorusmeSonucu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAramaTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAramaTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HizmetlookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubelerLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OlumlugridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OlumluGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olumluKatEditBtn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OlumsuzgridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OlumsuzgridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olumsuzKatEditBtn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dx4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dx5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmusteriyorumu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnketRaporu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupControl1.Controls.Add(this.FormListesiBtn);
            this.groupControl1.Controls.Add(this.cariAdiBtn);
            this.groupControl1.Controls.Add(this.txtTarih);
            this.groupControl1.Controls.Add(this.labelControl13);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.comboUlasimSecenegi);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.txtTlf);
            this.groupControl1.Controls.Add(this.txtcepTlf);
            this.groupControl1.Controls.Add(this.comboGorusmeSonucu);
            this.groupControl1.Controls.Add(this.txtFormNo);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtAramaTarihi);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.HizmetlookUp);
            this.groupControl1.Controls.Add(this.SubelerLookUp);
            this.groupControl1.Controls.Add(this.personelLookUp);
            this.groupControl1.Location = new System.Drawing.Point(8, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(766, 147);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Müşteri Bilgileri";
            // 
            // FormListesiBtn
            // 
            this.FormListesiBtn.Image = global::Hizmet_MusMemnuniyet.Properties.Resources.zoom_in;
            this.FormListesiBtn.Location = new System.Drawing.Point(243, 29);
            this.FormListesiBtn.Name = "FormListesiBtn";
            this.FormListesiBtn.Size = new System.Drawing.Size(25, 23);
            this.FormListesiBtn.TabIndex = 22;
            this.FormListesiBtn.Click += new System.EventHandler(this.FormListesiBtn_Click);
            // 
            // cariAdiBtn
            // 
            this.cariAdiBtn.Location = new System.Drawing.Point(89, 57);
            this.cariAdiBtn.Name = "cariAdiBtn";
            this.cariAdiBtn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cariAdiBtn.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cariAdiBtn.Size = new System.Drawing.Size(148, 20);
            this.cariAdiBtn.TabIndex = 17;
            this.cariAdiBtn.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cariKodBtn_ButtonClick);
            // 
            // txtTarih
            // 
            this.txtTarih.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTarih.EditValue = null;
            this.txtTarih.Location = new System.Drawing.Point(610, 31);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.Mask.EditMask = "";
            this.txtTarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtTarih.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtTarih.Size = new System.Drawing.Size(144, 20);
            this.txtTarih.TabIndex = 19;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(253, 60);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(32, 13);
            this.labelControl13.TabIndex = 9;
            this.labelControl13.Text = "Hizmet";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(253, 112);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(24, 13);
            this.labelControl8.TabIndex = 9;
            this.labelControl8.Text = "Şube";
            // 
            // comboUlasimSecenegi
            // 
            this.comboUlasimSecenegi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboUlasimSecenegi.EditValue = "";
            this.comboUlasimSecenegi.Location = new System.Drawing.Point(610, 83);
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
            this.comboUlasimSecenegi.Size = new System.Drawing.Size(144, 20);
            this.comboUlasimSecenegi.TabIndex = 21;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 112);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(41, 13);
            this.labelControl7.TabIndex = 9;
            this.labelControl7.Text = "Personel";
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl9.Location = new System.Drawing.Point(494, 112);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(80, 13);
            this.labelControl9.TabIndex = 9;
            this.labelControl9.Text = "Görüşme Sonucu";
            // 
            // txtTlf
            // 
            this.txtTlf.Location = new System.Drawing.Point(295, 83);
            this.txtTlf.Name = "txtTlf";
            this.txtTlf.Properties.ReadOnly = true;
            this.txtTlf.Size = new System.Drawing.Size(144, 20);
            this.txtTlf.TabIndex = 18;
            // 
            // txtcepTlf
            // 
            this.txtcepTlf.Location = new System.Drawing.Point(89, 83);
            this.txtcepTlf.Name = "txtcepTlf";
            this.txtcepTlf.Properties.ReadOnly = true;
            this.txtcepTlf.Size = new System.Drawing.Size(144, 20);
            this.txtcepTlf.TabIndex = 18;
            // 
            // comboGorusmeSonucu
            // 
            this.comboGorusmeSonucu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboGorusmeSonucu.EditValue = "";
            this.comboGorusmeSonucu.Location = new System.Drawing.Point(610, 109);
            this.comboGorusmeSonucu.Name = "comboGorusmeSonucu";
            this.comboGorusmeSonucu.Properties.AutoComplete = false;
            this.comboGorusmeSonucu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboGorusmeSonucu.Properties.Items.AddRange(new object[] {
            "Olumlu",
            "Olumsuz",
            "Yorum Yok"});
            this.comboGorusmeSonucu.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboGorusmeSonucu.Size = new System.Drawing.Size(144, 20);
            this.comboGorusmeSonucu.TabIndex = 21;
            // 
            // txtFormNo
            // 
            this.txtFormNo.Location = new System.Drawing.Point(89, 31);
            this.txtFormNo.Name = "txtFormNo";
            this.txtFormNo.Size = new System.Drawing.Size(148, 20);
            this.txtFormNo.TabIndex = 8;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(253, 86);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(36, 13);
            this.labelControl10.TabIndex = 13;
            this.labelControl10.Text = "Telefon";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl6.Location = new System.Drawing.Point(494, 86);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(76, 13);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "Ulaşım Seçeneği";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 86);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(58, 13);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Cep Telefon";
            // 
            // txtAramaTarihi
            // 
            this.txtAramaTarihi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAramaTarihi.EditValue = null;
            this.txtAramaTarihi.Location = new System.Drawing.Point(610, 57);
            this.txtAramaTarihi.Name = "txtAramaTarihi";
            this.txtAramaTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtAramaTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtAramaTarihi.Properties.Mask.EditMask = "";
            this.txtAramaTarihi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtAramaTarihi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtAramaTarihi.Size = new System.Drawing.Size(144, 20);
            this.txtAramaTarihi.TabIndex = 20;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 60);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 13);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Müşteri Adı";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl5.Location = new System.Drawing.Point(494, 60);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(98, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Müşteri Arama Tarihi";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 13);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Form Numarası";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl4.Location = new System.Drawing.Point(494, 34);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(53, 13);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Form Tarihi";
            // 
            // HizmetlookUp
            // 
            this.HizmetlookUp.EditValue = "Fatura Türü";
            this.HizmetlookUp.Location = new System.Drawing.Point(295, 57);
            this.HizmetlookUp.Name = "HizmetlookUp";
            this.HizmetlookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.HizmetlookUp.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HizmetAdi", "", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.True)});
            this.HizmetlookUp.Properties.NullText = "";
            this.HizmetlookUp.Properties.PopupSizeable = false;
            this.HizmetlookUp.Size = new System.Drawing.Size(144, 20);
            this.HizmetlookUp.TabIndex = 21;
            // 
            // SubelerLookUp
            // 
            this.SubelerLookUp.EditValue = "Fatura Türü";
            this.SubelerLookUp.Location = new System.Drawing.Point(295, 109);
            this.SubelerLookUp.Name = "SubelerLookUp";
            this.SubelerLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SubelerLookUp.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubeAdi", "", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.True)});
            this.SubelerLookUp.Properties.NullText = "";
            this.SubelerLookUp.Properties.PopupSizeable = false;
            this.SubelerLookUp.Size = new System.Drawing.Size(144, 20);
            this.SubelerLookUp.TabIndex = 21;
            // 
            // personelLookUp
            // 
            this.personelLookUp.EditValue = "Fatura Türü";
            this.personelLookUp.Location = new System.Drawing.Point(89, 109);
            this.personelLookUp.Name = "personelLookUp";
            this.personelLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.personelLookUp.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PersonelAdi", "", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.True)});
            this.personelLookUp.Properties.NullText = "";
            this.personelLookUp.Properties.PopupSizeable = false;
            this.personelLookUp.Size = new System.Drawing.Size(144, 20);
            this.personelLookUp.TabIndex = 21;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupControl2.Controls.Add(this.OlumlugridControl);
            this.groupControl2.Controls.Add(this.olumluKatEditBtn);
            this.groupControl2.Controls.Add(this.olumlukatEkleBtn);
            this.groupControl2.Location = new System.Drawing.Point(8, 165);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(380, 263);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Olumlu Seçimler";
            // 
            // OlumlugridControl
            // 
            this.OlumlugridControl.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.OlumlugridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.OlumlugridControl.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.OlumlugridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.OlumlugridControl.Location = new System.Drawing.Point(2, 48);
            this.OlumlugridControl.MainView = this.OlumluGridView;
            this.OlumlugridControl.Name = "OlumlugridControl";
            this.OlumlugridControl.Size = new System.Drawing.Size(376, 213);
            this.OlumlugridControl.TabIndex = 0;
            this.OlumlugridControl.UseEmbeddedNavigator = true;
            this.OlumlugridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.OlumluGridView});
            // 
            // OlumluGridView
            // 
            this.OlumluGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Olumlu_KatID,
            this.Olumlu_KatAd,
            this.Olumlu_AnaKatAd,
            this.Olumlu_Aktif});
            this.OlumluGridView.GridControl = this.OlumlugridControl;
            this.OlumluGridView.Name = "OlumluGridView";
            this.OlumluGridView.OptionsView.ShowGroupPanel = false;
            this.OlumluGridView.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.OlumluGridView_ShowingEditor);
            this.OlumluGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.OlumluGridView_InitNewRow);
            this.OlumluGridView.RowCountChanged += new System.EventHandler(this.OlumluGridView_RowCountChanged);
            // 
            // Olumlu_KatID
            // 
            this.Olumlu_KatID.Caption = "ID";
            this.Olumlu_KatID.FieldName = "KategoriID";
            this.Olumlu_KatID.Name = "Olumlu_KatID";
            // 
            // Olumlu_KatAd
            // 
            this.Olumlu_KatAd.Caption = "KATEGORİ";
            this.Olumlu_KatAd.FieldName = "Ad";
            this.Olumlu_KatAd.Name = "Olumlu_KatAd";
            this.Olumlu_KatAd.OptionsColumn.FixedWidth = true;
            this.Olumlu_KatAd.OptionsColumn.ReadOnly = true;
            this.Olumlu_KatAd.Visible = true;
            this.Olumlu_KatAd.VisibleIndex = 0;
            this.Olumlu_KatAd.Width = 288;
            // 
            // Olumlu_AnaKatAd
            // 
            this.Olumlu_AnaKatAd.Caption = "ANA KATEGORİ";
            this.Olumlu_AnaKatAd.FieldName = "AnaAd";
            this.Olumlu_AnaKatAd.Name = "Olumlu_AnaKatAd";
            this.Olumlu_AnaKatAd.OptionsColumn.FixedWidth = true;
            this.Olumlu_AnaKatAd.OptionsColumn.ReadOnly = true;
            this.Olumlu_AnaKatAd.Visible = true;
            this.Olumlu_AnaKatAd.VisibleIndex = 1;
            this.Olumlu_AnaKatAd.Width = 150;
            // 
            // Olumlu_Aktif
            // 
            this.Olumlu_Aktif.Caption = "Aktif";
            this.Olumlu_Aktif.FieldName = "IsActive";
            this.Olumlu_Aktif.Name = "Olumlu_Aktif";
            this.Olumlu_Aktif.Width = 25;
            // 
            // olumluKatEditBtn
            // 
            this.olumluKatEditBtn.Location = new System.Drawing.Point(2, 23);
            this.olumluKatEditBtn.Name = "olumluKatEditBtn";
            this.olumluKatEditBtn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.olumluKatEditBtn.Properties.ReadOnly = true;
            this.olumluKatEditBtn.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.olumluKatEditBtn.Size = new System.Drawing.Size(305, 20);
            this.olumluKatEditBtn.TabIndex = 17;
            this.olumluKatEditBtn.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.OlumluKategoriSecBtn_ButtonClick);
            // 
            // olumlukatEkleBtn
            // 
            this.olumlukatEkleBtn.Image = ((System.Drawing.Image)(resources.GetObject("olumlukatEkleBtn.Image")));
            this.olumlukatEkleBtn.Location = new System.Drawing.Point(313, 23);
            this.olumlukatEkleBtn.Name = "olumlukatEkleBtn";
            this.olumlukatEkleBtn.Size = new System.Drawing.Size(65, 21);
            this.olumlukatEkleBtn.TabIndex = 7;
            this.olumlukatEkleBtn.Text = "Ekle";
            this.olumlukatEkleBtn.Click += new System.EventHandler(this.olumlukatEkleBtn_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupControl3.Controls.Add(this.OlumsuzgridControl);
            this.groupControl3.Controls.Add(this.olumsuzKatEditBtn);
            this.groupControl3.Controls.Add(this.olumsuzkatEkleBtn);
            this.groupControl3.Location = new System.Drawing.Point(394, 165);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(380, 263);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "Olumsuz Seçimler";
            // 
            // OlumsuzgridControl
            // 
            this.OlumsuzgridControl.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.OlumsuzgridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.OlumsuzgridControl.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.OlumsuzgridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.OlumsuzgridControl.Location = new System.Drawing.Point(2, 48);
            this.OlumsuzgridControl.MainView = this.OlumsuzgridView;
            this.OlumsuzgridControl.Name = "OlumsuzgridControl";
            this.OlumsuzgridControl.Size = new System.Drawing.Size(376, 213);
            this.OlumsuzgridControl.TabIndex = 1;
            this.OlumsuzgridControl.UseEmbeddedNavigator = true;
            this.OlumsuzgridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.OlumsuzgridView});
            // 
            // OlumsuzgridView
            // 
            this.OlumsuzgridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID_Olumsuz,
            this.Ad_Olumsuz,
            this.AnaAd_Olumsuz,
            this.Olumsuz_aktif});
            this.OlumsuzgridView.GridControl = this.OlumsuzgridControl;
            this.OlumsuzgridView.Name = "OlumsuzgridView";
            this.OlumsuzgridView.OptionsView.ShowGroupPanel = false;
            this.OlumsuzgridView.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.OlumsuzgridView_ShowingEditor);
            this.OlumsuzgridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.OlumsuzgridView_InitNewRow);
            this.OlumsuzgridView.RowCountChanged += new System.EventHandler(this.OlumsuzgridView_RowCountChanged);
            // 
            // ID_Olumsuz
            // 
            this.ID_Olumsuz.Caption = "ID";
            this.ID_Olumsuz.FieldName = "KategoriID";
            this.ID_Olumsuz.Name = "ID_Olumsuz";
            // 
            // Ad_Olumsuz
            // 
            this.Ad_Olumsuz.Caption = "KATEGORİ";
            this.Ad_Olumsuz.FieldName = "Ad";
            this.Ad_Olumsuz.Name = "Ad_Olumsuz";
            this.Ad_Olumsuz.OptionsColumn.FixedWidth = true;
            this.Ad_Olumsuz.OptionsColumn.ReadOnly = true;
            this.Ad_Olumsuz.Visible = true;
            this.Ad_Olumsuz.VisibleIndex = 0;
            this.Ad_Olumsuz.Width = 288;
            // 
            // AnaAd_Olumsuz
            // 
            this.AnaAd_Olumsuz.Caption = "ANA KATEGORİ";
            this.AnaAd_Olumsuz.FieldName = "AnaAd";
            this.AnaAd_Olumsuz.Name = "AnaAd_Olumsuz";
            this.AnaAd_Olumsuz.OptionsColumn.FixedWidth = true;
            this.AnaAd_Olumsuz.OptionsColumn.ReadOnly = true;
            this.AnaAd_Olumsuz.Visible = true;
            this.AnaAd_Olumsuz.VisibleIndex = 1;
            this.AnaAd_Olumsuz.Width = 150;
            // 
            // Olumsuz_aktif
            // 
            this.Olumsuz_aktif.Caption = "Aktif";
            this.Olumsuz_aktif.FieldName = "IsActive";
            this.Olumsuz_aktif.Name = "Olumsuz_aktif";
            this.Olumsuz_aktif.Width = 25;
            // 
            // olumsuzKatEditBtn
            // 
            this.olumsuzKatEditBtn.Location = new System.Drawing.Point(0, 23);
            this.olumsuzKatEditBtn.Name = "olumsuzKatEditBtn";
            this.olumsuzKatEditBtn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.olumsuzKatEditBtn.Properties.ReadOnly = true;
            this.olumsuzKatEditBtn.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.olumsuzKatEditBtn.Size = new System.Drawing.Size(305, 20);
            this.olumsuzKatEditBtn.TabIndex = 17;
            this.olumsuzKatEditBtn.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.OlumsuzKategoriSecBtn_ButtonClick);
            // 
            // olumsuzkatEkleBtn
            // 
            this.olumsuzkatEkleBtn.Image = ((System.Drawing.Image)(resources.GetObject("olumsuzkatEkleBtn.Image")));
            this.olumsuzkatEkleBtn.Location = new System.Drawing.Point(315, 23);
            this.olumsuzkatEkleBtn.Name = "olumsuzkatEkleBtn";
            this.olumsuzkatEkleBtn.Size = new System.Drawing.Size(63, 21);
            this.olumsuzkatEkleBtn.TabIndex = 7;
            this.olumsuzkatEkleBtn.Text = "Ekle";
            this.olumsuzkatEkleBtn.Click += new System.EventHandler(this.olumsuzkatEkleBtn_Click);
            // 
            // KapatBtn
            // 
            this.KapatBtn.Image = ((System.Drawing.Image)(resources.GetObject("KapatBtn.Image")));
            this.KapatBtn.Location = new System.Drawing.Point(697, 516);
            this.KapatBtn.Name = "KapatBtn";
            this.KapatBtn.Size = new System.Drawing.Size(75, 23);
            this.KapatBtn.TabIndex = 7;
            this.KapatBtn.Text = "Kapat";
            this.KapatBtn.Click += new System.EventHandler(this.KapatBtn_Click);
            // 
            // SilBtn
            // 
            this.SilBtn.Enabled = false;
            this.SilBtn.Image = ((System.Drawing.Image)(resources.GetObject("SilBtn.Image")));
            this.SilBtn.Location = new System.Drawing.Point(616, 516);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(75, 23);
            this.SilBtn.TabIndex = 6;
            this.SilBtn.Text = "Sil";
            this.SilBtn.Click += new System.EventHandler(this.SilBtn_Click);
            // 
            // KaydetBtn
            // 
            this.KaydetBtn.Image = ((System.Drawing.Image)(resources.GetObject("KaydetBtn.Image")));
            this.KaydetBtn.Location = new System.Drawing.Point(535, 516);
            this.KaydetBtn.Name = "KaydetBtn";
            this.KaydetBtn.Size = new System.Drawing.Size(75, 23);
            this.KaydetBtn.TabIndex = 5;
            this.KaydetBtn.Text = "Kaydet";
            this.KaydetBtn.Click += new System.EventHandler(this.KaydetBtn_Click);
            // 
            // dx1
            // 
            this.dx1.ContainerControl = this;
            // 
            // dx2
            // 
            this.dx2.ContainerControl = this;
            // 
            // dx3
            // 
            this.dx3.ContainerControl = this;
            // 
            // dx4
            // 
            this.dx4.ContainerControl = this;
            // 
            // dx5
            // 
            this.dx5.ContainerControl = this;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(10, 436);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(74, 13);
            this.labelControl11.TabIndex = 13;
            this.labelControl11.Text = "Müşteri Yorumu";
            // 
            // txtmusteriyorumu
            // 
            this.txtmusteriyorumu.Location = new System.Drawing.Point(100, 434);
            this.txtmusteriyorumu.Name = "txtmusteriyorumu";
            this.txtmusteriyorumu.Size = new System.Drawing.Size(286, 68);
            this.txtmusteriyorumu.TabIndex = 14;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(396, 434);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(62, 13);
            this.labelControl12.TabIndex = 13;
            this.labelControl12.Text = "Form Raporu";
            // 
            // txtAnketRaporu
            // 
            this.txtAnketRaporu.Location = new System.Drawing.Point(486, 432);
            this.txtAnketRaporu.Name = "txtAnketRaporu";
            this.txtAnketRaporu.Size = new System.Drawing.Size(286, 68);
            this.txtAnketRaporu.TabIndex = 14;
            // 
            // frmFormGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 542);
            this.Controls.Add(this.txtAnketRaporu);
            this.Controls.Add(this.txtmusteriyorumu);
            this.Controls.Add(this.KapatBtn);
            this.Controls.Add(this.SilBtn);
            this.Controls.Add(this.KaydetBtn);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFormGirisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Form Kayıt";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFormGirisi_FormClosed);
            this.Load += new System.EventHandler(this.frmFormGirisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cariAdiBtn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboUlasimSecenegi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTlf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcepTlf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboGorusmeSonucu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAramaTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAramaTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HizmetlookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubelerLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OlumlugridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OlumluGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olumluKatEditBtn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OlumsuzgridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OlumsuzgridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olumsuzKatEditBtn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dx4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dx5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmusteriyorumu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnketRaporu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupControl groupControl1;
        private SimpleButton FormListesiBtn;
        private ButtonEdit cariAdiBtn;
        private LabelControl labelControl7;
        private LabelControl labelControl6;
        private LabelControl labelControl5;
        private TextEdit txtcepTlf;
        private LabelControl labelControl4;
        private TextEdit txtFormNo;
        private LabelControl labelControl3;
        private LabelControl labelControl2;
        private LabelControl labelControl1;
        private DateEdit txtTarih;
        private DateEdit txtAramaTarihi;
        private ComboBoxEdit comboUlasimSecenegi;
        private LabelControl labelControl8;
        private LabelControl labelControl9;
        private ComboBoxEdit comboGorusmeSonucu;
        private LookUpEdit SubelerLookUp;
        private LookUpEdit personelLookUp;
        private GroupControl groupControl2;
        private GridControl OlumlugridControl;
        private GridView OlumluGridView;
        private GridColumn Olumlu_KatID;
        private GridColumn Olumlu_KatAd;
        private GridColumn Olumlu_AnaKatAd;
        private GridColumn Olumlu_Aktif;
        private GroupControl groupControl3;
        private SimpleButton KapatBtn;
        private SimpleButton SilBtn;
        private SimpleButton KaydetBtn;
        private TextEdit txtTlf;
        private LabelControl labelControl10;
        private DXErrorProvider dx1;
        private DXErrorProvider dx2;
        private DXErrorProvider dx3;
        private DXErrorProvider dx4;
        private DXErrorProvider dx5;
        private MemoEdit txtAnketRaporu;
        private MemoEdit txtmusteriyorumu;
        private LabelControl labelControl12;
        private LabelControl labelControl11;
        private LabelControl labelControl13;
        private LookUpEdit HizmetlookUp;
        private GridControl OlumsuzgridControl;
        private GridView OlumsuzgridView;
        private GridColumn ID_Olumsuz;
        private GridColumn Ad_Olumsuz;
        private GridColumn AnaAd_Olumsuz;
        private GridColumn Olumsuz_aktif;
        private ButtonEdit olumluKatEditBtn;
        private SimpleButton olumlukatEkleBtn;
        private ButtonEdit olumsuzKatEditBtn;
        private SimpleButton olumsuzkatEkleBtn;
    }
}