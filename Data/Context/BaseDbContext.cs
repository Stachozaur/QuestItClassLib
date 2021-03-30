using Job.it_classes.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.it_classes.Data.Context
{
    public class BaseDbContext : DbContext
    {
        public BaseDbContext(DbContextOptions<BaseDbContext> options)
            : base(options)
        {

        }
        public DbSet<Quest> Quests { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder bldr)
        {
            bldr.Entity<Quest>()
                .HasData(new
                {
                    QuestId = 1,
                    Name = "Bloody Murlocs",
                    Description = "Kill 10 murlocs and bring me their heads",
                    QuestDate = new DateTime(2021, 10, 18),
                    PublishingDate = new DateTime(2021, 10, 18),
                    EstimatedTime = 25,
                    Price = 50,
                    Location = "Murzasichle"
                }); ;

            bldr.Entity<Quest>()
                .HasData(new
                {
                    QuestId = 2,
                    Name = "Shopping",
                    Description = "Bring me 2 polish Vodka with some glass",
                    QuestDate = new DateTime(2021, 05, 03),
                    PublishingDate = new DateTime(2021, 10, 18),
                    EstimatedTime = 15,
                    Price = 250,
                    Location = "Warsaw"
                });

            bldr.Entity<Quest>()
                .HasData(new
                {
                    QuestId = 3,
                    Name = "Dog Walking",
                    Description = "Have some fun with my little puppy",
                    QuestDate = new DateTime(2021, 05, 03),
                    EstimatedTime = 65,
                    Price = 520,
                    Location = "Polzga",
                    PublishingDate = new DateTime(2021, 10, 18),
                });

        }
    }
}
