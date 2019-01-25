using System;
using System.Collections.Generic;
using System.Text;
using BloggerKata.Features.Blogs;
using BloggerKata.Features.Users;

namespace BloggerKata.Data
{
    public interface IDatabase
    {
        int GetNextUserId { get; }
        int GetNextBlogId { get; }

        List<User> Users { get; set; }
        List<Blog> Blogs { get; set; }
    }
}
