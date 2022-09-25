using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace Hizmet_MusMemnuniyet.Personel
{
    partial class frmPersonelListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonelListesi));
            this.SID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PERID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SUBE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yeniKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excel2007AktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excel2013AktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hTMLAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resimOlarakKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.KapatBtn = new DevExpress.XtraEditors.SimpleButton();
            this.AraBtn = new DevExpress.XtraEditors.SimpleButton();
            this.SubeLookUp = new DevExpress.XtraEditors.LookUpEdit();
            this.AdSoyadBox = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubeLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdSoyadBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SID
            // 
            this.SID.Caption = "ŞUBE ID";
            this.SID.FieldName = "SubeID";
            this.SID.Name = "SID";
            // 
            // ADI
            // 
            this.ADI.Caption = "AD SOYAD";
            this.ADI.FieldName = "AdSoyad";
            this.ADI.Name = "ADI";
            this.ADI.OptionsColumn.AllowEdit = false;
            this.ADI.OptionsColumn.AllowFocus = false;
            this.ADI.OptionsColumn.ReadOnly = true;
            this.ADI.Visible = true;
            this.ADI.VisibleIndex = 0;
            this.ADI.Width = 150;
            // 
            // PERID
            // 
            this.PERID.Caption = "ID";
            this.PERID.FieldName = "PersonelID";
            this.PERID.Name = "PERID";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PERID,
            this.ADI,
            this.SUBE,
            this.SID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // SUBE
            // 
            this.SUBE.Caption = "ŞUBE ADI";
            this.SUBE.FieldName = "SubeAdi";
            this.SUBE.Name = "SUBE";
            this.SUBE.OptionsColumn.AllowEdit = false;
            this.SUBE.OptionsColumn.AllowFocus = false;
            this.SUBE.OptionsColumn.ReadOnly = true;
            this.SUBE.Visible = true;
            this.SUBE.VisibleIndex = 1;
            this.SUBE.Width = 156;
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(425, 353);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniKayıtToolStripMenuItem,
            this.düzenleToolStripMenuItem,
            this.excelAktarToolStripMenuItem,
            this.pDFAktarToolStripMenuItem,
            this.cSVAktarToolStripMenuItem,
            this.hTMLAktarToolStripMenuItem,
            this.resimOlarakKaydetToolStripMenuItem,
            this.yazdırToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(183, 202);
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
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Location = new System.Drawing.Point(13, 101);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(429, 375);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Personel Listesi";
            // 
            // KapatBtn
            // 
            this.KapatBtn.Image = ((System.Drawing.Image)(resources.GetObject("KapatBtn.Image")));
            this.KapatBtn.Location = new System.Drawing.Point(152, 50);
            this.KapatBtn.Name = "KapatBtn";
            this.KapatBtn.Size = new System.Drawing.Size(75, 23);
            this.KapatBtn.TabIndex = 3;
            this.KapatBtn.Text = "Kapat";
            this.KapatBtn.Click += new System.EventHandler(this.KapatBtn_Click);
            // 
            // AraBtn
            // 
            this.AraBtn.Image = ((System.Drawing.Image)(resources.GetObject("AraBtn.Image")));
            this.AraBtn.Location = new System.Drawing.Point(71, 50);
            this.AraBtn.Name = "AraBtn";
            this.AraBtn.Size = new System.Drawing.Size(75, 23);
            this.AraBtn.TabIndex = 2;
            this.AraBtn.Text = "Arama";
            this.AraBtn.Click += new System.EventHandler(this.AraBtn_Click);
            // 
            // SubeLookUp
            // 
            this.SubeLookUp.Location = new System.Drawing.Point(263, 24);
            this.SubeLookUp.Name = "SubeLookUp";
            this.SubeLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SubeLookUp.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubeAdi", "", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.True)});
            this.SubeLookUp.Properties.NullText = "";
            this.SubeLookUp.Size = new System.Drawing.Size(146, 20);
            this.SubeLookUp.TabIndex = 1;
            // 
            // AdSoyadBox
            // 
            this.AdSoyadBox.Location = new System.Drawing.Point(71, 24);
            this.AdSoyadBox.Name = "AdSoyadBox";
            this.AdSoyadBox.Size = new System.Drawing.Size(149, 20);
            this.AdSoyadBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şube";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.KapatBtn);
            this.groupControl1.Controls.Add(this.AraBtn);
            this.groupControl1.Controls.Add(this.SubeLookUp);
            this.groupControl1.Controls.Add(this.AdSoyadBox);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(13, 9);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(429, 86);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Arama";
            // 
            // yazdırToolStripMenuItem
            // 
            this.yazdırToolStripMenuItem.Image = global::Hizmet_MusMemnuniyet.Properties.Resources.indir;
            this.yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
            this.yazdırToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.yazdırToolStripMenuItem.Text = "Yazdır";
            this.yazdırToolStripMenuItem.Click += new System.EventHandler(this.yazdırToolStripMenuItem_Click);
            // 
            // frmPersonelListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 488);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPersonelListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Listesi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPersonelListesi_FormClosed);
            this.Load += new System.EventHandler(this.frmPersonelListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SubeLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdSoyadBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GridColumn SID;
        private GridColumn ADI;
        private GridColumn PERID;
        private GridView gridView1;
        private GridColumn SUBE;
        private GridControl gridControl1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem düzenleToolStripMenuItem;
        private GroupControl groupControl2;
        private SimpleButton KapatBtn;
        private SimpleButton AraBtn;
        private LookUpEdit SubeLookUp;
        private TextEdit AdSoyadBox;
        private Label label2;
        private Label label1;
        private GroupControl groupControl1;
        private ToolStripMenuItem yeniKayıtToolStripMenuItem;
        private ToolStripMenuItem excelAktarToolStripMenuItem;
        private ToolStripMenuItem excel2007AktarToolStripMenuItem;
        private ToolStripMenuItem excel2013AktarToolStripMenuItem;
        private ToolStripMenuItem pDFAktarToolStripMenuItem;
        private ToolStripMenuItem cSVAktarToolStripMenuItem;
        private ToolStripMenuItem hTMLAktarToolStripMenuItem;
        private ToolStripMenuItem resimOlarakKaydetToolStripMenuItem;
        private ToolStripMenuItem yazdırToolStripMenuItem;
    }
}