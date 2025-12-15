using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EduData.Domain.Entities;
namespace EduData.Repository.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("user"); 
            builder.HasKey(prop => prop.Id);
            builder.HasIndex(prop => prop.Name).IsUnique();
            builder.Property(prop => prop.Id).HasColumnName("id_user");
            builder.Property(prop => prop.Name).HasColumnName("username").HasMaxLength(50).IsRequired();
            builder.Property(prop => prop.Password).HasColumnName("password").HasMaxLength(100).IsRequired();
            builder.Property(prop => prop.Role).HasColumnName("role").HasMaxLength(100).IsRequired();

        }

    }
}
