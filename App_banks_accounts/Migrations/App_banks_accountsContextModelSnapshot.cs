﻿// <auto-generated />
using App_banks_accounts.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace App_banks_accounts.Migrations
{
    [DbContext(typeof(App_banks_accountsContext))]
    partial class App_banks_accountsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("App_banks_accounts.Models.AccountHolder", b =>
                {
                    b.Property<int>("AccountHolderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountHolderId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountHolderId");

                    b.ToTable("AccountHolder");
                });

            modelBuilder.Entity("App_banks_accounts.Models.BankAccount", b =>
                {
                    b.Property<int>("BankAccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BankAccountId"));

                    b.Property<int>("AccountHolderId")
                        .HasColumnType("int");

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("BankAccountId");

                    b.HasIndex("AccountHolderId");

                    b.ToTable("BankAccount");
                });

            modelBuilder.Entity("App_banks_accounts.Models.BankAccount", b =>
                {
                    b.HasOne("App_banks_accounts.Models.AccountHolder", "AccountHolder")
                        .WithMany("BankAccounts")
                        .HasForeignKey("AccountHolderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccountHolder");
                });

            modelBuilder.Entity("App_banks_accounts.Models.AccountHolder", b =>
                {
                    b.Navigation("BankAccounts");
                });
#pragma warning restore 612, 618
        }
    }
}
