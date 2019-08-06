using Microsoft.EntityFrameworkCore;
using Movie.Data.Contexts;
using Movie.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Data.Services
{
    public interface IUserService
    {
         Task<User> Authenticate(string email, string password);
         Task<User> Register(string name, string surname, DateTime birthday, string email, string password);
         Task<IEnumerable<User>> GetAll();
    }

    public class UserService : IUserService
    {
        private static MovieContext _userContext;

        public UserService(MovieContext userContext)
        {
            _userContext = userContext;
        }

        public async Task<User> Authenticate(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                throw new System.Exception("Your email or password doesn't have to be Null!!");
            }

            return await _userContext.Users.FirstOrDefaultAsync(x => x.Email == email && x.Password == password);
        }

        public Task<IEnumerable<User>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public async Task<User> Register(string name, string surname, DateTime birthday, string email, string password)
        {
            var user = new User
            {
                Name = name,
                Surname = surname,
                Birthday = birthday,
                Email = email,
                Password = password
            };

            _userContext.Users.Add(user);

            await _userContext.SaveChangesAsync();

            return user;
        }
    }
}
