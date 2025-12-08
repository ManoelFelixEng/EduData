using EduData.Domain.Base;
using EduData.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduData.Domain.Entities
{
    public class Enrollment : BaseEntity<int>
    {
        public Enrollment()
        {
        }

        public Enrollment(int id, Student student, Class @class, CollegeSubject collegeSubject, int finalScore) : base(id)
        {
            Student = student;
            Class = @class;
            CollegeSubject = collegeSubject;
            FinalScore = finalScore;
        }

        public int FinalScore { get; set; }

        // Propriedades de Navegação
        public Student Student { get; set; }
        public Class Class { get; set; }
        public CollegeSubject CollegeSubject { get; set; }
    }
}