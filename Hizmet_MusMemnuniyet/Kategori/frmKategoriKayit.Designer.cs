using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace Hizmet_MusMemnuniyet.Kategori
{
    partial class frmKategoriKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKategoriKayit));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.KapatBtn = new DevExpress.XtraEditors.SimpleButton();
            this.SilBtn = new DevExpress.XtraEditors.SimpleButton();
            this.KaydetBtn = new DevExpress.XtraEditors.SimpleButton();
            this.AnaKategoriLookUp = new DevExpress.XtraEditors.LookUpEdit();
            this.KategoriAdBox = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.KATID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ANA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AKID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.dxErrorProvider2 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnaKategoriLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KategoriAdBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.KapatBtn);
            this.groupControl1.Controls.Add(this.SilBtn);
            this.groupControl1.Controls.Add(this.KaydetBtn);
            this.groupControl1.Controls.Add(this.AnaKategoriLookUp);
            this.groupControl1.Controls.Add(this.KategoriAdBox);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(11, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(429, 110);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Kategori Bilgileri";
            // 
            // KapatBtn
            // 
            this.KapatBtn.Image = ((System.Drawing.Image)(resources.GetObject("KapatBtn.Image")));
            this.KapatBtn.Location = new System.Drawing.Point(255, 76);
            this.KapatBtn.Name = "KapatBtn";
            this.KapatBtn.Size = new System.Drawing.Size(75, 23);
            this.KapatBtn.TabIndex = 4;
            this.KapatBtn.Text = "Kapat";
            this.KapatBtn.Click += new System.EventHandler(this.KapatBtn_Click);
            // 
            // SilBtn
            // 
            this.SilBtn.Enabled = false;
            this.SilBtn.Image = ((System.Drawing.Image)(resources.GetObject("SilBtn.Image")));
            this.SilBtn.Location = new System.Drawing.Point(174, 76);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(75, 23);
            this.SilBtn.TabIndex = 3;
            this.SilBtn.Text = "Sil";
            this.SilBtn.Click += new System.EventHandler(this.SilBtn_Click);
            // 
            // KaydetBtn
            // 
            this.KaydetBtn.Image = ((System.Drawing.Image)(resources.GetObject("KaydetBtn.Image")));
            this.KaydetBtn.Location = new System.Drawing.Point(93, 76);
            this.KaydetBtn.Name = "KaydetBtn";
            this.KaydetBtn.Size = new System.Drawing.Size(75, 23);
            this.KaydetBtn.TabIndex = 2;
            this.KaydetBtn.Text = "Kaydet";
            this.KaydetBtn.Click += new System.EventHandler(this.KaydetBtn_Click);
            // 
            // AnaKategoriLookUp
            // 
            this.AnaKategoriLookUp.Location = new System.Drawing.Point(93, 50);
            this.AnaKategoriLookUp.Name = "AnaKategoriLookUp";
            this.AnaKategoriLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.AnaKategoriLookUp.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AnaAd", "", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.True)});
            this.AnaKategoriLookUp.Properties.NullText = "";
            this.AnaKategoriLookUp.Size = new System.Drawing.Size(237, 20);
            this.AnaKategoriLookUp.TabIndex = 1;
            // 
            // KategoriAdBox
            // 
            this.KategoriAdBox.Location = new System.Drawing.Point(93, 24);
            this.KategoriAdBox.Name = "KategoriAdBox";
            this.KategoriAdBox.Size = new System.Drawing.Size(237, 20);
            this.KategoriAdBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ana Kategori";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Location = new System.Drawing.Point(11, 128);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(429, 286);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Kategori Listesi";
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(425, 264);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 26);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Image = global::Hizmet_MusMemnuniyet.Properties.Resources.edit;
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.KATID,
            this.AD,
            this.ANA,
            this.AKID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // KATID
            // 
            this.KATID.Caption = "ID";
            this.KATID.FieldName = "KategoriID";
            this.KATID.Name = "KATID";
            // 
            // AD
            // 
            this.AD.Caption = "ALT KATEGORİ";
            this.AD.FieldName = "Ad";
            this.AD.Name = "AD";
            this.AD.OptionsColumn.AllowEdit = false;
            this.AD.OptionsColumn.AllowFocus = false;
            this.AD.OptionsColumn.ReadOnly = true;
            this.AD.Visible = true;
            this.AD.VisibleIndex = 1;
            this.AD.Width = 150;
            // 
            // ANA
            // 
            this.ANA.Caption = "ANA KATEGORİ";
            this.ANA.FieldName = "AnaAd";
            this.ANA.Name = "ANA";
            this.ANA.OptionsColumn.AllowEdit = false;
            this.ANA.OptionsColumn.AllowFocus = false;
            this.ANA.OptionsColumn.ReadOnly = true;
            this.ANA.Visible = true;
            this.ANA.VisibleIndex = 0;
            this.ANA.Width = 156;
            // 
            // AKID
            // 
            this.AKID.Caption = "ANA KATEGORİ ID";
            this.AKID.FieldName = "AnaKategoriID";
            this.AKID.Name = "AKID";
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // dxErrorProvider2
            // 
            this.dxErrorProvider2.ContainerControl = this;
            // 
            // frmKategoriKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 421);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKategoriKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kategori İşlemleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPersonelKayit_FormClosed);
            this.Load += new System.EventHandler(this.frmPersonelKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnaKategoriLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KategoriAdBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupControl groupControl1;
        private Label label2;
        private Label label1;
        private GroupControl groupControl2;
        private LookUpEdit AnaKategoriLookUp;
        private TextEdit KategoriAdBox;
        private SimpleButton SilBtn;
        private SimpleButton KaydetBtn;
        private GridControl gridControl1;
        private GridView gridView1;
        private SimpleButton KapatBtn;
        private GridColumn KATID;
        private GridColumn AD;
        private GridColumn ANA;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem düzenleToolStripMenuItem;
        private GridColumn AKID;
        private DXErrorProvider dxErrorProvider1;
        private DXErrorProvider dxErrorProvider2;
    }
}