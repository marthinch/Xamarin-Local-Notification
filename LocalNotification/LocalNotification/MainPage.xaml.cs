using Plugin.LocalNotifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LocalNotification
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonTestLocalNotification_Clicked(object sender, EventArgs e)
        {
            CrossLocalNotifications.Current.Show("Test local notification", "This is local notification");
        }

        private void ButtonTestLocalNotificationByTime_Clicked(object sender, EventArgs e)
        {
            CrossLocalNotifications.Current.Show("Test local notification", "This is local notification by time", 1, DateTime.Now.AddSeconds(10));
        }
    }
}
