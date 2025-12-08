using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduData.Domain.Base;

namespace EduData.Domain.Entities
{
    public class Evaluation : BaseEntity<int>
    {
        public Evaluation() { }

        public Evaluation(int id, string nameEvaluation, DateTime dateEvaluation, int scoreValue, Enrollment enrollment) : base(id)
        {
            NameEvaluation = nameEvaluation;
            DateEvaluation = dateEvaluation;
            ScoreValue = scoreValue;
            Enrollment = enrollment;
        }

        public string NameEvaluation { get; set; }
        public DateTime DateEvaluation { get; set; }
        public int ScoreValue { get; set; }

        // Liga a avaliação à matrícula do aluno naquela matéria
        public Enrollment Enrollment { get; set; }
    }
}