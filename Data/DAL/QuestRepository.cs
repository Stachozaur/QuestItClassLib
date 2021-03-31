using Job.it_classes.Data.Context;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.it_classes.Data.DAL
{
    public class QuestRepository
    {
        private readonly BaseDbContext _context;
        private readonly ILogger<QuestRepository> _logger;

        public QuestRepository(BaseDbContext context, ILogger<QuestRepository> logger)
        {
            _context = context;
            _logger = logger;
        }
    }
}
