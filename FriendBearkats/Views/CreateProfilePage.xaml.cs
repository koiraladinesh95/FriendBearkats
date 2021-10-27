using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite; 
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

        

        async void OnButtonClicked(object sender, EventArgs e)
        {
            if (
                !string.IsNullOrWhiteSpace(nameEntry.Text) && 
                !string.IsNullOrWhiteSpace(passwordEntry.Text) &&
                !string.IsNullOrWhiteSpace(emailEntry.Text) &&
                !string.IsNullOrWhiteSpace(genderEntry.Text) &&
                !string.IsNullOrWhiteSpace(addressEntry.Text) &&
                !string.IsNullOrWhiteSpace(sexPrefEntry.Text) &&
                !string.IsNullOrWhiteSpace(numberEntry.Text)

                /*!string.IsNullOrWhiteSpace(majorEntry.Text) &&
                !string.IsNullOrWhiteSpace(bioEntry.Text) &&
                !string.IsNullOrWhiteSpace(hobbyEntry.Text)*/
                )
            {
                await App.Database.SavePersonAsync(new Person
                {
                    Name = nameEntry.Text,
                   
                    Dob = dobEntry.Date.ToString(),
                    Email = emailEntry.Text,
                    Password = passwordEntry.Text,
                    Gender = genderEntry.Text,
                    Address = addressEntry.Text,
                    SexualPreference = sexPrefEntry.Text,
                    Number = numberEntry.Text,
                    
                    //Major = majorEntry.Text, 
                    //Bio = bioEntry.Text, 
                    //Hobbies = hobbyEntry.Text
                });

                nameEntry.Text = passwordEntry.Text = emailEntry.Text = genderEntry.Text = addressEntry.Text =
                    sexPrefEntry.Text = numberEntry.Text  /*= majorEntry.Text = bioEntry.Text =
                    hobbyEntry.Text*/ = string.Empty;

                await Shell.Current.GoToAsync(nameof(LoginPage));
            }
        }
     
    }
}