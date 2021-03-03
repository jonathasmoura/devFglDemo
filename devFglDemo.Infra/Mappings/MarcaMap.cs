using System;
using devFglDemo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace devDemo.Infra.Mappings
{
    public class MarcaMap : IEntityTypeConfiguration<Marca>
    {
        public void Configure(EntityTypeBuilder<Marca> builder)
        {
            Ignores(builder);
            Properties(builder);
            Relationship(builder);
            builder.ToTable(nameof(Marca));
        }


        private void Properties(EntityTypeBuilder<Marca> builder)
        {
            builder.HasKey(entity => entity.Id);
            builder.Property(entity => entity.Id)
            .HasColumnName(nameof(Marca.Id))
            .IsRequired();

            builder.Property(entity => entity.IsActive)
            .HasColumnName(nameof(Marca.IsActive))
            .IsRequired()
            .HasDefaultValue(true);

            builder.Property(entity => entity.Name)
            .HasColumnName(nameof(Marca.Name))
            .IsRequired();

            builder.Property(entity => entity.Description)
            .HasColumnName(nameof(Marca.Description))
            .IsRequired();        

            builder.Property(entity => entity.ActivationDate)
            .HasColumnName(nameof(Marca.ActivationDate))
            .IsRequired(false)
            .HasDefaultValue(DateTime.UtcNow);

            builder.Property(entity => entity.Created)
            .HasColumnName(nameof(Marca.Created))
            .IsRequired()
            .HasDefaultValue(DateTime.UtcNow);
        }
        private void Ignores(EntityTypeBuilder<Marca> builder)
        {
            builder.Ignore(entity => entity.Valid);
        }

        private void Relationship(EntityTypeBuilder<Marca> builder)
        {
        }
    }
}
