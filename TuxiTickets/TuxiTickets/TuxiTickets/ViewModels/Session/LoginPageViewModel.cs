using System;
using System.Collections.Generic;
using System.Text;
using TuxiTickets.ViewModels.Base;

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

        }
        #endregion
    }
}
