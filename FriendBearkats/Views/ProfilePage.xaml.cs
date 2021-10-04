using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace FriendBearkats.Views
{
   
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            // Launch the specified URL in the system browser.
            await Launcher.OpenAsync("https://www.instagram.com/rexbeeblebrox/");
        }

        async void OnHomeClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(HomePage));
        }
    }
}