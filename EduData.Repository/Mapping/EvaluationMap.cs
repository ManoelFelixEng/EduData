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
    public class EvaluationMap : IEntityTypeConfiguration<Evaluation>
    {
        public void Configure(EntityTypeBuilder<Evaluation> builder)
        {
            builder.ToTable("evaluation");
            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Id).HasColumnName("id_evaluation").IsRequired();

            builder.Property(prop => prop.Name_Evaluation).HasColumnName("name_evaluation").HasMaxLength(100).IsRequired();

            builder.Property(prop => prop.Date_Evaluation).HasColumnName("date_evaluation").HasColumnType("DATE").IsRequired();

            builder.Property(prop => prop.Score_Value).HasColumnName("score_value").IsRequired();

            builder.Property(prop => prop.IdEnrollment) .HasColumnName("id_enrollment").IsRequired();

            //estrangeiras
            builder.Property(prop => prop.Id_student).HasColumnName("enrolment_student_id_student").IsRequired();
            builder.Property(prop => prop.Id_class).HasColumnName("enrolment_student_id_class").IsRequired();
            builder.Property(prop => prop.Id_college_subject).HasColumnName("enrolment_college_subject_id_college_subject").IsRequired();

        }
    }
}






