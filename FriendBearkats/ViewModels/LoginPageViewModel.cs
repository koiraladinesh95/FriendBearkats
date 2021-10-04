using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using FriendBearkats.Views;

namespace FriendBearkats.ViewModels
{
    class LoginPageViewModel: INotifyPropertyChanged
    {
        public Action DisplayInvalidLoginPrompt;
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }
        public ICommand SubmitCommand { protected set; get; }
        public LoginPageViewModel()
        {
            SubmitCommand = new Command(OnSubmit);
        }
        public async  void OnSubmit()
        {
            if (email != "rex@shsu.edu" || password != "secret")
            {
                DisplayInvalidLoginPrompt();
            }
            else
            {
                //new AppShell();
                await Shell.Current.GoToAsync(nameof(HomePage));
                //new AppShell();
            }
        }
    }
}
