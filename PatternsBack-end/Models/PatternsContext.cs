using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PatternsBack_end.Models;

public partial class PatternsContext : DbContext
{
    public PatternsContext()
    {
    }

    public PatternsContext(DbContextOptions<PatternsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DescriptionLab> DescriptionLabs { get; set; }

    public virtual DbSet<Lab> Labs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; Database=Patterns; Trusted_Connection=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DescriptionLab>(entity =>
        {
            entity.HasKey(e => e.DescriptionLabsId);

            entity.Property(e => e.DescriptionLabsId).HasColumnName("DescriptionLabsID");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.LabDescription)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.LabLink)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.LabName)
                .HasMaxLength(256)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Lab>(entity =>
        {
            entity.HasKey(e => e.LabId).HasName("PK_LabList");

            entity.ToTable("Lab");

            entity.Property(e => e.LabIcon)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.LabLink)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.LabName)
                .HasMaxLength(256)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
