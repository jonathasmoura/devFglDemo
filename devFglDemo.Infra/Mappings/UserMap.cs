using System;
using devFglDemo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace devDemo.Infra.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            Ignores(builder);
            Properties(builder);
            Relationship(builder);
            builder.ToTable(nameof(User));
        }


        private void Properties(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(entity => entity.Id);
            builder.Property(entity => entity.Id)
            .HasColumnName(nameof(User.Id))
            .IsRequired();

            builder.Property(entity => entity.IsActive)
            .HasColumnName(nameof(User.IsActive))
            .IsRequired()
            .HasDefaultValue(true);

            builder.Property(entity => entity.Name)
            .HasColumnName(nameof(User.Name))
            .IsRequired();

            builder.Property(entity => entity.Email)
            .HasColumnName(nameof(User.Email))
            .IsRequired();

            builder.Property(entity => entity.Gender)
            .HasColumnName(nameof(User.Gender))
            .IsRequired();

            builder.Property(entity => entity.ActivationDate)
            .HasColumnName(nameof(User.ActivationDate))
            .IsRequired(false)
            .HasDefaultValue(DateTime.UtcNow);

            builder.Property(entity => entity.Created)
            .HasColumnName(nameof(User.Created))
            .IsRequired()
            .HasDefaultValue(DateTime.UtcNow);
        }
        private void Ignores(EntityTypeBuilder<User> builder)
        {
            builder.Ignore(entity => entity.Valid);
        }

        private void Relationship(EntityTypeBuilder<User> builder)
        {
        }
    }
}
