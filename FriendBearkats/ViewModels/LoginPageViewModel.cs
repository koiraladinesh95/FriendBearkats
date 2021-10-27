﻿using System;
using System.ComponentModel;
using System.Windows.Input;
using System.Linq;
using Xamarin.Forms;
using SQLite;
using FriendBearkats.Views;
using FriendBearkats;


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

        public string getEmail()
        {
            return email;
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
        public ICommand SignupCommand { protected set; get; }
        public LoginPageViewModel()
        {
            SubmitCommand = new Command(OnSubmit);
            SignupCommand = new Command(OnSignup);
        }

        public async void OnSignup()
        {
            await Shell.Current.GoToAsync(nameof(CreateProfilePage));
        }
        public async  void OnSubmit()
        {
            var details = await App.Database.GetPeopleAsync();
            var a1 = from x in details where x.Email == email && x.Password == password select x;
            
         
            //if (email != "rex@shsu.edu" || password != "secret")
            if(a1 == null)
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
