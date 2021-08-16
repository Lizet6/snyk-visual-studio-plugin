﻿namespace Snyk.VisualStudio.Extension.Settings
{
    partial class SnykGeneralSettingsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.customEndpointTextBox = new System.Windows.Forms.TextBox();
            this.customEndpointLabel = new System.Windows.Forms.Label();
            this.organizationLabel = new System.Windows.Forms.Label();
            this.organizationTextBox = new System.Windows.Forms.TextBox();
            this.tokenLabel = new System.Windows.Forms.Label();
            this.tokenTextBox = new System.Windows.Forms.TextBox();
            this.ignoreUnknownCACheckBox = new System.Windows.Forms.CheckBox();
            this.authenticateButton = new System.Windows.Forms.Button();
            this.authProgressBar = new System.Windows.Forms.ProgressBar();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.usageAnalyticsCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ossEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.codeSecurityEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.codeQualityEnabledCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // customEndpointTextBox
            // 
            this.customEndpointTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customEndpointTextBox.Location = new System.Drawing.Point(238, 88);
            this.customEndpointTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.customEndpointTextBox.Name = "customEndpointTextBox";
            this.customEndpointTextBox.Size = new System.Drawing.Size(899, 31);
            this.customEndpointTextBox.TabIndex = 0;
            this.customEndpointTextBox.TextChanged += new System.EventHandler(this.CustomEndpointTextBox_TextChanged);
            this.customEndpointTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.CustomEndpointTextBox_Validating);
            // 
            // customEndpointLabel
            // 
            this.customEndpointLabel.AutoSize = true;
            this.customEndpointLabel.Location = new System.Drawing.Point(4, 95);
            this.customEndpointLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customEndpointLabel.Name = "customEndpointLabel";
            this.customEndpointLabel.Size = new System.Drawing.Size(180, 25);
            this.customEndpointLabel.TabIndex = 1;
            this.customEndpointLabel.Text = "Custom endpoint:";
            // 
            // organizationLabel
            // 
            this.organizationLabel.AutoSize = true;
            this.organizationLabel.Location = new System.Drawing.Point(4, 166);
            this.organizationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.organizationLabel.Name = "organizationLabel";
            this.organizationLabel.Size = new System.Drawing.Size(140, 25);
            this.organizationLabel.TabIndex = 2;
            this.organizationLabel.Text = "Organization:";
            // 
            // organizationTextBox
            // 
            this.organizationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.organizationTextBox.Location = new System.Drawing.Point(238, 166);
            this.organizationTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.organizationTextBox.Name = "organizationTextBox";
            this.organizationTextBox.Size = new System.Drawing.Size(899, 31);
            this.organizationTextBox.TabIndex = 3;
            this.organizationTextBox.TextChanged += new System.EventHandler(this.OrganizationTextBox_TextChanged);
            // 
            // tokenLabel
            // 
            this.tokenLabel.AutoSize = true;
            this.tokenLabel.Location = new System.Drawing.Point(4, 30);
            this.tokenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tokenLabel.Name = "tokenLabel";
            this.tokenLabel.Size = new System.Drawing.Size(78, 25);
            this.tokenLabel.TabIndex = 4;
            this.tokenLabel.Text = "Token:";
            // 
            // tokenTextBox
            // 
            this.tokenTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tokenTextBox.Location = new System.Drawing.Point(238, 22);
            this.tokenTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.tokenTextBox.Name = "tokenTextBox";
            this.tokenTextBox.PasswordChar = '*';
            this.tokenTextBox.Size = new System.Drawing.Size(899, 31);
            this.tokenTextBox.TabIndex = 5;
            this.tokenTextBox.TextChanged += new System.EventHandler(this.TokenTextBox_TextChanged);
            this.tokenTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TokenTextBox_Validating);
            // 
            // ignoreUnknownCACheckBox
            // 
            this.ignoreUnknownCACheckBox.AutoSize = true;
            this.ignoreUnknownCACheckBox.Location = new System.Drawing.Point(238, 128);
            this.ignoreUnknownCACheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ignoreUnknownCACheckBox.Name = "ignoreUnknownCACheckBox";
            this.ignoreUnknownCACheckBox.Size = new System.Drawing.Size(231, 29);
            this.ignoreUnknownCACheckBox.TabIndex = 6;
            this.ignoreUnknownCACheckBox.Text = "Ignore unknown CA";
            this.ignoreUnknownCACheckBox.UseVisualStyleBackColor = true;
            this.ignoreUnknownCACheckBox.CheckedChanged += new System.EventHandler(this.IgnoreUnknownCACheckBox_CheckedChanged);
            // 
            // authenticateButton
            // 
            this.authenticateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.authenticateButton.Location = new System.Drawing.Point(1183, 18);
            this.authenticateButton.Margin = new System.Windows.Forms.Padding(6);
            this.authenticateButton.Name = "authenticateButton";
            this.authenticateButton.Size = new System.Drawing.Size(165, 39);
            this.authenticateButton.TabIndex = 7;
            this.authenticateButton.Text = "Authenticate";
            this.authenticateButton.UseVisualStyleBackColor = true;
            this.authenticateButton.Click += new System.EventHandler(this.AuthenticateButton_Click);
            // 
            // authProgressBar
            // 
            this.authProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authProgressBar.Location = new System.Drawing.Point(238, 59);
            this.authProgressBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.authProgressBar.MarqueeAnimationSpeed = 10;
            this.authProgressBar.Name = "authProgressBar";
            this.authProgressBar.Size = new System.Drawing.Size(900, 10);
            this.authProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.authProgressBar.TabIndex = 8;
            this.authProgressBar.Visible = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // usageAnalyticsCheckBox
            // 
            this.usageAnalyticsCheckBox.AutoSize = true;
            this.usageAnalyticsCheckBox.Checked = true;
            this.usageAnalyticsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.usageAnalyticsCheckBox.Location = new System.Drawing.Point(238, 492);
            this.usageAnalyticsCheckBox.Name = "usageAnalyticsCheckBox";
            this.usageAnalyticsCheckBox.Size = new System.Drawing.Size(250, 29);
            this.usageAnalyticsCheckBox.TabIndex = 9;
            this.usageAnalyticsCheckBox.Text = "Send usage analytics";
            this.usageAnalyticsCheckBox.UseVisualStyleBackColor = true;
            this.usageAnalyticsCheckBox.CheckedChanged += new System.EventHandler(this.UsageAnalyticsCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(238, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(898, 10);
            this.label1.TabIndex = 10;
            // 
            // ossEnabledCheckBox
            // 
            this.ossEnabledCheckBox.AutoSize = true;
            this.ossEnabledCheckBox.Checked = true;
            this.ossEnabledCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ossEnabledCheckBox.Location = new System.Drawing.Point(238, 285);
            this.ossEnabledCheckBox.Name = "ossEnabledCheckBox";
            this.ossEnabledCheckBox.Size = new System.Drawing.Size(362, 29);
            this.ossEnabledCheckBox.TabIndex = 11;
            this.ossEnabledCheckBox.Text = "Snyk Open Source vulnerabilities";
            this.ossEnabledCheckBox.UseVisualStyleBackColor = true;
            this.ossEnabledCheckBox.CheckedChanged += new System.EventHandler(this.OssEnabledCheckBox_CheckedChanged);
            // 
            // codeSecurityEnabledCheckBox
            // 
            this.codeSecurityEnabledCheckBox.AutoSize = true;
            this.codeSecurityEnabledCheckBox.Checked = true;
            this.codeSecurityEnabledCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.codeSecurityEnabledCheckBox.Location = new System.Drawing.Point(238, 331);
            this.codeSecurityEnabledCheckBox.Name = "codeSecurityEnabledCheckBox";
            this.codeSecurityEnabledCheckBox.Size = new System.Drawing.Size(301, 29);
            this.codeSecurityEnabledCheckBox.TabIndex = 12;
            this.codeSecurityEnabledCheckBox.Text = "Snyk Code Security issues";
            this.codeSecurityEnabledCheckBox.UseVisualStyleBackColor = true;
            this.codeSecurityEnabledCheckBox.CheckedChanged += new System.EventHandler(this.CodeSecurityEnabledCheckBox_CheckedChanged);
            // 
            // codeQualityEnabledCheckBox
            // 
            this.codeQualityEnabledCheckBox.AutoSize = true;
            this.codeQualityEnabledCheckBox.Location = new System.Drawing.Point(238, 376);
            this.codeQualityEnabledCheckBox.Name = "codeQualityEnabledCheckBox";
            this.codeQualityEnabledCheckBox.Size = new System.Drawing.Size(290, 29);
            this.codeQualityEnabledCheckBox.TabIndex = 13;
            this.codeQualityEnabledCheckBox.Text = "Snyk Code Quality issues";
            this.codeQualityEnabledCheckBox.UseVisualStyleBackColor = true;
            this.codeQualityEnabledCheckBox.CheckedChanged += new System.EventHandler(this.CodeQualityEnabledCheckBox_CheckedChanged);
            // 
            // SnykGeneralSettingsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.codeQualityEnabledCheckBox);
            this.Controls.Add(this.codeSecurityEnabledCheckBox);
            this.Controls.Add(this.ossEnabledCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usageAnalyticsCheckBox);
            this.Controls.Add(this.authProgressBar);
            this.Controls.Add(this.authenticateButton);
            this.Controls.Add(this.ignoreUnknownCACheckBox);
            this.Controls.Add(this.tokenTextBox);
            this.Controls.Add(this.tokenLabel);
            this.Controls.Add(this.organizationTextBox);
            this.Controls.Add(this.organizationLabel);
            this.Controls.Add(this.customEndpointLabel);
            this.Controls.Add(this.customEndpointTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SnykGeneralSettingsUserControl";
            this.Size = new System.Drawing.Size(1368, 586);
            this.Load += new System.EventHandler(this.SnykGeneralSettingsUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customEndpointTextBox;
        private System.Windows.Forms.Label customEndpointLabel;
        private System.Windows.Forms.Label organizationLabel;
        private System.Windows.Forms.TextBox organizationTextBox;
        private System.Windows.Forms.Label tokenLabel;
        private System.Windows.Forms.TextBox tokenTextBox;
        private System.Windows.Forms.CheckBox ignoreUnknownCACheckBox;
        private System.Windows.Forms.Button authenticateButton;
        private System.Windows.Forms.ProgressBar authProgressBar;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.CheckBox usageAnalyticsCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox codeQualityEnabledCheckBox;
        private System.Windows.Forms.CheckBox codeSecurityEnabledCheckBox;
        private System.Windows.Forms.CheckBox ossEnabledCheckBox;
    }
}
