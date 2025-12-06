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
    public class College_SubjectMap : IEntityTypeConfiguration<College_Subject>
    {
        public void Configure(EntityTypeBuilder<College_Subject> builder)
        {
            builder.ToTable("college_subject");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Id).HasColumnName("id_college_subject").IsRequired();
            builder.Property(prop => prop.Name).HasColumnName("name").HasMaxLength(100).IsRequired();
            builder.Property(prop => prop.Courseload).HasColumnName("courseload").IsRequired();
        }

    }
}
