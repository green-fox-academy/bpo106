using Reddit.Entities;
using Reddit.Models;
using System.Collections.Generic;
using System.Linq;

namespace Reddit.Repositories
{
    public class PostRepository
    {
        private PostContext postContext;

        public PostRepository(PostContext postContext)
        {
            this.postContext = postContext;
        }

        public List<Post> ListPosts()
        {
            return postContext.Posts.ToList();
        }

        public void Add (Post post)
        {
            postContext.Add(post);
            postContext.SaveChanges();
        }

        public void Change (int Id, bool IsIncrement)
        {
            postContext.Posts.Where(x => x.Id == Id).FirstOrDefault().ChangeScore(IsIncrement);
            postContext.SaveChanges();
        }
    }
}
