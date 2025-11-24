using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_examples.Models
{
    public class college
    {
        public int sid { get; set; }

        public string sname { get; set; }
        
        
        public DateTime Joining { get; set; }
        public string course { get; set; }
        public decimal Fee { get; set; }

        public  string std_cgpa { get; set;}
    }
}