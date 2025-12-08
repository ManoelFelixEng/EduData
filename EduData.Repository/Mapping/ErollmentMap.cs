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
            builder.Property(prop => prop.Id).HasColumnName("id_enrolment"); 

            builder.Property(e => e.FinalScore).HasColumnName("final_score").IsRequired();

            // Relacionamentos
            builder.HasOne(prop => prop.Student).WithMany().HasForeignKey("id_student");

            builder.HasOne(prop => prop.Class).WithMany().HasForeignKey("id_class");

            builder.HasOne(prop => prop.CollegeSubject).WithMany().HasForeignKey("id_college_subject");
        }
    }
}

