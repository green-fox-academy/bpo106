using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RandomProject.Models
{
    public class Car
    {
        private const string Error = "Sorry, the license plate is not valid.";

        [Key]
        [RegularExpression(@"^[A-Z''-'0-9]{1-7}$", ErrorMessage = Error)]
        public string Plate { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public string Color { get; set; }
        public string Year { get; set; }
    }
}
