﻿// <auto-generated />
using System;
using ListingScraper.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ListingScraper.Database.Migrations
{
    [DbContext(typeof(ListingScraperContext))]
    partial class ListingScraperContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("ListingScraper.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("FullAddress");

                    b.Property<string>("Latitude");

                    b.Property<string>("Longitude");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime?>("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("ListingScraper.Entities.PageDownloadData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("PageDownloadStatus");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("Source");

                    b.Property<DateTime?>("UpdatedOn");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("PageDownloadData");
                });

            modelBuilder.Entity("ListingScraper.Entities.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AddressId");

                    b.Property<int>("AreaInSquareMeters");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("Price");

                    b.Property<int>("Rooms");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime?>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("ListingScraper.Entities.ScrapeRequests", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("Pages");

                    b.Property<Guid>("RequestId");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime?>("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("ScrapeRequests");
                });

            modelBuilder.Entity("ListingScraper.Entities.Property", b =>
                {
                    b.HasOne("ListingScraper.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");
                });
#pragma warning restore 612, 618
        }
    }
}
