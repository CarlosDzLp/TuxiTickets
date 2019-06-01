using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using TuxiTickets.Droid.Helpers;
using TuxiTickets.Helpers;
using Xamarin.Forms;

[assembly:Dependency(typeof(FilePath))]
namespace TuxiTickets.Droid.Helpers
{
    public class FilePath : IFileString
    {
        string IFileString.FilePath()
        {
            try
            {
                var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                return System.IO.Path.Combine(path, "tuxitickets.db3");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }
    }
}