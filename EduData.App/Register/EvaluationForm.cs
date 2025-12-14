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

            // Eventos dos filtros
            this.BoxClass.SelectedIndexChanged += new EventHandler(this.BoxClass_SelectedIndexChanged);
            this.BoxStudent.SelectedIndexChanged += new EventHandler(this.BoxStudent_SelectedIndexChanged);
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

                poisonListView1.Columns.Add("ID", 50);
                poisonListView1.Columns.Add("Nome Avaliação", 200);
                poisonListView1.Columns.Add("Cód. Matrícula", 100); // Mostra a ligação
                poisonListView1.Columns.Add("Nota", 80);
                poisonListView1.Columns.Add("Data", 100);
            }
        }

        // --- LÓGICA DE SELEÇÃO (Mantida para encontrar o Enrollment ID) ---

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
            catch (Exception ex) { MessageBox.Show("Erro Turmas: " + ex.Message); }
        }

        private void BoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BoxClass.SelectedValue != null && int.TryParse(BoxClass.SelectedValue.ToString(), out int classId))
            {
                // Carrega alunos da turma selecionada
                var allStudents = _studentService.Get<StudentViewModel>();
                var filteredStudents = allStudents.Where(s => s.ClassId == classId).ToList();

                BoxStudent.DataSource = filteredStudents;
                BoxStudent.DisplayMember = "Name";
                BoxStudent.ValueMember = "Id";
                BoxStudent.SelectedIndex = -1;
                BoxSubject.DataSource = null;
            }
        }

        private void BoxStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BoxStudent.SelectedValue != null
                && int.TryParse(BoxStudent.SelectedValue.ToString(), out int studentId)
                && BoxClass.SelectedValue != null
                && int.TryParse(BoxClass.SelectedValue.ToString(), out int classId))
            {
                // Carrega as matrículas (disciplinas) desse aluno nessa turma
                var enrollments = _enrollmentService.Get<EnrollmentViewModel>();
                var studentEnrollments = enrollments.Where(en => en.StudentId == studentId && en.ClassId == classId).ToList();

                // O ValueMember aqui é o EnrollmentId (ID da Matrícula)
                var lista = studentEnrollments.Select(en => new { Id = en.Id, Name = en.CollegeSubjectName }).ToList();

                BoxSubject.DataSource = lista;
                BoxSubject.DisplayMember = "Name";
                BoxSubject.ValueMember = "Id";
                BoxSubject.SelectedIndex = -1;
            }
        }
        private void AtualizarMediaNaMatricula(int enrollmentId)
        {
            try
            {
                // 1. Busca todas as avaliações dessa matrícula específica
                var todasAvaliacoes = _evaluationService.Get<Evaluation>(new List<string> { "Enrollment" });
                var avaliacoesDaMatricula = todasAvaliacoes.Where(ev => ev.Enrollment.Id == enrollmentId).ToList();

                // 2. Calcula a média (se houver notas, senão é 0)
                int mediaFinal = avaliacoesDaMatricula.Count > 0
                    ? (int)avaliacoesDaMatricula.Average(ev => ev.ScoreValue)
                    : 0;

                // 3. Atualiza a tabela Enrollment
                var enrollment = _enrollmentService.GetById<Enrollment>(enrollmentId);
                if (enrollment != null)
                {
                    enrollment.FinalScore = mediaFinal;
                    _enrollmentService.Update<Enrollment, Enrollment, EnrollmentValidator>(enrollment);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar média: " + ex.Message);
            }
        }

        // --- CRUD ---

        protected override void Save()
        {
            try
            {
                if (BoxSubject.SelectedValue == null)
                {
                    MessageBox.Show("Selecione a Disciplina (Matrícula).");
                    return;
                }
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    MessageBox.Show("Informe o nome da avaliação.");
                    return;
                }

                // Recupera ID da Matrícula
                int enrollmentId = (int)BoxSubject.SelectedValue;
                // Busca objeto Enrollment
                var enrollment = _enrollmentService.GetById<Enrollment>(enrollmentId);

                int.TryParse(txtScore.Text, out int score);
                DateTime.TryParse(txtDate.Text, out DateTime date);

                var evaluation = new Evaluation
                {
                    NameEvaluation = txtName.Text,
                    ScoreValue = score,
                    DateEvaluation = date,
                    Enrollment = enrollment // Vincula
                };

                if (isEditMode)
                {
                    if (int.TryParse(txtId.Text, out int id))
                    {
                        evaluation.Id = id;
                        _evaluationService.Update<Evaluation, Evaluation, EvaluationValidator>(evaluation);
                        MessageBox.Show("Atualizado!");
                    }
                }
                else
                {
                    _evaluationService.Add<Evaluation, Evaluation, EvaluationValidator>(evaluation);
                    MessageBox.Show("Salvo!");
                }
                AtualizarMediaNaMatricula(enrollment.Id);

                ClearFields();
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }

        protected override void PopulateGrid()
        {
            try
            {
                // Trazemos Enrollment apenas para pegar o ID dele se necessário
                var includes = new List<string> { "Enrollment" };
                var evaluations = _evaluationService.Get<EvaluationViewModel>(includes);

                if (poisonListView1 != null)
                {
                    poisonListView1.Items.Clear();
                    foreach (var ev in evaluations)
                    {
                        var item = new ListViewItem(ev.Id.ToString());
                        item.SubItems.Add(ev.NameEvaluation);

                        // Mostra apenas o ID da Matrícula (Conforme solicitado)
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
                    // Busca dados básicos
                    var ev = _evaluationService.GetById<Evaluation>(id, new List<string> { "Enrollment" });

                    if (ev != null)
                    {
                        txtId.Text = ev.Id.ToString();
                        txtName.Text = ev.NameEvaluation;
                        txtScore.Text = ev.ScoreValue.ToString();
                        txtDate.Text = ev.DateEvaluation.ToString("dd/MM/yyyy");

                        // Na edição simplificada, apenas mostramos os dados. 
                        // Recarregar a cascata de combos (Turma->Aluno->Matrícula) é complexo 
                        // e pode ser feito se o usuário quiser alterar a quem a nota pertence.
                        // Por enquanto, focamos em editar a nota/nome.
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar: " + ex.Message);
            }
        }

        protected override void Excluir()
        {
            if (poisonListView1.SelectedItems.Count > 0)
            {
                if (int.TryParse(poisonListView1.SelectedItems[0].Text, out int id))
                {
                    if (MessageBox.Show("Excluir?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // --- TRECHO ALTERADO ---
                        // 1. Descobre a matrícula antes de deletar a prova
                        var avaliacao = _evaluationService.GetById<Evaluation>(id, new List<string> { "Enrollment" });
                        int enrollmentId = avaliacao?.Enrollment?.Id ?? 0;

                        // 2. Deleta a prova
                        _evaluationService.Delete(id);

                        // 3. Recalcula a média da matrícula (agora sem essa nota)
                        if (enrollmentId > 0)
                        {
                            AtualizarMediaNaMatricula(enrollmentId);
                        }
                        // -----------------------

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
        }
    }
}