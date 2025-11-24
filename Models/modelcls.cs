using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace mvc_examples.Models
{
    public class modelcls
    {
        [Required]
        [StringLength(40)]
        [RegularExpression (@"\D{1,40}",ErrorMessage="only alphabets allowed")]
        public string username {  get; set; }

        [Required]
        [StringLength(40)]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required]
        [StringLength(30)]
        [DataType(DataType.Password)]
        [Compare("password")]
        public string cpassword { get; set; }

        [Required]
        [StringLength(20)]
        [RegularExpression (@"(\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,6})",ErrorMessage ="Invalid E-Mail")]
        public string email {  get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression (@"([6-9][0-9]{9})",ErrorMessage ="first digit should start b/w 6-9")]

        public string phone { get; set; }

    }
}