﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Domain;

namespace WebApi.Migrations
{
    [DbContext(typeof(DomainContext))]
    partial class DomainContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity("WebApi.Workflows.Holiday.Holiday", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Assignee")
                        .IsRequired();

                    b.Property<DateTime?>("From");

                    b.Property<string>("Requester")
                        .IsRequired();

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<string>("Superior");

                    b.Property<DateTime?>("To");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Holiday");
                });

            modelBuilder.Entity("WebApi.Workflows.Holiday.HolidayMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author")
                        .IsRequired();

                    b.Property<int>("HolidayId");

                    b.Property<string>("Message")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("HolidayId");

                    b.ToTable("HolidayMessage");
                });

            modelBuilder.Entity("WebApi.Workflows.Issue.Issue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Assignee")
                        .IsRequired();

                    b.Property<string>("Creator")
                        .IsRequired();

                    b.Property<string>("Description");

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Issue");
                });

            modelBuilder.Entity("WebApi.Workflows.Stepper.Stepper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Assignee")
                        .IsRequired();

                    b.Property<string>("Creator")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Stepper");
                });

            modelBuilder.Entity("tomware.Microwf.Engine.WorkItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EntityId");

                    b.Property<string>("Error");

                    b.Property<int>("Retries");

                    b.Property<string>("TriggerName")
                        .IsRequired();

                    b.Property<string>("WorkflowType")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("WorkItem");
                });

            modelBuilder.Entity("tomware.Microwf.Engine.Workflow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Assignee");

                    b.Property<DateTime?>("Completed");

                    b.Property<int>("CorrelationId");

                    b.Property<DateTime>("Started");

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Workflow");
                });

            modelBuilder.Entity("tomware.Microwf.Engine.WorkflowHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("FromState")
                        .IsRequired();

                    b.Property<string>("ToState")
                        .IsRequired();

                    b.Property<string>("UserName");

                    b.Property<int>("WorkflowId");

                    b.HasKey("Id");

                    b.HasIndex("WorkflowId");

                    b.ToTable("WorkflowHistory");
                });

            modelBuilder.Entity("tomware.Microwf.Engine.WorkflowVariable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<string>("Type")
                        .IsRequired();

                    b.Property<int>("WorkflowId");

                    b.HasKey("Id");

                    b.HasIndex("WorkflowId");

                    b.ToTable("WorkflowVariable");
                });

            modelBuilder.Entity("WebApi.Workflows.Holiday.HolidayMessage", b =>
                {
                    b.HasOne("WebApi.Workflows.Holiday.Holiday", "Holiday")
                        .WithMany("Messages")
                        .HasForeignKey("HolidayId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("tomware.Microwf.Engine.WorkflowHistory", b =>
                {
                    b.HasOne("tomware.Microwf.Engine.Workflow", "Workflow")
                        .WithMany("WorkflowHistories")
                        .HasForeignKey("WorkflowId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("tomware.Microwf.Engine.WorkflowVariable", b =>
                {
                    b.HasOne("tomware.Microwf.Engine.Workflow", "Workflow")
                        .WithMany("WorkflowVariables")
                        .HasForeignKey("WorkflowId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
