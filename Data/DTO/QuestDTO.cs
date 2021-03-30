using Job.it_classes.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.it_classes.Data.DTO
{
    public class QuestDTO
    {
        public int QuestId { get; set; }
        public int Price { get; set; }
        public QuestCategory Category { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public DateTime PublishingDate { get; set; }
        public DateTime QuestDate { get; set; }
        public int EstimatedTime { get; set; }
        public string Location { get; set; }
        public User User { get; set; }
    }
}
