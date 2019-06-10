using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using TuxiTickets.ViewModels.Base;
using Xamarin.Forms;

namespace TuxiTickets.ViewModels.Session
{
    public class LoginPageViewModel : BindableBase
    {
        #region Proiperties
        private string _email;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }
        private string _password;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }
        #endregion

        #region Constructor

        public LoginPageViewModel()
        {
            SignInCommand = new Command(SignInCommandExecuted);
        }
        #endregion

        #region Command
        public ICommand SignInCommand { get; set; }
        #endregion

        #region CommandExecuted
        private void SignInCommandExecuted()
        {
            try
            {
                App.Current.MainPage = new Views.Principal.HomePage();
            }
            catch(Exception ex)
            {
                throw;
            }
        }
        #endregion
    }
}
