using System.ComponentModel;
using DevExpress.XtraEditors;

namespace Hizmet_MusMemnuniyet
{
    partial class frmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiris));
            this.GirisBtn = new DevExpress.XtraEditors.SimpleButton();
            this.Sifrebox = new DevExpress.XtraEditors.TextEdit();
            this.KulAdiBox = new DevExpress.XtraEditors.TextEdit();
            this.SifreCheck = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.Sifrebox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KulAdiBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SifreCheck.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GirisBtn
            // 
            this.GirisBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GirisBtn.Location = new System.Drawing.Point(342, 258);
            this.GirisBtn.Name = "GirisBtn";
            this.GirisBtn.Size = new System.Drawing.Size(86, 31);
            this.GirisBtn.TabIndex = 8;
            this.GirisBtn.Text = "Giriş Yapın";
            this.GirisBtn.Click += new System.EventHandler(this.GirisBtn_Click);
            // 
            // Sifrebox
            // 
            this.Sifrebox.Location = new System.Drawing.Point(203, 155);
            this.Sifrebox.Name = "Sifrebox";
            this.Sifrebox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.Sifrebox.Properties.PasswordChar = '*';
            this.Sifrebox.Size = new System.Drawing.Size(143, 18);
            this.Sifrebox.TabIndex = 5;
            // 
            // KulAdiBox
            // 
            this.KulAdiBox.Location = new System.Drawing.Point(203, 127);
            this.KulAdiBox.Name = "KulAdiBox";
            this.KulAdiBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.KulAdiBox.Size = new System.Drawing.Size(143, 18);
            this.KulAdiBox.TabIndex = 4;
            // 
            // SifreCheck
            // 
            this.SifreCheck.Location = new System.Drawing.Point(164, 185);
            this.SifreCheck.Name = "SifreCheck";
            this.SifreCheck.Properties.Caption = "Şifreyi Hatırla";
            this.SifreCheck.Size = new System.Drawing.Size(92, 19);
            this.SifreCheck.TabIndex = 6;
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::Hizmet_MusMemnuniyet.Properties.Resources.Giris_fw;
            this.ClientSize = new System.Drawing.Size(470, 301);
            this.Controls.Add(this.GirisBtn);
            this.Controls.Add(this.Sifrebox);
            this.Controls.Add(this.KulAdiBox);
            this.Controls.Add(this.SifreCheck);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.frmGiris_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGiris_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Sifrebox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KulAdiBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SifreCheck.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SimpleButton GirisBtn;
        private TextEdit Sifrebox;
        private TextEdit KulAdiBox;
        private CheckEdit SifreCheck;
    }
}