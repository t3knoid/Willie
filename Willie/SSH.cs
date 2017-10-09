using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;

namespace Willie
{
    public class SSH
    {
        public string username { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public string port { get; set; }
        public string keyfile { get; set; }
        public uint forwardedPort { get; set; }

        ForwardedPortDynamic forwardedPortDynamic;
        SshClient sshClient;

        public SSH()
        {

        }

		public SSH(string user, string pw, string addy, string p, string key, uint fport)
        {
            username = user;
            password = pw;
            address = addy;
            port = p;
            keyfile = key;
            forwardedPort = fport;
        }
        public bool Connect()
        {
            try
            {
                var connectionInfo = new ConnectionInfo(address, port,
                                            new PasswordAuthenticationMethod(username, password),
                                            new PrivateKeyAuthenticationMethod(keyfile));

                sshClient = new SshClient(connectionInfo);
                sshClient.Connect();
                forwardedPortDynamic = new ForwardedPortDynamic("127.0.0.1", forwardedPort);
                sshClient.AddForwardedPort(forwardedPortDynamic);
                forwardedPortDynamic.Start();    
            }
			catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

            if (sshClient.IsConnected && forwardedPortDynamic.IsStarted)
                return true;
            else return false;

        }

        public bool Disconnect()
        {
            return true;
        }
    }


}
