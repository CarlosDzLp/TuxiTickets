using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TuxiTickets.Models;

namespace TuxiTickets.Service
{
    public class ServiceClient : IServices
    {
        public async Task<T> Delete<T>(string controller)
        {
            throw new NotImplementedException();
        }

        public async Task<T> Get<T>(string controller)
        {
            throw new NotImplementedException();
        }

        public async Task<T> Post<T, K>(K serializer, string controller)
        {
            throw new NotImplementedException();
        }

        public async Task<T> Put<T, K>(K serializer, string controller)
        {
            throw new NotImplementedException();
        }

        public async Task<TokenRequest> Token(string controller)
        {
            throw new NotImplementedException();
        }
    }
}
