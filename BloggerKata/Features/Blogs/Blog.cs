using System;
using BloggerKata.Features.Users;

namespace BloggerKata.Features.Blogs
{
    public class Blog
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
