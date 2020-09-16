﻿// <auto-generated />
using System;
using CreditCardEligibilityCheckerAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CreditCardEligibilityCheckerAPI.Migrations
{
    [DbContext(typeof(CardDataContext))]
    [Migration("20200711214520_PromotionalMessage")]
    partial class PromotionalMessage
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CreditCardEligibilityCheckerAPI.Models.Audit", b =>
                {
                    b.Property<int>("AuditId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnnualIncome")
                        .HasColumnType("int");

                    b.Property<string>("CardId")
                        .HasColumnType("varchar(3)");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("Datetime2");

                    b.Property<string>("DOB")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(16)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(16)");

                    b.HasKey("AuditId");

                    b.HasIndex("CardId");

                    b.ToTable("CreditCardAudit");

                    b.HasData(
                        new
                        {
                            AuditId = 1,
                            AnnualIncome = 30000,
                            CardId = "BAR",
                            CreatedDateTime = new DateTime(2020, 7, 11, 21, 45, 20, 82, DateTimeKind.Utc).AddTicks(9370),
                            DOB = "01-01-2010",
                            Email = "JoneBoll@gmail.com",
                            FirstName = "Jone",
                            LastName = "Boll"
                        });
                });

            modelBuilder.Entity("CreditCardEligibilityCheckerAPI.Models.CreditCardType", b =>
                {
                    b.Property<string>("CardId")
                        .HasColumnType("varchar(3)");

                    b.Property<decimal>("APR")
                        .HasColumnType("decimal(4,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(16)");

                    b.Property<string>("PromotionalMessage")
                        .IsRequired()
                        .HasColumnType("varchar(800)");

                    b.HasKey("CardId");

                    b.ToTable("CreditCardType");

                    b.HasData(
                        new
                        {
                            CardId = "BAR",
                            APR = 33.9m,
                            Name = "Barclays",
                            PromotionalMessage = "0.25% cashback on all your spend.No fees abroad – you’ll be able to withdraw cash from an ATM or buy your souvenirs without any charges and benefit from Visa’s competitive exchange rate"
                        },
                        new
                        {
                            CardId = "VAN",
                            APR = 39.9m,
                            Name = "Vanquis",
                            PromotionalMessage = "Great for credit building. Opening credit limit of £150 - £1,000.Increase your credit limit after the fifth statement,subject to eligibility.Manage your spending online or via the Vanquis app.Quick and easy eligibility check that won’t affect your credit score"
                        });
                });

            modelBuilder.Entity("CreditCardEligibilityCheckerAPI.Models.Audit", b =>
                {
                    b.HasOne("CreditCardEligibilityCheckerAPI.Models.CreditCardType", "CardType")
                        .WithMany()
                        .HasForeignKey("CardId");
                });
#pragma warning restore 612, 618
        }
    }
}
