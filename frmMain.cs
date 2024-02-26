using LiteDB;
using NebimResimSiralama.Data;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NebimResimSiralama
{
    public partial class frmMain : Form
    {
        public frmSQLSettings frmSQLSettings;
        public DataTable dtResimler = new DataTable();

        public frmMain()
        {
            InitializeComponent();

            prBar.Visible = false;
        }
        private void frmMain_Shown(object sender, EventArgs e)
        {
            TabloOlustur();
        }
        private void btnVeritabani_Click(object sender, EventArgs e)
        {
            if (frmSQLSettings == null || frmSQLSettings.IsDisposed)
            {
                frmSQLSettings = new frmSQLSettings();
                frmSQLSettings.Show();
            }
            else
            {
                frmSQLSettings.Activate();
            }
        }
        private void btnImageSetting_Click(object sender, EventArgs e)
        {
            string strItems = "";

            try
            {
                string strQuery = @"SELECT 
                      p1.ItemCode AS ItemCode, p1.ColorCode,
                      (
                        SELECT 
                          FolderPath 
                        FROM 
                          dbo.dfGlobalFolder 
                        WHERE 
                          GlobalDefaultCode = 1 
                          AND FolderCode = N'ProductPhotoPath'
                      )+ p1.ItemCode + '\ColorPhotos\'+p1.ColorCode AS ResimKlasoru FROM dbo.cdItem c1
                    INNER JOIN dbo.ProductColorAttributes p1 ON p1.ItemCode = c1.ItemCode
                    WHERE c1.ItemTypeCode = 1 AND c1.UseInternet = 1 AND p1.ColorCode NOT LIKE '%*%'";

                DataTable dtPicture = new DataTable();

                using (SqlConnection cnn = new SqlConnection(MSSQLConnectionString()))
                {
                    cnn.Open();

                    dtPicture.Load(cnn.ExecuteReader(strQuery, null, null, null, null));

                    cnn.Close();
                }

                List<DataTable> result = dtPicture.AsEnumerable()
                   .GroupBy(x => x.Field<string>("ItemCode"))
                   .Select(grp => grp.CopyToDataTable())
                   .ToList();

                prBar.Properties.Step = 1;
                prBar.Properties.PercentView = true;
                prBar.Properties.Maximum = result.Count;
                prBar.Properties.Minimum = 0;
                prBar.Visible = true;

                foreach (var items in result)//.Where(x => x.Rows[0]["ItemCode"].ToString() == "23Y111121524"))
                {
                    var ResimBilgileri = new ImageItem();

                    foreach (DataRow item in dtPicture.Select("ItemCode='" + items.Rows[0]["ItemCode"].ToString() + "'"))
                    {
                        List<ImageItem> ResimListesi = new List<ImageItem>();

                        DirectoryInfo df = new DirectoryInfo(item["ResimKlasoru"].ToString());
                        int dSay = 1;
                        strItems = item["ItemCode"].ToString();

                        if (Directory.Exists(item["ResimKlasoru"].ToString()))
                        {
                            foreach (FileInfo file in df.GetFiles())
                            {
                                if (!file.Name.Contains(strItems))
                                {
                                    string[] strUzanti = file.Name.Split('.');

                                    ResimBilgileri = new ImageItem
                                    {
                                        UrunKodu = strItems,
                                        DosyaYolu = item["ResimKlasoru"].ToString(),
                                        MevcutResim = file.Name.ToString(),
                                        YeniResim = strItems + "_" + item["ColorCode"].ToString() + "_" + dSay + "." + file.Name.Split('.')[strUzanti.Length - 1].ToString(),
                                        SiraNumarasi = dSay
                                    };

                                    dSay++;
                                    ResimListesi.Add(ResimBilgileri);
                                }
                            }

                            for (int i = 0; i < ResimListesi.Count; i++)
                            {
                                DataRow drPicture = dtResimler.NewRow();
                                drPicture["UrunKodu"] = ResimListesi[i].UrunKodu.ToString();
                                drPicture["DosyaYolu"] = ResimListesi[i].DosyaYolu.ToString();
                                drPicture["MevcutResim"] = ResimListesi[i].MevcutResim.ToString();
                                drPicture["YeniResim"] = ResimListesi[i].YeniResim.ToString();
                                drPicture["SiraNumarasi"] = ResimListesi[i].SiraNumarasi;
                                dtResimler.Rows.Add(drPicture);
                            }
                            dtResimler.AcceptChanges();
                            grdPicture.DataSource = dtResimler;
                        }
                    }

                    prBar.PerformStep();
                    prBar.Update();
                }
                prBar.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilinmeyen Bir Hata Oluştu.Detay:\n" + ex.Message.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                prBar.Properties.Step = 1;
                prBar.Properties.PercentView = true;
                prBar.Properties.Minimum = 0;
                prBar.Visible = false;
            }
        }
        private void btnPictureEdit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Resimler Tekrar İsimlendirilecektir. Onaylıyor musunuz?", "Resim İsimlerini Düzenleme", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    prBar.Properties.Step = 1;
                    prBar.Properties.PercentView = true;
                    prBar.Properties.Maximum = dtResimler.Rows.Count;
                    prBar.Properties.Minimum = 0;
                    prBar.Visible = true;

                    foreach (DataRow item in dtResimler.Rows)
                    {
                        string strOldFileName = item["DosyaYolu"].ToString() + "\\" + item["MevcutResim"].ToString();
                        string strNewFileName = item["DosyaYolu"].ToString() + "\\" + item["YeniResim"].ToString();
                        System.IO.File.Move(strOldFileName, strNewFileName);

                        prBar.PerformStep();
                        prBar.Update();
                    }

                    prBar.Visible = false;

                    MessageBox.Show("Resimlerin Yeniden İsimlendirilmesi Başarılı Şekilde Tamamlanmıştır.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bilinmeyen Bir Hata Oluştu.Detay:\n" + ex.Message.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    prBar.Properties.Step = 1;
                    prBar.Properties.PercentView = true;
                    prBar.Properties.Minimum = 0;
                    prBar.Visible = false;
                }
            }
        }
        private void TabloOlustur()
        {
            if(dtResimler.Columns.Count <= 0)
            {
                dtResimler.Columns.Add("UrunKodu", typeof(string));
                dtResimler.Columns.Add("DosyaYolu", typeof(string));
                dtResimler.Columns.Add("MevcutResim", typeof(string));
                dtResimler.Columns.Add("YeniResim", typeof(string));
                dtResimler.Columns.Add("SiraNumarasi", typeof(int));
            }
        }
        private string MSSQLConnectionString()
        {
            string result;
            using (LiteRepository liteRepository = new LiteRepository(App.GetAppDataFile, null))
            {
                AppSettings appSettings = liteRepository.FirstOrDefault<AppSettings>((AppSettings x) => x.Id == 1, null);
                result = string.Format("Server={0};Database={1};User Id={2};Password = {3}; ", new object[]
                {
                    appSettings.SQLServer,
                    appSettings.SQLDatabase,
                    appSettings.SQLUser,
                    appSettings.SQLPass
                });
            }
            return result;
        }
    }
    public class ImageItem
    {
        public string UrunKodu { get; set; }
        public string DosyaYolu { get; set; }
        public string MevcutResim { get; set; }
        public string YeniResim { get; set; }
        public int SiraNumarasi { get; set; }
    }
}
