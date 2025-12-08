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

            builder.Property(prop => prop.Id).HasColumnName("id_evaluation");
            builder.Property(prop => prop.NameEvaluation).HasColumnName("name_evaluation").HasMaxLength(100).IsRequired();
            builder.Property(prop => prop.DateEvaluation).HasColumnName("date_evaluation").HasColumnType("DATE").IsRequired();
            builder.Property(prop => prop.ScoreValue).HasColumnName("score_value").IsRequired();

           
            // id_enrollment para ligar as tabelas
            builder.HasOne(prop => prop.Enrollment).WithMany().HasForeignKey("id_enrollment");

        }
    }
}






