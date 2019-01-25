using System;
using System.Collections.Generic;
using System.Text;

namespace BloggerKata.Features.Users
{
    public class UserDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public int Age { get; set; }
    }

    public class UserGetDto : UserDto
    {
        public int Id { get; set; }
    }
}
