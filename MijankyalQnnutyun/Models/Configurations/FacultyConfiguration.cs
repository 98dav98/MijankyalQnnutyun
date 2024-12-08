﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MijankyalQnnutyun.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace MijankyalQnnutyun.Models.Configurations
{
    public partial class FacultyConfiguration : IEntityTypeConfiguration<Faculty>
    {
        public void Configure(EntityTypeBuilder<Faculty> entity)
        {
            entity.HasKey(e => e.Id).HasName("Faculty_pkey");

            entity.ToTable("Faculty");

            entity.Property(e => e.Id).UseIdentityAlwaysColumn();
            entity.Property(e => e.Dekan).HasColumnType("char");
            entity.Property(e => e.Name).HasColumnType("char");

            entity.HasOne(d => d.Learning).WithMany(p => p.Faculties)
                .HasForeignKey(d => d.LearningId)
                .HasConstraintName("LearningId");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Faculty> entity);
    }
}
