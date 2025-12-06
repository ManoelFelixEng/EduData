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

            builder.Property(prop => prop.Name_evaluation).HasColumnName("name_evaluation").HasMaxLength(100).IsRequired();

            builder.Property(prop => prop.Date_evaluation).HasColumnName("date_evaluation").HasColumnType("DATE").IsRequired();

            builder.Property(prop => prop.Score_value).HasColumnName("score_value").IsRequired();

            //estrangeiras
            builder.Property(prop => prop.Id_student).HasColumnName("enrolment_student_id_student").IsRequired();
            builder.Property(prop => prop.Id_class).HasColumnName("enrolment_student_id_class").IsRequired();
            builder.Property(prop => prop.Id_college_subject).HasColumnName("enrolment_college_subject_id_college_subject").IsRequired();

        }
    }
}



        // **NOTA**: A configuração do relacionamento entre Evaluation e Enrollment, 
        // que usa esta FK composta, é mais facilmente feita no DbContext 
        // quando as propriedades de navegação estão ausentes do modelo.
 