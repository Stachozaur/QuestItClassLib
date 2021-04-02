using Job.it_classes.Data.Entities;
using Job.it_ClassLib.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.it_ClassLib.Data.DAL
{
    public interface IUserRepository
    {
        // General 
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();

        // Users

        Task<User[]> GetAllUsersAsync();
        Task<User> GetUserAsync(int id);
        Task<User> GetUserAsync(string email);
        Task<Role> GetRoleAsync(string name);
    }
}
