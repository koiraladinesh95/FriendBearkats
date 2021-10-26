using System;
using System.Linq;
using Xamarin.Essentials;
using Xamarin.Forms;
using FriendBearkats;
using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;


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

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            //myCollectionView.ItemsSource = await App.Database.GetPeopleAsync();
            var details = await App.Database.GetPeopleAsync();
            var a1 = from x in details where x.Name == "Rex" select x;
            myCollectionView.ItemsSource = a1;
        }
    }
}