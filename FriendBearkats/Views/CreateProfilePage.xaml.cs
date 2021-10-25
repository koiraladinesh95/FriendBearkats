using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FriendBearkats.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateProfilePage : ContentPage
    {
        public CreateProfilePage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            collectionView.ItemsSource = await App.Database.GetPeopleAsync();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            if (
                !string.IsNullOrWhiteSpace(nameEntry.Text) && 
                !string.IsNullOrWhiteSpace(ageEntry.Text) && 
                !string.IsNullOrWhiteSpace(emailEntry.Text) &&
                !string.IsNullOrWhiteSpace(genderEntry.Text) &&
                !string.IsNullOrWhiteSpace(addressEntry.Text) &&
                !string.IsNullOrWhiteSpace(sexPrefEntry.Text) &&
                !string.IsNullOrWhiteSpace(numberEntry.Text) &&
                !string.IsNullOrWhiteSpace(majorEntry.Text) &&
                !string.IsNullOrWhiteSpace(bioEntry.Text) &&
                !string.IsNullOrWhiteSpace(hobbyEntry.Text)
                )
            {
                await App.Database.SavePersonAsync(new Person
                {
                    Name = nameEntry.Text,
                    Age = int.Parse(ageEntry.Text),
                    Email = emailEntry.Text,
                    Gender = genderEntry.Text,
                    Address = addressEntry.Text,
                    SexualPreference = sexPrefEntry.Text,
                    Number = numberEntry.Text,
                    Major = majorEntry.Text, 
                    Bio = bioEntry.Text, 
                    Hobbies = hobbyEntry.Text
                });

                nameEntry.Text = ageEntry.Text = emailEntry.Text = genderEntry.Text = addressEntry.Text =
                    sexPrefEntry.Text = numberEntry.Text = majorEntry.Text = bioEntry.Text =
                    hobbyEntry.Text = string.Empty;
                
                collectionView.ItemsSource = await App.Database.GetPeopleAsync();
            }
        }
        async void OnProfileClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(ProfilePage));
        }
    }
}