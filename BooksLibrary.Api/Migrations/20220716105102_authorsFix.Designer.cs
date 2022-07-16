﻿// <auto-generated />
using System;
using BooksLibrary.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BooksLibrary.Migrations
{
    [DbContext(typeof(BooksDbContext))]
    [Migration("20220716105102_authorsFix")]
    partial class authorsFix
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BooksLibrary.Domain.Entities.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BirthPlace")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DoB")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthPlace = "Poland",
                            Created = new DateTime(2022, 7, 16, 12, 51, 1, 975, DateTimeKind.Local).AddTicks(7350),
                            CreatedBy = "",
                            DoB = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StatusId = 1
                        },
                        new
                        {
                            Id = 2,
                            BirthPlace = "Poland",
                            Created = new DateTime(2022, 7, 16, 12, 51, 1, 975, DateTimeKind.Local).AddTicks(7538),
                            CreatedBy = "",
                            DoB = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StatusId = 1
                        },
                        new
                        {
                            Id = 3,
                            BirthPlace = "Poland",
                            Created = new DateTime(2022, 7, 16, 12, 51, 1, 975, DateTimeKind.Local).AddTicks(7629),
                            CreatedBy = "",
                            DoB = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StatusId = 1
                        },
                        new
                        {
                            Id = 4,
                            BirthPlace = "Poland",
                            Created = new DateTime(2022, 7, 16, 12, 51, 1, 975, DateTimeKind.Local).AddTicks(7705),
                            CreatedBy = "",
                            DoB = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StatusId = 1
                        },
                        new
                        {
                            Id = 5,
                            BirthPlace = "USA",
                            Created = new DateTime(2022, 7, 16, 12, 51, 1, 975, DateTimeKind.Local).AddTicks(7781),
                            CreatedBy = "",
                            DoB = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StatusId = 1
                        });
                });

            modelBuilder.Entity("BooksLibrary.Domain.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailAble")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublicationCountry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("GenreId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            GenreId = 1,
                            IsAvailAble = false,
                            PublicationCountry = "Poland",
                            StatusId = 1,
                            Title = "Wiedźmin"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 1,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            GenreId = 1,
                            IsAvailAble = false,
                            PublicationCountry = "Poland",
                            StatusId = 1,
                            Title = "Krew elfów"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 1,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            GenreId = 1,
                            IsAvailAble = false,
                            PublicationCountry = "Poland",
                            StatusId = 1,
                            Title = "Ostatnie życzenie"
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 1,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            GenreId = 1,
                            IsAvailAble = false,
                            PublicationCountry = "Poland",
                            StatusId = 1,
                            Title = "Sezon burz"
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 1,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            GenreId = 1,
                            IsAvailAble = false,
                            PublicationCountry = "Poland",
                            StatusId = 1,
                            Title = "Pani Jeziora"
                        },
                        new
                        {
                            Id = 6,
                            AuthorId = 1,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            GenreId = 1,
                            IsAvailAble = false,
                            PublicationCountry = "Poland",
                            StatusId = 1,
                            Title = "Czas pogardy"
                        },
                        new
                        {
                            Id = 7,
                            AuthorId = 2,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            GenreId = 2,
                            IsAvailAble = false,
                            PublicationCountry = "Poland",
                            StatusId = 1,
                            Title = "Solaris"
                        },
                        new
                        {
                            Id = 8,
                            AuthorId = 2,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            GenreId = 2,
                            IsAvailAble = false,
                            PublicationCountry = "Poland",
                            StatusId = 1,
                            Title = "Eden"
                        },
                        new
                        {
                            Id = 9,
                            AuthorId = 2,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            GenreId = 2,
                            IsAvailAble = false,
                            PublicationCountry = "Poland",
                            StatusId = 1,
                            Title = "Fiasko"
                        },
                        new
                        {
                            Id = 10,
                            AuthorId = 2,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            GenreId = 2,
                            IsAvailAble = false,
                            PublicationCountry = "Poland",
                            StatusId = 1,
                            Title = "Dzienniki gwiazdowe"
                        },
                        new
                        {
                            Id = 11,
                            AuthorId = 2,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            GenreId = 2,
                            IsAvailAble = false,
                            PublicationCountry = "Poland",
                            StatusId = 1,
                            Title = "Cyberiada"
                        },
                        new
                        {
                            Id = 12,
                            AuthorId = 2,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            GenreId = 2,
                            IsAvailAble = false,
                            PublicationCountry = "Poland",
                            StatusId = 1,
                            Title = "Bajki robotów"
                        },
                        new
                        {
                            Id = 13,
                            AuthorId = 3,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            GenreId = 3,
                            IsAvailAble = false,
                            PublicationCountry = "Poland",
                            StatusId = 1,
                            Title = "Klin"
                        },
                        new
                        {
                            Id = 14,
                            AuthorId = 3,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            GenreId = 3,
                            IsAvailAble = false,
                            PublicationCountry = "Poland",
                            StatusId = 1,
                            Title = "Lesio"
                        },
                        new
                        {
                            Id = 15,
                            AuthorId = 3,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            GenreId = 3,
                            IsAvailAble = false,
                            PublicationCountry = "Poland",
                            StatusId = 1,
                            Title = "Dzikie białko"
                        },
                        new
                        {
                            Id = 16,
                            AuthorId = 3,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            GenreId = 3,
                            IsAvailAble = false,
                            PublicationCountry = "Poland",
                            StatusId = 1,
                            Title = "Nawiedzony dom"
                        },
                        new
                        {
                            Id = 17,
                            AuthorId = 3,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            GenreId = 3,
                            IsAvailAble = false,
                            PublicationCountry = "Poland",
                            StatusId = 1,
                            Title = "Wszystko czerwone"
                        },
                        new
                        {
                            Id = 18,
                            AuthorId = 3,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            GenreId = 3,
                            IsAvailAble = false,
                            PublicationCountry = "Poland",
                            StatusId = 1,
                            Title = "Zwyczajne życie"
                        },
                        new
                        {
                            Id = 19,
                            AuthorId = 4,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            GenreId = 4,
                            IsAvailAble = false,
                            PublicationCountry = "Poland",
                            StatusId = 1,
                            Title = "Kareta"
                        },
                        new
                        {
                            Id = 20,
                            AuthorId = 4,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            GenreId = 4,
                            IsAvailAble = false,
                            PublicationCountry = "Poland",
                            StatusId = 1,
                            Title = "W ręku Boga"
                        },
                        new
                        {
                            Id = 21,
                            AuthorId = 4,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            GenreId = 4,
                            IsAvailAble = false,
                            PublicationCountry = "Poland",
                            StatusId = 1,
                            Title = "Zamek w Karpatach"
                        },
                        new
                        {
                            Id = 22,
                            AuthorId = 4,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            GenreId = 4,
                            IsAvailAble = false,
                            PublicationCountry = "Poland",
                            StatusId = 1,
                            Title = "Chłopiec na kucu"
                        },
                        new
                        {
                            Id = 23,
                            AuthorId = 4,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            GenreId = 4,
                            IsAvailAble = false,
                            PublicationCountry = "Poland",
                            StatusId = 1,
                            Title = "Carskie wrota"
                        },
                        new
                        {
                            Id = 24,
                            AuthorId = 4,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            GenreId = 4,
                            IsAvailAble = false,
                            PublicationCountry = "Poland",
                            StatusId = 1,
                            Title = "Kanonierka"
                        },
                        new
                        {
                            Id = 25,
                            AuthorId = 5,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            GenreId = 5,
                            IsAvailAble = false,
                            PublicationCountry = "USA",
                            StatusId = 1,
                            Title = "Les Pionniers"
                        },
                        new
                        {
                            Id = 26,
                            AuthorId = 5,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            GenreId = 5,
                            IsAvailAble = false,
                            PublicationCountry = "USA",
                            StatusId = 1,
                            Title = "Bugles in the Afternoon"
                        },
                        new
                        {
                            Id = 27,
                            AuthorId = 5,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            GenreId = 5,
                            IsAvailAble = false,
                            PublicationCountry = "USA",
                            StatusId = 1,
                            Title = "Alder Gulch"
                        },
                        new
                        {
                            Id = 28,
                            AuthorId = 5,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            GenreId = 5,
                            IsAvailAble = false,
                            PublicationCountry = "USA",
                            StatusId = 1,
                            Title = "Free Grass"
                        },
                        new
                        {
                            Id = 29,
                            AuthorId = 5,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            GenreId = 5,
                            IsAvailAble = false,
                            PublicationCountry = "USA",
                            StatusId = 1,
                            Title = "Trail Town"
                        },
                        new
                        {
                            Id = 30,
                            AuthorId = 5,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            GenreId = 5,
                            IsAvailAble = false,
                            PublicationCountry = "USA",
                            StatusId = 1,
                            Title = "Trouble Shooter"
                        },
                        new
                        {
                            Id = 31,
                            AuthorId = 5,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            GenreId = 5,
                            IsAvailAble = false,
                            PublicationCountry = "USA",
                            StatusId = 1,
                            Title = "The Adventures"
                        },
                        new
                        {
                            Id = 32,
                            AuthorId = 5,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            GenreId = 5,
                            IsAvailAble = false,
                            PublicationCountry = "USA",
                            StatusId = 1,
                            Title = "The wild bunch"
                        });
                });

            modelBuilder.Entity("BooksLibrary.Domain.Entities.BorrowHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<DateTime>("BorrowDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("BorrowHistories");
                });

            modelBuilder.Entity("BooksLibrary.Domain.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            Name = "Fantasy",
                            StatusId = 0
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            Name = "Science fiction",
                            StatusId = 0
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            Name = "Thriller",
                            StatusId = 0
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            Name = "Romance",
                            StatusId = 0
                        },
                        new
                        {
                            Id = 5,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            Name = "Western",
                            StatusId = 0
                        });
                });

            modelBuilder.Entity("BooksLibrary.Domain.Entities.Author", b =>
                {
                    b.OwnsOne("BooksLibrary.Domain.ValueObjects.PersonName", "FullName", b1 =>
                        {
                            b1.Property<int>("AuthorId")
                                .HasColumnType("int");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasMaxLength(300)
                                .HasColumnType("nvarchar(300)")
                                .HasColumnName("FirstName");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasMaxLength(300)
                                .HasColumnType("nvarchar(300)")
                                .HasColumnName("LastName");

                            b1.HasKey("AuthorId");

                            b1.ToTable("Authors");

                            b1.WithOwner()
                                .HasForeignKey("AuthorId");

                            b1.HasData(
                                new
                                {
                                    AuthorId = 1,
                                    FirstName = "Andrzej",
                                    LastName = "Sapkowski"
                                },
                                new
                                {
                                    AuthorId = 2,
                                    FirstName = "Stanisław",
                                    LastName = "Lem"
                                },
                                new
                                {
                                    AuthorId = 3,
                                    FirstName = "Joanna",
                                    LastName = "Chmielewska"
                                },
                                new
                                {
                                    AuthorId = 4,
                                    FirstName = "Andrzej",
                                    LastName = "Stojowski"
                                },
                                new
                                {
                                    AuthorId = 5,
                                    FirstName = "Ernest",
                                    LastName = "Haycox"
                                });
                        });

                    b.Navigation("FullName")
                        .IsRequired();
                });

            modelBuilder.Entity("BooksLibrary.Domain.Entities.Book", b =>
                {
                    b.HasOne("BooksLibrary.Domain.Entities.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BooksLibrary.Domain.Entities.Genre", "Genre")
                        .WithMany("Books")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("BooksLibrary.Domain.Entities.BorrowHistory", b =>
                {
                    b.HasOne("BooksLibrary.Domain.Entities.Book", "Book")
                        .WithMany("BorrowHistories")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("BooksLibrary.Domain.Entities.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BooksLibrary.Domain.Entities.Book", b =>
                {
                    b.Navigation("BorrowHistories");
                });

            modelBuilder.Entity("BooksLibrary.Domain.Entities.Genre", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
