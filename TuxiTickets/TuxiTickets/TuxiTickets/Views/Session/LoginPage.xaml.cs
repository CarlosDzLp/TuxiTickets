using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuxiTickets.ViewModels.Session;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TuxiTickets.Views.Session
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		    this.BindingContext = new LoginPageViewModel();
		}
	}
}