using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace Hizmet_MusMemnuniyet.Kategori
{
    partial class frmAnaKategoriKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaKategoriKayit));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.KapatBtn = new DevExpress.XtraEditors.SimpleButton();
            this.SilBtn = new DevExpress.XtraEditors.SimpleButton();
            this.KaydetBtn = new DevExpress.XtraEditors.SimpleButton();
            this.KategoriBox = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KATEGORİ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KategoriBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.KapatBtn);
            this.groupControl1.Controls.Add(this.SilBtn);
            this.groupControl1.Controls.Add(this.KaydetBtn);
            this.groupControl1.Controls.Add(this.KategoriBox);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(11, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(429, 81);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Kategori Bilgileri";
            // 
            // KapatBtn
            // 
            this.KapatBtn.Image = ((System.Drawing.Image)(resources.GetObject("KapatBtn.Image")));
            this.KapatBtn.Location = new System.Drawing.Point(245, 50);
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
            this.SilBtn.Location = new System.Drawing.Point(164, 50);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(75, 23);
            this.SilBtn.TabIndex = 3;
            this.SilBtn.Text = "Sil";
            this.SilBtn.Click += new System.EventHandler(this.SilBtn_Click);
            // 
            // KaydetBtn
            // 
            this.KaydetBtn.Image = ((System.Drawing.Image)(resources.GetObject("KaydetBtn.Image")));
            this.KaydetBtn.Location = new System.Drawing.Point(83, 50);
            this.KaydetBtn.Name = "KaydetBtn";
            this.KaydetBtn.Size = new System.Drawing.Size(75, 23);
            this.KaydetBtn.TabIndex = 2;
            this.KaydetBtn.Text = "Kaydet";
            this.KaydetBtn.Click += new System.EventHandler(this.KaydetBtn_Click);
            // 
            // KategoriBox
            // 
            this.KategoriBox.Location = new System.Drawing.Point(83, 24);
            this.KategoriBox.Name = "KategoriBox";
            this.KategoriBox.Size = new System.Drawing.Size(237, 20);
            this.KategoriBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adı";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Location = new System.Drawing.Point(11, 99);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(429, 315);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Kategori Listesi";
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 21);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(425, 292);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.KATEGORİ});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "AnaKategoriID";
            this.ID.Name = "ID";
            this.ID.Width = 25;
            // 
            // KATEGORİ
            // 
            this.KATEGORİ.Caption = "KATEGORİ";
            this.KATEGORİ.FieldName = "AnaAd";
            this.KATEGORİ.Name = "KATEGORİ";
            this.KATEGORİ.OptionsColumn.AllowEdit = false;
            this.KATEGORİ.OptionsColumn.AllowFocus = false;
            this.KATEGORİ.OptionsColumn.ReadOnly = true;
            this.KATEGORİ.Visible = true;
            this.KATEGORİ.VisibleIndex = 0;
            this.KATEGORİ.Width = 381;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Image = global::Hizmet_MusMemnuniyet.Properties.Resources.edit;
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // frmAnaKategoriKayit
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
            this.Name = "frmAnaKategoriKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ana Kategori İşlemleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPersonelKayit_FormClosed);
            this.Load += new System.EventHandler(this.frmPersonelKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KategoriBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupControl groupControl1;
        private Label label1;
        private GroupControl groupControl2;
        private TextEdit KategoriBox;
        private SimpleButton SilBtn;
        private SimpleButton KaydetBtn;
        private SimpleButton KapatBtn;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem düzenleToolStripMenuItem;
        private DXErrorProvider dxErrorProvider1;
        private GridControl gridControl1;
        private GridView gridView1;
        private GridColumn ID;
        private GridColumn KATEGORİ;
    }
}