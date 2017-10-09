using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Willie
{
    public class Config : ConfigurationSection
    {
        [ConfigurationProperty("Username")]
        public string username
        {
            get { return (string)this["Username"]; }
            set { this["Username"] = value; }
        }

        [ConfigurationProperty("Password")]
        public string password
        {
            get { return (string)this["Password"]; }
            set { this["Password"] = value; }
        }

        [ConfigurationProperty("Address")]
        public string address
        {
            get { return (string)this["Address"]; }
            set { this["Address"] = value; }
        }

        [ConfigurationProperty("Port")]
        public string port
        {
            get { return (string)this["Port"]; }
            set { this["Port"] = value; }
        }

        //[ConfigurationProperty("PK")]
        //public string pk
        //{
        //    get { return (string)this["pk"]; }
        //    set { this["PK"] = value; }
        //}

        Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        [ConfigurationProperty("FPort")]
        public string fport
        {
            get { return (string)this["FPort"]; }
            set { this["FPort"] = value; }
        }

        public Config ()
        {

            try
            {
                this.username = ConfigurationManager.AppSettings["Username"];
                this.password = ConfigurationManager.AppSettings["Password"];
                this.address = ConfigurationManager.AppSettings["Address"];
                this.port = ConfigurationManager.AppSettings["Port"];
                ////this.pk = ConfigurationManager.AppSettings["PK"];
                this.fport = ConfigurationManager.AppSettings["FPort"];
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
                //appSettings.Settings.Remove("PK");
                //appSettings.Settings.Add("PK", this.pk);
                appSettings.Settings.Remove("FPort");
                appSettings.Settings.Add("FPort", this.fport);
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
        }

    }
}
