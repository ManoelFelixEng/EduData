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
        public Evaluation(int id, string name_evaluation, DateTime date_evaluation, int score_value, int id_student, int id_class, int id_collegesubject) : base(id)
        {
            Name_Evaluation = name_evaluation;
            Date_Evaluation = date_evaluation;
            Score_Value = score_value;

            Id_student = id_student;
            Id_class = id_class;
            Id_college_subject = id_collegesubject;
        }

        public string Name_Evaluation { get; set; }
        public DateTime Date_Evaluation { get; set; }
        public int Score_Value { get; set; }

        // chaves estrangeiras 
        public int Id_student { get; set; }
        public int Id_class { get; set; }
        public int Id_college_subject { get; set; }


        public int IdEnrollment { get; set; }



    }
}
