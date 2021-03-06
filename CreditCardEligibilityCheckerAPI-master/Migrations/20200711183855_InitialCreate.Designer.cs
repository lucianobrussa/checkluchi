﻿// <auto-generated />
using CreditCardEligibilityCheckerAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CreditCardEligibilityCheckerAPI.Migrations
{
    [DbContext(typeof(CardDataContext))]
    [Migration("20200711183855_InitialCreate")]
    partial class InitialCreate
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

                    b.Property<string>("CardId")
                        .HasColumnType("varchar(3)");

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
                            CardId = "BAR",
                            DOB = "01-01-2010",
                            Email = "vidyarao.malka@gmail.com",
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
                        .HasColumnType("varchar(16)");

                    b.HasKey("CardId");

                    b.ToTable("CreditCardType");

                    b.HasData(
                        new
                        {
                            CardId = "BAR",
                            APR = 33.9m,
                            Name = "Barclays",
                            PromotionalMessage = "abcd"
                        },
                        new
                        {
                            CardId = "VAN",
                            APR = 36.2m,
                            Name = "Vanquis",
                            PromotionalMessage = "abcd"
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
