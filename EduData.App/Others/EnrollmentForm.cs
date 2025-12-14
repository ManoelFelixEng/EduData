using EduData.App.Base;
using EduData.App.ViewModel;
using EduData.Domain.Base;
using EduData.Domain.Entities;
using EduData.Service.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EduData.App.Others
{
    public partial class EnrollmentForm : BaseForm
    {
        private readonly IBaseService<Enrollment> _enrollmentService;
        private readonly IBaseService<Student> _studentService;
        private readonly IBaseService<Class> _classService; // Reintroduzido
        private readonly IBaseService<CollegeSubject> _subjectService;

        public EnrollmentForm(
            IBaseService<Enrollment> enrollmentService,
            IBaseService<Student> studentService,
            IBaseService<Class> classService,
            IBaseService<CollegeSubject> subjectService)
        {
            _enrollmentService = enrollmentService;
            _studentService = studentService;
            _classService = classService;
            _subjectService = subjectService;

            InitializeComponent();
            ConfigurarGrid();

            // Associação do evento manualmente, caso não consiga pelo Designer
            this.cboClass.SelectedIndexChanged += new EventHandler(this.cboClass_SelectedIndexChanged);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CarregarCombosIniciais();
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
                poisonListView1.Columns.Add("Turma (ID - Curso)", 150); // Alterado conforme pedido
                poisonListView1.Columns.Add("Aluno", 200);
                poisonListView1.Columns.Add("Disciplina", 150);
                poisonListView1.Columns.Add("Média", 80);
            }
        }

        private void CarregarCombosIniciais()
        {
            try
            {
                // Carrega Turmas
                var classes = _classService.Get<ClassViewModel>().ToList();
                cboClass.DataSource = classes;
                // Exibe "ID - Curso" para facilitar seleção
                // Mas como DisplayMember pega só uma propriedade, vamos usar "Course" 
                // e assumir que o usuário checa o ID se houver duplicidade ou concatenar na ViewModel
                cboClass.DisplayMember = "Course";
                cboClass.ValueMember = "Id";
                cboClass.SelectedIndex = -1;

                // Carrega Disciplinas
                var subjects = _subjectService.Get<CollegeSubjectViewModel>().ToList();
                cboSubject.DataSource = subjects;
                cboSubject.DisplayMember = "Name";
                cboSubject.ValueMember = "Id";
                cboSubject.SelectedIndex = -1;

                // Alunos começam vazios até selecionar a turma
                cboStudent.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar listas: " + ex.Message);
            }
        }

        // EVENTO: Disparado ao escolher uma turma
        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboClass.SelectedValue != null && int.TryParse(cboClass.SelectedValue.ToString(), out int classId))
            {
                CarregarAlunosDaTurma(classId);
            }
        }

        private void CarregarAlunosDaTurma(int classId)
        {
            try
            {
                // Busca todos os alunos
                var allStudents = _studentService.Get<StudentViewModel>();

                // Filtra apenas os alunos da turma selecionada
                var filteredStudents = allStudents.Where(s => s.ClassId == classId).ToList();

                cboStudent.DataSource = filteredStudents;
                cboStudent.DisplayMember = "Name";
                cboStudent.ValueMember = "Id";
                cboStudent.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao filtrar alunos: " + ex.Message);
            }
        }

        protected override void Save()
        {
            try
            {
                // Validações
                if (cboClass.SelectedValue == null) { MessageBox.Show("Selecione uma Turma."); return; }
                if (cboStudent.SelectedValue == null) { MessageBox.Show("Selecione um Aluno."); return; }
                if (cboSubject.SelectedValue == null) { MessageBox.Show("Selecione uma Disciplina."); return; }

                // Busca entidades
                var student = _studentService.GetById<Student>((int)cboStudent.SelectedValue);
                var turma = _classService.GetById<Class>((int)cboClass.SelectedValue);
                var subject = _subjectService.GetById<CollegeSubject>((int)cboSubject.SelectedValue);

                int finalScore = 0;
                int.TryParse(txtFinalScore.Text, out finalScore);

                var enrollment = new Enrollment
                {
                    Student = student,
                    Class = turma, // Salva explicitamente a turma selecionada
                    CollegeSubject = subject,
                    FinalScore = finalScore
                };

                if (isEditMode)
                {
                    if (int.TryParse(txtId.Text, out int id))
                    {
                        enrollment.Id = id;
                        _enrollmentService.Update<Enrollment, Enrollment, EnrollmentValidator>(enrollment);
                        MessageBox.Show("Atualizado com sucesso!");
                    }
                }
                else
                {
                    _enrollmentService.Add<Enrollment, Enrollment, EnrollmentValidator>(enrollment);
                    MessageBox.Show("Matrícula realizada!");
                }

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
                var includes = new List<string> { "Student", "Class", "CollegeSubject" };
                var enrollments = _enrollmentService.Get<EnrollmentViewModel>(includes);

                if (poisonListView1 != null)
                {
                    poisonListView1.Items.Clear();
                    foreach (var e in enrollments)
                    {
                        var item = new ListViewItem(e.Id.ToString());

                        // Exibe ID da Turma - Nome do Curso (Conforme pedido)
                        item.SubItems.Add($"{e.ClassId} - {e.ClassCourse}");

                        item.SubItems.Add(e.StudentName);
                        item.SubItems.Add(e.CollegeSubjectName);
                        item.SubItems.Add(e.FinalScore.ToString());

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
                    var includes = new List<string> { "Student", "Class", "CollegeSubject" };
                    var enrollment = _enrollmentService.GetById<Enrollment>(id, includes);

                    if (enrollment != null)
                    {
                        txtId.Text = enrollment.Id.ToString();
                        txtFinalScore.Text = enrollment.FinalScore.ToString();

                        // 1. Seta a Turma primeiro
                        cboClass.SelectedValue = enrollment.Class.Id;

                        // 2. Força o carregamento dos alunos dessa turma (caso o evento não dispare a tempo)
                        CarregarAlunosDaTurma(enrollment.Class.Id);

                        // 3. Seta o Aluno
                        cboStudent.SelectedValue = enrollment.Student.Id;

                        // 4. Seta a Disciplina
                        cboSubject.SelectedValue = enrollment.CollegeSubject.Id;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar para edição: " + ex.Message);
            }
        }

        protected override void Excluir()
        {
            if (poisonListView1.SelectedItems.Count > 0)
            {
                if (int.TryParse(poisonListView1.SelectedItems[0].Text, out int id))
                {
                    if (MessageBox.Show("Deseja excluir?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        _enrollmentService.Delete(id);
                        PopulateGrid();
                    }
                }
            }
        }

        protected override void ClearFields()
        {
            base.ClearFields();
            txtId.Text = "";
            cboClass.SelectedIndex = -1;
            cboStudent.DataSource = null; // Limpa alunos ao resetar
            cboSubject.SelectedIndex = -1;
            txtFinalScore.Text = "0";
        }
    }
}