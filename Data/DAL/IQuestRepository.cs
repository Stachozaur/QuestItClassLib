using Job.it_classes.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.it_ClassLib.Data.DAL
{
    public interface IQuestRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();


        Task<Quest[]> GetAllQuestsAsync();
        Task<Quest> GetQuestAsync(int id);
        Task<Quest> GetQuestsByCategoryAsync(int categoryId);

    }
}
