﻿namespace KeeOtp2
{
    partial class OtpInformation
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
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.textBoxStep = new System.Windows.Forms.TextBox();
            this.radioButtonSix = new System.Windows.Forms.RadioButton();
            this.labelStep = new System.Windows.Forms.Label();
            this.radioButtonEight = new System.Windows.Forms.RadioButton();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.radioButtonBase32 = new System.Windows.Forms.RadioButton();
            this.radioButtonBase64 = new System.Windows.Forms.RadioButton();
            this.radioButtonHex = new System.Windows.Forms.RadioButton();
            this.pictureBoxBanner = new System.Windows.Forms.PictureBox();
            this.checkBoxCustomSettings = new System.Windows.Forms.CheckBox();
            this.radioButtonSha256 = new System.Windows.Forms.RadioButton();
            this.radioButtonSha512 = new System.Windows.Forms.RadioButton();
            this.radioButtonSha1 = new System.Windows.Forms.RadioButton();
            this.groupboxHashAlgorithm = new System.Windows.Forms.GroupBox();
            this.groupboxTimeStep = new System.Windows.Forms.GroupBox();
            this.groupboxEncoding = new System.Windows.Forms.GroupBox();
            this.radioButtonUtf8 = new System.Windows.Forms.RadioButton();
            this.groupboxSize = new System.Windows.Forms.GroupBox();
            this.textBoxCustomDigits = new System.Windows.Forms.TextBox();
            this.radioButtonCustomDigits = new System.Windows.Forms.RadioButton();
            this.groupboxInfo = new System.Windows.Forms.GroupBox();
            this.checkboxOldKeeOtp = new System.Windows.Forms.CheckBox();
            this.linkLabelLoadUriScanQR = new System.Windows.Forms.LinkLabel();
            this.groupBoxKey = new System.Windows.Forms.GroupBox();
            this.timerUpdateTotp = new System.Windows.Forms.Timer(this.components);
            this.linkLabelMigrate = new System.Windows.Forms.LinkLabel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.groupBoxTransform = new System.Windows.Forms.GroupBox();
            this.radioButtonDigits = new System.Windows.Forms.RadioButton();
            this.radioButtonSteam = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).BeginInit();
            this.groupboxHashAlgorithm.SuspendLayout();
            this.groupboxTimeStep.SuspendLayout();
            this.groupboxEncoding.SuspendLayout();
            this.groupboxSize.SuspendLayout();
            this.groupboxInfo.SuspendLayout();
            this.groupBoxKey.SuspendLayout();
            this.groupBoxTransform.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(6, 19);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(446, 20);
            this.textBoxKey.TabIndex = 0;
            this.textBoxKey.TextChanged += new System.EventHandler(this.textBoxKey_TextChanged);
            this.textBoxKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxKey_KeyDown);
            // 
            // textBoxStep
            // 
            this.textBoxStep.Location = new System.Drawing.Point(118, 13);
            this.textBoxStep.Name = "textBoxStep";
            this.textBoxStep.Size = new System.Drawing.Size(20, 20);
            this.textBoxStep.TabIndex = 1;
            // 
            // radioButtonSix
            // 
            this.radioButtonSix.AutoSize = true;
            this.radioButtonSix.Checked = true;
            this.radioButtonSix.Location = new System.Drawing.Point(6, 19);
            this.radioButtonSix.Name = "radioButtonSix";
            this.radioButtonSix.Size = new System.Drawing.Size(60, 17);
            this.radioButtonSix.TabIndex = 2;
            this.radioButtonSix.TabStop = true;
            this.radioButtonSix.Text = "6 Digits";
            this.radioButtonSix.UseVisualStyleBackColor = true;
            // 
            // labelStep
            // 
            this.labelStep.AutoSize = true;
            this.labelStep.Location = new System.Drawing.Point(6, 16);
            this.labelStep.Name = "labelStep";
            this.labelStep.Size = new System.Drawing.Size(106, 13);
            this.labelStep.TabIndex = 4;
            this.labelStep.Text = "Time Step (Seconds)";
            // 
            // radioButtonEight
            // 
            this.radioButtonEight.AutoSize = true;
            this.radioButtonEight.Location = new System.Drawing.Point(6, 42);
            this.radioButtonEight.Name = "radioButtonEight";
            this.radioButtonEight.Size = new System.Drawing.Size(60, 17);
            this.radioButtonEight.TabIndex = 6;
            this.radioButtonEight.Text = "8 Digits";
            this.radioButtonEight.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(317, 312);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 7;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(398, 312);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // radioButtonBase32
            // 
            this.radioButtonBase32.AutoSize = true;
            this.radioButtonBase32.Checked = true;
            this.radioButtonBase32.Location = new System.Drawing.Point(6, 19);
            this.radioButtonBase32.Name = "radioButtonBase32";
            this.radioButtonBase32.Size = new System.Drawing.Size(64, 17);
            this.radioButtonBase32.TabIndex = 9;
            this.radioButtonBase32.TabStop = true;
            this.radioButtonBase32.Text = "Base 32";
            this.radioButtonBase32.UseVisualStyleBackColor = true;
            // 
            // radioButtonBase64
            // 
            this.radioButtonBase64.AutoSize = true;
            this.radioButtonBase64.Location = new System.Drawing.Point(6, 42);
            this.radioButtonBase64.Name = "radioButtonBase64";
            this.radioButtonBase64.Size = new System.Drawing.Size(64, 17);
            this.radioButtonBase64.TabIndex = 10;
            this.radioButtonBase64.Text = "Base 64";
            this.radioButtonBase64.UseVisualStyleBackColor = true;
            // 
            // radioButtonHex
            // 
            this.radioButtonHex.AutoSize = true;
            this.radioButtonHex.Location = new System.Drawing.Point(6, 65);
            this.radioButtonHex.Name = "radioButtonHex";
            this.radioButtonHex.Size = new System.Drawing.Size(44, 17);
            this.radioButtonHex.TabIndex = 11;
            this.radioButtonHex.Text = "Hex";
            this.radioButtonHex.UseVisualStyleBackColor = true;
            // 
            // pictureBoxBanner
            // 
            this.pictureBoxBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxBanner.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBanner.Name = "pictureBoxBanner";
            this.pictureBoxBanner.Size = new System.Drawing.Size(490, 58);
            this.pictureBoxBanner.TabIndex = 12;
            this.pictureBoxBanner.TabStop = false;
            // 
            // checkBoxCustomSettings
            // 
            this.checkBoxCustomSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxCustomSettings.AutoSize = true;
            this.checkBoxCustomSettings.Location = new System.Drawing.Point(21, 120);
            this.checkBoxCustomSettings.Name = "checkBoxCustomSettings";
            this.checkBoxCustomSettings.Size = new System.Drawing.Size(128, 17);
            this.checkBoxCustomSettings.TabIndex = 13;
            this.checkBoxCustomSettings.Text = "Use Custom Settings*";
            this.checkBoxCustomSettings.UseVisualStyleBackColor = true;
            this.checkBoxCustomSettings.CheckedChanged += new System.EventHandler(this.checkBoxCustomSettings_CheckedChanged);
            // 
            // radioButtonSha256
            // 
            this.radioButtonSha256.AutoSize = true;
            this.radioButtonSha256.Location = new System.Drawing.Point(6, 42);
            this.radioButtonSha256.Name = "radioButtonSha256";
            this.radioButtonSha256.Size = new System.Drawing.Size(65, 17);
            this.radioButtonSha256.TabIndex = 14;
            this.radioButtonSha256.Text = "Sha-256";
            this.radioButtonSha256.UseVisualStyleBackColor = true;
            // 
            // radioButtonSha512
            // 
            this.radioButtonSha512.AutoSize = true;
            this.radioButtonSha512.Location = new System.Drawing.Point(6, 65);
            this.radioButtonSha512.Name = "radioButtonSha512";
            this.radioButtonSha512.Size = new System.Drawing.Size(65, 17);
            this.radioButtonSha512.TabIndex = 15;
            this.radioButtonSha512.Text = "Sha-512";
            this.radioButtonSha512.UseVisualStyleBackColor = true;
            // 
            // radioButtonSha1
            // 
            this.radioButtonSha1.AutoSize = true;
            this.radioButtonSha1.Checked = true;
            this.radioButtonSha1.Location = new System.Drawing.Point(6, 19);
            this.radioButtonSha1.Name = "radioButtonSha1";
            this.radioButtonSha1.Size = new System.Drawing.Size(53, 17);
            this.radioButtonSha1.TabIndex = 16;
            this.radioButtonSha1.TabStop = true;
            this.radioButtonSha1.Text = "Sha-1";
            this.radioButtonSha1.UseVisualStyleBackColor = true;
            // 
            // groupboxHashAlgorithm
            // 
            this.groupboxHashAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupboxHashAlgorithm.Controls.Add(this.radioButtonSha1);
            this.groupboxHashAlgorithm.Controls.Add(this.radioButtonSha512);
            this.groupboxHashAlgorithm.Controls.Add(this.radioButtonSha256);
            this.groupboxHashAlgorithm.Location = new System.Drawing.Point(247, 190);
            this.groupboxHashAlgorithm.Name = "groupboxHashAlgorithm";
            this.groupboxHashAlgorithm.Size = new System.Drawing.Size(110, 113);
            this.groupboxHashAlgorithm.TabIndex = 17;
            this.groupboxHashAlgorithm.TabStop = false;
            this.groupboxHashAlgorithm.Text = "Hash Algorithm";
            // 
            // groupboxTimeStep
            // 
            this.groupboxTimeStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupboxTimeStep.Controls.Add(this.labelStep);
            this.groupboxTimeStep.Controls.Add(this.textBoxStep);
            this.groupboxTimeStep.Location = new System.Drawing.Point(15, 143);
            this.groupboxTimeStep.Name = "groupboxTimeStep";
            this.groupboxTimeStep.Size = new System.Drawing.Size(226, 41);
            this.groupboxTimeStep.TabIndex = 17;
            this.groupboxTimeStep.TabStop = false;
            this.groupboxTimeStep.Text = "Time Step";
            // 
            // groupboxEncoding
            // 
            this.groupboxEncoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupboxEncoding.Controls.Add(this.radioButtonUtf8);
            this.groupboxEncoding.Controls.Add(this.radioButtonBase32);
            this.groupboxEncoding.Controls.Add(this.radioButtonBase64);
            this.groupboxEncoding.Controls.Add(this.radioButtonHex);
            this.groupboxEncoding.Location = new System.Drawing.Point(15, 190);
            this.groupboxEncoding.Name = "groupboxEncoding";
            this.groupboxEncoding.Size = new System.Drawing.Size(110, 113);
            this.groupboxEncoding.TabIndex = 5;
            this.groupboxEncoding.TabStop = false;
            this.groupboxEncoding.Text = "Encoding";
            // 
            // radioButtonUtf8
            // 
            this.radioButtonUtf8.AutoSize = true;
            this.radioButtonUtf8.Location = new System.Drawing.Point(6, 88);
            this.radioButtonUtf8.Name = "radioButtonUtf8";
            this.radioButtonUtf8.Size = new System.Drawing.Size(48, 17);
            this.radioButtonUtf8.TabIndex = 12;
            this.radioButtonUtf8.Text = "Utf-8";
            this.radioButtonUtf8.UseVisualStyleBackColor = true;
            // 
            // groupboxSize
            // 
            this.groupboxSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupboxSize.Controls.Add(this.textBoxCustomDigits);
            this.groupboxSize.Controls.Add(this.radioButtonCustomDigits);
            this.groupboxSize.Controls.Add(this.radioButtonSix);
            this.groupboxSize.Controls.Add(this.radioButtonEight);
            this.groupboxSize.Location = new System.Drawing.Point(131, 190);
            this.groupboxSize.Name = "groupboxSize";
            this.groupboxSize.Size = new System.Drawing.Size(110, 113);
            this.groupboxSize.TabIndex = 12;
            this.groupboxSize.TabStop = false;
            this.groupboxSize.Text = "Size";
            // 
            // textBoxCustomDigits
            // 
            this.textBoxCustomDigits.Location = new System.Drawing.Point(70, 64);
            this.textBoxCustomDigits.Name = "textBoxCustomDigits";
            this.textBoxCustomDigits.Size = new System.Drawing.Size(34, 20);
            this.textBoxCustomDigits.TabIndex = 26;
            // 
            // radioButtonCustomDigits
            // 
            this.radioButtonCustomDigits.AutoSize = true;
            this.radioButtonCustomDigits.Location = new System.Drawing.Point(6, 65);
            this.radioButtonCustomDigits.Name = "radioButtonCustomDigits";
            this.radioButtonCustomDigits.Size = new System.Drawing.Size(63, 17);
            this.radioButtonCustomDigits.TabIndex = 25;
            this.radioButtonCustomDigits.TabStop = true;
            this.radioButtonCustomDigits.Text = "Custom:";
            this.radioButtonCustomDigits.UseVisualStyleBackColor = true;
            this.radioButtonCustomDigits.CheckedChanged += new System.EventHandler(this.radioButtonCustomDigits_CheckedChanged);
            // 
            // groupboxInfo
            // 
            this.groupboxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupboxInfo.Controls.Add(this.checkboxOldKeeOtp);
            this.groupboxInfo.Location = new System.Drawing.Point(247, 143);
            this.groupboxInfo.Name = "groupboxInfo";
            this.groupboxInfo.Size = new System.Drawing.Size(226, 41);
            this.groupboxInfo.TabIndex = 5;
            this.groupboxInfo.TabStop = false;
            this.groupboxInfo.Text = "KeeOtp1 String (Deprecated)";
            // 
            // checkboxOldKeeOtp
            // 
            this.checkboxOldKeeOtp.AutoSize = true;
            this.checkboxOldKeeOtp.Location = new System.Drawing.Point(6, 15);
            this.checkboxOldKeeOtp.Name = "checkboxOldKeeOtp";
            this.checkboxOldKeeOtp.Size = new System.Drawing.Size(160, 17);
            this.checkboxOldKeeOtp.TabIndex = 0;
            this.checkboxOldKeeOtp.Text = "Use old KeeOtp save mode*";
            this.checkboxOldKeeOtp.UseVisualStyleBackColor = true;
            // 
            // linkLabelLoadUriScanQR
            // 
            this.linkLabelLoadUriScanQR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelLoadUriScanQR.Location = new System.Drawing.Point(375, 0);
            this.linkLabelLoadUriScanQR.Name = "linkLabelLoadUriScanQR";
            this.linkLabelLoadUriScanQR.Size = new System.Drawing.Size(80, 13);
            this.linkLabelLoadUriScanQR.TabIndex = 20;
            this.linkLabelLoadUriScanQR.TabStop = true;
            this.linkLabelLoadUriScanQR.Text = "Scan QR Code";
            this.linkLabelLoadUriScanQR.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkLabelLoadUriScanQR.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLoadUriScanQR_LinkClicked);
            // 
            // groupBoxKey
            // 
            this.groupBoxKey.Controls.Add(this.textBoxKey);
            this.groupBoxKey.Controls.Add(this.linkLabelLoadUriScanQR);
            this.groupBoxKey.Location = new System.Drawing.Point(15, 64);
            this.groupBoxKey.Name = "groupBoxKey";
            this.groupBoxKey.Size = new System.Drawing.Size(458, 49);
            this.groupBoxKey.TabIndex = 22;
            this.groupBoxKey.TabStop = false;
            this.groupBoxKey.Text = "Key or Uri (otpauth://):";
            // 
            // timerUpdateTotp
            // 
            this.timerUpdateTotp.Interval = 1000;
            this.timerUpdateTotp.Tick += new System.EventHandler(this.timerUpdateTotp_Tick);
            // 
            // linkLabelMigrate
            // 
            this.linkLabelMigrate.AutoSize = true;
            this.linkLabelMigrate.Enabled = false;
            this.linkLabelMigrate.Location = new System.Drawing.Point(379, 121);
            this.linkLabelMigrate.Name = "linkLabelMigrate";
            this.linkLabelMigrate.Size = new System.Drawing.Size(91, 13);
            this.linkLabelMigrate.TabIndex = 23;
            this.linkLabelMigrate.TabStop = true;
            this.linkLabelMigrate.Text = "Migrate to built-in*";
            this.linkLabelMigrate.Visible = false;
            this.linkLabelMigrate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMigrate_LinkClicked);
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelStatus.AutoSize = true;
            this.labelStatus.Enabled = false;
            this.labelStatus.Location = new System.Drawing.Point(12, 317);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(141, 13);
            this.labelStatus.TabIndex = 24;
            this.labelStatus.Text = "(*Hover for more information)";
            // 
            // groupBoxTransform
            // 
            this.groupBoxTransform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxTransform.Controls.Add(this.radioButtonDigits);
            this.groupBoxTransform.Controls.Add(this.radioButtonSteam);
            this.groupBoxTransform.Location = new System.Drawing.Point(363, 190);
            this.groupBoxTransform.Name = "groupBoxTransform";
            this.groupBoxTransform.Size = new System.Drawing.Size(110, 113);
            this.groupBoxTransform.TabIndex = 18;
            this.groupBoxTransform.TabStop = false;
            this.groupBoxTransform.Text = "Transform";
            // 
            // radioButtonDigits
            // 
            this.radioButtonDigits.AutoSize = true;
            this.radioButtonDigits.Checked = true;
            this.radioButtonDigits.Location = new System.Drawing.Point(6, 19);
            this.radioButtonDigits.Name = "radioButtonDigits";
            this.radioButtonDigits.Size = new System.Drawing.Size(51, 17);
            this.radioButtonDigits.TabIndex = 16;
            this.radioButtonDigits.TabStop = true;
            this.radioButtonDigits.Text = "Digits";
            this.radioButtonDigits.UseVisualStyleBackColor = true;
            // 
            // radioButtonSteam
            // 
            this.radioButtonSteam.AutoSize = true;
            this.radioButtonSteam.Location = new System.Drawing.Point(6, 42);
            this.radioButtonSteam.Name = "radioButtonSteam";
            this.radioButtonSteam.Size = new System.Drawing.Size(55, 17);
            this.radioButtonSteam.TabIndex = 14;
            this.radioButtonSteam.Text = "Steam";
            this.radioButtonSteam.UseVisualStyleBackColor = true;
            // 
            // OtpInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 350);
            this.Controls.Add(this.groupBoxTransform);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.linkLabelMigrate);
            this.Controls.Add(this.groupBoxKey);
            this.Controls.Add(this.groupboxInfo);
            this.Controls.Add(this.groupboxSize);
            this.Controls.Add(this.groupboxEncoding);
            this.Controls.Add(this.groupboxTimeStep);
            this.Controls.Add(this.groupboxHashAlgorithm);
            this.Controls.Add(this.checkBoxCustomSettings);
            this.Controls.Add(this.pictureBoxBanner);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OtpInformation";
            this.Text = "Configuration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OtpInformation_FormClosing);
            this.Load += new System.EventHandler(this.OtpInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).EndInit();
            this.groupboxHashAlgorithm.ResumeLayout(false);
            this.groupboxHashAlgorithm.PerformLayout();
            this.groupboxTimeStep.ResumeLayout(false);
            this.groupboxTimeStep.PerformLayout();
            this.groupboxEncoding.ResumeLayout(false);
            this.groupboxEncoding.PerformLayout();
            this.groupboxSize.ResumeLayout(false);
            this.groupboxSize.PerformLayout();
            this.groupboxInfo.ResumeLayout(false);
            this.groupboxInfo.PerformLayout();
            this.groupBoxKey.ResumeLayout(false);
            this.groupBoxKey.PerformLayout();
            this.groupBoxTransform.ResumeLayout(false);
            this.groupBoxTransform.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.TextBox textBoxStep;
        private System.Windows.Forms.RadioButton radioButtonSix;
        private System.Windows.Forms.Label labelStep;
        private System.Windows.Forms.RadioButton radioButtonEight;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.RadioButton radioButtonBase32;
        private System.Windows.Forms.RadioButton radioButtonBase64;
        private System.Windows.Forms.RadioButton radioButtonHex;
        private System.Windows.Forms.PictureBox pictureBoxBanner;
        private System.Windows.Forms.CheckBox checkBoxCustomSettings;
        private System.Windows.Forms.RadioButton radioButtonSha256;
        private System.Windows.Forms.RadioButton radioButtonSha512;
        private System.Windows.Forms.RadioButton radioButtonSha1;
        private System.Windows.Forms.GroupBox groupboxHashAlgorithm;
        private System.Windows.Forms.GroupBox groupboxTimeStep;
        private System.Windows.Forms.GroupBox groupboxEncoding;
        private System.Windows.Forms.GroupBox groupboxSize;
        private System.Windows.Forms.GroupBox groupboxInfo;
        private System.Windows.Forms.RadioButton radioButtonUtf8;
        private System.Windows.Forms.CheckBox checkboxOldKeeOtp;
        private System.Windows.Forms.LinkLabel linkLabelLoadUriScanQR;
        private System.Windows.Forms.GroupBox groupBoxKey;
        private System.Windows.Forms.Timer timerUpdateTotp;
        private System.Windows.Forms.LinkLabel linkLabelMigrate;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxCustomDigits;
        private System.Windows.Forms.RadioButton radioButtonCustomDigits;
        private System.Windows.Forms.GroupBox groupBoxTransform;
        private System.Windows.Forms.RadioButton radioButtonDigits;
        private System.Windows.Forms.RadioButton radioButtonSteam;
    }
}