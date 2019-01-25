using System.Collections.Generic;
using BloggerKata.Core.Features.Blogs;

namespace BloggerKata.Core.Features.Users
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public int Age { get; set; }

        public List<Blog> Blogs { get; set; }
    }
}
