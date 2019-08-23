using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Movie.Contract.Services
{
    public interface IUserService
    {
        Task<UserModel> Authenticate(string email, string password);
        Task<UserModel> Register(string name, string surname, DateTime? birthday, string email, string password);
        Task<IEnumerable<UserModel>> GetAll();
    }

    public class UserModel
    {

    }
}
