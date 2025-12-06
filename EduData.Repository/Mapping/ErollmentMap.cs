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
            builder.HasKey(prop => new { prop.Id_student, prop.Id_class, prop.Id_college_subject });

            builder.Property(prop => prop.Id_student).HasColumnName("id_student").IsRequired();
            builder.Property(prop => prop.Id_class).HasColumnName("id_class").IsRequired();
            builder.Property(prop => prop.Id_college_subject).HasColumnName("id_college_subject").IsRequired();

            builder.Property(e => e.Final_score).HasColumnName("final_score").IsRequired();
        }
    }
}



