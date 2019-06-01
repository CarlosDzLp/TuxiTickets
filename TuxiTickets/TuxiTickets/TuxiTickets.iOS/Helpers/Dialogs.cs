using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigTed;
using CoreGraphics;
using Foundation;
using TTGSnackBar;
using TuxiTickets.Helpers;
using TuxiTickets.iOS.Helpers;
using UIKit;
using Xamarin.Forms;

[assembly:Dependency(typeof(Dialogs))]
namespace TuxiTickets.iOS.Helpers
{
    public class Dialogs : IDialogs
    {
        public async Task HideLoading()
        {
            BTProgressHUD.Dismiss();
        }

        public async Task ShowLoading(string message)
        {
            BTProgressHUD.Show(message, -1, ProgressHUD.MaskType.Black);
        }

        public async Task SnackBar(string message, TypeSnack typesnack)
        {
            var snackbar = new TTGSnackbar(message);
            snackbar.CornerRadius = 8;
            snackbar.BottomMargin = 10;
            snackbar.TopMargin = 10;
            snackbar.LeftMargin = 10;
            snackbar.RightMargin = 10;
            snackbar.MessageTextColor = UIColor.White;
            snackbar.Message = message;
            if (typesnack == TypeSnack.Error)
            {
                snackbar.BackgroundColor = UIColor.FromRGB(244, 67, 54);
                snackbar.Show();
            }
            else
            {
                snackbar.BackgroundColor = UIColor.FromRGB(30, 150, 144);
                snackbar.Show();
            }
        }
    }
}