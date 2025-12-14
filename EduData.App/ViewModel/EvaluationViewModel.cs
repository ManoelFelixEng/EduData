using System;

namespace EduData.App.ViewModel
{
    public class EvaluationViewModel
    {

        public int Id { get; set; }
        public string NameEvaluation { get; set; }
        public DateTime DateEvaluation { get; set; }
        public int ScoreValue { get; set; }

       
        public int EnrollmentId { get; set; }


    }
}