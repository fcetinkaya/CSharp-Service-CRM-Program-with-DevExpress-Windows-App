using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;

namespace Hizmet_MusMemnuniyet.Musteriler
{
    partial class frmMusteriKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriKayit));
            this.EPostabox = new DevExpress.XtraEditors.TextEdit();
            this.TelefonBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.MusteriAdiBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.AdresBox = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.CepTlfBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.MeslekBox = new DevExpress.XtraEditors.TextEdit();
            this.DogumTarihiDtime = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.KapatBtn = new DevExpress.XtraEditors.SimpleButton();
            this.SilBtn = new DevExpress.XtraEditors.SimpleButton();
            this.KaydetBtn = new DevExpress.XtraEditors.SimpleButton();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.EvlilikTarihiDtime = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.EPostabox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelefonBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusteriAdiBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdresBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CepTlfBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeslekBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DogumTarihiDtime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DogumTarihiDtime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EvlilikTarihiDtime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EvlilikTarihiDtime.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // EPostabox
            // 
            this.EPostabox.Location = new System.Drawing.Point(93, 281);
            this.EPostabox.Name = "EPostabox";
            this.EPostabox.Size = new System.Drawing.Size(427, 20);
            this.EPostabox.TabIndex = 5;
            // 
            // TelefonBox
            // 
            this.TelefonBox.Location = new System.Drawing.Point(93, 253);
            this.TelefonBox.Name = "TelefonBox";
            this.TelefonBox.Size = new System.Drawing.Size(147, 20);
            this.TelefonBox.TabIndex = 3;
            // 
            // labelControl13
            // 
            this.labelControl13.LineVisible = true;
            this.labelControl13.Location = new System.Drawing.Point(12, 284);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(37, 13);
            this.labelControl13.TabIndex = 38;
            this.labelControl13.Text = "E-Posta";
            // 
            // MusteriAdiBox
            // 
            this.MusteriAdiBox.Location = new System.Drawing.Point(93, 9);
            this.MusteriAdiBox.Name = "MusteriAdiBox";
            this.MusteriAdiBox.Size = new System.Drawing.Size(427, 20);
            this.MusteriAdiBox.TabIndex = 0;
            // 
            // labelControl9
            // 
            this.labelControl9.LineVisible = true;
            this.labelControl9.Location = new System.Drawing.Point(12, 310);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(62, 13);
            this.labelControl9.TabIndex = 41;
            this.labelControl9.Text = "Doğum Tarihi";
            // 
            // labelControl5
            // 
            this.labelControl5.LineVisible = true;
            this.labelControl5.Location = new System.Drawing.Point(12, 256);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(63, 13);
            this.labelControl5.TabIndex = 34;
            this.labelControl5.Text = "Sabit Telefon";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 63);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 13);
            this.labelControl3.TabIndex = 29;
            this.labelControl3.Text = "Adres";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 13);
            this.labelControl2.TabIndex = 28;
            this.labelControl2.Text = "Müşteri Adı";
            // 
            // AdresBox
            // 
            this.AdresBox.EditValue = "";
            this.AdresBox.Location = new System.Drawing.Point(93, 61);
            this.AdresBox.Name = "AdresBox";
            this.AdresBox.Properties.MaxLength = 500;
            this.AdresBox.Size = new System.Drawing.Size(427, 184);
            this.AdresBox.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(292, 254);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 13);
            this.labelControl1.TabIndex = 34;
            this.labelControl1.Text = "Cep Telefon";
            // 
            // CepTlfBox
            // 
            this.CepTlfBox.Location = new System.Drawing.Point(373, 251);
            this.CepTlfBox.Name = "CepTlfBox";
            this.CepTlfBox.Size = new System.Drawing.Size(147, 20);
            this.CepTlfBox.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 38);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(32, 13);
            this.labelControl4.TabIndex = 28;
            this.labelControl4.Text = "Meslek";
            // 
            // MeslekBox
            // 
            this.MeslekBox.Location = new System.Drawing.Point(93, 35);
            this.MeslekBox.Name = "MeslekBox";
            this.MeslekBox.Size = new System.Drawing.Size(427, 20);
            this.MeslekBox.TabIndex = 1;
            // 
            // DogumTarihiDtime
            // 
            this.DogumTarihiDtime.EditValue = null;
            this.DogumTarihiDtime.Location = new System.Drawing.Point(93, 307);
            this.DogumTarihiDtime.Name = "DogumTarihiDtime";
            this.DogumTarihiDtime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DogumTarihiDtime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DogumTarihiDtime.Properties.Mask.EditMask = "";
            this.DogumTarihiDtime.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.DogumTarihiDtime.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.DogumTarihiDtime.Size = new System.Drawing.Size(147, 20);
            this.DogumTarihiDtime.TabIndex = 6;
            // 
            // labelControl6
            // 
            this.labelControl6.LineVisible = true;
            this.labelControl6.Location = new System.Drawing.Point(292, 310);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(54, 13);
            this.labelControl6.TabIndex = 41;
            this.labelControl6.Text = "Evlilik Tarihi";
            // 
            // KapatBtn
            // 
            this.KapatBtn.Image = ((System.Drawing.Image)(resources.GetObject("KapatBtn.Image")));
            this.KapatBtn.Location = new System.Drawing.Point(445, 345);
            this.KapatBtn.Name = "KapatBtn";
            this.KapatBtn.Size = new System.Drawing.Size(75, 23);
            this.KapatBtn.TabIndex = 10;
            this.KapatBtn.Text = "Kapat";
            this.KapatBtn.Click += new System.EventHandler(this.KapatBtn_Click);
            // 
            // SilBtn
            // 
            this.SilBtn.Enabled = false;
            this.SilBtn.Image = ((System.Drawing.Image)(resources.GetObject("SilBtn.Image")));
            this.SilBtn.Location = new System.Drawing.Point(364, 345);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(75, 23);
            this.SilBtn.TabIndex = 9;
            this.SilBtn.Text = "Sil";
            this.SilBtn.Click += new System.EventHandler(this.SilBtn_Click);
            // 
            // KaydetBtn
            // 
            this.KaydetBtn.Image = ((System.Drawing.Image)(resources.GetObject("KaydetBtn.Image")));
            this.KaydetBtn.Location = new System.Drawing.Point(283, 345);
            this.KaydetBtn.Name = "KaydetBtn";
            this.KaydetBtn.Size = new System.Drawing.Size(75, 23);
            this.KaydetBtn.TabIndex = 8;
            this.KaydetBtn.Text = "Kaydet";
            this.KaydetBtn.Click += new System.EventHandler(this.KaydetBtn_Click);
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // EvlilikTarihiDtime
            // 
            this.EvlilikTarihiDtime.EditValue = null;
            this.EvlilikTarihiDtime.Location = new System.Drawing.Point(373, 307);
            this.EvlilikTarihiDtime.Name = "EvlilikTarihiDtime";
            this.EvlilikTarihiDtime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EvlilikTarihiDtime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EvlilikTarihiDtime.Properties.Mask.EditMask = "";
            this.EvlilikTarihiDtime.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.EvlilikTarihiDtime.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.EvlilikTarihiDtime.Size = new System.Drawing.Size(147, 20);
            this.EvlilikTarihiDtime.TabIndex = 6;
            // 
            // frmMusteriKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 371);
            this.Controls.Add(this.KapatBtn);
            this.Controls.Add(this.SilBtn);
            this.Controls.Add(this.KaydetBtn);
            this.Controls.Add(this.EPostabox);
            this.Controls.Add(this.CepTlfBox);
            this.Controls.Add(this.TelefonBox);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.MeslekBox);
            this.Controls.Add(this.MusteriAdiBox);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.AdresBox);
            this.Controls.Add(this.EvlilikTarihiDtime);
            this.Controls.Add(this.DogumTarihiDtime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMusteriKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Müşteri Kayıt";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMusteriKayit_FormClosed);
            this.Load += new System.EventHandler(this.frmMusteriKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EPostabox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelefonBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusteriAdiBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdresBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CepTlfBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeslekBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DogumTarihiDtime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DogumTarihiDtime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EvlilikTarihiDtime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EvlilikTarihiDtime.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextEdit EPostabox;
        private TextEdit TelefonBox;
        private LabelControl labelControl13;
        private TextEdit MusteriAdiBox;
        private LabelControl labelControl9;
        private LabelControl labelControl5;
        private LabelControl labelControl3;
        private LabelControl labelControl2;
        private MemoEdit AdresBox;
        private LabelControl labelControl1;
        private TextEdit CepTlfBox;
        private LabelControl labelControl4;
        private TextEdit MeslekBox;
        private DateEdit DogumTarihiDtime;
        private LabelControl labelControl6;
        private SimpleButton KapatBtn;
        private SimpleButton SilBtn;
        private SimpleButton KaydetBtn;
        private DXErrorProvider dxErrorProvider1;
        private DateEdit EvlilikTarihiDtime;
    }
}