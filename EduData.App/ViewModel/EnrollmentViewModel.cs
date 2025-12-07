namespace EduData.App.ViewModel
{
    public class EnrollmentViewModel
    {
        // Propriedades da Entidade
        public int Final_score { get; set; }
        public int Id_student { get; set; }
        public int Id_class { get; set; }
        public int Id_college_subject { get; set; }

        // EXTRAS (Visualização na Grid)
        public string StudentName { get; set; }      // Nome do Aluno
        public string SubjectName { get; set; }      // Nome da Disciplina
        public string ClassName { get; set; }        // Nome da Turma
    }
}