using System.Collections.Generic;
using BloggerKata.Features.Blogs;

namespace BloggerKata.Repositories.Blogs
{
    public interface IBlogRepository
    {
        BlogGetDto GetBlog(int id);
        List<BlogGetDto> GetAllBlogs();
        BlogGetDto CreateBlog(BlogDto blogToCreate);
        BlogGetDto EditBlog(int blogToEditId, BlogDto blogToEdit);
        void DeleteBlog(int blogToDeleteId);
    }
}
