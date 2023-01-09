﻿// <auto-generated />
using System;
using ExerciseApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ExerciseApi.Migrations
{
    [DbContext(typeof(ExerciseApiDbContext))]
    [Migration("20230109110136_fix createdby and datecreated 2")]
    partial class fixcreatedbyanddatecreated2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ExerciseApi.Models.Components.TimeComponent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("BasicActionFacadeId")
                        .HasColumnType("uuid");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("interval");

                    b.Property<Guid?>("ExerciseFacadeId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ExerciseRepFacadeId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ExerciseStepFacadeId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("BasicActionFacadeId");

                    b.HasIndex("ExerciseFacadeId");

                    b.HasIndex("ExerciseRepFacadeId");

                    b.HasIndex("ExerciseStepFacadeId");

                    b.ToTable("TimeComponent");

                    b.HasDiscriminator<string>("Discriminator").HasValue("TimeComponent");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("ExerciseApi.Models.Equipment.BaseEquipment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("BaseEquipments");
                });

            modelBuilder.Entity("ExerciseApi.Models.ExerciseComponents.BasicActionModel.BasicAction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<Guid?>("EquipmentId")
                        .HasColumnType("uuid");

                    b.Property<string>("Instruction")
                        .HasColumnType("text");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("EquipmentId");

                    b.ToTable("BasicActions");
                });

            modelBuilder.Entity("ExerciseApi.Models.ExerciseComponents.BasicActionModel.BasicActionFacade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("BasicActionId")
                        .HasColumnType("uuid");

                    b.Property<bool>("Completed")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("ExerciseStepId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("BasicActionId");

                    b.HasIndex("ExerciseStepId");

                    b.ToTable("BasicActionFacades");
                });

            modelBuilder.Entity("ExerciseApi.Models.ExerciseComponents.ExerciseModel.Exercise", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Completed")
                        .HasColumnType("boolean");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("ExerciseApi.Models.ExerciseComponents.ExerciseModel.ExerciseFacade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Completed")
                        .HasColumnType("boolean");

                    b.Property<Guid>("ExerciseId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("WorkoutDayId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.HasIndex("WorkoutDayId");

                    b.ToTable("ExerciseFacades");
                });

            modelBuilder.Entity("ExerciseApi.Models.ExerciseComponents.RepModel.ExerciseRep", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Completed")
                        .HasColumnType("boolean");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<bool>("PerformConcurrently")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("ExerciseReps");
                });

            modelBuilder.Entity("ExerciseApi.Models.ExerciseComponents.RepModel.ExerciseRepFacade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Completed")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("ExerciseId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RepId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.HasIndex("RepId");

                    b.ToTable("ExerciseRepFacades");
                });

            modelBuilder.Entity("ExerciseApi.Models.ExerciseComponents.StepModel.ExerciseStep", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Completed")
                        .HasColumnType("boolean");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<bool>("PerformConcurrently")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("ExerciseSteps");
                });

            modelBuilder.Entity("ExerciseApi.Models.ExerciseComponents.StepModel.ExerciseStepFacade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Completed")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("ExerciseRepId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("StepId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseRepId");

                    b.HasIndex("StepId");

                    b.ToTable("ExerciseStepFacades");
                });

            modelBuilder.Entity("ExerciseApi.Models.WorkoutDay", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Completed")
                        .HasColumnType("boolean");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateTaken")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("WorkoutDays");
                });

            modelBuilder.Entity("ExerciseApi.Models.Break.BasicBreak", b =>
                {
                    b.HasBaseType("ExerciseApi.Models.Components.TimeComponent");

                    b.HasDiscriminator().HasValue("BasicBreak");
                });

            modelBuilder.Entity("ExerciseApi.Models.Break.BreakWithActions", b =>
                {
                    b.HasBaseType("ExerciseApi.Models.Components.TimeComponent");

                    b.HasDiscriminator().HasValue("BreakWithActions");
                });

            modelBuilder.Entity("ExerciseApi.Models.Time.StartTime", b =>
                {
                    b.HasBaseType("ExerciseApi.Models.Components.TimeComponent");

                    b.HasDiscriminator().HasValue("StartTime");
                });

            modelBuilder.Entity("ExerciseApi.Models.Time.StopTime", b =>
                {
                    b.HasBaseType("ExerciseApi.Models.Components.TimeComponent");

                    b.HasDiscriminator().HasValue("StopTime");
                });

            modelBuilder.Entity("ExerciseApi.Models.Components.TimeComponent", b =>
                {
                    b.HasOne("ExerciseApi.Models.ExerciseComponents.BasicActionModel.BasicActionFacade", null)
                        .WithMany("Timeline")
                        .HasForeignKey("BasicActionFacadeId");

                    b.HasOne("ExerciseApi.Models.ExerciseComponents.ExerciseModel.ExerciseFacade", null)
                        .WithMany("Timeline")
                        .HasForeignKey("ExerciseFacadeId");

                    b.HasOne("ExerciseApi.Models.ExerciseComponents.RepModel.ExerciseRepFacade", null)
                        .WithMany("Timeline")
                        .HasForeignKey("ExerciseRepFacadeId");

                    b.HasOne("ExerciseApi.Models.ExerciseComponents.StepModel.ExerciseStepFacade", null)
                        .WithMany("Timeline")
                        .HasForeignKey("ExerciseStepFacadeId");
                });

            modelBuilder.Entity("ExerciseApi.Models.ExerciseComponents.BasicActionModel.BasicAction", b =>
                {
                    b.HasOne("ExerciseApi.Models.Equipment.BaseEquipment", "Equipment")
                        .WithMany()
                        .HasForeignKey("EquipmentId");

                    b.Navigation("Equipment");
                });

            modelBuilder.Entity("ExerciseApi.Models.ExerciseComponents.BasicActionModel.BasicActionFacade", b =>
                {
                    b.HasOne("ExerciseApi.Models.ExerciseComponents.BasicActionModel.BasicAction", "BasicAction")
                        .WithMany()
                        .HasForeignKey("BasicActionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExerciseApi.Models.ExerciseComponents.StepModel.ExerciseStep", null)
                        .WithMany("Actions")
                        .HasForeignKey("ExerciseStepId");

                    b.Navigation("BasicAction");
                });

            modelBuilder.Entity("ExerciseApi.Models.ExerciseComponents.ExerciseModel.ExerciseFacade", b =>
                {
                    b.HasOne("ExerciseApi.Models.ExerciseComponents.ExerciseModel.Exercise", "Exercise")
                        .WithMany()
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExerciseApi.Models.WorkoutDay", null)
                        .WithMany("Exercises")
                        .HasForeignKey("WorkoutDayId");

                    b.Navigation("Exercise");
                });

            modelBuilder.Entity("ExerciseApi.Models.ExerciseComponents.RepModel.ExerciseRepFacade", b =>
                {
                    b.HasOne("ExerciseApi.Models.ExerciseComponents.ExerciseModel.Exercise", null)
                        .WithMany("ExerciseSet")
                        .HasForeignKey("ExerciseId");

                    b.HasOne("ExerciseApi.Models.ExerciseComponents.RepModel.ExerciseRep", "Rep")
                        .WithMany()
                        .HasForeignKey("RepId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rep");
                });

            modelBuilder.Entity("ExerciseApi.Models.ExerciseComponents.StepModel.ExerciseStepFacade", b =>
                {
                    b.HasOne("ExerciseApi.Models.ExerciseComponents.RepModel.ExerciseRep", null)
                        .WithMany("Steps")
                        .HasForeignKey("ExerciseRepId");

                    b.HasOne("ExerciseApi.Models.ExerciseComponents.StepModel.ExerciseStep", "Step")
                        .WithMany()
                        .HasForeignKey("StepId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Step");
                });

            modelBuilder.Entity("ExerciseApi.Models.ExerciseComponents.BasicActionModel.BasicActionFacade", b =>
                {
                    b.Navigation("Timeline");
                });

            modelBuilder.Entity("ExerciseApi.Models.ExerciseComponents.ExerciseModel.Exercise", b =>
                {
                    b.Navigation("ExerciseSet");
                });

            modelBuilder.Entity("ExerciseApi.Models.ExerciseComponents.ExerciseModel.ExerciseFacade", b =>
                {
                    b.Navigation("Timeline");
                });

            modelBuilder.Entity("ExerciseApi.Models.ExerciseComponents.RepModel.ExerciseRep", b =>
                {
                    b.Navigation("Steps");
                });

            modelBuilder.Entity("ExerciseApi.Models.ExerciseComponents.RepModel.ExerciseRepFacade", b =>
                {
                    b.Navigation("Timeline");
                });

            modelBuilder.Entity("ExerciseApi.Models.ExerciseComponents.StepModel.ExerciseStep", b =>
                {
                    b.Navigation("Actions");
                });

            modelBuilder.Entity("ExerciseApi.Models.ExerciseComponents.StepModel.ExerciseStepFacade", b =>
                {
                    b.Navigation("Timeline");
                });

            modelBuilder.Entity("ExerciseApi.Models.WorkoutDay", b =>
                {
                    b.Navigation("Exercises");
                });
#pragma warning restore 612, 618
        }
    }
}
