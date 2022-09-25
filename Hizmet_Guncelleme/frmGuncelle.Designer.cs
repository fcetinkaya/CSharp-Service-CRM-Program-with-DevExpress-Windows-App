using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using ProgressBar = System.Windows.Forms.ProgressBar;

namespace Hizmet_MusMemnuniyet
{
    partial class frmGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuncelle));
            this.Versiyongroup = new DevExpress.XtraEditors.GroupControl();
            this.GuncelProgLbl = new System.Windows.Forms.Label();
            this.ProgramVerLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Guncellemegroup = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VERSIYON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DosyaIndirBtn = new DevExpress.XtraEditors.SimpleButton();
            this.GuncellemeStartgroup = new DevExpress.XtraEditors.GroupControl();
            this.labelDownloaded = new System.Windows.Forms.Label();
            this.labelPerc = new System.Windows.Forms.Label();
            this.ProgramGuncelleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.YuklenenVersiyonLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Versiyongroup)).BeginInit();
            this.Versiyongroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guncellemegroup)).BeginInit();
            this.Guncellemegroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuncellemeStartgroup)).BeginInit();
            this.GuncellemeStartgroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // Versiyongroup
            // 
            this.Versiyongroup.Controls.Add(this.GuncelProgLbl);
            this.Versiyongroup.Controls.Add(this.ProgramVerLbl);
            this.Versiyongroup.Controls.Add(this.label2);
            this.Versiyongroup.Controls.Add(this.label1);
            this.Versiyongroup.Location = new System.Drawing.Point(2, 2);
            this.Versiyongroup.Name = "Versiyongroup";
            this.Versiyongroup.Size = new System.Drawing.Size(476, 99);
            this.Versiyongroup.TabIndex = 0;
            this.Versiyongroup.Text = "Versiyon Bilgileri";
            // 
            // GuncelProgLbl
            // 
            this.GuncelProgLbl.AutoSize = true;
            this.GuncelProgLbl.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.GuncelProgLbl.ForeColor = System.Drawing.Color.Red;
            this.GuncelProgLbl.Location = new System.Drawing.Point(170, 55);
            this.GuncelProgLbl.Name = "GuncelProgLbl";
            this.GuncelProgLbl.Size = new System.Drawing.Size(28, 13);
            this.GuncelProgLbl.TabIndex = 0;
            this.GuncelProgLbl.Text = "{0}";
            // 
            // ProgramVerLbl
            // 
            this.ProgramVerLbl.AutoSize = true;
            this.ProgramVerLbl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ProgramVerLbl.ForeColor = System.Drawing.Color.Red;
            this.ProgramVerLbl.Location = new System.Drawing.Point(170, 32);
            this.ProgramVerLbl.Name = "ProgramVerLbl";
            this.ProgramVerLbl.Size = new System.Drawing.Size(28, 13);
            this.ProgramVerLbl.TabIndex = 0;
            this.ProgramVerLbl.Text = "{0}";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Güncellenecek Versiyon   :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Program Versiyonu            :";
            // 
            // Guncellemegroup
            // 
            this.Guncellemegroup.Controls.Add(this.gridControl1);
            this.Guncellemegroup.Location = new System.Drawing.Point(2, 107);
            this.Guncellemegroup.Name = "Guncellemegroup";
            this.Guncellemegroup.Size = new System.Drawing.Size(476, 200);
            this.Guncellemegroup.TabIndex = 0;
            this.Guncellemegroup.Text = "Güncelleme Bilgileri";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(472, 178);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TARIH,
            this.VERSIYON,
            this.ACIKLAMA});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // TARIH
            // 
            this.TARIH.Caption = "Tarih";
            this.TARIH.FieldName = "Tarih";
            this.TARIH.Name = "TARIH";
            this.TARIH.OptionsColumn.AllowEdit = false;
            this.TARIH.OptionsColumn.AllowFocus = false;
            this.TARIH.OptionsColumn.FixedWidth = true;
            this.TARIH.Visible = true;
            this.TARIH.VisibleIndex = 0;
            // 
            // VERSIYON
            // 
            this.VERSIYON.Caption = "Versiyon";
            this.VERSIYON.FieldName = "Versiyon";
            this.VERSIYON.Name = "VERSIYON";
            this.VERSIYON.OptionsColumn.AllowEdit = false;
            this.VERSIYON.OptionsColumn.AllowFocus = false;
            this.VERSIYON.OptionsColumn.FixedWidth = true;
            this.VERSIYON.OptionsColumn.ReadOnly = true;
            this.VERSIYON.Visible = true;
            this.VERSIYON.VisibleIndex = 1;
            this.VERSIYON.Width = 100;
            // 
            // ACIKLAMA
            // 
            this.ACIKLAMA.Caption = "Açıklama";
            this.ACIKLAMA.FieldName = "Aciklama";
            this.ACIKLAMA.Name = "ACIKLAMA";
            this.ACIKLAMA.OptionsColumn.AllowEdit = false;
            this.ACIKLAMA.OptionsColumn.AllowFocus = false;
            this.ACIKLAMA.OptionsColumn.ReadOnly = true;
            this.ACIKLAMA.Visible = true;
            this.ACIKLAMA.VisibleIndex = 2;
            this.ACIKLAMA.Width = 279;
            // 
            // DosyaIndirBtn
            // 
            this.DosyaIndirBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DosyaIndirBtn.Appearance.Options.UseFont = true;
            this.DosyaIndirBtn.Image = ((System.Drawing.Image)(resources.GetObject("DosyaIndirBtn.Image")));
            this.DosyaIndirBtn.Location = new System.Drawing.Point(327, 313);
            this.DosyaIndirBtn.Name = "DosyaIndirBtn";
            this.DosyaIndirBtn.Size = new System.Drawing.Size(140, 31);
            this.DosyaIndirBtn.TabIndex = 1;
            this.DosyaIndirBtn.Text = "Dosyayı İndir";
            this.DosyaIndirBtn.Click += new System.EventHandler(this.DosyaIndirBtn_Click);
            // 
            // GuncellemeStartgroup
            // 
            this.GuncellemeStartgroup.Controls.Add(this.labelDownloaded);
            this.GuncellemeStartgroup.Controls.Add(this.labelPerc);
            this.GuncellemeStartgroup.Controls.Add(this.ProgramGuncelleBtn);
            this.GuncellemeStartgroup.Controls.Add(this.progressBar);
            this.GuncellemeStartgroup.Controls.Add(this.YuklenenVersiyonLbl);
            this.GuncellemeStartgroup.Controls.Add(this.label5);
            this.GuncellemeStartgroup.Location = new System.Drawing.Point(2, 354);
            this.GuncellemeStartgroup.Name = "GuncellemeStartgroup";
            this.GuncellemeStartgroup.Size = new System.Drawing.Size(476, 143);
            this.GuncellemeStartgroup.TabIndex = 0;
            this.GuncellemeStartgroup.Text = "Yükleniyor..";
            // 
            // labelDownloaded
            // 
            this.labelDownloaded.AutoSize = true;
            this.labelDownloaded.Location = new System.Drawing.Point(220, 67);
            this.labelDownloaded.Name = "labelDownloaded";
            this.labelDownloaded.Size = new System.Drawing.Size(13, 13);
            this.labelDownloaded.TabIndex = 2;
            this.labelDownloaded.Text = "0";
            this.labelDownloaded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPerc
            // 
            this.labelPerc.AutoSize = true;
            this.labelPerc.BackColor = System.Drawing.Color.Transparent;
            this.labelPerc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPerc.Location = new System.Drawing.Point(249, 82);
            this.labelPerc.Name = "labelPerc";
            this.labelPerc.Size = new System.Drawing.Size(14, 13);
            this.labelPerc.TabIndex = 4;
            this.labelPerc.Text = "0";
            // 
            // ProgramGuncelleBtn
            // 
            this.ProgramGuncelleBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ProgramGuncelleBtn.Appearance.Options.UseFont = true;
            this.ProgramGuncelleBtn.Image = ((System.Drawing.Image)(resources.GetObject("ProgramGuncelleBtn.Image")));
            this.ProgramGuncelleBtn.Location = new System.Drawing.Point(325, 107);
            this.ProgramGuncelleBtn.Name = "ProgramGuncelleBtn";
            this.ProgramGuncelleBtn.Size = new System.Drawing.Size(140, 31);
            this.ProgramGuncelleBtn.TabIndex = 1;
            this.ProgramGuncelleBtn.Text = "Programı Güncelle";
            this.ProgramGuncelleBtn.Visible = false;
            this.ProgramGuncelleBtn.Click += new System.EventHandler(this.ProgramGuncelleBtn_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(14, 23);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(451, 28);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 3;
            // 
            // YuklenenVersiyonLbl
            // 
            this.YuklenenVersiyonLbl.AutoSize = true;
            this.YuklenenVersiyonLbl.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.YuklenenVersiyonLbl.ForeColor = System.Drawing.Color.Red;
            this.YuklenenVersiyonLbl.Location = new System.Drawing.Point(137, 117);
            this.YuklenenVersiyonLbl.Name = "YuklenenVersiyonLbl";
            this.YuklenenVersiyonLbl.Size = new System.Drawing.Size(28, 13);
            this.YuklenenVersiyonLbl.TabIndex = 0;
            this.YuklenenVersiyonLbl.Text = "{0}";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(10, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Yüklenen Versiyon  :";
            // 
            // frmGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 502);
            this.Controls.Add(this.DosyaIndirBtn);
            this.Controls.Add(this.Guncellemegroup);
            this.Controls.Add(this.GuncellemeStartgroup);
            this.Controls.Add(this.Versiyongroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program Güncelleme";
            this.Load += new System.EventHandler(this.frmGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Versiyongroup)).EndInit();
            this.Versiyongroup.ResumeLayout(false);
            this.Versiyongroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guncellemegroup)).EndInit();
            this.Guncellemegroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuncellemeStartgroup)).EndInit();
            this.GuncellemeStartgroup.ResumeLayout(false);
            this.GuncellemeStartgroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupControl Versiyongroup;
        private Label GuncelProgLbl;
        private Label ProgramVerLbl;
        private Label label2;
        private Label label1;
        private GroupControl Guncellemegroup;
        private GridControl gridControl1;
        private GridView gridView1;
        private GridColumn TARIH;
        private GridColumn VERSIYON;
        private GridColumn ACIKLAMA;
        private SimpleButton DosyaIndirBtn;
        private GroupControl GuncellemeStartgroup;
        private Label YuklenenVersiyonLbl;
        private Label label5;
        private SimpleButton ProgramGuncelleBtn;
        private Label labelPerc;
        private ProgressBar progressBar;
        private Label labelDownloaded;
    }
}