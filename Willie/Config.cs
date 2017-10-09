using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Willie
{
    public class Config 
    {
        public string username { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public string port { get; set; }
        public string pk { get; set; }
        public string fport { get; set; }

        Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);



        public Config ()
        {
            try
            {
                
                this.username = ConfigurationManager.AppSettings["Username"];
                this.password = ConfigurationManager.AppSettings["Password"];
                this.address = ConfigurationManager.AppSettings["Address"];
                this.port = ConfigurationManager.AppSettings["Port"];
                this.fport = ConfigurationManager.AppSettings["FPort"];
                this.pk = ConfigurationManager.AppSettings["PK"];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Save()
        {
            AppSettingsSection appSettings = configFile.AppSettings;

            if (appSettings.IsReadOnly() == false)
            {
                appSettings.Settings.Remove("Username");
                appSettings.Settings.Add("Username", this.username);
                appSettings.Settings.Remove("Password");
                appSettings.Settings.Add("Password", this.password);
                appSettings.Settings.Remove("Address");
                appSettings.Settings.Add("Address", this.address);
                appSettings.Settings.Remove("Port");
                appSettings.Settings.Add("Port", this.port);
                appSettings.Settings.Remove("PK");
                appSettings.Settings.Add("PK", this.pk);
                appSettings.Settings.Remove("FPort");
                appSettings.Settings.Add("FPort", this.fport);
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
        }

    }
}
