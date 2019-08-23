using Movie.Contract.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Movie.Data.Services
{
    public class UserService : IUserService
    {
        public UserService()
        {

        }

        public Task<UserModel> Register(string name, string surname, DateTime? birthday, string email, string password)
        {
            var user = new UserModel
            {
            };

            //_userContext.Users.Add(user);

            //await _userContext.SaveChangesAsync();

            return Task.FromResult(user);
        }

        Task<UserModel> IUserService.Authenticate(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                throw new System.Exception("Your email or password doesn't have to be Null!!");
            }

            //return await _userContext.Users.FirstOrDefaultAsync(x => x.Email == email && x.Password == password);7

            return Task.FromResult(new UserModel { });
        }

        Task<IEnumerable<UserModel>> IUserService.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
