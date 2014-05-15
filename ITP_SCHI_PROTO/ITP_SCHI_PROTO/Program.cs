using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ITPPROTO
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //
            Configuration configManager = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            KeyValueConfigurationCollection confCollection = configManager.AppSettings.Settings;
            Console.WriteLine(configManager.FilePath);
            KeyValueConfigurationElement[] brr = new KeyValueConfigurationElement[1];
            confCollection.CopyTo(brr, 0);
            ConfigurationManager.RefreshSection(configManager.AppSettings.SectionInformation.Name);
            //
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(brr.GetValue(0).ToString()));
            Application.Run(new ResultSelect());
        }
    }
}
