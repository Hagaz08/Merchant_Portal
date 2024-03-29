﻿// <auto-generated />
using System;
using Merchant_Portal.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Merchant_Portal.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240219143047_SeededUserId")]
    partial class SeededUserId
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Merchant_Portal.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<double>("AccountBalance")
                        .HasColumnType("float");

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TerminalId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("createdOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("updatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Merchant_Portal.Models.Card", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("appuserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("cardBalance")
                        .HasColumnType("float");

                    b.Property<string>("cardName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cardNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cardType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cardscheme")
                        .HasColumnType("int");

                    b.Property<int>("cardstatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("deletedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("expiryDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("updatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("appuserId");

                    b.ToTable("Cards");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            UserId = "4c4231f9-ccf8-47c1-9ce3-2da365fa19d7",
                            cardBalance = 128.44999999999999,
                            cardName = "Nosa Bless",
                            cardNumber = "77048390",
                            cardType = "physical",
                            cardscheme = 2,
                            cardstatus = 0,
                            createdAt = new DateTime(2024, 2, 19, 15, 30, 47, 129, DateTimeKind.Local).AddTicks(9880),
                            expiryDate = new DateTime(2028, 2, 19, 15, 30, 47, 129, DateTimeKind.Local).AddTicks(9908),
                            updatedAt = new DateTime(2024, 2, 19, 15, 30, 47, 129, DateTimeKind.Local).AddTicks(9899)
                        },
                        new
                        {
                            Id = "2",
                            UserId = "4c4231f9-ccf8-47c1-9ce3-2da365fa19d7",
                            cardBalance = 456.44999999999999,
                            cardName = "Eti Bless",
                            cardNumber = "77048380",
                            cardType = "Virtual",
                            cardscheme = 0,
                            cardstatus = 1,
                            createdAt = new DateTime(2024, 2, 19, 15, 30, 47, 129, DateTimeKind.Local).AddTicks(9923),
                            expiryDate = new DateTime(2028, 2, 19, 15, 30, 47, 129, DateTimeKind.Local).AddTicks(9926),
                            updatedAt = new DateTime(2024, 2, 19, 15, 30, 47, 129, DateTimeKind.Local).AddTicks(9924)
                        },
                        new
                        {
                            Id = "3",
                            UserId = "4c4231f9-ccf8-47c1-9ce3-2da365fa19d7",
                            cardBalance = 128.44999999999999,
                            cardName = "Chike Bless Bless",
                            cardNumber = "77048370",
                            cardType = "physical",
                            cardscheme = 1,
                            cardstatus = 2,
                            createdAt = new DateTime(2024, 2, 19, 15, 30, 47, 129, DateTimeKind.Local).AddTicks(9933),
                            expiryDate = new DateTime(2028, 2, 19, 15, 30, 47, 129, DateTimeKind.Local).AddTicks(9936),
                            updatedAt = new DateTime(2024, 2, 19, 15, 30, 47, 129, DateTimeKind.Local).AddTicks(9933)
                        },
                        new
                        {
                            Id = "4",
                            UserId = "4c4231f9-ccf8-47c1-9ce3-2da365fa19d7",
                            cardBalance = 128.44999999999999,
                            cardName = "Nosa Bless",
                            cardNumber = "77048360",
                            cardType = "physical",
                            cardscheme = 2,
                            cardstatus = 0,
                            createdAt = new DateTime(2024, 2, 19, 15, 30, 47, 129, DateTimeKind.Local).AddTicks(9957),
                            expiryDate = new DateTime(2028, 2, 19, 15, 30, 47, 129, DateTimeKind.Local).AddTicks(9960),
                            updatedAt = new DateTime(2024, 2, 19, 15, 30, 47, 129, DateTimeKind.Local).AddTicks(9957)
                        });
                });

            modelBuilder.Entity("Merchant_Portal.Models.Transaction", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AppUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cardId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("deletedAt")
                        .HasColumnType("datetime2");

                    b.Property<double>("transAmount")
                        .HasColumnType("float");

                    b.Property<string>("transReferenceNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("transactionType")
                        .HasColumnType("int");

                    b.Property<int>("transactionstatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("updatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("cardId");

                    b.ToTable("Transactions");

                    b.HasData(
                        new
                        {
                            Id = "479f9aa1-efb4-4c81-9797-708c1187d6db",
                            Description = "My_Funding",
                            UserId = "4c4231f9-ccf8-47c1-9ce3-2da365fa19d7",
                            cardId = "1",
                            createdAt = new DateTime(2024, 2, 19, 15, 30, 47, 130, DateTimeKind.Local).AddTicks(17),
                            transAmount = 5000.0,
                            transReferenceNumber = "Ref323112",
                            transactionType = 0,
                            transactionstatus = 0,
                            updatedAt = new DateTime(2024, 2, 19, 15, 30, 47, 130, DateTimeKind.Local).AddTicks(18)
                        },
                        new
                        {
                            Id = "410f1646-afdb-4d12-90f9-5a23a4bdc787",
                            Description = "My_Withdrawal",
                            UserId = "4c4231f9-ccf8-47c1-9ce3-2da365fa19d7",
                            cardId = "1",
                            createdAt = new DateTime(2024, 2, 19, 15, 30, 47, 130, DateTimeKind.Local).AddTicks(28),
                            transAmount = 3500.5599999999999,
                            transReferenceNumber = "Ref323113",
                            transactionType = 1,
                            transactionstatus = 1,
                            updatedAt = new DateTime(2024, 2, 19, 15, 30, 47, 130, DateTimeKind.Local).AddTicks(28)
                        },
                        new
                        {
                            Id = "30bd71dc-169c-40c0-bdd8-e7dbcf36ec64",
                            Description = "My_Funding",
                            UserId = "4c4231f9-ccf8-47c1-9ce3-2da365fa19d7",
                            cardId = "1",
                            createdAt = new DateTime(2024, 2, 19, 15, 30, 47, 130, DateTimeKind.Local).AddTicks(35),
                            transAmount = 1500.8699999999999,
                            transReferenceNumber = "Ref323114",
                            transactionType = 0,
                            transactionstatus = 0,
                            updatedAt = new DateTime(2024, 2, 19, 15, 30, 47, 130, DateTimeKind.Local).AddTicks(36)
                        },
                        new
                        {
                            Id = "08240136-f7d1-4a5e-8f53-29761217d4fd",
                            Description = "My_Withdrawal",
                            UserId = "4c4231f9-ccf8-47c1-9ce3-2da365fa19d7",
                            cardId = "2",
                            createdAt = new DateTime(2024, 2, 19, 15, 30, 47, 130, DateTimeKind.Local).AddTicks(42),
                            transAmount = 3500.4499999999998,
                            transReferenceNumber = "Ref323115",
                            transactionType = 1,
                            transactionstatus = 0,
                            updatedAt = new DateTime(2024, 2, 19, 15, 30, 47, 130, DateTimeKind.Local).AddTicks(42)
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2",
                            Name = "regular",
                            NormalizedName = "REGULAR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Merchant_Portal.Models.Card", b =>
                {
                    b.HasOne("Merchant_Portal.Models.AppUser", "appuser")
                        .WithMany()
                        .HasForeignKey("appuserId");

                    b.Navigation("appuser");
                });

            modelBuilder.Entity("Merchant_Portal.Models.Transaction", b =>
                {
                    b.HasOne("Merchant_Portal.Models.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId");

                    b.HasOne("Merchant_Portal.Models.Card", "card")
                        .WithMany("transactions")
                        .HasForeignKey("cardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("card");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Merchant_Portal.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Merchant_Portal.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Merchant_Portal.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Merchant_Portal.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Merchant_Portal.Models.Card", b =>
                {
                    b.Navigation("transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
