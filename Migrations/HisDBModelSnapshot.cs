﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using THE_REAL_ONE.Models;

#nullable disable

namespace THE_REAL_ONE.Migrations
{
    [DbContext(typeof(HisDB))]
    partial class HisDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("THE_REAL_ONE.Models.HisPProjects", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("HisPProjects");
                });

            modelBuilder.Entity("THE_REAL_ONE.Models.HisTTasks", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("HisPProjectsId")
                        .HasColumnType("int");

                    b.Property<int>("HisProjectID")
                        .HasColumnType("int");

                    b.Property<int?>("HisTTeamMembersId")
                        .HasColumnType("int");

                    b.Property<int>("HisTeamMemberID")
                        .HasColumnType("int");

                    b.Property<string>("Priority")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("HisPProjectsId");

                    b.HasIndex("HisTTeamMembersId");

                    b.ToTable("HisTTasks");
                });

            modelBuilder.Entity("THE_REAL_ONE.Models.HisTTeamMembers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("HisTTeamMembers");
                });

            modelBuilder.Entity("THE_REAL_ONE.Models.HisTTasks", b =>
                {
                    b.HasOne("THE_REAL_ONE.Models.HisPProjects", null)
                        .WithMany("Task")
                        .HasForeignKey("HisPProjectsId");

                    b.HasOne("THE_REAL_ONE.Models.HisTTeamMembers", null)
                        .WithMany("Task")
                        .HasForeignKey("HisTTeamMembersId");
                });

            modelBuilder.Entity("THE_REAL_ONE.Models.HisPProjects", b =>
                {
                    b.Navigation("Task");
                });

            modelBuilder.Entity("THE_REAL_ONE.Models.HisTTeamMembers", b =>
                {
                    b.Navigation("Task");
                });
#pragma warning restore 612, 618
        }
    }
}
