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
    }
}
