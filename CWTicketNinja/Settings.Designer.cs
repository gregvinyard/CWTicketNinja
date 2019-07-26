namespace CWTicketNinja
{
    partial class Settings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.btnApplySettings = new System.Windows.Forms.Button();
            this.btnCancelSettings = new System.Windows.Forms.Button();
            this.btnOkSettings = new System.Windows.Forms.Button();
            this.tabCtlSettings = new System.Windows.Forms.TabControl();
            this.tabSettingsGeneral = new System.Windows.Forms.TabPage();
            this.tabSettingsAccount = new System.Windows.Forms.TabPage();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.tabSettingsHotkeys = new System.Windows.Forms.TabPage();
            this.txtSiteName = new System.Windows.Forms.TextBox();
            this.lblSiteName = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabDebug = new System.Windows.Forms.TabPage();
            this.btnTestNotification = new System.Windows.Forms.Button();
            this.tabCtlSettings.SuspendLayout();
            this.tabSettingsAccount.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabDebug.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApplySettings
            // 
            this.btnApplySettings.Location = new System.Drawing.Point(377, 246);
            this.btnApplySettings.Name = "btnApplySettings";
            this.btnApplySettings.Size = new System.Drawing.Size(75, 23);
            this.btnApplySettings.TabIndex = 0;
            this.btnApplySettings.Text = "Apply";
            this.btnApplySettings.UseVisualStyleBackColor = true;
            // 
            // btnCancelSettings
            // 
            this.btnCancelSettings.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelSettings.Location = new System.Drawing.Point(296, 246);
            this.btnCancelSettings.Name = "btnCancelSettings";
            this.btnCancelSettings.Size = new System.Drawing.Size(75, 23);
            this.btnCancelSettings.TabIndex = 1;
            this.btnCancelSettings.Text = "Cancel";
            this.btnCancelSettings.UseVisualStyleBackColor = true;
            // 
            // btnOkSettings
            // 
            this.btnOkSettings.Location = new System.Drawing.Point(215, 246);
            this.btnOkSettings.Name = "btnOkSettings";
            this.btnOkSettings.Size = new System.Drawing.Size(75, 23);
            this.btnOkSettings.TabIndex = 2;
            this.btnOkSettings.Text = "OK";
            this.btnOkSettings.UseVisualStyleBackColor = true;
            // 
            // tabCtlSettings
            // 
            this.tabCtlSettings.Controls.Add(this.tabSettingsGeneral);
            this.tabCtlSettings.Controls.Add(this.tabSettingsAccount);
            this.tabCtlSettings.Controls.Add(this.tabSettingsHotkeys);
            this.tabCtlSettings.Controls.Add(this.tabDebug);
            this.tabCtlSettings.Location = new System.Drawing.Point(12, 12);
            this.tabCtlSettings.Name = "tabCtlSettings";
            this.tabCtlSettings.SelectedIndex = 0;
            this.tabCtlSettings.Size = new System.Drawing.Size(440, 228);
            this.tabCtlSettings.TabIndex = 3;
            // 
            // tabSettingsGeneral
            // 
            this.tabSettingsGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabSettingsGeneral.Name = "tabSettingsGeneral";
            this.tabSettingsGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettingsGeneral.Size = new System.Drawing.Size(432, 202);
            this.tabSettingsGeneral.TabIndex = 1;
            this.tabSettingsGeneral.Text = "General";
            this.tabSettingsGeneral.UseVisualStyleBackColor = true;
            // 
            // tabSettingsAccount
            // 
            this.tabSettingsAccount.Controls.Add(this.txtSiteName);
            this.tabSettingsAccount.Controls.Add(this.lblSiteName);
            this.tabSettingsAccount.Controls.Add(this.txtCompanyName);
            this.tabSettingsAccount.Controls.Add(this.lblCompanyName);
            this.tabSettingsAccount.Controls.Add(this.txtPassword);
            this.tabSettingsAccount.Controls.Add(this.lblPassword);
            this.tabSettingsAccount.Controls.Add(this.lblUserName);
            this.tabSettingsAccount.Controls.Add(this.txtUserName);
            this.tabSettingsAccount.Location = new System.Drawing.Point(4, 22);
            this.tabSettingsAccount.Name = "tabSettingsAccount";
            this.tabSettingsAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettingsAccount.Size = new System.Drawing.Size(432, 202);
            this.tabSettingsAccount.TabIndex = 0;
            this.tabSettingsAccount.Text = "Account";
            this.tabSettingsAccount.UseVisualStyleBackColor = true;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(102, 42);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(235, 20);
            this.txtCompanyName.TabIndex = 5;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(15, 45);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(51, 13);
            this.lblCompanyName.TabIndex = 4;
            this.lblCompanyName.Text = "Company";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(102, 94);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(235, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(15, 97);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(15, 71);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "User Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(102, 68);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(235, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // tabSettingsHotkeys
            // 
            this.tabSettingsHotkeys.Location = new System.Drawing.Point(4, 22);
            this.tabSettingsHotkeys.Name = "tabSettingsHotkeys";
            this.tabSettingsHotkeys.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettingsHotkeys.Size = new System.Drawing.Size(432, 202);
            this.tabSettingsHotkeys.TabIndex = 2;
            this.tabSettingsHotkeys.Text = "Hotkeys";
            this.tabSettingsHotkeys.UseVisualStyleBackColor = true;
            // 
            // txtSiteName
            // 
            this.txtSiteName.Location = new System.Drawing.Point(102, 16);
            this.txtSiteName.Name = "txtSiteName";
            this.txtSiteName.Size = new System.Drawing.Size(235, 20);
            this.txtSiteName.TabIndex = 7;
            // 
            // lblSiteName
            // 
            this.lblSiteName.AutoSize = true;
            this.lblSiteName.Location = new System.Drawing.Point(15, 19);
            this.lblSiteName.Name = "lblSiteName";
            this.lblSiteName.Size = new System.Drawing.Size(25, 13);
            this.lblSiteName.TabIndex = 6;
            this.lblSiteName.Text = "Site";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 48);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // tabDebug
            // 
            this.tabDebug.Controls.Add(this.btnTestNotification);
            this.tabDebug.Location = new System.Drawing.Point(4, 22);
            this.tabDebug.Name = "tabDebug";
            this.tabDebug.Padding = new System.Windows.Forms.Padding(3);
            this.tabDebug.Size = new System.Drawing.Size(432, 202);
            this.tabDebug.TabIndex = 3;
            this.tabDebug.Text = "Debug";
            this.tabDebug.UseVisualStyleBackColor = true;
            // 
            // btnTestNotification
            // 
            this.btnTestNotification.Location = new System.Drawing.Point(280, 53);
            this.btnTestNotification.Name = "btnTestNotification";
            this.btnTestNotification.Size = new System.Drawing.Size(75, 23);
            this.btnTestNotification.TabIndex = 0;
            this.btnTestNotification.Text = "Test Notification";
            this.btnTestNotification.UseVisualStyleBackColor = true;
            this.btnTestNotification.Click += new System.EventHandler(this.BtnTestNotification_Click);
            // 
            // Settings
            // 
            this.AcceptButton = this.btnOkSettings;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelSettings;
            this.ClientSize = new System.Drawing.Size(464, 281);
            this.Controls.Add(this.tabCtlSettings);
            this.Controls.Add(this.btnOkSettings);
            this.Controls.Add(this.btnCancelSettings);
            this.Controls.Add(this.btnApplySettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Settings";
            this.tabCtlSettings.ResumeLayout(false);
            this.tabSettingsAccount.ResumeLayout(false);
            this.tabSettingsAccount.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabDebug.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApplySettings;
        private System.Windows.Forms.Button btnCancelSettings;
        private System.Windows.Forms.Button btnOkSettings;
        private System.Windows.Forms.TabControl tabCtlSettings;
        private System.Windows.Forms.TabPage tabSettingsGeneral;
        private System.Windows.Forms.TabPage tabSettingsAccount;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TabPage tabSettingsHotkeys;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtSiteName;
        private System.Windows.Forms.Label lblSiteName;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.TabPage tabDebug;
        private System.Windows.Forms.Button btnTestNotification;
    }
}

