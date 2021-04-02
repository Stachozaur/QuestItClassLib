using Job.it_classes.Data.Entities;
using Job.it_ClassLib.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.it_classes.Data.Context
{
    public class BaseDbContext : DbContext
    {
        private readonly IConfiguration _config;

        public BaseDbContext(DbContextOptions<BaseDbContext> options, IConfiguration config)
            : base(options)
        {
            _config = config;
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Quest> Quests { get; set; }

        protected override void OnModelCreating(ModelBuilder bldr)
        {

            bldr.Entity<User>()
                .HasData(new
                {
                    UserId = 1,
                    FirstName = "Eddie",
                    LastName = "Hall",
                    Email = "eddiehall@beast.com",
                    Password = "25000kcal",
                    City = "Newcastle",
                    RoleId = 2,
                });

            bldr.Entity<User>()
                .HasData(new
                {
                    UserId = 2,
                    FirstName = "Luigi",
                    LastName = "Scissorio",
                    Email = "lugii@barber.com",
                    Password = "whisky2137",
                    City = "Milan",
                    RoleId = 2,
                });

            bldr.Entity<User>()
                .HasData(new
                {
                    UserId = 3,
                    FirstName = "Mario",
                    LastName = "Pipeman",
                    Email = "Mario@Pipeman.com",
                    Password = "sąsiadkaobok",
                    City = "Warszawa",
                    RoleId = 2,
                });

            bldr.Entity<Role>()
                .HasData(new
                {
                    RoleId = 1,
                    Name = "Admin"
                });

            bldr.Entity<Role>()
                .HasData(new
                {
                    RoleId = 2,
                    Name = "User"
                });

            bldr.Entity<QuestCategory>()
                .HasData(new
                {
                    QuestCategoryId = 1,
                    Name = "Sport",
                    IconFilepath = "/assets/images/hantla1.svg"
                });


            bldr.Entity<QuestCategory>()
                .HasData(new
                {
                    QuestCategoryId = 2,
                    Name = "Animals",
                    IconFilepath = "/assets/images/dogev2_cat.svg"
                });

            bldr.Entity<QuestCategory>()
                .HasData(new
                {
                    QuestCategoryId = 3,
                    Name = "Barber",
                    IconFilepath = "/assets/images/Barber_category.svg"
                });

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
                });

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
