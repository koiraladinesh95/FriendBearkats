using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FriendBearkats.ViewModels;

namespace FriendBearkats.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public static string em;
        public static string getEm()
        {
           
            return em;
            
        }

        public LoginPage()
        {
            var vm = new LoginPageViewModel();
            
            this.BindingContext = vm;
            vm.DisplayInvalidLoginPrompt += () => DisplayAlert("Error", "Invalid Login, try again", "OK");
            InitializeComponent();


            Email.Completed += (object sender, EventArgs e) =>
            {
                Password.Focus();
            };

            Password.Completed += (object sender, EventArgs e) =>
            {
                vm.SubmitCommand.Execute(null);
            };

            string currentEmail = vm.getEmail();
            em = currentEmail;


        }


    }
}