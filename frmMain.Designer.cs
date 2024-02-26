namespace NebimResimSiralama
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnTop = new System.Windows.Forms.Panel();
            this.prBar = new DevExpress.XtraEditors.ProgressBarControl();
            this.btnPictureEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnImageSetting = new DevExpress.XtraEditors.SimpleButton();
            this.btnVeritabani = new DevExpress.XtraEditors.SimpleButton();
            this.pnFill = new System.Windows.Forms.Panel();
            this.grdPicture = new DevExpress.XtraGrid.GridControl();
            this.gvPicture = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gvMevcutResim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvYeniResim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvSiraNumarasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvDosyaYolu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvUrunKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prBar.Properties)).BeginInit();
            this.pnFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.prBar);
            this.pnTop.Controls.Add(this.btnPictureEdit);
            this.pnTop.Controls.Add(this.btnImageSetting);
            this.pnTop.Controls.Add(this.btnVeritabani);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(706, 93);
            this.pnTop.TabIndex = 0;
            // 
            // prBar
            // 
            this.prBar.Location = new System.Drawing.Point(55, 61);
            this.prBar.Name = "prBar";
            this.prBar.Size = new System.Drawing.Size(380, 26);
            this.prBar.TabIndex = 4;
            this.prBar.Visible = false;
            // 
            // btnPictureEdit
            // 
            this.btnPictureEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPictureEdit.ImageOptions.Image")));
            this.btnPictureEdit.Location = new System.Drawing.Point(314, 13);
            this.btnPictureEdit.Name = "btnPictureEdit";
            this.btnPictureEdit.Size = new System.Drawing.Size(121, 42);
            this.btnPictureEdit.TabIndex = 2;
            this.btnPictureEdit.Text = "&Resim Düzenle";
            this.btnPictureEdit.Click += new System.EventHandler(this.btnPictureEdit_Click);
            // 
            // btnImageSetting
            // 
            this.btnImageSetting.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnImageSetting.ImageOptions.Image")));
            this.btnImageSetting.Location = new System.Drawing.Point(166, 13);
            this.btnImageSetting.Name = "btnImageSetting";
            this.btnImageSetting.Size = new System.Drawing.Size(141, 42);
            this.btnImageSetting.TabIndex = 1;
            this.btnImageSetting.Text = "&Resim Ayarla";
            this.btnImageSetting.Click += new System.EventHandler(this.btnImageSetting_Click);
            // 
            // btnVeritabani
            // 
            this.btnVeritabani.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVeritabani.ImageOptions.Image")));
            this.btnVeritabani.Location = new System.Drawing.Point(55, 13);
            this.btnVeritabani.Name = "btnVeritabani";
            this.btnVeritabani.Size = new System.Drawing.Size(105, 42);
            this.btnVeritabani.TabIndex = 0;
            this.btnVeritabani.Text = "&Veritabanı";
            this.btnVeritabani.Click += new System.EventHandler(this.btnVeritabani_Click);
            // 
            // pnFill
            // 
            this.pnFill.Controls.Add(this.grdPicture);
            this.pnFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFill.Location = new System.Drawing.Point(0, 93);
            this.pnFill.Name = "pnFill";
            this.pnFill.Size = new System.Drawing.Size(706, 354);
            this.pnFill.TabIndex = 1;
            // 
            // grdPicture
            // 
            this.grdPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPicture.Location = new System.Drawing.Point(0, 0);
            this.grdPicture.MainView = this.gvPicture;
            this.grdPicture.Name = "grdPicture";
            this.grdPicture.Size = new System.Drawing.Size(706, 354);
            this.grdPicture.TabIndex = 0;
            this.grdPicture.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPicture});
            // 
            // gvPicture
            // 
            this.gvPicture.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gvUrunKodu,
            this.gvMevcutResim,
            this.gvYeniResim,
            this.gvSiraNumarasi,
            this.gvDosyaYolu});
            this.gvPicture.GridControl = this.grdPicture;
            this.gvPicture.Name = "gvPicture";
            this.gvPicture.OptionsView.ShowGroupPanel = false;
            // 
            // gvMevcutResim
            // 
            this.gvMevcutResim.AppearanceCell.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gvMevcutResim.AppearanceCell.Options.UseFont = true;
            this.gvMevcutResim.AppearanceCell.Options.UseTextOptions = true;
            this.gvMevcutResim.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvMevcutResim.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gvMevcutResim.AppearanceHeader.Options.UseFont = true;
            this.gvMevcutResim.AppearanceHeader.Options.UseTextOptions = true;
            this.gvMevcutResim.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvMevcutResim.Caption = "Mevcut Resim Adı";
            this.gvMevcutResim.FieldName = "MevcutResim";
            this.gvMevcutResim.Name = "gvMevcutResim";
            this.gvMevcutResim.Visible = true;
            this.gvMevcutResim.VisibleIndex = 1;
            // 
            // gvYeniResim
            // 
            this.gvYeniResim.AppearanceCell.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gvYeniResim.AppearanceCell.Options.UseFont = true;
            this.gvYeniResim.AppearanceCell.Options.UseTextOptions = true;
            this.gvYeniResim.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvYeniResim.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gvYeniResim.AppearanceHeader.Options.UseFont = true;
            this.gvYeniResim.AppearanceHeader.Options.UseTextOptions = true;
            this.gvYeniResim.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvYeniResim.Caption = "Yeni Resim Adı";
            this.gvYeniResim.FieldName = "YeniResim";
            this.gvYeniResim.Name = "gvYeniResim";
            this.gvYeniResim.Visible = true;
            this.gvYeniResim.VisibleIndex = 2;
            // 
            // gvSiraNumarasi
            // 
            this.gvSiraNumarasi.AppearanceCell.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gvSiraNumarasi.AppearanceCell.Options.UseFont = true;
            this.gvSiraNumarasi.AppearanceCell.Options.UseTextOptions = true;
            this.gvSiraNumarasi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvSiraNumarasi.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gvSiraNumarasi.AppearanceHeader.Options.UseFont = true;
            this.gvSiraNumarasi.AppearanceHeader.Options.UseTextOptions = true;
            this.gvSiraNumarasi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvSiraNumarasi.Caption = "Sıra Numarası";
            this.gvSiraNumarasi.FieldName = "SiraNumarasi";
            this.gvSiraNumarasi.Name = "gvSiraNumarasi";
            this.gvSiraNumarasi.Visible = true;
            this.gvSiraNumarasi.VisibleIndex = 3;
            // 
            // gvDosyaYolu
            // 
            this.gvDosyaYolu.AppearanceCell.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gvDosyaYolu.AppearanceCell.Options.UseFont = true;
            this.gvDosyaYolu.AppearanceCell.Options.UseTextOptions = true;
            this.gvDosyaYolu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvDosyaYolu.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gvDosyaYolu.AppearanceHeader.Options.UseFont = true;
            this.gvDosyaYolu.AppearanceHeader.Options.UseTextOptions = true;
            this.gvDosyaYolu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvDosyaYolu.Caption = "Dosya Yolu";
            this.gvDosyaYolu.FieldName = "DosyaYolu";
            this.gvDosyaYolu.Name = "gvDosyaYolu";
            this.gvDosyaYolu.Visible = true;
            this.gvDosyaYolu.VisibleIndex = 4;
            // 
            // gvUrunKodu
            // 
            this.gvUrunKodu.AppearanceCell.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.gvUrunKodu.AppearanceCell.Options.UseFont = true;
            this.gvUrunKodu.AppearanceCell.Options.UseTextOptions = true;
            this.gvUrunKodu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvUrunKodu.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.gvUrunKodu.AppearanceHeader.Options.UseFont = true;
            this.gvUrunKodu.AppearanceHeader.Options.UseTextOptions = true;
            this.gvUrunKodu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvUrunKodu.Caption = "Ürün Kodu";
            this.gvUrunKodu.FieldName = "UrunKodu";
            this.gvUrunKodu.Name = "gvUrunKodu";
            this.gvUrunKodu.Visible = true;
            this.gvUrunKodu.VisibleIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(706, 447);
            this.Controls.Add(this.pnFill);
            this.Controls.Add(this.pnTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nebim Resimlerini Yeniden İsimlendirme";
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.pnTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prBar.Properties)).EndInit();
            this.pnFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private DevExpress.XtraEditors.SimpleButton btnVeritabani;
        private System.Windows.Forms.Panel pnFill;
        private DevExpress.XtraEditors.SimpleButton btnImageSetting;
        private DevExpress.XtraEditors.SimpleButton btnPictureEdit;
        private DevExpress.XtraGrid.GridControl grdPicture;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPicture;
        private DevExpress.XtraGrid.Columns.GridColumn gvMevcutResim;
        private DevExpress.XtraGrid.Columns.GridColumn gvYeniResim;
        private DevExpress.XtraGrid.Columns.GridColumn gvSiraNumarasi;
        private DevExpress.XtraGrid.Columns.GridColumn gvDosyaYolu;
        private DevExpress.XtraEditors.ProgressBarControl prBar;
        private DevExpress.XtraGrid.Columns.GridColumn gvUrunKodu;
    }
}

