﻿// <auto-generated />
using System;
using Job.it_classes.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Job.it_ClassLib.Migrations
{
    [DbContext(typeof(BaseDbContext))]
    partial class BaseDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Job.it_ClassLib.Data.Entities.Applicant", b =>
                {
                    b.Property<int>("ApplicantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("QuestId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ApplicantId");

                    b.HasIndex("QuestId");

                    b.HasIndex("UserId");

                    b.ToTable("Applicant");
                });

            modelBuilder.Entity("Job.it_ClassLib.Data.Entities.QuestCategory", b =>
                {
                    b.Property<int>("QuestCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IconFilepath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuestCategoryId");

                    b.ToTable("QuestCategory");

                    b.HasData(
                        new
                        {
                            QuestCategoryId = 1,
                            IconFilepath = "/assets/images/hantla1.svg",
                            Name = "Sport"
                        },
                        new
                        {
                            QuestCategoryId = 2,
                            IconFilepath = "/assets/images/dogev2_cat.svg",
                            Name = "Animals"
                        },
                        new
                        {
                            QuestCategoryId = 3,
                            IconFilepath = "/assets/images/Barber_category.svg",
                            Name = "Barber"
                        });
                });

            modelBuilder.Entity("Job.it_ClassLib.Data.Entities.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            Name = "Admin"
                        },
                        new
                        {
                            RoleId = 2,
                            Name = "User"
                        });
                });

            modelBuilder.Entity("Job.it_classes.Data.Entities.Quest", b =>
                {
                    b.Property<int>("QuestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstimatedTime")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishingDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("QuestCategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("QuestDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("QuestId");

                    b.HasIndex("QuestCategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Quests");

                    b.HasData(
                        new
                        {
                            QuestId = 1,
                            Description = "Kill 10 murlocs and bring me their heads",
                            EstimatedTime = 25,
                            Location = "Murzasichle",
                            Name = "Bloody Murlocs",
                            Price = 50,
                            PublishingDate = new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QuestDate = new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            QuestId = 2,
                            Description = "Bring me 2 polish Vodka with some glass",
                            EstimatedTime = 15,
                            Location = "Warsaw",
                            Name = "Shopping",
                            Price = 250,
                            PublishingDate = new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QuestDate = new DateTime(2021, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            QuestId = 3,
                            Description = "Have some fun with my little puppy",
                            EstimatedTime = 65,
                            Location = "Polzga",
                            Name = "Dog Walking",
                            Price = 520,
                            PublishingDate = new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QuestDate = new DateTime(2021, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Job.it_classes.Data.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            City = "Newcastle",
                            Email = "eddiehall@beast.com",
                            FirstName = "Eddie",
                            LastName = "Hall",
                            Password = "25000kcal",
                            RoleId = 2
                        },
                        new
                        {
                            UserId = 2,
                            City = "Milan",
                            Email = "lugii@barber.com",
                            FirstName = "Luigi",
                            LastName = "Scissorio",
                            Password = "whisky2137",
                            RoleId = 2
                        },
                        new
                        {
                            UserId = 3,
                            City = "Warszawa",
                            Email = "Mario@Pipeman.com",
                            FirstName = "Mario",
                            LastName = "Pipeman",
                            Password = "sąsiadkaobok",
                            RoleId = 2
                        });
                });

            modelBuilder.Entity("Job.it_ClassLib.Data.Entities.Applicant", b =>
                {
                    b.HasOne("Job.it_classes.Data.Entities.Quest", "Quest")
                        .WithMany("Applicants")
                        .HasForeignKey("QuestId");

                    b.HasOne("Job.it_classes.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Quest");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Job.it_classes.Data.Entities.Quest", b =>
                {
                    b.HasOne("Job.it_ClassLib.Data.Entities.QuestCategory", "QuestCategory")
                        .WithMany()
                        .HasForeignKey("QuestCategoryId");

                    b.HasOne("Job.it_classes.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("QuestCategory");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Job.it_classes.Data.Entities.User", b =>
                {
                    b.HasOne("Job.it_ClassLib.Data.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Job.it_classes.Data.Entities.Quest", b =>
                {
                    b.Navigation("Applicants");
                });
#pragma warning restore 612, 618
        }
    }
}
