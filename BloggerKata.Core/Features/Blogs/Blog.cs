using System;
using BloggerKata.Core.Features.Users;

namespace BloggerKata.Core.Features.Blogs
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime CreatedDate { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
