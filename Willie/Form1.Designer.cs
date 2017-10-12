namespace Willie
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxPrivateKey = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.labelPrivateKey = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelPort = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxforwardedPort = new System.Windows.Forms.TextBox();
            this.labelforwardedPort = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxPassphrase = new System.Windows.Forms.TextBox();
            this.labelPassphrase = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.horizontalLine1 = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(77, 95);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(168, 20);
            this.textBoxAddress.TabIndex = 0;
            this.textBoxAddress.TextChanged += new System.EventHandler(this.textBoxAddress_TextChanged);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(77, 123);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(135, 20);
            this.textBoxUsername.TabIndex = 2;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(25, 97);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(48, 13);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "Address:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(13, 125);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(58, 13);
            this.labelUsername.TabIndex = 3;
            this.labelUsername.Text = "Username:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(15, 155);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 13);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Password:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(77, 153);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(135, 20);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // textBoxPrivateKey
            // 
            this.textBoxPrivateKey.Location = new System.Drawing.Point(77, 181);
            this.textBoxPrivateKey.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPrivateKey.Name = "textBoxPrivateKey";
            this.textBoxPrivateKey.Size = new System.Drawing.Size(249, 20);
            this.textBoxPrivateKey.TabIndex = 5;
            this.textBoxPrivateKey.TextChanged += new System.EventHandler(this.textBoxPrivateKey_TextChanged);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(263, 208);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(63, 21);
            this.buttonBrowse.TabIndex = 6;
            this.buttonBrowse.Text = "&Browse...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // labelPrivateKey
            // 
            this.labelPrivateKey.AutoSize = true;
            this.labelPrivateKey.Location = new System.Drawing.Point(9, 184);
            this.labelPrivateKey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrivateKey.Name = "labelPrivateKey";
            this.labelPrivateKey.Size = new System.Drawing.Size(64, 13);
            this.labelPrivateKey.TabIndex = 8;
            this.labelPrivateKey.Text = "Private Key:";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(195, 243);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(63, 21);
            this.buttonConnect.TabIndex = 7;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(249, 97);
            this.labelPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(29, 13);
            this.labelPort.TabIndex = 10;
            this.labelPort.Text = "Port:";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(281, 96);
            this.textBoxPort.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(47, 20);
            this.textBoxPort.TabIndex = 1;
            this.textBoxPort.TextChanged += new System.EventHandler(this.textBoxPort_TextChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(263, 243);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(63, 21);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxforwardedPort
            // 
            this.textBoxforwardedPort.Location = new System.Drawing.Point(281, 125);
            this.textBoxforwardedPort.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxforwardedPort.Name = "textBoxforwardedPort";
            this.textBoxforwardedPort.Size = new System.Drawing.Size(47, 20);
            this.textBoxforwardedPort.TabIndex = 4;
            this.textBoxforwardedPort.TextChanged += new System.EventHandler(this.textBoxforwardedPort_TextChanged);
            // 
            // labelforwardedPort
            // 
            this.labelforwardedPort.AutoSize = true;
            this.labelforwardedPort.Location = new System.Drawing.Point(219, 128);
            this.labelforwardedPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelforwardedPort.Name = "labelforwardedPort";
            this.labelforwardedPort.Size = new System.Drawing.Size(62, 13);
            this.labelforwardedPort.TabIndex = 14;
            this.labelforwardedPort.Text = "Socks Port:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "ppk";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "RSA (id_rsa)|id_rsa|Putty key file (*.ppk)|*.ppk|*.*|All files";
            // 
            // textBoxPassphrase
            // 
            this.textBoxPassphrase.Location = new System.Drawing.Point(77, 208);
            this.textBoxPassphrase.Name = "textBoxPassphrase";
            this.textBoxPassphrase.Size = new System.Drawing.Size(135, 20);
            this.textBoxPassphrase.TabIndex = 15;
            this.textBoxPassphrase.TextChanged += new System.EventHandler(this.textBoxPassphrase_TextChanged);
            // 
            // labelPassphrase
            // 
            this.labelPassphrase.AutoSize = true;
            this.labelPassphrase.Location = new System.Drawing.Point(12, 214);
            this.labelPassphrase.Name = "labelPassphrase";
            this.labelPassphrase.Size = new System.Drawing.Size(62, 13);
            this.labelPassphrase.TabIndex = 16;
            this.labelPassphrase.Text = "Passphrase";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Willie.Properties.Resources.willie;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 68);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // horizontalLine1
            // 
            this.horizontalLine1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.horizontalLine1.Location = new System.Drawing.Point(0, 274);
            this.horizontalLine1.Name = "horizontalLine1";
            this.horizontalLine1.Size = new System.Drawing.Size(348, 2);
            this.horizontalLine1.TabIndex = 18;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStatus.Location = new System.Drawing.Point(12, 281);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(169, 13);
            this.textBoxStatus.TabIndex = 19;
            this.textBoxStatus.Text = "Not connected";
            this.textBoxStatus.TextChanged += new System.EventHandler(this.textBoxStatus_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 304);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.horizontalLine1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelPassphrase);
            this.Controls.Add(this.textBoxPassphrase);
            this.Controls.Add(this.labelforwardedPort);
            this.Controls.Add(this.textBoxforwardedPort);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.labelPrivateKey);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxPrivateKey);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxAddress);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Willie - The Tunnel King";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxPrivateKey;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label labelPrivateKey;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxforwardedPort;
        private System.Windows.Forms.Label labelforwardedPort;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxPassphrase;
        private System.Windows.Forms.Label labelPassphrase;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label horizontalLine1;
        private System.Windows.Forms.TextBox textBoxStatus;
    }
}

