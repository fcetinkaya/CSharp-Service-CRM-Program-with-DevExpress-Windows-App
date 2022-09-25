using System.ComponentModel;
using DevExpress.XtraEditors;

namespace Hizmet_MusMemnuniyet.Kullanıcılar
{
    partial class frmKullaniciEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciEkle));
            this.adSoyadbox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.KullaniciAdiBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Sifrebox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.comboYetki = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.comboDurum = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ListeBtn = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.KapatBtn = new DevExpress.XtraEditors.SimpleButton();
            this.YeniBtn = new DevExpress.XtraEditors.SimpleButton();
            this.KaydetBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.adSoyadbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KullaniciAdiBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sifrebox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboYetki.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboDurum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // adSoyadbox
            // 
            this.adSoyadbox.Location = new System.Drawing.Point(86, 100);
            this.adSoyadbox.Name = "adSoyadbox";
            this.adSoyadbox.Properties.Mask.EditMask = "\\p{Lu}+";
            this.adSoyadbox.Size = new System.Drawing.Size(353, 20);
            this.adSoyadbox.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 103);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Ad Soyad";
            // 
            // KullaniciAdiBox
            // 
            this.KullaniciAdiBox.Location = new System.Drawing.Point(86, 126);
            this.KullaniciAdiBox.Name = "KullaniciAdiBox";
            this.KullaniciAdiBox.Size = new System.Drawing.Size(132, 20);
            this.KullaniciAdiBox.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(10, 129);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Kullanıcı Adı";
            // 
            // Sifrebox
            // 
            this.Sifrebox.Location = new System.Drawing.Point(345, 126);
            this.Sifrebox.Name = "Sifrebox";
            this.Sifrebox.Size = new System.Drawing.Size(132, 20);
            this.Sifrebox.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(304, 129);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(22, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Şifre";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(10, 155);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(70, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Kullanıcı Yetkisi";
            // 
            // comboYetki
            // 
            this.comboYetki.EditValue = "Seçiniz";
            this.comboYetki.Location = new System.Drawing.Point(86, 152);
            this.comboYetki.Name = "comboYetki";
            this.comboYetki.Properties.AutoComplete = false;
            this.comboYetki.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboYetki.Properties.Items.AddRange(new object[] {
            "Giriş",
            "Yönetici"});
            this.comboYetki.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboYetki.Size = new System.Drawing.Size(132, 20);
            this.comboYetki.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(249, 155);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(77, 13);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Kullanıcı Durumu";
            // 
            // comboDurum
            // 
            this.comboDurum.EditValue = "Seçiniz";
            this.comboDurum.Location = new System.Drawing.Point(345, 152);
            this.comboDurum.Name = "comboDurum";
            this.comboDurum.Properties.AutoComplete = false;
            this.comboDurum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboDurum.Properties.Items.AddRange(new object[] {
            "Aktif",
            "Pasif"});
            this.comboDurum.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboDurum.Size = new System.Drawing.Size(132, 20);
            this.comboDurum.TabIndex = 4;
            // 
            // ListeBtn
            // 
            this.ListeBtn.Image = global::Hizmet_MusMemnuniyet.Properties.Resources.zoom_in;
            this.ListeBtn.Location = new System.Drawing.Point(445, 100);
            this.ListeBtn.Name = "ListeBtn";
            this.ListeBtn.Size = new System.Drawing.Size(32, 20);
            this.ListeBtn.TabIndex = 3;
            this.ListeBtn.Click += new System.EventHandler(this.ListeBtn_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.ContentImage = ((System.Drawing.Image)(resources.GetObject("panelControl1.ContentImage")));
            this.panelControl1.ContentImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(488, 80);
            this.panelControl1.TabIndex = 0;
            // 
            // KapatBtn
            // 
            this.KapatBtn.Image = ((System.Drawing.Image)(resources.GetObject("KapatBtn.Image")));
            this.KapatBtn.Location = new System.Drawing.Point(402, 192);
            this.KapatBtn.Name = "KapatBtn";
            this.KapatBtn.Size = new System.Drawing.Size(75, 23);
            this.KapatBtn.TabIndex = 7;
            this.KapatBtn.Text = "Kapat";
            this.KapatBtn.Click += new System.EventHandler(this.KapatBtn_Click);
            // 
            // YeniBtn
            // 
            this.YeniBtn.Image = ((System.Drawing.Image)(resources.GetObject("YeniBtn.Image")));
            this.YeniBtn.Location = new System.Drawing.Point(240, 192);
            this.YeniBtn.Name = "YeniBtn";
            this.YeniBtn.Size = new System.Drawing.Size(75, 23);
            this.YeniBtn.TabIndex = 5;
            this.YeniBtn.Text = "Yeni";
            this.YeniBtn.Click += new System.EventHandler(this.YeniBtn_Click);
            // 
            // KaydetBtn
            // 
            this.KaydetBtn.Image = ((System.Drawing.Image)(resources.GetObject("KaydetBtn.Image")));
            this.KaydetBtn.Location = new System.Drawing.Point(321, 192);
            this.KaydetBtn.Name = "KaydetBtn";
            this.KaydetBtn.Size = new System.Drawing.Size(75, 23);
            this.KaydetBtn.TabIndex = 6;
            this.KaydetBtn.Text = "Kaydet";
            this.KaydetBtn.Click += new System.EventHandler(this.KaydetBtn_Click);
            // 
            // frmKullaniciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 227);
            this.Controls.Add(this.KapatBtn);
            this.Controls.Add(this.YeniBtn);
            this.Controls.Add(this.KaydetBtn);
            this.Controls.Add(this.comboDurum);
            this.Controls.Add(this.comboYetki);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.ListeBtn);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.Sifrebox);
            this.Controls.Add(this.KullaniciAdiBox);
            this.Controls.Add(this.adSoyadbox);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmKullaniciEkle";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Ekleme";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmKullaniciEkle_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.adSoyadbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KullaniciAdiBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sifrebox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboYetki.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboDurum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PanelControl panelControl1;
        private TextEdit adSoyadbox;
        private LabelControl labelControl1;
        private SimpleButton ListeBtn;
        private TextEdit KullaniciAdiBox;
        private LabelControl labelControl2;
        private TextEdit Sifrebox;
        private LabelControl labelControl3;
        private LabelControl labelControl4;
        private ComboBoxEdit comboYetki;
        private LabelControl labelControl5;
        private ComboBoxEdit comboDurum;
        private SimpleButton KapatBtn;
        private SimpleButton YeniBtn;
        private SimpleButton KaydetBtn;
    }
}