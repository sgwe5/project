using filmLib;
using FlmLib.DataAcces.etites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace FlmLib.DataAcces.config
{
    public class Filmcfg : IEntityTypeConfiguration<FilmEntity>
    {
        public void Configure(EntityTypeBuilder<FilmEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(b => b.Name)
                   .HasMaxLength(Film.MAX_LENGTH)
            .IsRequired();

            builder.Property(b => b.Genre)
                   .HasMaxLength(Film.MAX_LENGTH)
            .IsRequired();

            builder.Property(b => b.Year)
            .IsRequired();
        }
    }
}
