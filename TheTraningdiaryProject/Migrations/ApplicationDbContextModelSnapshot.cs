using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using TheTraningdiaryProject.Models;

namespace TheTraningdiaryProject.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TheTraningdiaryProject.Models.Endurance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Activity");

                    b.Property<int>("Intensity");

                    b.Property<double>("Length");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("TheTraningdiaryProject.Models.Mobility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Length");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("TheTraningdiaryProject.Models.Rest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Length");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("TheTraningdiaryProject.Models.Speed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Activity");

                    b.Property<double>("Length");

                    b.Property<int>("Quantity");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("TheTraningdiaryProject.Models.Strength", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Activity");

                    b.Property<double>("Length");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("TheTraningdiaryProject.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Gender");

                    b.Property<int>("Length");

                    b.Property<string>("Name");

                    b.Property<int>("Weight");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("TheTraningdiaryProject.Models.Workout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment");

                    b.Property<int>("Status");

                    b.Property<string>("Title");

                    b.Property<DateTime>("WorkoutDate");

                    b.Property<int?>("userId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("TheTraningdiaryProject.Models.WorkoutType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("enduranceId");

                    b.Property<int?>("mobilityId");

                    b.Property<int?>("restId");

                    b.Property<int?>("speedId");

                    b.Property<int?>("strengthId");

                    b.Property<int?>("workoutId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("TheTraningdiaryProject.Models.Workout", b =>
                {
                    b.HasOne("TheTraningdiaryProject.Models.User")
                        .WithMany()
                        .HasForeignKey("userId");
                });

            modelBuilder.Entity("TheTraningdiaryProject.Models.WorkoutType", b =>
                {
                    b.HasOne("TheTraningdiaryProject.Models.Endurance")
                        .WithMany()
                        .HasForeignKey("enduranceId");

                    b.HasOne("TheTraningdiaryProject.Models.Mobility")
                        .WithMany()
                        .HasForeignKey("mobilityId");

                    b.HasOne("TheTraningdiaryProject.Models.Rest")
                        .WithMany()
                        .HasForeignKey("restId");

                    b.HasOne("TheTraningdiaryProject.Models.Speed")
                        .WithMany()
                        .HasForeignKey("speedId");

                    b.HasOne("TheTraningdiaryProject.Models.Strength")
                        .WithMany()
                        .HasForeignKey("strengthId");

                    b.HasOne("TheTraningdiaryProject.Models.Workout")
                        .WithMany()
                        .HasForeignKey("workoutId");
                });
        }
    }
}
