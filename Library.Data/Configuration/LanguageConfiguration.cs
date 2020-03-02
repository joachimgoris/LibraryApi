using Library.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Data.Configuration
{
    internal class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.ToTable("dc_Languages");

            builder.Property(e => e.Id)
                .HasColumnName("ID");

            builder.Property(e => e.Value)
                .HasColumnName("Language")
                .IsRequired();

            builder.HasData(new Language
            {
                Value = "DUTCH"
            },
            new Language
            {

                Value = "ENGLISH"
            },
            new Language
            {
                Value = "FRENCH"
            },
            new Language
            {
                Value = "GERMAN"
            });
        }
    }
}
