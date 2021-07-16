﻿// <auto-generated />
using System;
using CleanArchitecture.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CleanArchitecture.Infra.Data.Migrations
{
    [DbContext(typeof(LibraryDbContext))]
    [Migration("20210716170533_Validation")]
    partial class Validation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Models.ContactInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ContactInformation");
                });

            modelBuilder.Entity("Domain.Models.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("BornDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ContactFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContactInformationId")
                        .HasColumnType("int");

                    b.Property<string>("ContactLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstNameGeorgian")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstNameLatin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdentityNumber")
                        .HasColumnType("int");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondNameGeorgian")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondNameLatin")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContactInformationId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("Domain.Models.Person", b =>
                {
                    b.HasOne("Domain.Models.ContactInformation", "ContactInformation")
                        .WithMany("Persons")
                        .HasForeignKey("ContactInformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ContactInformation");
                });

            modelBuilder.Entity("Domain.Models.ContactInformation", b =>
                {
                    b.Navigation("Persons");
                });
#pragma warning restore 612, 618
        }
    }
}
