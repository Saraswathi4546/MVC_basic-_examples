using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_examples.Models
{
    public class std_marks
    {
        public int sid { get; set; }
        public string sname { get; set; }
        public double maths { get; set; }
        public double phy { get; set; }
        public double che { get; set; }
        public double total { get; set; }
        public double average { get; set; }
        public string  grade { get; set; }
    }
}