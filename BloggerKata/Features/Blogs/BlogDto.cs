using System;
using System.Collections.Generic;
using System.Text;

namespace BloggerKata.Features.Blogs
{
    public class BlogDto
    {
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }

    public class BlogGetDto : BlogDto
    {
        public int Id { get; set; }
    }
}
