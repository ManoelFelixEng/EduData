namespace EduData.App.ViewModel
{
    public class EnrollmentViewModel
    {
        public int Id { get; set; }
        public int FinalScore { get; set; }

        
        public int StudentId { get; set; }
        public int ClassId { get; set; }
        public int CollegeSubjectId { get; set; }

        
        public string StudentName { get; set; }
        public string ClassCourse { get; set; }
        public string CollegeSubjectName { get; set; }
    }
}