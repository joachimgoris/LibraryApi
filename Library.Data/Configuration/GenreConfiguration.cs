using Library.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Data.Configuration
{
    internal class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.ToTable("dc_Genres");

            builder.Property(e => e.Id)
                .HasColumnName("ID");

            builder.Property(e => e.Title)
                .HasColumnName("Title")
                .IsRequired();
        }
    }
}
