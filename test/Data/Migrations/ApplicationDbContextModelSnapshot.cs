﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using test.Data;

namespace test.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("test.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("test.Models.ApprovalStep", b =>
                {
                    b.Property<int>("ApprovalStepID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("ApprovalStepIsActive");

                    b.Property<string>("ApprovalStepName");

                    b.Property<int>("WorkStepID");

                    b.HasKey("ApprovalStepID");

                    b.HasIndex("WorkStepID");

                    b.ToTable("ApprovalStep");
                });

            modelBuilder.Entity("test.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("DepartmentIsActive");

                    b.Property<string>("DepartmentName");

                    b.Property<int>("InstitutionID");

                    b.HasKey("DepartmentId");

                    b.HasIndex("InstitutionID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("test.Models.Institution", b =>
                {
                    b.Property<int>("InstitutionID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("InstitutionIsActive");

                    b.Property<string>("InstitutionName");

                    b.HasKey("InstitutionID");

                    b.ToTable("Institutions");
                });

            modelBuilder.Entity("test.Models.Process", b =>
                {
                    b.Property<int>("ProcessID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DepartmentID");

                    b.Property<bool>("ProcessIsActive");

                    b.Property<string>("ProcessName");

                    b.Property<int>("ProcessSerialNumber");

                    b.HasKey("ProcessID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Processes");
                });

            modelBuilder.Entity("test.Models.WorkStep", b =>
                {
                    b.Property<int>("WorkStepID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ProcessID");

                    b.Property<bool>("WorkStepIsActive");

                    b.Property<string>("WorkStepName");

                    b.Property<int>("WorkStepSerialNumber");

                    b.HasKey("WorkStepID");

                    b.HasIndex("ProcessID");

                    b.ToTable("WorkSteps");
                });

            modelBuilder.Entity("test.Models.WSDetailView", b =>
                {
                    b.Property<int>("WSDetailViewID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("WSDVSerialNumber");

                    b.Property<int>("WSDVWorkStepID");

                    b.Property<string>("WSDetailViewName");

                    b.Property<bool>("wSDVIsActive");

                    b.HasKey("WSDetailViewID");

                    b.HasIndex("WSDVWorkStepID");

                    b.ToTable("WSDetailViews");
                });

            modelBuilder.Entity("test.Models.WSDVDetailObject", b =>
                {
                    b.Property<int>("WSDVDetailObjectID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("DVDOAllowNull");

                    b.Property<string>("DVDOCalculationFormula");

                    b.Property<string>("DVDOControlType");

                    b.Property<string>("DVDODataType");

                    b.Property<string>("DVDODefaultValue");

                    b.Property<int>("DVDODetailViewID");

                    b.Property<bool>("DVDOExecutionIdentifier");

                    b.Property<bool>("DVDOIsActive");

                    b.Property<bool>("DVDOIsCalculated");

                    b.Property<bool>("DVDOIsEditingByUserAllowed");

                    b.Property<bool>("DVDOIsUnique");

                    b.Property<string>("DVDOName");

                    b.Property<int>("DVDOSerialNumber");

                    b.Property<int>("DVDOTabOrder");

                    b.HasKey("WSDVDetailObjectID");

                    b.HasIndex("DVDODetailViewID");

                    b.ToTable("GetWSDVDetailObjects");
                });

            modelBuilder.Entity("test.Models.WSHeaderObject", b =>
                {
                    b.Property<int>("WSHeaderObjectID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("WSHHOSerialNumber");

                    b.Property<int>("WSHOWorkStepID");

                    b.Property<string>("WSHObjectName");

                    b.Property<bool>("wSHOAllowNull");

                    b.Property<string>("wSHOCalculationFormula");

                    b.Property<string>("wSHOControlType");

                    b.Property<string>("wSHODataType");

                    b.Property<string>("wSHODefaultValue");

                    b.Property<int>("wSHOExecutionIdentifier");

                    b.Property<bool>("wSHOIsActive");

                    b.Property<bool>("wSHOIsCalculated");

                    b.Property<bool>("wSHOIsEditingByUserAllowed");

                    b.Property<bool>("wSHOIsUnique");

                    b.Property<int>("wSHOTabOrder");

                    b.HasKey("WSHeaderObjectID");

                    b.HasIndex("WSHOWorkStepID");

                    b.ToTable("WSHeaderObjects");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("test.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("test.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("test.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("test.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("test.Models.ApprovalStep", b =>
                {
                    b.HasOne("test.Models.WorkStep", "WorkStep")
                        .WithMany("ApprovalSteps")
                        .HasForeignKey("WorkStepID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("test.Models.Department", b =>
                {
                    b.HasOne("test.Models.Institution", "Institution")
                        .WithMany("Departments")
                        .HasForeignKey("InstitutionID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("test.Models.Process", b =>
                {
                    b.HasOne("test.Models.Department", "ProcessDepartment")
                        .WithMany("Processes")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("test.Models.WorkStep", b =>
                {
                    b.HasOne("test.Models.Process", "WorkStepProcess")
                        .WithMany("ProcessSteps")
                        .HasForeignKey("ProcessID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("test.Models.WSDetailView", b =>
                {
                    b.HasOne("test.Models.WorkStep", "WSDVWorkStep")
                        .WithMany("WSDetailViews")
                        .HasForeignKey("WSDVWorkStepID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("test.Models.WSDVDetailObject", b =>
                {
                    b.HasOne("test.Models.WSDetailView", "DVDODetailView")
                        .WithMany("WSDVDetailObjects")
                        .HasForeignKey("DVDODetailViewID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("test.Models.WSHeaderObject", b =>
                {
                    b.HasOne("test.Models.WorkStep", "WSHOWorkStep")
                        .WithMany("WSHeaderObjects")
                        .HasForeignKey("WSHOWorkStepID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
