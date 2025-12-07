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
        public Enrollment(int idStudent, int idClass, int idCollegeSubject, int finalScore)
        {
            Id_student = idStudent;
            Id_class = idClass;
            Id_college_subject = idCollegeSubject;
            Final_score = finalScore;
        }
        public int Final_score { get; set; }

        //chave estrangeira
        public int Id_student { get; set; }
        public int Id_class { get; set; }
        public int Id_college_subject { get; set; }
  
    }
}



