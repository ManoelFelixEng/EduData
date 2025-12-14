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
    public class StudentMap : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("student");
            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Id).HasColumnName("id_student").ValueGeneratedOnAdd(); ;
            builder.Property(prop => prop.Name).HasColumnName("name").HasMaxLength(100).IsRequired();
            builder.Property(prop => prop.DateBirth).HasColumnName("date_birth").HasColumnType("DATE").IsRequired();


            builder.HasOne(prop => prop.Class).WithMany().HasForeignKey("id_class");

        }

    }
}