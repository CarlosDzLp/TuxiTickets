using System;
using System.Collections.Generic;
using System.Text;

namespace TuxiTickets.Models
{
    public class TokenRequest
    {
        public string Token { get; set; }
        public DateTime TokenExpired { get; set; }
    }
}
