﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.Persistence.Configurations
{
    public class BookConfigurations : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(300).IsRequired();
            builder.Property(x => x.Title).HasMaxLength(500).IsRequired();
            builder.Property(x => x.Author).HasMaxLength(500).IsRequired();
            builder.Property(x => x.Comments).HasMaxLength(500).IsRequired(false);
        }
    }
}
