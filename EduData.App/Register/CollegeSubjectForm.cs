using EduData.App.Base;
using EduData.App.ViewModel;
using EduData.Domain.Base;
using EduData.Domain.Entities;
using EduData.Service.Validators;
using ReaLTaiizor.Forms;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic; 

namespace EduData.App.Register
{
    public partial class CollegeSubjectForm : BaseForm
    {
        private readonly IBaseService<CollegeSubject> _subjectService;

        public CollegeSubjectForm(IBaseService<CollegeSubject> subjectService)
        {
            _subjectService = subjectService;
            InitializeComponent();

            ConfigurarGrid();
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
                poisonListView1.Columns.Add("Course Load", 100);
            }
        }

        protected override void Save()
        {
            try
            {
                // 1. Validações
                if (string.IsNullOrEmpty(hopeTextBoxID.Text) || string.IsNullOrEmpty(hopeTextBoxName.Text))
                {
                    MessageBox.Show("ID e Nome são obrigatórios.", "Atenção");
                    return;
                }

                // 2. Conversão
                if (!int.TryParse(hopeTextBoxID.Text, out int id))
                {
                    MessageBox.Show("O ID deve ser um número válido.");
                    return;
                }

                string name = hopeTextBoxName.Text;

                if (!int.TryParse(hopeTextBoxLoad.Text, out int courseLoad))
                {
                    courseLoad = 0;
                }

                // 3. Lógica de Salvar
                if (isEditMode)
                {
                    // EDIÇÃO (ID Travado)
                    var existingSubject = _subjectService.GetById<CollegeSubject>(id);

                    if (existingSubject != null)
                    {
                        existingSubject.Name = name;
                        existingSubject.CourseLoad = courseLoad;

                        _subjectService.Update<CollegeSubject, CollegeSubject, CollegeSubjectValidator>(existingSubject);
                        MessageBox.Show("Disciplina atualizada!");
                    }
                    else
                    {
                        MessageBox.Show("Registro não encontrado.");
                        return;
                    }
                }
                else
                {
                    // CRIAÇÃO (ID Manual)

                    // Verifica duplicidade antes de inserir
                    var existe = _subjectService.GetById<CollegeSubject>(id);
                    if (existe != null)
                    {
                        MessageBox.Show($"Já existe uma disciplina com o ID {id}!", "Erro de Duplicidade");
                        return;
                    }

                    var newSubject = new CollegeSubject
                    {
                        Id = id, // ID Manual
                        Name = name,
                        CourseLoad = courseLoad
                    };

                    _subjectService.Add<CollegeSubject, CollegeSubject, CollegeSubjectValidator>(newSubject);
                    MessageBox.Show("Disciplina cadastrada!");
                }

                ClearFields();
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar: {ex.Message}", "Erro");
            }
        }

        protected override void PopulateGrid()
        {
            try
            {
                var subjects = _subjectService.Get<CollegeSubjectViewModel>();

                if (poisonListView1 != null)
                {
                    poisonListView1.Items.Clear();

                    foreach (var s in subjects)
                    {
                        var item = new ListViewItem(s.Id.ToString());
                        item.SubItems.Add(s.Name);
                        item.SubItems.Add(s.CourseLoad.ToString());

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
                hopeTextBoxID.Text = item.SubItems[0].Text;
                hopeTextBoxName.Text = item.SubItems[1].Text;
                hopeTextBoxLoad.Text = item.SubItems[2].Text;

                // TRAVA O ID NA EDIÇÃO (Regra de Ouro)
                hopeTextBoxID.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar: " + ex.Message);
            }
        }

        protected override void Excluir()
        {
            try
            {
                if (poisonListView1.SelectedItems.Count > 0 &&
                    int.TryParse(poisonListView1.SelectedItems[0].Text, out int id))
                {
                    if (MessageBox.Show("Deseja excluir?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        _subjectService.Delete(id);
                        PopulateGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir (Verifique se há alunos matriculados nesta disciplina): " + ex.Message, "Erro");
            }
        }

        // --- IMPORTANTE: Destravar o ID para novos cadastros ---
        protected override void ClearFields()
        {
            base.ClearFields(); // Limpa os textos (se o base fizer isso)

            // Garante a limpeza manual
            hopeTextBoxID.Text = "";
            hopeTextBoxName.Text = "";
            hopeTextBoxLoad.Text = "";

            // DESTRAVA O ID
            hopeTextBoxID.Enabled = true;
        }

    }
}