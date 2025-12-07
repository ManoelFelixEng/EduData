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
    public class EnrollmentMap : IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {
            builder.ToTable("enrolment");
            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Id_Student).HasColumnName("id_student").IsRequired();
            builder.Property(prop => prop.Id_Class).HasColumnName("id_class").IsRequired();
            builder.Property(prop => prop.Id_College_Subject).HasColumnName("id_college_subject").IsRequired();

            builder.Property(e => e.Final_Score).HasColumnName("final_score").IsRequired();
        }
    }
}

