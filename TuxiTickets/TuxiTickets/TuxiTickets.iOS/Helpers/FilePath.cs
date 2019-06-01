using System;
using System.Diagnostics;
using System.IO;
using TuxiTickets.Helpers;
using TuxiTickets.iOS.Helpers;
using Xamarin.Forms;

[assembly: Dependency(typeof(FilePath))]
namespace TuxiTickets.iOS.Helpers
{
    public class FilePath : IFileString
    {
        string IFileString.FilePath()
        {
            try
            {
                string docFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                string libFolder = System.IO.Path.Combine(docFolder, "..", "Library", "Databases");

                if (!Directory.Exists(libFolder))
                {
                    Directory.CreateDirectory(libFolder);
                }

                return Path.Combine(libFolder, "tuxitickets.db3");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }
    }
}