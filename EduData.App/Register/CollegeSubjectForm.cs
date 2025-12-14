using EduData.App.Base;
using EduData.App.ViewModel;
using EduData.Domain.Base;
using EduData.Domain.Entities;
using EduData.Service.Validators;
using ReaLTaiizor.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

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
                poisonListView1.Columns.Add("Nome", 250);
                poisonListView1.Columns.Add("Carga Horária", 100);
            }
        }

        // --- SALVAR (SAVE) ---
        protected override void Save()
        {
            try
            {
                // Validação Básica de Campos Vazios
                if (string.IsNullOrEmpty(hopeTextBoxID.Text) || string.IsNullOrEmpty(hopeTextBoxName.Text))
                {
                    MessageBox.Show("ID e Nome são obrigatórios.", "Atenção");
                    return;
                }

                // Conversão dos dados
                int id = int.Parse(hopeTextBoxID.Text);
                string name = hopeTextBoxName.Text;

                // Tenta converter a carga horária com segurança
                if (!int.TryParse(hopeTextBoxLoad.Text, out int courseLoad))
                {
                    courseLoad = 0; // Se deixar vazio ou digitar letra, vira 0
                }

                if (isEditMode)
                {
                    // --- EDIÇÃO (Busca o original para evitar erro de Tracking) ---
                    var existingSubject = _subjectService.Get<CollegeSubject>().FirstOrDefault(x => x.Id == id);

                    if (existingSubject != null)
                    {
                        existingSubject.Name = name;
                        existingSubject.CourseLoad = courseLoad;

                        _subjectService.Update<CollegeSubject, CollegeSubject, CollegeSubjectValidator>(existingSubject);
                    }
                    else
                    {
                        MessageBox.Show("Registro não encontrado no banco para edição.");
                        return;
                    }
                }
                else
                {
                    // --- CRIAÇÃO ---
                    var newSubject = new CollegeSubject
                    {
                        Id = id,
                        Name = name,
                        CourseLoad = courseLoad
                    };

                    // Verifica ID duplicado antes de inserir
                    if (_subjectService.Get<CollegeSubject>().Any(x => x.Id == id))
                    {
                        MessageBox.Show($"Já existe um registro com o ID {id}!", "Erro");
                        return;
                    }

                    _subjectService.Add<CollegeSubject, CollegeSubject, CollegeSubjectValidator>(newSubject);
                }

                MessageBox.Show("Salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                PopulateGrid();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- POPULAR GRID (CARREGAR LISTA) ---
        protected override void PopulateGrid()
        {
            var subjects = _subjectService.Get<CollegeSubjectViewModel>();

            if (poisonListView1 != null)
            {
                poisonListView1.Items.Clear();

                foreach (var s in subjects)
                {
                    var item = new ListViewItem(s.Id.ToString());
                    item.SubItems.Add(s.Name);
                    // Aqui estava o erro: CourseLoad com L maiúsculo
                    item.SubItems.Add(s.CourseLoad.ToString());

                    poisonListView1.Items.Add(item);
                }
            }
        }

        // --- GRID PARA O FORMULÁRIO (AO CLICAR EM EDITAR) ---
        protected override void GridToForm(ListViewItem item)
        {
            // Preenche os textboxes com os dados da linha selecionada
            hopeTextBoxID.Text = item.SubItems[0].Text;   // Coluna 0: ID
            hopeTextBoxName.Text = item.SubItems[1].Text; // Coluna 1: Nome
            hopeTextBoxLoad.Text = item.SubItems[2].Text; // Coluna 2: Carga Horária
        }

        // --- EXCLUIR ---
        protected override void Excluir()
        {
            try
            {
                if (poisonListView1.SelectedItems.Count > 0 &&
                    int.TryParse(poisonListView1.SelectedItems[0].Text, out int id))
                {
                    _subjectService.Delete(id);
                    MessageBox.Show("Registro excluído.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir (Pode estar vinculado a outro registro): " + ex.Message, "Erro");
            }
        }

        // Evento do Painel (Pode deixar vazio se não usar)
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void hopeTextBoxLoad_Click(object sender, EventArgs e)
        {

        }
    }
}