﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SJTech.Core.Models
{
    public class AdminUserInfoConfigurationMapping : IEntityTypeConfiguration<AdminUserInfo>
    {
        public void Configure(EntityTypeBuilder<AdminUserInfo> builder)
        {
            builder.Property(e => e.AddTime).HasColumnType("datetime").IsRequired();

            builder.Property(e => e.LastLoginIp)
                .HasColumnName("LastLoginIP")
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.LastLoginTime).HasColumnType("datetime");

            builder.Property(e => e.Password).HasMaxLength(50);

            builder.Property(e => e.PasswordSalt)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.RealName).HasMaxLength(50);

            builder.Property(e => e.ThisLoginIp)
                .HasColumnName("ThisLoginIP")
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.ThisLoginTime).HasColumnType("datetime");

            builder.Property(e => e.UserName).HasMaxLength(50);
        }
    }
}
