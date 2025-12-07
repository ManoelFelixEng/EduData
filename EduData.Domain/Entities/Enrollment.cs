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
        public Enrollment(int id, int id_student, int id_class, int id_collegeSubject, int finalScore) : base(id)
        {
            Id_Student = id_student;
            Id_Class = id_class;
            Id_College_Subject = id_collegeSubject;
            Final_Score = finalScore;
        }
        public int Final_Score { get; set; }
            
        //chave estrangeira
        public int Id_Student { get; set; }
        public int Id_Class { get; set; }
        public int Id_College_Subject { get; set; }
  
    }
}


