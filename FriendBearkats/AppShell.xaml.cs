using FriendBearkats.Views;
using Xamarin.Forms;

namespace FriendBearkats
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ChatPage), typeof(ChatPage));
            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
            Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));

        }

    }
}
