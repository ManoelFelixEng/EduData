using System;

namespace EduData.App.ViewModel
{
    public class EvaluationViewModel
    {
        
        public int Id { get; set; }
        public string Name_Evaluation { get; set; }
        public DateTime Date_Evaluation { get; set; }
        public int Score_Value { get; set; }

        // chaves estrangeiras
        public int Id_student { get; set; }
        public int Id_class { get; set; }
        public int Id_college_subject { get; set; }
        public int IdEnrollment { get; set; }

        /
        public string StudentName { get; set; } // Para mostrar "João" em vez de ID 15
        public string SubjectName { get; set; } // Para mostrar "Matemática"
        public string ClassName { get; set; }   // Para mostrar "Turma A"
    }
}