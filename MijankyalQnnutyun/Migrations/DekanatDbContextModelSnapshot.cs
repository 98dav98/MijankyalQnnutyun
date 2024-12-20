﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MijankyalQnnutyun.Models;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MijankyalQnnutyun.Migrations
{
    [DbContext(typeof(DekanatDbContext))]
    partial class DekanatDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MijankyalQnnutyun.Models.Faculty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Id"));

                    b.Property<char?>("Dekan")
                        .HasColumnType("char");

                    b.Property<int?>("LearningId")
                        .HasColumnType("integer");

                    b.Property<char?>("Name")
                        .HasColumnType("char");

                    b.Property<int?>("NumberOfSeats")
                        .HasColumnType("integer");

                    b.HasKey("Id")
                        .HasName("Faculty_pkey");

                    b.HasIndex("LearningId");

                    b.ToTable("Faculty", (string)null);
                });

            modelBuilder.Entity("MijankyalQnnutyun.Models.Learning", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Id"));

                    b.Property<char?>("Group")
                        .HasColumnType("char");

                    b.Property<int?>("ScholarshipAmount")
                        .HasColumnType("integer");

                    b.Property<char?>("Speciality")
                        .HasColumnType("char");

                    b.Property<int?>("Year")
                        .HasColumnType("integer");

                    b.HasKey("Id")
                        .HasName("Learning_pkey");

                    b.ToTable("Learning", (string)null);
                });

            modelBuilder.Entity("MijankyalQnnutyun.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Id"));

                    b.Property<char?>("City")
                        .HasColumnType("char");

                    b.Property<DateOnly?>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<int?>("LearningId")
                        .HasColumnType("integer");

                    b.Property<char?>("Nsf")
                        .HasColumnType("char")
                        .HasColumnName("NSF");

                    b.Property<DateOnly?>("YearOfEnrollment")
                        .HasColumnType("date");

                    b.HasKey("Id")
                        .HasName("Students_pkey");

                    b.HasIndex("LearningId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("MijankyalQnnutyun.Models.Faculty", b =>
                {
                    b.HasOne("MijankyalQnnutyun.Models.Learning", "Learning")
                        .WithMany("Faculties")
                        .HasForeignKey("LearningId")
                        .HasConstraintName("LearningId");

                    b.Navigation("Learning");
                });

            modelBuilder.Entity("MijankyalQnnutyun.Models.Student", b =>
                {
                    b.HasOne("MijankyalQnnutyun.Models.Learning", "Learning")
                        .WithMany("Students")
                        .HasForeignKey("LearningId")
                        .HasConstraintName("LearningId");

                    b.Navigation("Learning");
                });

            modelBuilder.Entity("MijankyalQnnutyun.Models.Learning", b =>
                {
                    b.Navigation("Faculties");

                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
