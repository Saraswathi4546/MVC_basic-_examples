using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_examples.Models
{
    public class usermodel
    {
        public string username { get; set; }
        public string password { get; set; }
        public string cpassword { get; set; }
        public string city { get; set; }
        public string gender { get; set; }
        public bool Chat { get; set; }
        public bool movies { get; set; }
        public bool sports { get; set; }

    }
}