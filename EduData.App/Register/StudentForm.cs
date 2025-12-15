using EduData.App.Base;
using EduData.App.ViewModel;
using EduData.Domain.Base;
using EduData.Domain.Entities;
using EduData.Service.Validators;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EduData.App.Register
{
    public partial class StudentForm : BaseForm
    {
        private readonly IBaseService<Student> _studentService;
        private readonly IBaseService<Class> _classService;

        public StudentForm(IBaseService<Student> studentService, IBaseService<Class> classService)
        {
            _studentService = studentService;
            _classService = classService;

            InitializeComponent();

            this.ComboClass.SelectedIndexChanged += new EventHandler(this.ComboClass_SelectedIndexChanged);
            ConfigurarGrid();
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
                poisonListView1.OwnerDraw = false;
                poisonListView1.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;

                poisonListView1.Columns.Add("ID", 50);
                poisonListView1.Columns.Add("Name", 250);
                poisonListView1.Columns.Add("Birth", 120);
                poisonListView1.Columns.Add("Class", 200);
            }
        }
        private void ComboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (ComboClass.SelectedValue != null && int.TryParse(ComboClass.SelectedValue.ToString(), out int idTurma))
            {
                lblIdClass.Text = idTurma.ToString(); 
            }
            else
            {
                lblIdClass.Text = ""; 
            }
        }

        private void CarregarTurmas()
        {
            try
            {
                var classes = _classService.Get<ClassViewModel>().ToList();

                ComboClass.DataSource = classes;
                ComboClass.DisplayMember = "Course";
                ComboClass.ValueMember = "Id";

                ComboClass.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar turmas: " + ex.Message);
            }
        }

        protected override void Save()
        {
            try
            {
                // 1. Validações
                if(string.IsNullOrEmpty(txtId.Text))
        {
                    MessageBox.Show("O ID (Matrícula) é obrigatório.");
                    return;
                }

                if (string.IsNullOrEmpty(lblName.Text))
                {
                    MessageBox.Show("O nome é obrigatório.");
                    return;
                }

                if (!DateTime.TryParse(lblDATE.Text, out DateTime dataNascimento))
                {
                    MessageBox.Show("Data inválida.");
                    return;
                }

                if (ComboClass.SelectedValue == null)
                {
                    MessageBox.Show("Selecione uma turma.");
                    return;
                }

                int idManual = int.Parse(txtId.Text);
                int idTurma = (int)ComboClass.SelectedValue;
                // Busca a entidade turma para vincular corretamente
                var turmaSelecionada = _classService.GetById<Class>(idTurma);

                var student = new Student
                {
                    Id = idManual,  
                    Name = lblName.Text,
                    DateBirth = dataNascimento,
                    Class = turmaSelecionada
                };

                // 3. Salvar
                if (isEditMode)
                {
                    _studentService.Update<Student, Student, StudentValidator>(student);
                    MessageBox.Show("Aluno atualizado!");
                    // EDIÇÃO: Usa o ID que está na tela (escondido/travado)
                    if (int.TryParse(txtId.Text, out int id))
                    {
                        student.Id = id;
                        _studentService.Update<Student, Student, StudentValidator>(student);
                        MessageBox.Show("Aluno atualizado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao identificar o aluno para edição.");
                        return;
                    }
                }
                else
                {
                    var existe = _studentService.GetById<Student>(idManual);
                    if (existe != null)
                    {
                        MessageBox.Show($"Já existe um aluno com a matrícula {idManual}!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    _studentService.Add<Student, Student, StudentValidator>(student);
                    MessageBox.Show("Aluno cadastrado com sucesso!");
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
                var students = _studentService.Get<StudentViewModel>(new List<string> { "Class" });

                if (poisonListView1 != null)
                {
                    poisonListView1.Items.Clear();
                    foreach (var s in students)
                    {
                        var item = new ListViewItem(s.Id.ToString());
                        item.SubItems.Add(s.Name);
                        item.SubItems.Add(s.DateBirth.ToShortDateString());
                        item.SubItems.Add(s.ClassCourse ?? "Sem Turma");

                        poisonListView1.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar alunos: " + ex.Message);
            }
        }

        protected override void GridToForm(ListViewItem item)
        {
            try
            {
                if (int.TryParse(item.SubItems[0].Text, out int id))
                {
                    var student = _studentService.GetById<StudentViewModel>(id, new List<string> { "Class" });

                    if (student != null)
                    {
                        txtId.Enabled = false;
                        txtId.Text = student.Id.ToString(); // Preenche o ID travado
                        lblName.Text = student.Name;
                        lblDATE.Text = student.DateBirth.ToString("dd/MM/yyyy");
                        ComboClass.SelectedValue = student.ClassId;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados para edição: " + ex.Message);
            }
        }

        protected override void Excluir()
        {
            if (poisonListView1.SelectedItems.Count > 0)
            {
                if (int.TryParse(poisonListView1.SelectedItems[0].Text, out int id))
                {
                    if (MessageBox.Show("Tem certeza que deseja excluir?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            _studentService.Delete(id);
                            MessageBox.Show("Aluno excluído com sucesso.");
                            PopulateGrid();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao excluir (verifique dependências): " + ex.Message);
                        }
                    }
                }
            }
        }

        protected override void ClearFields()
        {
            base.ClearFields();
            txtId.Text = "";
            ComboClass.SelectedIndex = -1;
            lblIdClass.Text = ""; 
        }
    }
}