using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MvcCv.Models.Entity;

namespace MvcCv.Models;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblAdmin> TblAdmin { get; set; }

    public virtual DbSet<TblDeneyimlerim> TblDeneyimlerim { get; set; }

    public virtual DbSet<TblEgitimlerim> TblEgitimlerim { get; set; }

    public virtual DbSet<TblHakkimda> TblHakkimda { get; set; }

    public virtual DbSet<TblHobilerim> TblHobilerim { get; set; }

    public virtual DbSet<TblSertifikalarim> TblSertifikalarim { get; set; }

    public virtual DbSet<TblSosyalMedya> TblSosyalMedya { get; set; }

    public virtual DbSet<TblYeteneklerim> TblYeteneklerim { get; set; }

    public virtual DbSet<Tbliletisim> Tbliletisim { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblAdmin>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.KullaniciAdi)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Sifre)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblDeneyimlerim>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama).IsUnicode(false);
            entity.Property(e => e.AltBaslik)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Baslik)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Tarih)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblEgitimlerim>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AltBaslik2)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Altaslik1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Baslik)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Gno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("GNO");
            entity.Property(e => e.Tarih)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblHakkimda>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Adres)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Açıklama).IsUnicode(false);
            entity.Property(e => e.Mail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Resim)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Soyad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telefon)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblHobilerim>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama1)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Aciklama2)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblSertifikalarim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TblSertifikalarım");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Tarih)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblSosyalMedya>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TblSosya__3214EC27D3AA96F5");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ad)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Link)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblYeteneklerim>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Yetenek)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Tbliletisim>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AdSoyad)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Konu)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Mail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mesaj)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
