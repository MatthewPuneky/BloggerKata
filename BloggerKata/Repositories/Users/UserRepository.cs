using System.Collections.Generic;
using System.Linq;
using BloggerKata.Data;
using BloggerKata.Features.Users;

namespace BloggerKata.Repositories.Users
{
    public class UserRepository : IUserRepository
    {
        private readonly IDatabase _database;

        public UserRepository(IDatabase database)
        {
            _database = database;
        }

        public UserGetDto GetUser(int id)
        {
            var userToReturn = _database.Users
                .Select(x => new UserGetDto
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    UserName = x.UserName,
                    Age = x.Age
                })
                .First(x => x.Id == id);
            
            return userToReturn;
        }

        public List<UserGetDto> GetAllUsers()
        {
            var usersToReturn = _database.Users
                .Select(x => new UserGetDto
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    UserName = x.UserName,
                    Age = x.Age
                })
                .ToList();

            return usersToReturn;
        }

        public UserGetDto CreateUser(UserDto userToCreate)
        {
            var newUser = new User
            {
                Id = _database.GetNextBlogId,
                FirstName = userToCreate.FirstName,
                LastName = userToCreate.LastName,
                UserName = userToCreate.UserName,
                Age = userToCreate.Age
            };

            _database.Users.Add(newUser);

            var userToReturn = new UserGetDto
            {
                Id = newUser.Id,
                FirstName = newUser.FirstName,
                LastName = newUser.LastName,
                UserName = newUser.UserName,
                Age = newUser.Age
            };

            return userToReturn;
        }

        public UserGetDto EditUser(int userToEditId, UserDto userToEdit)
        {
            var user = _database.Users.First(x => x.Id == userToEditId);
            user.FirstName = userToEdit.FirstName;
            user.LastName = userToEdit.LastName;
            user.UserName = userToEdit.UserName;
            user.Age = userToEdit.Age;

            var userToReturn = new UserGetDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
                Age = user.Age
            };

            return userToReturn;
        }

        public void DeleteUser(int userToDeleteId)
        {
            var user = _database.Users.First(x => x.Id == userToDeleteId);
            _database.Users.Remove(user);
        }
    }
}
