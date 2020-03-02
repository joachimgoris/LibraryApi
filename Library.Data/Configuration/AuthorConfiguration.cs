using Library.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Data.Configuration
{
    internal class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("db_Authors");

            builder.Property(e => e.Id)
                .HasColumnName("ID");

            builder.Property(e => e.FirstName)
                .HasColumnName("First_Name");

            builder.Property(e => e.LastName)
                .HasColumnName("Last_Name");

            builder.Property(e => e.Email)
                .HasColumnName("Email");

            builder.Property(e => e.Phone)
                .HasColumnName("Phone")
                .HasMaxLength(15);

            builder.Property(e => e.BirthDate)
                .HasColumnName("Date_Of_Birth")
                .HasColumnType("datetime");

            builder.Property(e => e.DeathDate)
                .HasColumnName("Date_Of_Death")
                .HasColumnType("datetime");
        }
    }
}
