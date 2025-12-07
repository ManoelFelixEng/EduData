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
    public class ClassMap : IEntityTypeConfiguration<Class> 
    {
        public void Configure(EntityTypeBuilder<Class> builder) 
        {
            builder.ToTable("class");
            builder.HasKey(c => c.Id);
            builder.Property(prop => prop.Id).HasColumnName("id_class").IsRequired();
            builder.Property(prop => prop.Period).HasColumnName("period").IsRequired();
            builder.Property(prop => prop.Course).HasColumnName("course").HasMaxLength(100).IsRequired();
            builder.Property(prop => prop.Number_Students).HasColumnName("number_students").IsRequired();

        }



    }
}



