using Microsoft.EntityFrameworkCore;

namespace News.Models
{
    public partial class NewsContext : DbContext
    {
        public NewsContext()
        {
        }

        public NewsContext(DbContextOptions<NewsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAds> TblAds { get; set; }
        public virtual DbSet<TblCategory> TblCategory { get; set; }
        public virtual DbSet<TblNews> TblNews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblAds>(entity =>
            {
                entity.ToTable("tbl_ads");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Ads).HasColumnName("ads");
            });

            modelBuilder.Entity<TblCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_category");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.CategoryName)
                    .HasColumnName("category_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Keywords).HasColumnName("keywords");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.UrlFriendly)
                    .HasColumnName("url_friendly")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblNews>(entity =>
            {
                entity.HasKey(e => e.IdNews)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_news");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("category_id");

                entity.Property(e => e.IdNews)
                    .HasColumnName("id_news")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.DateNews).HasColumnName("date_news");

                entity.Property(e => e.DescriptionNews).HasColumnName("description_news");

                entity.Property(e => e.TitleNews).HasColumnName("title_news");

                entity.Property(e => e.UrlImg).HasColumnName("url_img");

                entity.Property(e => e.UrlFriendly)
                    .HasColumnName("url_friendly")
                    .HasMaxLength(200)
                    .IsUnicode(false);


                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TblNews)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("tbl_news_ibfk_1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
