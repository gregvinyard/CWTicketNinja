using DesktopNotifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DesktopNotifications.NotificationActivator;

namespace CWTicketNinja
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Register AUMID and COM server (for Desktop Bridge apps, this no-ops)
            DesktopNotificationManagerCompat.RegisterAumidAndComServer<MyNotificationActivator>("com.thewired.cwticketninja");

            // Register COM server and activator type
            DesktopNotificationManagerCompat.RegisterActivator<MyNotificationActivator>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Settings());
        }
    }

    [ClassInterface(ClassInterfaceType.None)]
    [ComSourceInterfaces(typeof(INotificationActivationCallback))]
    [Guid(appGuid), ComVisible(true)]
    public class MyNotificationActivator : NotificationActivator
    {
        private const string appGuid = "b9fa03c3-bece-4ba0-bd28-011f1d982f00";

        public override void OnActivated(string invokedArgs, NotificationUserInput userInput, string appUserModelId)
        {
            // TODO: Handle activation
        }
    }
}
