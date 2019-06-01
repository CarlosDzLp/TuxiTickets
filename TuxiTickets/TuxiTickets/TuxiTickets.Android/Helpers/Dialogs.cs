using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Views;
using Android.Widget;
using AndroidHUD;
using Plugin.CurrentActivity;
using TuxiTickets.Droid.Helpers;
using TuxiTickets.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:Dependency(typeof(Dialogs))]
namespace TuxiTickets.Droid.Helpers
{
    public class Dialogs : IDialogs
    {
        public async Task HideLoading()
        {
            AndHUD.Shared.Dismiss();
        }
        public async Task ShowLoading(string message)
        {
            AndHUD.Shared.Show(MainActivity.CurrentActivity, message, -1, MaskType.Black, null, null, true, null);
        }
        public async Task SnackBar(string message, TypeSnack typesnack)
        {
            if (typesnack == TypeSnack.Error)
            {
                Activity activity = CrossCurrentActivity.Current.Activity;
                Android.Views.View activityRootView = activity.FindViewById(Android.Resource.Id.Content);
                Android.Support.Design.Widget.Snackbar snackBar = Android.Support.Design.Widget.Snackbar.Make(activityRootView, message, Snackbar.LengthLong);
                snackBar.SetActionTextColor(Android.Graphics.Color.ParseColor("#FFFFFF"));
                Android.Views.View snackbarview = snackBar.View;
                snackbarview.SetBackgroundResource(Resource.Drawable.snackerror);
                ViewGroup.MarginLayoutParams paramss = (ViewGroup.MarginLayoutParams)snackbarview.LayoutParameters;
                paramss.SetMargins(30, 0, 30, 40);
                snackbarview.SetBackground(
                    MainActivity.CurrentActivity.ApplicationContext.GetDrawable(Resource.Drawable.snackerror));
                snackBar.Show();
            }
            else
            {
                Activity activity = CrossCurrentActivity.Current.Activity;
                Android.Views.View activityRootView = activity.FindViewById(Android.Resource.Id.Content);
                Android.Support.Design.Widget.Snackbar snackBar = Android.Support.Design.Widget.Snackbar.Make(activityRootView, message, Snackbar.LengthLong);
                snackBar.SetActionTextColor(Android.Graphics.Color.ParseColor("#FFFFFF"));
                Android.Views.View snackbarview = snackBar.View;
                snackbarview.SetBackgroundResource(Resource.Drawable.snackBackground);
                ViewGroup.MarginLayoutParams paramss = (ViewGroup.MarginLayoutParams)snackbarview.LayoutParameters;
                paramss.SetMargins(30, 0, 30, 40);
                snackbarview.SetBackground(
                    MainActivity.CurrentActivity.ApplicationContext.GetDrawable(Resource.Drawable.snackBackground));
                snackBar.Show();
            }
        }
    }
}