using EduData.App.Base;
using EduData.App.ViewModel;
using EduData.Domain.Base;
using EduData.Domain.Entities;
using EduData.Service.Validators;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        protected override void Save()
        {
            try 
            { 

                var txtId = hopeTextBoxID;       // TextBox do ID
                var txtName = hopeTextBoxName;   // TextBox do Nome
                var txtLoad = hopeTextBoxLoad;   // TextBox do Course Load

                // Validação Básica
                if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtName.Text))
                {
                    MessageBox.Show("ID e Nome são obrigatórios.", "Atenção");
                    return;
                }

                // Conversão dos dados
                int id = int.Parse(txtId.Text);
                string name = txtName.Text;
                int courseLoad = int.Parse(txtLoad.Text); // Converte Carga Horária para numero

                if (isEditMode)
                {
                    // --- EDIÇÃO ---
                    var existingSubject = _subjectService.Get<CollegeSubject>().FirstOrDefault(x => x.Id == id);
                    if (existingSubject != null)
                    {
                        existingSubject.Name = name;
                        existingSubject.CourseLoad = courseLoad; // Atualiza Carga Horária

                        _subjectService.Update<CollegeSubject, CollegeSubject, CollegeSubjectValidator>(existingSubject);
                    }
                    else
                    {
                        MessageBox.Show("Registro não encontrado para edição.");
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
                        CourseLoad = courseLoad // Salva Carga Horária
                    };

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
        protected override void PopulateGrid()
        {
            var subjects = _subjectService.Get<CollegeSubjectViewModel>();
            poisonListView1.Items.Clear();

            foreach (var s in subjects)
            {
                var item = new ListViewItem(s.Id.ToString());
                item.SubItems.Add(s.Name);
                item.SubItems.Add(s.Courseload.ToString()); // Mostra Carga Horária na lista

                poisonListView1.Items.Add(item);
            }
        }
        protected override void GridToForm(ListViewItem item)
        {
            // --- TROQUE PELOS SEUS TEXTBOXES REAIS ---
            hopeTextBoxID.Text = item.SubItems[0].Text;
            hopeTextBoxName.Text = item.SubItems[1].Text;
            hopeTextBoxLoad.Text = item.SubItems[2].Text; // Preenche Carga Horária
        }
        protected override void Excluir()
        {
            try
            {
                if (int.TryParse(poisonListView1.SelectedItems[0].Text, out int id))
                {
                    _subjectService.Delete(id);
                    MessageBox.Show("Registro excluído.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir: " + ex.Message, "Erro");
            }
        }





        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
