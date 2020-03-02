using Library.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Data.Configuration
{
    internal class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("dc_Books");

            builder.Property(e => e.Id).HasColumnName("ID");

            builder.Property(e => e.ISBN).HasColumnName("ISBN")
                .HasMaxLength(13)
                .IsUnicode(false)
                .IsRequired();

            builder.Property(e => e.Title)
                .HasColumnName("Title")
                .IsRequired();

            builder.Property(e => e.ReleaseDate)
                .HasColumnType("datetime");

            builder.Property(e => e.PageCount)
                .HasColumnName("Page_Count");

            builder.Property(e => e.Price)
                .HasColumnName("Price");

            builder.HasOne(e => e.Language);

            builder.HasOne(e => e.Author)
                .WithMany(a => a.Books)
                .HasForeignKey(e => e.AuthorId);

            builder.HasOne(e => e.Series)
                .WithMany(s => s.Books)
                .HasForeignKey(e => e.SeriesId);

            builder.HasOne(e => e.Genre)
                .WithMany(g => g.Books)
                .HasForeignKey(e => e.GenreId);
        }
    }
}
