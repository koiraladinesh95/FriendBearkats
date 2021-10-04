
using Xamarin.Forms;

namespace FriendBearkats
{
    public partial class App : Application
    {
        
        public App()
        {
            InitializeComponent();
            //MainPage = new FriendBearkats.Views.LoginPage();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
