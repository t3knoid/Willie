using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Willie
{
    public partial class Form1 : Form
    {
        private bool isConnected = false;
        private bool requiresSaving = false;

        // Using this property to control enabling and disabling the Connect button
        // when we successfully make a connection.
        public bool Connected
        {
            get {return isConnected;}
            set
            {
                isConnected = value;
                if (isConnected == true)
                {
                    this.buttonConnect.Enabled = false;
                    this.textBoxStatus.Text = "Connected";
                }
                else
                {
                    this.buttonConnect.Enabled = true;
                    this.textBoxStatus.Text = "Not Connected";
                }
                    
            }
        }
        Config config = new Config();
        SSH ssh = new SSH();

        public Form1()
        {
            InitializeComponent();
            //
            // Initialize form fields
            //
            this.textBoxUsername.Text = config.username;
            this.textBoxPassword.Text = config.password;
            this.textBoxAddress.Text = config.address;
            this.textBoxPort.Text = config.port.ToString();
            this.textBoxforwardedPort.Text = config.forwardedport.ToString();
            this.textBoxPrivateKey.Text = config.privatekey;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Connected)
            {
                var result = MessageBox.Show("Save changes before exiting?", "Save Changes", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.Yes:
                        // Disconnect
                        ssh.Disconnect();
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            this.textBoxStatus.Text = "Connecting...";
            if (requiresSaving) ConfigSave();
            OpenConnection();
        }

        private void ConfigSave()
        {

            try
            {
                config.username = this.textBoxUsername.Text;
                config.password = this.textBoxPassword.Text;
                config.address = this.textBoxAddress.Text;
                config.port = Convert.ToInt32(this.textBoxPort.Text);
                config.forwardedport= Convert.ToUInt32(this.textBoxforwardedPort.Text);
                config.privatekey = this.textBoxPrivateKey.Text;
                config.passphrase = this.textBoxPassphrase.Text;
                config.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in saving. " + ex.Message + " " + ex.StackTrace);
            }

        }
        private bool OpenConnection()
        {
            try
            {
                Connected = ssh.Connect();
                //MessageBox.Show("Connected successfully", "Connected", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return false;
        }

        private void CloseConnection()
        {
            try
            {
                ssh.Disconnect();
                //MessageBox.Show("Disconnected.");
                Connected = false;
                textBoxStatus.Text = "Not Connected";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (Connected)
            {
                CloseConnection();
            }
            else
            {
                Application.Exit();
            }
        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {
            requiresSaving = true;
            ssh.address = textBoxAddress.Text;
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            requiresSaving = true;
            ssh.username = textBoxUsername.Text;
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxPassword.Text))
            {
                buttonBrowse.Enabled = false;
                textBoxPassphrase.Enabled = false;
                textBoxPrivateKey.Enabled = false;
            }
            else
            {
                buttonBrowse.Enabled = true;
                textBoxPassphrase.Enabled = true;
                textBoxPrivateKey.Enabled = true;
            }
            requiresSaving = true;
            ssh.password = textBoxPassword.Text;
        }

        private void textBoxPort_TextChanged(object sender, EventArgs e)
        {
            requiresSaving = true;
            ssh.port = textBoxPort.Text;
        }

        private void textBoxPrivateKey_TextChanged(object sender, EventArgs e)
        {
            requiresSaving = true;
            ssh.keyfile = textBoxPrivateKey.Text;
        }

        private void textBoxforwardedPort_TextChanged(object sender, EventArgs e)
        {
            requiresSaving = true;
            if (String.IsNullOrEmpty(textBoxforwardedPort.Text))
                ssh.forwardedPort = "0";
            else
                ssh.forwardedPort = textBoxforwardedPort.Text;           
        }

        private void textBoxPassphrase_TextChanged(object sender, EventArgs e)
        {
            requiresSaving = true;
            ssh.passphrase = textBoxPassphrase.Text;
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                this.textBoxPrivateKey.Text = openFileDialog1.FileName.ToString();
            }

        }

        private void textBoxStatus_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
