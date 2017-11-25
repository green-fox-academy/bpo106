using System.ComponentModel.DataAnnotations;

namespace Reddit.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public int Score { get; set; } = 0;
        public string Content { get; set; }

        public void ChangeScore(bool IsIncrease)
        {
            Score+= IsIncrease ? 1 : -1;
        }
    }
}
