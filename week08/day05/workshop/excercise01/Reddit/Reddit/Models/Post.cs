using System.ComponentModel.DataAnnotations;

namespace Reddit.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public int Score { get; set; }
        public string Content { get; set; }
    }
}
