﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using api_cinema_challenge.Data;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    [DbContext(typeof(CinemaContext))]
    partial class CinemaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("api_cinema_challenge.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("rating");

                    b.Property<int>("RuntimeMins")
                        .HasColumnType("integer")
                        .HasColumnName("runtime_mins");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 2, 10, 17, 49, 59, 656, DateTimeKind.Utc).AddTicks(8544),
                            Description = "A short comedy movie",
                            Rating = "Good",
                            RuntimeMins = 77,
                            Title = "The Sweet Potato",
                            UpdatedAt = new DateTime(2024, 2, 10, 17, 49, 59, 656, DateTimeKind.Utc).AddTicks(8545)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 2, 5, 17, 49, 59, 656, DateTimeKind.Utc).AddTicks(8547),
                            Description = "A thrilling mystery movie",
                            Rating = "Excellent",
                            RuntimeMins = 120,
                            Title = "Mystery Mansion",
                            UpdatedAt = new DateTime(2024, 2, 7, 17, 49, 59, 656, DateTimeKind.Utc).AddTicks(8548)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 1, 31, 17, 49, 59, 656, DateTimeKind.Utc).AddTicks(8549),
                            Description = "A beautiful romantic movie",
                            Rating = "Great",
                            RuntimeMins = 90,
                            Title = "Romantic Sunset",
                            UpdatedAt = new DateTime(2024, 2, 2, 17, 49, 59, 656, DateTimeKind.Utc).AddTicks(8553)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 1, 26, 17, 49, 59, 656, DateTimeKind.Utc).AddTicks(8554),
                            Description = "An epic science fiction movie",
                            Rating = "Excellent",
                            RuntimeMins = 150,
                            Title = "Sci-Fi Odyssey",
                            UpdatedAt = new DateTime(2024, 1, 29, 17, 49, 59, 656, DateTimeKind.Utc).AddTicks(8555)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 1, 21, 17, 49, 59, 656, DateTimeKind.Utc).AddTicks(8556),
                            Description = "A gripping drama movie",
                            Rating = "Good",
                            RuntimeMins = 110,
                            Title = "Drama Junction",
                            UpdatedAt = new DateTime(2024, 1, 23, 17, 49, 59, 656, DateTimeKind.Utc).AddTicks(8556)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("integer")
                        .HasColumnName("movie_id");

                    b.Property<int>("ScreenNumber")
                        .HasColumnType("integer")
                        .HasColumnName("screen_number");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("start_time");

                    b.Property<int>("Capacity")
                        .HasColumnType("integer")
                        .HasColumnName("capacity");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("MovieId", "ScreenNumber", "StartTime");

                    b.ToTable("screenings");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            ScreenNumber = 1,
                            StartTime = new DateTime(2024, 2, 10, 18, 49, 59, 657, DateTimeKind.Utc).AddTicks(790),
                            Capacity = 100,
                            CreatedAt = new DateTime(2024, 2, 10, 17, 49, 59, 657, DateTimeKind.Utc).AddTicks(791),
                            UpdatedAt = new DateTime(2024, 2, 10, 17, 49, 59, 657, DateTimeKind.Utc).AddTicks(792)
                        },
                        new
                        {
                            MovieId = 1,
                            ScreenNumber = 2,
                            StartTime = new DateTime(2024, 2, 10, 20, 49, 59, 657, DateTimeKind.Utc).AddTicks(793),
                            Capacity = 120,
                            CreatedAt = new DateTime(2024, 2, 10, 17, 49, 59, 657, DateTimeKind.Utc).AddTicks(794),
                            UpdatedAt = new DateTime(2024, 2, 10, 17, 49, 59, 657, DateTimeKind.Utc).AddTicks(794)
                        },
                        new
                        {
                            MovieId = 2,
                            ScreenNumber = 3,
                            StartTime = new DateTime(2024, 2, 10, 21, 49, 59, 657, DateTimeKind.Utc).AddTicks(795),
                            Capacity = 70,
                            CreatedAt = new DateTime(2024, 2, 10, 17, 49, 59, 657, DateTimeKind.Utc).AddTicks(795),
                            UpdatedAt = new DateTime(2024, 2, 10, 17, 49, 59, 657, DateTimeKind.Utc).AddTicks(796)
                        },
                        new
                        {
                            MovieId = 2,
                            ScreenNumber = 4,
                            StartTime = new DateTime(2024, 2, 10, 18, 49, 59, 657, DateTimeKind.Utc).AddTicks(797),
                            Capacity = 80,
                            CreatedAt = new DateTime(2024, 2, 10, 17, 49, 59, 657, DateTimeKind.Utc).AddTicks(804),
                            UpdatedAt = new DateTime(2024, 2, 10, 17, 49, 59, 657, DateTimeKind.Utc).AddTicks(805)
                        },
                        new
                        {
                            MovieId = 3,
                            ScreenNumber = 5,
                            StartTime = new DateTime(2024, 2, 10, 22, 49, 59, 657, DateTimeKind.Utc).AddTicks(805),
                            Capacity = 83,
                            CreatedAt = new DateTime(2024, 2, 10, 17, 49, 59, 657, DateTimeKind.Utc).AddTicks(806),
                            UpdatedAt = new DateTime(2024, 2, 10, 17, 49, 59, 657, DateTimeKind.Utc).AddTicks(806)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("LastUpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("MovieId")
                        .HasColumnType("integer");

                    b.Property<int>("NumSeats")
                        .HasColumnType("integer")
                        .HasColumnName("num_of_seats");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("UserId");

                    b.ToTable("tickets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 2, 10, 17, 49, 59, 657, DateTimeKind.Utc).AddTicks(838),
                            LastUpdatedAt = new DateTime(2024, 2, 10, 17, 49, 59, 657, DateTimeKind.Utc).AddTicks(838),
                            MovieId = 1,
                            NumSeats = 2,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 2, 10, 17, 49, 59, 657, DateTimeKind.Utc).AddTicks(840),
                            LastUpdatedAt = new DateTime(2024, 2, 10, 17, 49, 59, 657, DateTimeKind.Utc).AddTicks(840),
                            MovieId = 2,
                            NumSeats = 3,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 2, 10, 17, 49, 59, 657, DateTimeKind.Utc).AddTicks(841),
                            LastUpdatedAt = new DateTime(2024, 2, 10, 17, 49, 59, 657, DateTimeKind.Utc).AddTicks(842),
                            MovieId = 3,
                            NumSeats = 5,
                            UserId = 3
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("phone_number");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 2, 10, 17, 49, 59, 656, DateTimeKind.Utc).AddTicks(8224),
                            Email = "joel@email.com",
                            Name = "Joel Joelsson",
                            PhoneNumber = "0700050088",
                            UpdatedAt = new DateTime(2024, 2, 10, 17, 49, 59, 656, DateTimeKind.Utc).AddTicks(8230)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 2, 8, 17, 49, 59, 656, DateTimeKind.Utc).AddTicks(8232),
                            Email = "alice@email.com",
                            Name = "Alice Johnson",
                            PhoneNumber = "0701122334",
                            UpdatedAt = new DateTime(2024, 2, 8, 17, 49, 59, 656, DateTimeKind.Utc).AddTicks(8238)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 2, 5, 17, 49, 59, 656, DateTimeKind.Utc).AddTicks(8240),
                            Email = "bob@email.com",
                            Name = "Bob Smith",
                            PhoneNumber = "0709876543",
                            UpdatedAt = new DateTime(2024, 2, 7, 17, 49, 59, 656, DateTimeKind.Utc).AddTicks(8240)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 2, 2, 17, 49, 59, 656, DateTimeKind.Utc).AddTicks(8241),
                            Email = "emma@email.com",
                            Name = "Emma White",
                            PhoneNumber = "0703344556",
                            UpdatedAt = new DateTime(2024, 2, 4, 17, 49, 59, 656, DateTimeKind.Utc).AddTicks(8242)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 1, 31, 17, 49, 59, 656, DateTimeKind.Utc).AddTicks(8243),
                            Email = "david@email.com",
                            Name = "David Brown",
                            PhoneNumber = "0706677889",
                            UpdatedAt = new DateTime(2024, 2, 3, 17, 49, 59, 656, DateTimeKind.Utc).AddTicks(8244)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
                {
                    b.HasOne("api_cinema_challenge.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Ticket", b =>
                {
                    b.HasOne("api_cinema_challenge.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api_cinema_challenge.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
