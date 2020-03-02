using Library.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Data.Configuration
{
    internal class SeriesConfiguration : IEntityTypeConfiguration<Series>
    {
        public void Configure(EntityTypeBuilder<Series> builder)
        {
            builder.ToTable("dc_Series");

            builder.Property(e => e.Id)
                .HasColumnName("ID");

            builder.Property(e => e.Name)
                .HasColumnName("Name")
                .IsRequired();

            builder.Property(e => e.AmountOfBooks)
                .HasColumnName("Books_In_Series")
                .IsRequired();
        }
    }
}
