using System.ComponentModel.DataAnnotations;

namespace GreetSomeone.Models
{
    public class Name
    {
        [Required]
        [RegularExpression(@"^[A-Za-z]{1-7}$", ErrorMessage = "Sorry, you have to type the name in a valid format.")]
        public string Namestring { get; set; }
    }
}