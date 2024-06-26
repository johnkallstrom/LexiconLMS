﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LexiconLMS.Persistence.EntityConfigurations
{
    public class ActivityConfiguration : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.ToTable("Activities");
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Created).ValueGeneratedOnAdd();
            builder.Property(a => a.LastModified).ValueGeneratedOnUpdate();
        }
    }
}
