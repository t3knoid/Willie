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
            this.textBoxPort.Text = config.port;
            this.textBoxforwardedPort.Text = config.fport;
            //this.textBoxPrivateKey.Text = config.pk;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isConnected)
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
            if (requiresSaving)
            {
                config.Save();
            }
            OpenConnection();
        }

        private void OpenConnection()
        {
            isConnected = ssh.Connect();
            if (isConnected)
            {
                MessageBox.Show("Connected successfully", "Connected", MessageBoxButtons.OK);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            requiresSaving = true;
            ssh.forwardedPort = Convert.ToUInt32(textBoxforwardedPort.Text);           
        }
    }
}
