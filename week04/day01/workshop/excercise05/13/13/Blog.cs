using System;
using System.Collections.Generic;

namespace _13
{
    public class Blog
    {
        private List<BlogPost> Posts;

        public Blog()
        {
            Posts = new List<BlogPost>();
        }

        public void Add(BlogPost post)
        {
            Posts.Add(post);
        }

        public void Delete(int num)
        {
            Posts.RemoveAt(num);
        }

        public void Update(int num, BlogPost post)
        {
            Posts.RemoveAt(num);
            Posts.Insert(num, post);
        }
    }
}