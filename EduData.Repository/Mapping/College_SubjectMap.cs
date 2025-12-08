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
    public class College_SubjectMap : IEntityTypeConfiguration<CollegeSubject>
    {
        public void Configure(EntityTypeBuilder<CollegeSubject> builder)
        {
            builder.ToTable("college_subject");
            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Id).HasColumnName("id_college_subject");
            builder.Property(prop => prop.Name).HasColumnName("name").HasMaxLength(100).IsRequired();
            builder.Property(prop => prop.CourseLoad).HasColumnName("courseload").IsRequired();
        }

    }
}
