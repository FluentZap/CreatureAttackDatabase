﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rampage;

namespace RampageConsole.Migrations
{
    [DbContext(typeof(CADContext))]
    partial class CADContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("Rampage.City", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("Population");

                    b.HasKey("Id");

                    b.ToTable("city");
                });

            modelBuilder.Entity("Rampage.Creature", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("Threat_level");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("creature");
                });

            modelBuilder.Entity("Rampage.Rampage", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("City_id");

                    b.Property<long>("Creature_id");

                    b.Property<int>("Damages");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Status");

                    b.HasKey("Id");

                    b.ToTable("rampage");
                });
#pragma warning restore 612, 618
        }
    }
}
