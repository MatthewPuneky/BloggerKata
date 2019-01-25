using System;
using System.Collections.Generic;
using System.Text;
using BloggerKata.Features.Blogs;
using BloggerKata.Features.Users;

namespace BloggerKata.Data
{
    public class RealFakeDatabase : IDatabase
    {
        private static int _nextUserId = 1;
        private static int _nextBlogId = 1;
        
        public int GetNextUserId => _nextUserId++;
        public int GetNextBlogId => _nextBlogId++;

        public List<User> Users { get; set; } = new List<User>();
        public List<Blog> Blogs { get; set; } = new List<Blog>();
    }
}
