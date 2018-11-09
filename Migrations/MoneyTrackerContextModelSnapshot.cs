﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoneyTracker.Persistence;

namespace MoneyTracker.Migrations
{
    [DbContext(typeof(MoneyTrackerContext))]
    partial class MoneyTrackerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MoneyTracker.Persistence.CategoryDA", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<Guid>("IconID");

                    b.HasKey("ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("MoneyTracker.Persistence.IconDA", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("IconKey")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("IconName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("ID");

                    b.ToTable("Icons");
                });

            modelBuilder.Entity("MoneyTracker.Persistence.SpendingAccountDA", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccountName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("ID");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("MoneyTracker.Persistence.SpendingItemDA", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CategoryID");

                    b.Property<decimal>("ChangeValue");

                    b.Property<Guid>("SpendingAccountID");

                    b.Property<int>("Type")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.HasKey("ID");

                    b.ToTable("SpendingItems");
                });
#pragma warning restore 612, 618
        }
    }
}
