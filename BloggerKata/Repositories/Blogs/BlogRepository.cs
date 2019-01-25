using System.Collections.Generic;
using System.Linq;
using BloggerKata.Data;
using BloggerKata.Features.Blogs;

namespace BloggerKata.Repositories.Blogs
{
    public class BlogRepository : IBlogRepository
    {
        private readonly IDatabase _database;

        public BlogRepository(IDatabase database)
        {
            _database = database;
        }

        public BlogGetDto GetBlog(int id)
        {
            var blogToReturn = _database.Blogs
                .Select(x => new BlogGetDto
                {
                    Id = x.Id,
                    UserId = x.UserId,
                    Title = x.Title,
                    Body = x.Body
                })
                .First(x => x.Id == id);

            return blogToReturn;
        }

        public List<BlogGetDto> GetAllBlogs()
        {
            var blogsToReturn = _database.Blogs
                .Select(x => new BlogGetDto
                {
                    Id = x.Id,
                    UserId = x.UserId,
                    Title = x.Title,
                    Body = x.Body
                })
                .ToList();

            return blogsToReturn;
        }

        public BlogGetDto CreateBlog(BlogDto blogToCreate)
        {
            var newBlog = new Blog
            {
                Id = _database.GetNextBlogId,
                UserId = blogToCreate.UserId,
                Title = blogToCreate.Title,
                Body = blogToCreate.Body
            };

            _database.Blogs.Add(newBlog);

            var blogToReturn = new BlogGetDto
            {
                Id = newBlog.Id,
                UserId = newBlog.UserId,
                Title = newBlog.Title,
                Body = newBlog.Body
            };

            return blogToReturn;
        }

        public BlogGetDto EditBlog(int blogToEditId, BlogDto blogToEdit)
        {
            var blog = _database.Blogs.First(x => x.Id == blogToEditId);
            blog.UserId = blogToEdit.UserId;
            blog.Title = blogToEdit.Title;
            blog.Body = blogToEdit.Body;

            var blogToReturn = new BlogGetDto
            {
                Id = blog.Id,
                UserId = blog.UserId,
                Title = blog.Title,
                Body = blog.Body
            };

            return blogToReturn;
        }

        public void DeleteBlog(int blogToDeleteId)
        {
            var blog = _database.Blogs.First(x => x.Id == blogToDeleteId);
            _database.Blogs.Remove(blog);
        }
    }
}
