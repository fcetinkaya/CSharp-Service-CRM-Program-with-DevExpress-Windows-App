using System.ComponentModel;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace Hizmet_MusMemnuniyet.Kullanıcılar
{
    partial class frmKullaniciListesi
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.KULID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AdSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KulAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SIFRE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Durum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Yetki = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(795, 402);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.KULID,
            this.AdSoyad,
            this.KulAdi,
            this.SIFRE,
            this.Durum,
            this.Yetki});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowRowSizing = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // KULID
            // 
            this.KULID.Caption = "KULLANICI NO";
            this.KULID.FieldName = "KullaniciID";
            this.KULID.Name = "KULID";
            // 
            // AdSoyad
            // 
            this.AdSoyad.Caption = "AD SOYAD";
            this.AdSoyad.FieldName = "AdSoyad";
            this.AdSoyad.Name = "AdSoyad";
            this.AdSoyad.OptionsColumn.AllowEdit = false;
            this.AdSoyad.OptionsColumn.AllowSize = false;
            this.AdSoyad.OptionsColumn.FixedWidth = true;
            this.AdSoyad.OptionsColumn.ReadOnly = true;
            this.AdSoyad.Visible = true;
            this.AdSoyad.VisibleIndex = 0;
            this.AdSoyad.Width = 150;
            // 
            // KulAdi
            // 
            this.KulAdi.Caption = "KULLANICI ADI";
            this.KulAdi.FieldName = "KullaniciAdi";
            this.KulAdi.Name = "KulAdi";
            this.KulAdi.OptionsColumn.AllowEdit = false;
            this.KulAdi.OptionsColumn.ReadOnly = true;
            this.KulAdi.Visible = true;
            this.KulAdi.VisibleIndex = 1;
            this.KulAdi.Width = 250;
            // 
            // SIFRE
            // 
            this.SIFRE.Caption = "ŞİFRE";
            this.SIFRE.FieldName = "Sifre";
            this.SIFRE.Name = "SIFRE";
            this.SIFRE.OptionsColumn.AllowEdit = false;
            this.SIFRE.OptionsColumn.ReadOnly = true;
            this.SIFRE.Visible = true;
            this.SIFRE.VisibleIndex = 2;
            this.SIFRE.Width = 125;
            // 
            // Durum
            // 
            this.Durum.Caption = "KULLANICI DURUMU";
            this.Durum.FieldName = "Durum";
            this.Durum.Name = "Durum";
            this.Durum.OptionsColumn.AllowEdit = false;
            this.Durum.OptionsColumn.AllowSize = false;
            this.Durum.OptionsColumn.FixedWidth = true;
            this.Durum.OptionsColumn.ReadOnly = true;
            this.Durum.Visible = true;
            this.Durum.VisibleIndex = 3;
            this.Durum.Width = 125;
            // 
            // Yetki
            // 
            this.Yetki.Caption = "KULLANICI YETKİSİ";
            this.Yetki.FieldName = "Yetki";
            this.Yetki.Name = "Yetki";
            this.Yetki.OptionsColumn.AllowEdit = false;
            this.Yetki.OptionsColumn.AllowSize = false;
            this.Yetki.OptionsColumn.FixedWidth = true;
            this.Yetki.OptionsColumn.ReadOnly = true;
            this.Yetki.Visible = true;
            this.Yetki.VisibleIndex = 4;
            this.Yetki.Width = 125;
            // 
            // frmKullaniciListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 402);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKullaniciListesi";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcılar Listesi";
            this.Load += new System.EventHandler(this.frmKullaniciListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GridControl gridControl1;
        private GridView gridView1;
        private GridColumn KULID;
        private GridColumn AdSoyad;
        private GridColumn KulAdi;
        private GridColumn Durum;
        private GridColumn Yetki;
        private GridColumn SIFRE;


    }
}