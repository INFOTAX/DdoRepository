﻿// <auto-generated />
using DDO.Domain.Enums;
using DDO.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DDO.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DDO.Domain.Accounting.AccountingUnit", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<int>("AdminId");

                    b.Property<string>("AuthorizedRepresentativeName");

                    b.Property<string>("BankAccountName");

                    b.Property<string>("BankAccountNumber");

                    b.Property<string>("BusinessName");

                    b.Property<string>("Contact");

                    b.Property<string>("ContactNumber");

                    b.Property<string>("CurrentGrossTurnOver");

                    b.Property<string>("Email");

                    b.Property<string>("Gstin");

                    b.Property<string>("GstinPassword");

                    b.Property<string>("IfscCode");

                    b.Property<string>("ImgUrl");

                    b.Property<string>("LastGrossTurnOver");

                    b.Property<string>("Name");

                    b.Property<string>("Pan");

                    b.Property<string>("PlaceOfSupply");

                    b.Property<string>("RegistrationType");

                    b.Property<string>("Role");

                    b.Property<int>("SelectedYear");

                    b.Property<string>("Subject");

                    b.Property<string>("TdsGstin");

                    b.Property<string>("TermsAndCondition");

                    b.Property<string>("TurnOver");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.ToTable("AccountingUnits");
                });

            modelBuilder.Entity("DDO.Domain.AdminModule.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("DDO.Domain.SupplierModule.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccountingUnitId");

                    b.Property<string>("Address");

                    b.Property<int>("AdminId");

                    b.Property<string>("ContactNumber");

                    b.Property<string>("Email");

                    b.Property<string>("Gstin");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name");

                    b.Property<int>("RegistrationType");

                    b.Property<string>("State");

                    b.HasKey("Id");

                    b.HasIndex("AccountingUnitId");

                    b.HasIndex("AdminId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("DDO.Domain.TdsModule.Tds", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccountingUnitId");

                    b.Property<int>("AdminId");

                    b.Property<double>("AmountPaid");

                    b.Property<double>("CgstAmount");

                    b.Property<DateTime>("Date");

                    b.Property<double>("IgstAmount");

                    b.Property<bool>("IsActive");

                    b.Property<double>("NetAmount");

                    b.Property<string>("PlaceOfSupply");

                    b.Property<double>("SgstAmount");

                    b.Property<int>("SupplierId");

                    b.Property<double>("TdsAmount");

                    b.HasKey("Id");

                    b.HasIndex("AccountingUnitId");

                    b.HasIndex("AdminId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Tdss");
                });

            modelBuilder.Entity("DDO.Domain.Accounting.AccountingUnit", b =>
                {
                    b.HasOne("DDO.Domain.AdminModule.Admin", "Admin")
                        .WithMany("AccountingUnits")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DDO.Domain.SupplierModule.Supplier", b =>
                {
                    b.HasOne("DDO.Domain.Accounting.AccountingUnit", "AccountingUnit")
                        .WithMany("Suppliers")
                        .HasForeignKey("AccountingUnitId");

                    b.HasOne("DDO.Domain.AdminModule.Admin", "Admin")
                        .WithMany("Suppliers")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DDO.Domain.TdsModule.Tds", b =>
                {
                    b.HasOne("DDO.Domain.Accounting.AccountingUnit", "AccountingUnit")
                        .WithMany()
                        .HasForeignKey("AccountingUnitId");

                    b.HasOne("DDO.Domain.AdminModule.Admin", "Admin")
                        .WithMany("Tdss")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DDO.Domain.SupplierModule.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
