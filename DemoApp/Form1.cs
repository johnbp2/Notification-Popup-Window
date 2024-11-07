/*
 *	Created/modified in 2011 by Simon Baer
 *	
 *  Licensed under the Code Project Open License (CPOL).
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace DemoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            popupNotifier.TitleText = txtTitle.Text;
            popupNotifier.ContentText = txtText.Text;
            popupNotifier.ShowCloseButton = chkClose.Checked;
            popupNotifier.ShowOptionsButton = chkMenu.Checked;
            popupNotifier.ShowGrip = chkGrip.Checked;
            popupNotifier.Delay = int.Parse(txtDelay.Text);
            popupNotifier.AnimationInterval = int.Parse(txtInterval.Text);
            popupNotifier.AnimationDuration = int.Parse(txtAnimationDuration.Text);
            popupNotifier.TitlePadding = new Padding(int.Parse(txtPaddingTitle.Text));
            popupNotifier.ContentPadding = new Padding(int.Parse(txtPaddingContent.Text));
            popupNotifier.ImagePadding = new Padding(int.Parse(txtPaddingIcon.Text));
            popupNotifier.Scroll = chkScroll.Checked;
            popupNotifier.IsRightToLeft = chkIsRightToLeft.Checked;
            if (chkIcon.Checked)
            {
                popupNotifier.Image = Properties.Resources._157_GetPermission_48x48_72;
            }
            else
            {
                popupNotifier.Image = null;
            }

            popupNotifier.Popup();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
