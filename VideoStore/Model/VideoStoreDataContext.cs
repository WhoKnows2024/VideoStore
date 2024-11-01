using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;

namespace VideoStore.Model
{
    public partial class VideoStoreDataContext : DbContext
    {
        public VideoStoreDataContext()
        {
        }

        public VideoStoreDataContext(DbContextOptions<VideoStoreDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Genre> Genres { get; set; } = null!;
        public virtual DbSet<Rating> Ratings { get; set; } = null!;
        public virtual DbSet<Video> Videos { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Genre");

                entity.Property(e => e.GenreDescription)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.GenreName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GenreaStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Rating>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Rating");

                entity.Property(e => e.RatingCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RatingDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RatingStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Video>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Actor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("Notes.");

                entity.Property(e => e.ReleaseYear).HasColumnType("date");

                entity.Property(e => e.VideoId).ValueGeneratedOnAdd();

                entity.Property(e => e.VideoName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
