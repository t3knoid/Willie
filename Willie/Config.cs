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
        private string _port;
        public int port
        {
            get { return Convert.ToInt32(_port); }
            set { _port = Convert.ToString(value); }
        }

        public string privatekey { get; set; }
        private string _forwardedport;
        public uint forwardedport
        {
            get { return Convert.ToUInt32(_forwardedport); }
            set { _forwardedport = Convert.ToString(value); }
        }

        public string passphrase { get; set; }

        Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        public Config ()
        {
            try
            {
                
                this.username = ConfigurationManager.AppSettings["Username"];
                this.password = ConfigurationManager.AppSettings["Password"];
                this.address = ConfigurationManager.AppSettings["Address"];
                this._port = ConfigurationManager.AppSettings["Port"];
                this._forwardedport = ConfigurationManager.AppSettings["ForwardedPort"];
                this.privatekey = ConfigurationManager.AppSettings["PrivateKey"];
                this.passphrase = ConfigurationManager.AppSettings["Passphrase"];
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
                appSettings.Settings.Add("Port", this._port);
                appSettings.Settings.Remove("PrivateKey");
                appSettings.Settings.Add("PrivateKey", this.privatekey);
                appSettings.Settings.Remove("ForwardedPort");
                appSettings.Settings.Add("ForwardedPort", this._forwardedport);
                appSettings.Settings.Remove("Passphrase");
                appSettings.Settings.Add("Passphrase", this._forwardedport);
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
        }

    }
}
