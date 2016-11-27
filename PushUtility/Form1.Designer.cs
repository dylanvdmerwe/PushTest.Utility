namespace PushTest.Utility
{
    partial class frmMain
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
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtBadgeCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdbiOS = new System.Windows.Forms.RadioButton();
            this.rdbAndroid = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGoogleApiKey = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCertPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectCert = new System.Windows.Forms.Button();
            this.txtCertFilename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkProduction = new System.Windows.Forms.CheckBox();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(192, 403);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(182, 50);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "SEND MESSAGE";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtBadgeCount);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtMessage);
            this.groupBox4.Controls.Add(this.txtTitle);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(20, 254);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(554, 124);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Push Details";
            // 
            // txtBadgeCount
            // 
            this.txtBadgeCount.Location = new System.Drawing.Point(172, 80);
            this.txtBadgeCount.Name = "txtBadgeCount";
            this.txtBadgeCount.Size = new System.Drawing.Size(83, 20);
            this.txtBadgeCount.TabIndex = 6;
            this.txtBadgeCount.Text = "0";
            this.txtBadgeCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Badge Count";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(172, 53);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(372, 20);
            this.txtMessage.TabIndex = 4;
            this.txtMessage.Text = "This is a test message. Yay";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(172, 27);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(372, 20);
            this.txtTitle.TabIndex = 3;
            this.txtTitle.Text = "Hello!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Message";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Title";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtToken);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.rdbiOS);
            this.groupBox3.Controls.Add(this.rdbAndroid);
            this.groupBox3.Location = new System.Drawing.Point(20, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(553, 102);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Push Settings";
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(172, 56);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(371, 20);
            this.txtToken.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Push Token";
            // 
            // rdbiOS
            // 
            this.rdbiOS.AutoSize = true;
            this.rdbiOS.Checked = true;
            this.rdbiOS.Location = new System.Drawing.Point(172, 20);
            this.rdbiOS.Name = "rdbiOS";
            this.rdbiOS.Size = new System.Drawing.Size(42, 17);
            this.rdbiOS.TabIndex = 1;
            this.rdbiOS.TabStop = true;
            this.rdbiOS.Text = "iOS";
            this.rdbiOS.UseVisualStyleBackColor = true;
            // 
            // rdbAndroid
            // 
            this.rdbAndroid.AutoSize = true;
            this.rdbAndroid.Location = new System.Drawing.Point(288, 20);
            this.rdbAndroid.Name = "rdbAndroid";
            this.rdbAndroid.Size = new System.Drawing.Size(61, 17);
            this.rdbAndroid.TabIndex = 0;
            this.rdbAndroid.Text = "Android";
            this.rdbAndroid.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGoogleApiKey);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtCertPassword);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnSelectCert);
            this.groupBox2.Controls.Add(this.txtCertFilename);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.chkProduction);
            this.groupBox2.Location = new System.Drawing.Point(20, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(551, 128);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Push Configuration";
            // 
            // txtGoogleApiKey
            // 
            this.txtGoogleApiKey.Location = new System.Drawing.Point(170, 82);
            this.txtGoogleApiKey.Name = "txtGoogleApiKey";
            this.txtGoogleApiKey.Size = new System.Drawing.Size(371, 20);
            this.txtGoogleApiKey.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "GCM Sender ID";
            // 
            // txtCertPassword
            // 
            this.txtCertPassword.Location = new System.Drawing.Point(170, 56);
            this.txtCertPassword.Name = "txtCertPassword";
            this.txtCertPassword.Size = new System.Drawing.Size(371, 20);
            this.txtCertPassword.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apple Cert Password";
            // 
            // btnSelectCert
            // 
            this.btnSelectCert.Location = new System.Drawing.Point(429, 27);
            this.btnSelectCert.Name = "btnSelectCert";
            this.btnSelectCert.Size = new System.Drawing.Size(25, 23);
            this.btnSelectCert.TabIndex = 6;
            this.btnSelectCert.Text = ">";
            this.btnSelectCert.UseVisualStyleBackColor = true;
            this.btnSelectCert.Click += new System.EventHandler(this.btnSelectCert_Click);
            // 
            // txtCertFilename
            // 
            this.txtCertFilename.Location = new System.Drawing.Point(170, 29);
            this.txtCertFilename.Name = "txtCertFilename";
            this.txtCertFilename.ReadOnly = true;
            this.txtCertFilename.Size = new System.Drawing.Size(260, 20);
            this.txtCertFilename.TabIndex = 6;
            this.txtCertFilename.Text = ".p12";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Apple Push Cert";
            // 
            // chkProduction
            // 
            this.chkProduction.AutoSize = true;
            this.chkProduction.Location = new System.Drawing.Point(465, 31);
            this.chkProduction.Name = "chkProduction";
            this.chkProduction.Size = new System.Drawing.Size(77, 17);
            this.chkProduction.TabIndex = 1;
            this.chkProduction.Text = "Production";
            this.chkProduction.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 472);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmMain";
            this.Text = "Push Test Utility";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtBadgeCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbiOS;
        private System.Windows.Forms.RadioButton rdbAndroid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCertFilename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkProduction;
        private System.Windows.Forms.TextBox txtGoogleApiKey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCertPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectCert;
    }
}

