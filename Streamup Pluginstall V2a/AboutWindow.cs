using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Streamup_Pluginstall_V2 {
    public partial class AboutWindow : Form {
        public AboutWindow() {
            InitializeComponent();
        }

        private void openURL(string url) {
            try {
                System.Diagnostics.Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            } catch (System.ComponentModel.Win32Exception noBrowser) {

            } catch (System.Exception other) {

            }
        }

        private void AboutWindow_Load(object sender, EventArgs e) {

        }

        private void linkLabelSilverlinkTwitch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            openURL("https://twitch.tv/silverlink");
        }

        private void linkLabelSUKofi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            openURL("https://ko-fi.com/streamup");
        }

        private void linkLabelSUPatreon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            openURL("https://patreon.com/StreamUP");
        }

        private void linkLabelStreamUPYoutube_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            openURL("https://youtube.com/streamuptips");
        }

        private void linkLabelStreamUPTwitch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            openURL("https://twitch.tv/streamuptips");
        }

        private void linkLabelAndilippiTwitch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            openURL("https://twitch.tv/andilippi");
        }

        private void linkLabelSilverlinkDoras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            openURL("https://doras.to/silverlink");
        }

        private void linkLabelAndilippiDoras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            openURL("https://doras.to/andilippi");
        }

        private void linkLabelWaldoDoras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            openURL("https://doras.to/waldo");
        }

        private void linkLabelWaldoTwitch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            openURL("https://twitch.tv/waldoandfriends");
        }
    }
}
