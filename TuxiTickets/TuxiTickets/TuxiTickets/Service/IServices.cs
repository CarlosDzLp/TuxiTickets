using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TuxiTickets.Models;

namespace TuxiTickets.Service
{
    public interface IServices
    {
        Task<T> Get<T>(string controller);
        Task<T> Post<T,K>(K serializer,string controller);
        Task<T> Put<T,K>(K serializer,string controller);
        Task<T> Delete<T>(string controller);
        Task<TokenRequest> Token(string controller);
    }
}
