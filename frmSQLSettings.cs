using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LiteDB;

namespace NebimResimSiralama
{
    public partial class frmSQLSettings : Form
    {
        public frmSQLSettings()
        {
            InitializeComponent();
        }
        private void frmSQLSettings_Shown(object sender, EventArgs e)
        {
            if (!File.Exists(Path.GetFullPath(App.GetAppDataFile)))
            {
                using (LiteDatabase liteDatabase = new LiteDatabase(App.GetAppDataFile, null, null))
                {
                    if (!liteDatabase.CollectionExists("AppSettings"))
                    {
                        liteDatabase.GetCollection<AppSettings>("AppSettings").Insert(new AppSettings
                        {
                            Id = 1,
                            SQLServer = "",
                            SQLDatabase = "",
                            SQLUser = "",
                            SQLPass = ""
                        });
                    }
                }
            }

            using (LiteRepository liteRepository = new LiteRepository(App.GetAppDataFile, null))
            {
                AppSettings appSettings = liteRepository.FirstOrDefault<AppSettings>((AppSettings x) => x.Id == 1, null);
                this.txtServer.Text = appSettings.SQLServer;
                this.txtDatabase.Text = appSettings.SQLDatabase;
                this.txtUser.Text = appSettings.SQLUser;
                this.txtPassword.Text = appSettings.SQLPass;
            }
        }
        private void btKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                using (LiteRepository liteRepository = new LiteRepository(App.GetAppDataFile, null))
                {
                    AppSettings appSettings = liteRepository.FirstOrDefault<AppSettings>((AppSettings x) => x.Id == 1, null);
                    appSettings.SQLServer = this.txtServer.Text;
                    appSettings.SQLDatabase = this.txtDatabase.Text;
                    appSettings.SQLUser = this.txtUser.Text;
                    appSettings.SQLPass = this.txtPassword.Text;
                    liteRepository.Update<AppSettings>(appSettings, null);
                }
                MessageBox.Show("Başarılı");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu. Detay:\n " + ex.Message);
            }
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            base.Close();
        }
    }
}
