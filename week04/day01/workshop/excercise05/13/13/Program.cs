using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            Blog blogs = new Blog();

            DateTime date = new DateTime(2000, 05, 04, 12, 43, 22);
            BlogPost blogPost1 = new BlogPost("John Doe", "Lorem Ipsum", "Lorem ipsum dolor sit amet.", date);
            date = new DateTime(2010, 10, 10, 05, 09, 02);
            BlogPost blogPost2 = new BlogPost("Tim Urban", "Wait but why", "A popular long-form, stick-figure-illustrated blog about almost everything.", date);
            date = new DateTime(2017, 03, 28, 11, 22, 33);
            BlogPost blogPost3 = new BlogPost("William Turton", "One Engineer Is Trying to Get IBM to Reckon With Trump", "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing.", date);

            blogs.Add(blogPost1);
            blogs.Add(blogPost2);
            blogs.Add(blogPost3);

            blogs.Delete(2);

            blogs.Update(1, blogPost3);

            Console.ReadLine();
        }
    }
}
