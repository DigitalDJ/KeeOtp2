﻿using KeeOtp2.Properties;
using KeePass.Plugins;
using KeePass.Util;
using KeePassLib;
using KeePassLib.Security;
using ZXing;
using ZXing.Common;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KeeOtp2
{
    public partial class ShowQrCode : Form
    {
        const int SHARINGTIMEOUT = 180;
        private bool sharingExpired = false;

        IPluginHost host;
        PwEntry entry;
        Uri uri;

        private ToolTip copyUriToolTip;
        private ToolTip reloadToolTip;

        public ShowQrCode(Uri uri, PwEntry entry, IPluginHost host)
        {
            InitializeComponent();

            pictureBoxBanner.Image = KeePass.UI.BannerFactory.CreateBanner(pictureBoxBanner.Width,
                pictureBoxBanner.Height,
                KeePass.UI.BannerStyle.Default,
                Resources.qr_white,
                KeeOtp2Statics.ShowQr,
                KeeOtp2Statics.ShowQrSubline);

            this.Icon = host.MainWindow.Icon;
            this.TopMost = host.MainWindow.TopMost;

            this.uri = uri;
            this.entry = entry;
            this.host = host;

            groupBoxQRCode.Text = KeeOtp2Statics.ShowQrDisclamer;
            buttonOk.Text = KeeOtp2Statics.OK;


            copyUriToolTip = new ToolTip();
            copyUriToolTip.ToolTipTitle = KeeOtp2Statics.ShowQrCopyUri;
            copyUriToolTip.IsBalloon = true;

            string toolTipCopyUri = String.Format(KeeOtp2Statics.ToolTipShowQrCodeCopyUri, this.uri.AbsoluteUri);
            copyUriToolTip.SetToolTip(buttonCopyUriReload, toolTipCopyUri);

            reloadToolTip = new ToolTip();
            reloadToolTip.ToolTipTitle = KeeOtp2Statics.ShowQr;
            reloadToolTip.IsBalloon = true;

            string toolTipReload = KeeOtp2Statics.ToolTipShowQrCodeReload;
            reloadToolTip.SetToolTip(buttonCopyUriReload, toolTipReload);
        }

        private void showQrCodeImage()
        {
            sharingExpired = false;
            buttonCopyUriReload.Text = KeeOtp2Statics.ShowQrCopyUri + KeeOtp2Statics.InformationChar;
            reloadToolTip.Active = false;
            copyUriToolTip.Active = true;

            formTimeout = SHARINGTIMEOUT;

            EncodingOptions options = new EncodingOptions();
            options.Width = pictureBoxQrCode.Width;
            options.Height = pictureBoxQrCode.Height;

            IBarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Options = options;
            var result = writer.Write(this.uri.AbsoluteUri);
            pictureBoxQrCode.Image = new Bitmap(result);

            timerFormTimeout.Start();
        }

        private void ShowQrCode_Load(object sender, EventArgs e)
        {
            this.Left = this.host.MainWindow.Left + 20;
            this.Top = this.host.MainWindow.Top + 20;

            showQrCodeImage();
        }

        private void buttonCopyUriReload_Click(object sender, EventArgs e)
        {
            if (sharingExpired)
            {
                showQrCodeImage();
            }
            else
            {
                if (ClipboardUtil.CopyAndMinimize(new ProtectedString(true, this.uri.AbsoluteUri), true, this.host.MainWindow, this.entry, this.host.Database))
                    this.host.MainWindow.StartClipboardCountdown();

                this.Close();
            }
        }

        private int formTimeout = SHARINGTIMEOUT;
        private void timerFormTimeout_Tick(object sender, EventArgs e)
        {
            this.Text = String.Format(KeeOtp2Statics.ShowQrTimeout, formTimeout);

            if (formTimeout < 1)
            {
                timerFormTimeout.Stop();
                Rectangle rectangle = new Rectangle(0, 0, pictureBoxQrCode.Width, pictureBoxQrCode.Height);
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                Bitmap bitmap = new Bitmap(pictureBoxQrCode.Width, pictureBoxQrCode.Height);
                using (Font font = new Font("Arial", 14))
                {
                    Graphics graphics = Graphics.FromImage(bitmap);
                    graphics.DrawString(String.Format(KeeOtp2Statics.ShowQrExpired, SHARINGTIMEOUT), font, Brushes.Black, rectangle, sf);
                    pictureBoxQrCode.Image = bitmap;
                }
                sharingExpired = true;
                buttonCopyUriReload.Text = KeeOtp2Statics.Reload + KeeOtp2Statics.InformationChar;
                copyUriToolTip.Active = false;
                reloadToolTip.Active = true;
            }
            formTimeout--;
        }
    }
}
