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
        private int _port;
        public string port
        {
            get { return Convert.ToString(_port); }
            set { _port = Convert.ToInt32 (value); }
        }
        public string keyfile { get; set; }
        public string passphrase { get; set; }
        private uint _forwardedPort;
        public string forwardedPort
        { 
            get {return Convert.ToString(_forwardedPort); }
            set { _forwardedPort = Convert.ToUInt32(value); }
        }

        ForwardedPortDynamic forwardedPortDynamic;
        SshClient sshClient;

        public SSH()
        {

        }

        public bool Connect()
        {
            ConnectionInfo connectionInfo = null;

            try
            {
                // If password is empty, use private key authentication
                if (String.IsNullOrEmpty(this.password)) {
                    connectionInfo = new ConnectionInfo(this.address, this._port, this.username,
                        new AuthenticationMethod[]{
                            new PrivateKeyAuthenticationMethod(this.username, new PrivateKeyFile[] {
                                new PrivateKeyFile(keyfile, passphrase)
                            }),
                        });
                }

                else
                {
                    connectionInfo = new ConnectionInfo(this.address, this._port, this.username,
                        new AuthenticationMethod[]{
                            new PasswordAuthenticationMethod(this.username,this.password),
                        });

                };

                sshClient = new SshClient(connectionInfo);
                sshClient.Connect();
                forwardedPortDynamic = new ForwardedPortDynamic("127.0.0.1", this._forwardedPort);
                sshClient.AddForwardedPort(forwardedPortDynamic);
                forwardedPortDynamic.Start();    
            }
			catch (Exception ex)
            {
                switch (ex.Message)
                {
                    case "Only one usage of each socket address (protocol/network address/port) is normally permitted" :
                        throw new Exception("Socks Port " + forwardedPort + " is in use. Specify a different port.");
                    case "Permission denied (password)." :
                        throw new Exception("Permission denied. Invalid password specified.");
                    default:
                        throw new Exception(ex.Message);
                }               
            }

            if (sshClient.IsConnected && forwardedPortDynamic.IsStarted)
                return true;
            else return false;

        }

        public bool Disconnect()
        {
            try
            {
                sshClient.Disconnect();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }


}
