using System;
using System.Windows.Forms;
using DesktopNotifications;

namespace CWTicketNinja
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void BtnTestNotification_Click(object sender, EventArgs e)
        {
            ToastHandler th = new ToastHandler();
            DesktopNotificationManagerCompat.CreateToastNotifier().Show(th.BuildToast("hello dork"));
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
