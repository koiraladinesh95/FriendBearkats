using FriendBearkats.Views;
using Xamarin.Forms;

namespace FriendBearkats
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(FindPage), typeof(FindPage));
            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
            Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
            Routing.RegisterRoute(nameof(CreateProfilePage), typeof(CreateProfilePage));
        }

    }
}
