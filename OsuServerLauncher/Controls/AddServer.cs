using OsuServerLauncher.Helpers;
using OsuServerLauncher.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace OsuServerLauncher.Controls
{
    public partial class AddServer : Form {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Server Server { get; private set; }

        private Timer m_logodelay = new Timer() { Interval = 500 };
        private SynchronizationContext m_context = null;

        public AddServer() {
            InitializeComponent();

            m_logodelay.Tick += UpdateLogo;
            m_context = SynchronizationContext.Current;
        }

        public AddServer(Server server) : this() {
            txtName.Text = server.Name;
            txtDomain.Text = server.Domain;
            if (server.Credentials?.ClientLocation != null)
                textBox1.Text = server.Credentials.ClientLocation;
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();

        private void FormDraggable(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= 0x20000;
                return cp;
            }
        }

        private void btnAddServer_Click(object sender, EventArgs e) {
            string domain = TrimStart(TrimStart(TrimStart(txtDomain.Text, "https://"), "www."), "osu.").TrimEnd('/');
            Server = new Server(txtName.Text, domain);

            string clientLocation = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(clientLocation))
                Server.Credentials = new ServerInfo("", "", clientLocation);

            Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e) {
            btnAddServer.Enabled = txtName.TextLength > 0 && txtDomain.TextLength > 0;
        }

        private void txtDomain_TextChanged(object sender, EventArgs e) {
            btnAddServer.Enabled = txtName.TextLength > 0 && txtDomain.TextLength > 0;
            pictureBox.Image = null;

            m_logodelay.Stop();
            m_logodelay.Start();
        }
        private void textBox1_TextChanged(object sender, EventArgs e) {
            btnAddServer.Enabled = txtName.TextLength > 0 && txtDomain.TextLength > 0;
        }

        private void UpdateLogo(object sender, EventArgs e) {
            m_logodelay.Stop();
            new Thread(_ => {
                string domain = TrimStart(TrimStart(TrimStart(txtDomain.Text, "https://"), "www."), "osu.").TrimEnd('/');
                Image img = Utils.GetServerIcon(domain);
                if (img != null)
                    m_context.Post(_ => pictureBox.Image = img, null);
            }).Start();
        }

        private string TrimStart(string str, string trim) {
            while (str.StartsWith(trim))
                str = str.Substring(trim.Length);

            return str;
        }

        private void label3_Click(object sender, EventArgs e) {

        }

    }
}
