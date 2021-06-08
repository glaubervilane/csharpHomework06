using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Homework06.Models
{
    public class SendCard
    {
        [Required]
        public string From { get; set; }
        [Required]
        public string To { get; set; }
        [Required]
        public string Message { get; set; }
    }
}