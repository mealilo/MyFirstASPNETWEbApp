using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstASPNETWEbApp.Models
{
    public class FanMailModel
    {
        [Required]
        public string from { get; set; }
        [Required]
        public string subject { get; set; }

        public string message { get; set; }


    }
}
