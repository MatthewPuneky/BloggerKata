using System;
using BloggerKata.Data;
using BloggerKata.Features.Users;
using BloggerKata.Repositories.Blogs;
using BloggerKata.Repositories.Users;

namespace BloggerKata
{
    public class Program
    {
        static void Main(string[] args)
        {
            var dataBaseToUse = new RealFakeDatabase();

            var letsDoTheThing = 
                new LetsDoTheThing(
                    new UserRepository(dataBaseToUse),
                    new BlogRepository(dataBaseToUse));

            letsDoTheThing.DoIt();
        }
    }

    public class LetsDoTheThing
    {
        private readonly IUserRepository _userRepository;
        private readonly IBlogRepository _blogRepository;

        public LetsDoTheThing(
            IUserRepository userRepository,
            IBlogRepository blogRepository)
        {
            _userRepository = userRepository;
            _blogRepository = blogRepository;
        }

        public void DoIt()
        {
            var user = _userRepository.CreateUser(new UserDto
            {
                FirstName = "Jane",
                LastName = "Doe",
                UserName = "jdoe",
                Age = 28
            });

            var editedUser = new UserDto
            {
                FirstName = "Jim",
                LastName = "Smith",
                UserName = "jsmith",
                Age = 30
            };

            var editUserResult = _userRepository.EditUser(user.Id, editedUser);

            Console.ReadLine();
        }
    }
}
