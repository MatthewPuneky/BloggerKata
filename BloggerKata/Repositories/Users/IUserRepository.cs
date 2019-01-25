using System.Collections.Generic;
using BloggerKata.Features.Users;

namespace BloggerKata.Repositories.Users
{
    public interface IUserRepository
    {
        UserGetDto GetUser(int id);
        List<UserGetDto> GetAllUsers();
        UserGetDto CreateUser(UserDto userToCreate);
        UserGetDto EditUser(int userToEditId, UserDto userToEdit);
        void DeleteUser(int userToDeleteId);
    }
}
