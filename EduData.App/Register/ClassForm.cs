using EduData.App.Base;
using EduData.App.ViewModel;
using EduData.Domain.Base;
using EduData.Domain.Entities;
using EduData.Service.Validators;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.Linq; // Importante para o FirstOrDefault
using System.Windows.Forms;

namespace EduData.App.Register
{
    public partial class ClassForm : BaseForm
    {
        private readonly IBaseService<Class> _classService;

        public ClassForm(IBaseService<Class> classService)
        {
            _classService = classService;
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
                poisonListView1.Columns.Add("Curso", 250);
                poisonListView1.Columns.Add("Período", 80);
                poisonListView1.Columns.Add("Alunos", 80);
            }
            else
            {
                MessageBox.Show("Erro Crítico: A lista não foi carregada do BaseForm.");
            }
        }

        
        protected override void Save()
        {
            try
            {
                if (string.IsNullOrEmpty(hopeTextBox14.Text))
                {
                    MessageBox.Show("O ID é obrigatório.", "Atenção");
                    return;
                }
                

                int id = int.Parse(hopeTextBox14.Text);
                string course = hopeTextBox16.Text;
                int period = int.Parse(hopeTextBox15.Text);
                int numStudents = int.Parse(hopeTextBox17.Text);

                
                if (isEditMode)
                {
                    var existingClass = _classService.Get<Class>().FirstOrDefault(x => x.Id == id);

                    if (existingClass != null)
                    {
                        existingClass.Course = course;
                        existingClass.Period = period;
                        existingClass.NumberStudents = numStudents;

                        _classService.Update<Class, Class, ClassValidator>(existingClass);
                    }
                    else
                    {
                        MessageBox.Show("Erro: Turma não encontrada no banco para edição.");
                        return;
                    }
                }
                else
                {
                    var newClass = new Class
                    {
                        Id = id,
                        Course = course,
                        Period = period,
                        NumberStudents = numStudents
                    };

                    var exists = _classService.Get<Class>().Any(x => x.Id == id);
                    if (exists)
                    {
                        MessageBox.Show($"Já existe uma turma com o ID {id}!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    _classService.Add<Class, Class, ClassValidator>(newClass);
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
            var classes = _classService.Get<ClassViewModel>();

            poisonListView1.Items.Clear();

            foreach (var c in classes)
            {
                var item = new ListViewItem(c.Id.ToString());
                item.SubItems.Add(c.Course);
                item.SubItems.Add(c.Period.ToString());
                item.SubItems.Add(c.NumberStudents.ToString());

                poisonListView1.Items.Add(item);
            }
        }

        
        protected override void GridToForm(ListViewItem item)
        {
            hopeTextBox14.Text = item.SubItems[0].Text; // ID
            hopeTextBox16.Text = item.SubItems[1].Text; // Course
            hopeTextBox15.Text = item.SubItems[2].Text; // Period
            hopeTextBox17.Text = item.SubItems[3].Text; // Students
        }

       
        protected override void Excluir()
        {
            try
            {
                if (int.TryParse(poisonListView1.SelectedItems[0].Text, out int id))
                {
                    _classService.Delete(id);
                    MessageBox.Show("Turma excluída.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não é possível excluir esta turma pois existem alunos matriculados nela.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void materialButton1_Click(object sender, EventArgs e) 
        {

        }
        private void hopeTextBox4_Click(object sender, EventArgs e) 
        {

        }
        private void hopeTextBox14_Click(object sender, EventArgs e) 
        {

        }
        private void hopeTextBox15_Click(object sender, EventArgs e) 
        {

        }
        private void poisonListView1_SelectedIndexChanged(object sender, EventArgs e) 
        {

        }
    }
}