using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.it_classes.Data.Entities
{
    public class Quest
    {
        public int QuestId { get; set; }
        public int Price { get; set; }
        public QuestCategory Category { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public DateTime PublishingDate { get; set; } = DateTime.Now;
        public DateTime QuestDate { get; set; }
        public int EstimatedTime { get; set; }
        public User User { get; set; }
        public string Location { get; set; }
        public IEnumerable<User> Applicants { get; set; }

    }
}
