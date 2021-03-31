using Job.it_classes.Data.Context;
using Job.it_classes.Data.Entities;
using Job.it_ClassLib.Data.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.it_classes.Data.DAL
{
    public class QuestRepository : IQuestRepository
    {
        private readonly BaseDbContext _context;
        private readonly ILogger<QuestRepository> _logger;

        public QuestRepository(BaseDbContext context, ILogger<QuestRepository> logger)
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

        public async Task<Quest[]> GetAllQuestsAsync()
        {
            _logger.LogInformation($"Getting all Quests");

            IQueryable<Quest> query = _context.Quests;

            return await query.ToArrayAsync();
        }

        public async Task<Quest> GetQuestAsync(int id)
        {
            _logger.LogInformation($"Getting Quest by ID");

            IQueryable<Quest> query = _context.Quests;

            query = query
                .Where(q => q.QuestId == id);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Quest> GetQuestsByCategoryAsync(int categoryId)
        {
            _logger.LogInformation($"Getting all Quests by category");

            IQueryable<Quest> query = _context.Quests;

            query = query
                .Where(q => q.QuestCategory.QuestCategoryId == categoryId);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            _logger.LogInformation($"Attempitng to save the changes in the context");

            // Only return success if at least one row was changed
            return (await _context.SaveChangesAsync()) > 0;
        }
    }

}
