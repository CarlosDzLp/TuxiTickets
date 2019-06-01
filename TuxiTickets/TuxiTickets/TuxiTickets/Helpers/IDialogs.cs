using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TuxiTickets.Helpers
{
    public interface IDialogs
    {
        Task ShowLoading(string message);
        Task HideLoading();
        //Task ShowSuccess(string message);
        //Task ShowError(string message);
        Task SnackBar(string message, TypeSnack typesnack);
    }

    public enum TypeSnack
    {
        Error,
        Success
    }
}
