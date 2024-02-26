using System;
using System.IO;
using System.Windows.Forms;

namespace NebimResimSiralama
{
    public static class App
    {
        public static string GetAppDataFile
        {
            get
            {
                return Path.Combine(Application.StartupPath, Application.StartupPath + "\\AppDatabase.db");
            }
        }
    }
}
