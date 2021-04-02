using Job.it_classes.Data.Context;
using Job.it_classes.Data.Entities;
using Job.it_ClassLib.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.it_ClassLib.Data.DAL
{
    public class UserRepository : IUserRepository
    {
        private readonly BaseDbContext _context;
        private readonly ILogger<UserRepository> _logger;

        public UserRepository(BaseDbContext context, ILogger<UserRepository> logger)
        {
            _context = context;
            _logger = logger;
        }
        public void Add<T>(T entity) where T : class
        {
            _logger.LogInformation($"Adding an object of type {entity.GetType()} to the context.");
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _logger.LogInformation($"Removing an object of type {entity.GetType()} to the context.");
            _context.Remove(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            _logger.LogInformation($"Attempitng to save the changes in the context");

            // Only return success if at least one row was changed
            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<User[]> GetAllUsersAsync()
        {
            _logger.LogInformation($"Getting all Users");

            IQueryable<User> query = _context.Users
                .Include(r => r.Role)
                .OrderBy(n => n.LastName);

            return await query.ToArrayAsync();
        }

        public async Task<User> GetUserAsync(int id)
        {
            _logger.LogInformation($"Getting an User for {id}");

            IQueryable<User> query = _context.Users
                .Include(r => r.Role)
                .Where(c => c.UserId == id);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<User> GetUserAsync(string email)
        {
            _logger.LogInformation($"Getting an User for {email}");

            IQueryable<User> query = _context.Users
                .Include(r => r.Role)
                .Where(c => c.Email == email);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Role> GetRoleAsync(string name)
        {
            _logger.LogInformation($"Getting a role for {name}");

            IQueryable<Role> query = _context.Roles
                .Where(n => n.Name == name);

            return await query.FirstOrDefaultAsync();
        }
    }
}
