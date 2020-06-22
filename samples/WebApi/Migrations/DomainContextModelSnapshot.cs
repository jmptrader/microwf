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
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("WebApi.Workflows.Holiday.Holiday", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Assignee")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("From")
                        .HasColumnType("TEXT");

                    b.Property<string>("Requester")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Superior")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("To")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Holiday");
                });

            modelBuilder.Entity("WebApi.Workflows.Holiday.HolidayMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("HolidayId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("HolidayId");

                    b.ToTable("HolidayMessage");
                });

            modelBuilder.Entity("WebApi.Workflows.Issue.Issue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Assignee")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Creator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Issue");
                });

            modelBuilder.Entity("WebApi.Workflows.Stepper.Stepper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Assignee")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Creator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Stepper");
                });

            modelBuilder.Entity("tomware.Microwf.Domain.WorkItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("EntityId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Error")
                        .HasColumnType("TEXT");

                    b.Property<int>("Retries")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TriggerName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkflowType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("WorkItem");
                });

            modelBuilder.Entity("tomware.Microwf.Domain.Workflow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Assignee")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Completed")
                        .HasColumnType("TEXT");

                    b.Property<int>("CorrelationId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Started")
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Workflow");
                });

            modelBuilder.Entity("tomware.Microwf.Domain.WorkflowHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("FromState")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ToState")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.Property<int>("WorkflowId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("WorkflowId");

                    b.ToTable("WorkflowHistory");
                });

            modelBuilder.Entity("tomware.Microwf.Domain.WorkflowVariable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("WorkflowId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("WorkflowId");

                    b.ToTable("WorkflowVariable");
                });

            modelBuilder.Entity("WebApi.Workflows.Holiday.HolidayMessage", b =>
                {
                    b.HasOne("WebApi.Workflows.Holiday.Holiday", "Holiday")
                        .WithMany("Messages")
                        .HasForeignKey("HolidayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("tomware.Microwf.Domain.WorkflowHistory", b =>
                {
                    b.HasOne("tomware.Microwf.Domain.Workflow", "Workflow")
                        .WithMany("WorkflowHistories")
                        .HasForeignKey("WorkflowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("tomware.Microwf.Domain.WorkflowVariable", b =>
                {
                    b.HasOne("tomware.Microwf.Domain.Workflow", "Workflow")
                        .WithMany("WorkflowVariables")
                        .HasForeignKey("WorkflowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
