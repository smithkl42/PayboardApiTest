using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PayboardApiTest.Models
{
    public class HomeIndexModel
    {
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerUserName { get; set; }
        public string ExternalUserId { get; set; }
        public string CustomerUserEmail { get; set; }
    }
}