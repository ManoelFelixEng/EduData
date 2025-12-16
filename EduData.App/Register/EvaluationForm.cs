using EduData.App.Base;
using EduData.App.ViewModel;
using EduData.Domain.Base;
using EduData.Domain.Entities;
using EduData.Service.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EduData.App.Register
{
    public partial class EvaluationForm : BaseForm
    {
        private readonly IBaseService<Evaluation> _evaluationService;
        private readonly IBaseService<Student> _studentService;
        private readonly IBaseService<Class> _classService;
        private readonly IBaseService<Enrollment> _enrollmentService;

        public EvaluationForm(
            IBaseService<Evaluation> evaluationService,
            IBaseService<Student> studentService,
            IBaseService<Class> classService,
            IBaseService<Enrollment> enrollmentService)
        {
            _evaluationService = evaluationService;
            _studentService = studentService;
            _classService = classService;
            _enrollmentService = enrollmentService;

            InitializeComponent();
            ConfigurarGrid();

            
            BoxClass.SelectedIndexChanged += new EventHandler(this.BoxClass_SelectedIndexChanged);
            BoxStudent.SelectedIndexChanged += new EventHandler(this.BoxStudent_SelectedIndexChanged);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CarregarTurmas();
            PopulateGrid();
        }

        private void ConfigurarGrid()
        {
            if (poisonListView1 != null)
            {
                poisonListView1.Columns.Clear();
                poisonListView1.View = View.Details;
                poisonListView1.GridLines = true;
                poisonListView1.FullRowSelect = true;

                // dark
                poisonListView1.OwnerDraw = false;
                poisonListView1.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;

                poisonListView1.Columns.Add("ID", 50);
                poisonListView1.Columns.Add("Name Rating", 200);
                poisonListView1.Columns.Add("ID enrollment", 100);
                poisonListView1.Columns.Add("Note", 80);
                poisonListView1.Columns.Add("Date", 100);
            }
        }


        private void AtualizarMediaFinal(int enrollmentId)
        {
            try
            {
                // as avaliações da disciplicna
                var avaliacoes = _evaluationService
                    .Get<Evaluation>(new List<string> { "Enrollment" })
                    .Where(e => e.Enrollment.Id == enrollmentId)
                    .ToList();

                // média (Arredondada)
                int media = avaliacoes.Any()
                    ? (int)Math.Round(avaliacoes.Average(e => e.ScoreValue))
                    : 0;

                // atualiza a matrícula
                var enrollment = _enrollmentService.GetById<Enrollment>(enrollmentId);

                if (enrollment != null)
                {
                    enrollment.FinalScore = media;
                    _enrollmentService.Update<Enrollment, Enrollment, EnrollmentValidator>(enrollment);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating final average:" + ex.Message);
            }
        }

       

        private void CarregarTurmas()
        {
            try
            {
                var classes = _classService.Get<ClassViewModel>().ToList();
                BoxClass.DataSource = classes;
                BoxClass.DisplayMember = "Course";
                BoxClass.ValueMember = "Id";
                BoxClass.SelectedIndex = -1;
            }
            catch (Exception ex) { MessageBox.Show("Error Classes: " + ex.Message); }
        }

        private void BoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BoxClass.SelectedValue != null && int.TryParse(BoxClass.SelectedValue.ToString(), out int classId))
            {
                // mostra id disciplina
                if (txtClassId != null) txtClassId.Text = classId.ToString();

                // carrega alunos 
                var allStudents = _studentService.Get<StudentViewModel>();
                var filteredStudents = allStudents.Where(s => s.ClassId == classId).ToList();

                BoxStudent.DataSource = filteredStudents;
                BoxStudent.DisplayMember = "Name";
                BoxStudent.ValueMember = "Id";
                BoxStudent.SelectedIndex = -1;
                BoxSubject.DataSource = null;
            }
            else
            {
                if (txtClassId != null) txtClassId.Text = "";
                BoxStudent.DataSource = null;
            }
        }

        private void BoxStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BoxStudent.SelectedValue != null
                && int.TryParse(BoxStudent.SelectedValue.ToString(), out int studentId)
                && BoxClass.SelectedValue != null
                && int.TryParse(BoxClass.SelectedValue.ToString(), out int classId))
            {
                // caregar disciplinas 
                var enrollments = _enrollmentService.Get<EnrollmentViewModel>();
                var studentEnrollments = enrollments.Where(en => en.StudentId == studentId && en.ClassId == classId).ToList();

                var lista = studentEnrollments.Select(en => new { Id = en.Id, Name = en.CollegeSubjectName }).ToList();

                BoxSubject.DataSource = lista;
                BoxSubject.DisplayMember = "Name";
                BoxSubject.ValueMember = "Id"; 
                BoxSubject.SelectedIndex = -1;
            }
        }

        // 

        protected override void Save()
        {
            try
            {
                
                if (BoxSubject.SelectedValue == null)
                {
                    MessageBox.Show("Select the Subject (enrollment).");
                    return;
                }
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    MessageBox.Show("Please provide the name of the assessment.");
                    return;
                }

                // Preparação
                int enrollmentId = (int)BoxSubject.SelectedValue;
                var enrollment = _enrollmentService.GetById<Enrollment>(enrollmentId);

                int.TryParse(txtScore.Text, out int score);
                DateTime.TryParse(txtDate.Text, out DateTime date);

                var evaluation = new Evaluation
                {
                    NameEvaluation = txtName.Text,
                    ScoreValue = score,
                    DateEvaluation = date,
                    Enrollment = enrollment
                };

                // Salvar
                if (isEditMode)
                {
                    if (int.TryParse(txtId.Text, out int id))
                    {
                        evaluation.Id = id;
                        _evaluationService.Update<Evaluation, Evaluation, EvaluationValidator>(evaluation);
                        MessageBox.Show("Updated assessment!");
                    }
                }
                else
                {
                    _evaluationService.Add<Evaluation, Evaluation, EvaluationValidator>(evaluation);
                    MessageBox.Show("Review recorded!");
                }

                
                AtualizarMediaFinal(enrollmentId);

                ClearFields();
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving: " + ex.Message);
            }
        }

        protected override void PopulateGrid()
        {
            try
            {
                var includes = new List<string> { "Enrollment" };
                var evaluations = _evaluationService.Get<EvaluationViewModel>(includes);

                if (poisonListView1 != null)
                {
                    poisonListView1.Items.Clear();
                    foreach (var ev in evaluations)
                    {
                        var item = new ListViewItem(ev.Id.ToString());
                        item.SubItems.Add(ev.NameEvaluation);
                        item.SubItems.Add(ev.EnrollmentId.ToString());
                        item.SubItems.Add(ev.ScoreValue.ToString());
                        item.SubItems.Add(ev.DateEvaluation.ToShortDateString());

                        poisonListView1.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar: " + ex.Message);
            }
        }

        protected override void GridToForm(ListViewItem item)
        {
            try
            {
                if (int.TryParse(item.SubItems[0].Text, out int id))
                {
                    
                    var ev = _evaluationService.GetById<Evaluation>(id, new List<string> { "Enrollment.Class" });

                    if (ev != null)
                    {
                        txtId.Text = ev.Id.ToString();
                        txtName.Text = ev.NameEvaluation;
                        txtScore.Text = ev.ScoreValue.ToString();
                        txtDate.Text = ev.DateEvaluation.ToString("dd/MM/yyyy");

                        // Tenta mostrar o ID da turma
                        if (ev.Enrollment?.Class != null && txtClassId != null)
                        {
                            txtClassId.Text = ev.Enrollment.Class.Id.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loading error: " + ex.Message);
            }
        }

        protected override void Excluir()
        {
            if (poisonListView1.SelectedItems.Count > 0)
            {
                if (int.TryParse(poisonListView1.SelectedItems[0].Text, out int id))
                {
                    if (MessageBox.Show("Delete this review?", "Delete this review?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        
                        var avaliacao = _evaluationService.GetById<Evaluation>(id, new List<string> { "Enrollment" });
                        int enrollmentId = avaliacao?.Enrollment?.Id ?? 0;

                        
                        _evaluationService.Delete(id);

                       
                        if (enrollmentId > 0)
                        {
                            AtualizarMediaFinal(enrollmentId);
                        }

                        PopulateGrid();
                    }
                }
            }
        }

        protected override void ClearFields()
        {
            base.ClearFields();
            txtId.Text = "";
            BoxClass.SelectedIndex = -1;
            BoxStudent.DataSource = null;
            BoxSubject.DataSource = null;

            if (txtClassId != null) txtClassId.Text = "";
        }

        private void txtDate_Click(object sender, EventArgs e)
        {

        }
    }
}