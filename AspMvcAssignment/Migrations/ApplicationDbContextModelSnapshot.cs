﻿// <auto-generated />
using AspMvcAssignment.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AspMvcAssignment.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AspMvcAssignment.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityId"), 1L, 1);

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.HasKey("CityId");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            CityId = 1,
                            CityName = "Devon",
                            CountryId = 1
                        },
                        new
                        {
                            CityId = 2,
                            CityName = "London",
                            CountryId = 1
                        },
                        new
                        {
                            CityId = 3,
                            CityName = "Ottawa",
                            CountryId = 2
                        },
                        new
                        {
                            CityId = 4,
                            CityName = "Ontario",
                            CountryId = 2
                        },
                        new
                        {
                            CityId = 5,
                            CityName = "Tanta",
                            CountryId = 3
                        },
                        new
                        {
                            CityId = 6,
                            CityName = "Cairo",
                            CountryId = 3
                        },
                        new
                        {
                            CityId = 7,
                            CityName = "Tokyo",
                            CountryId = 4
                        },
                        new
                        {
                            CityId = 8,
                            CityName = "Handa",
                            CountryId = 4
                        });
                });

            modelBuilder.Entity("AspMvcAssignment.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryId"), 1L, 1);

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            CountryName = "England"
                        },
                        new
                        {
                            CountryId = 2,
                            CountryName = "Canada"
                        },
                        new
                        {
                            CountryId = 3,
                            CountryName = "Egypt"
                        },
                        new
                        {
                            CountryId = 4,
                            CountryName = "Japan"
                        });
                });

            modelBuilder.Entity("AspMvcAssignment.Models.Language", b =>
                {
                    b.Property<int>("LanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LanguageId"), 1L, 1);

                    b.Property<string>("LanguageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LanguageId");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            LanguageId = 1,
                            LanguageName = "English"
                        },
                        new
                        {
                            LanguageId = 2,
                            LanguageName = "Arabic"
                        },
                        new
                        {
                            LanguageId = 3,
                            LanguageName = "Swedish"
                        },
                        new
                        {
                            LanguageId = 4,
                            LanguageName = "Spanish"
                        },
                        new
                        {
                            LanguageId = 5,
                            LanguageName = "Turkish"
                        },
                        new
                        {
                            LanguageId = 6,
                            LanguageName = "Chinese"
                        },
                        new
                        {
                            LanguageId = 7,
                            LanguageName = "Hindi"
                        },
                        new
                        {
                            LanguageId = 8,
                            LanguageName = "French"
                        },
                        new
                        {
                            LanguageId = 9,
                            LanguageName = "Danish"
                        });
                });

            modelBuilder.Entity("AspMvcAssignment.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfBooks")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 1,
                            Name = "Agatha Christie",
                            NumberOfBooks = 85
                        },
                        new
                        {
                            Id = 2,
                            CityId = 2,
                            Name = "Dan Brown",
                            NumberOfBooks = 7
                        },
                        new
                        {
                            Id = 3,
                            CityId = 7,
                            Name = "Yasuo Uchida",
                            NumberOfBooks = 130
                        },
                        new
                        {
                            Id = 4,
                            CityId = 6,
                            Name = "Ahmed Tawfik",
                            NumberOfBooks = 200
                        });
                });

            modelBuilder.Entity("LanguagePerson", b =>
                {
                    b.Property<int>("LanguagesLanguageId")
                        .HasColumnType("int");

                    b.Property<int>("PeopleId")
                        .HasColumnType("int");

                    b.HasKey("LanguagesLanguageId", "PeopleId");

                    b.HasIndex("PeopleId");

                    b.ToTable("LanguagePerson");

                    b.HasData(
                        new
                        {
                            LanguagesLanguageId = 1,
                            PeopleId = 1
                        },
                        new
                        {
                            LanguagesLanguageId = 6,
                            PeopleId = 1
                        },
                        new
                        {
                            LanguagesLanguageId = 1,
                            PeopleId = 2
                        },
                        new
                        {
                            LanguagesLanguageId = 3,
                            PeopleId = 2
                        },
                        new
                        {
                            LanguagesLanguageId = 9,
                            PeopleId = 3
                        },
                        new
                        {
                            LanguagesLanguageId = 4,
                            PeopleId = 3
                        },
                        new
                        {
                            LanguagesLanguageId = 8,
                            PeopleId = 4
                        },
                        new
                        {
                            LanguagesLanguageId = 2,
                            PeopleId = 4
                        });
                });

            modelBuilder.Entity("AspMvcAssignment.Models.City", b =>
                {
                    b.HasOne("AspMvcAssignment.Models.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("AspMvcAssignment.Models.Person", b =>
                {
                    b.HasOne("AspMvcAssignment.Models.City", "City")
                        .WithMany("People")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("LanguagePerson", b =>
                {
                    b.HasOne("AspMvcAssignment.Models.Language", null)
                        .WithMany()
                        .HasForeignKey("LanguagesLanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AspMvcAssignment.Models.Person", null)
                        .WithMany()
                        .HasForeignKey("PeopleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AspMvcAssignment.Models.City", b =>
                {
                    b.Navigation("People");
                });

            modelBuilder.Entity("AspMvcAssignment.Models.Country", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
