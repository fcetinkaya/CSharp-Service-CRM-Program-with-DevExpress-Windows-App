using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;

namespace Hizmet_MusMemnuniyet.Kullanıcılar
{
    partial class frmSifreDegistir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSifreDegistir));
            this.YeniTekrarParola = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.YeniParolaTxt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.EskiParaloTxt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.KaydetBtn = new DevExpress.XtraEditors.SimpleButton();
            this.KapatBtn = new DevExpress.XtraEditors.SimpleButton();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.dxErrorProvider2 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.dxErrorProvider3 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.YeniTekrarParola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YeniParolaTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EskiParaloTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // YeniTekrarParola
            // 
            this.YeniTekrarParola.Location = new System.Drawing.Point(153, 61);
            this.YeniTekrarParola.Name = "YeniTekrarParola";
            this.YeniTekrarParola.Size = new System.Drawing.Size(156, 20);
            this.YeniTekrarParola.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl3.Location = new System.Drawing.Point(12, 64);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(126, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Yeni Parolanız Tekrar :";
            // 
            // YeniParolaTxt
            // 
            this.YeniParolaTxt.Location = new System.Drawing.Point(153, 35);
            this.YeniParolaTxt.Name = "YeniParolaTxt";
            this.YeniParolaTxt.Size = new System.Drawing.Size(156, 20);
            this.YeniParolaTxt.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Location = new System.Drawing.Point(12, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Yeni Parolanız :";
            // 
            // EskiParaloTxt
            // 
            this.EskiParaloTxt.Location = new System.Drawing.Point(153, 9);
            this.EskiParaloTxt.Name = "EskiParaloTxt";
            this.EskiParaloTxt.Size = new System.Drawing.Size(156, 20);
            this.EskiParaloTxt.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Eski Parolanız :";
            // 
            // KaydetBtn
            // 
            this.KaydetBtn.Image = ((System.Drawing.Image)(resources.GetObject("KaydetBtn.Image")));
            this.KaydetBtn.Location = new System.Drawing.Point(12, 90);
            this.KaydetBtn.Name = "KaydetBtn";
            this.KaydetBtn.Size = new System.Drawing.Size(96, 23);
            this.KaydetBtn.TabIndex = 3;
            this.KaydetBtn.Text = "Kaydet";
            this.KaydetBtn.Click += new System.EventHandler(this.KaydetBtn_Click);
            // 
            // KapatBtn
            // 
            this.KapatBtn.Image = ((System.Drawing.Image)(resources.GetObject("KapatBtn.Image")));
            this.KapatBtn.Location = new System.Drawing.Point(114, 90);
            this.KapatBtn.Name = "KapatBtn";
            this.KapatBtn.Size = new System.Drawing.Size(96, 23);
            this.KapatBtn.TabIndex = 4;
            this.KapatBtn.Text = "Kapat";
            this.KapatBtn.Click += new System.EventHandler(this.KapatBtn_Click);
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // dxErrorProvider2
            // 
            this.dxErrorProvider2.ContainerControl = this;
            // 
            // dxErrorProvider3
            // 
            this.dxErrorProvider3.ContainerControl = this;
            // 
            // frmSifreDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 125);
            this.Controls.Add(this.KapatBtn);
            this.Controls.Add(this.KaydetBtn);
            this.Controls.Add(this.YeniTekrarParola);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.YeniParolaTxt);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.EskiParaloTxt);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSifreDegistir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Değiştir";
            ((System.ComponentModel.ISupportInitialize)(this.YeniTekrarParola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YeniParolaTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EskiParaloTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextEdit YeniTekrarParola;
        private LabelControl labelControl3;
        private TextEdit YeniParolaTxt;
        private LabelControl labelControl2;
        private TextEdit EskiParaloTxt;
        private LabelControl labelControl1;
        private SimpleButton KaydetBtn;
        private SimpleButton KapatBtn;
        private DXErrorProvider dxErrorProvider1;
        private DXErrorProvider dxErrorProvider2;
        private DXErrorProvider dxErrorProvider3;
    }
}