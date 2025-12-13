using EduData.App.Base;
using EduData.App.ViewModel;
using EduData.Domain.Base;
using EduData.Domain.Entities;
using EduData.Service.Validators;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
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
            
            

        }




        // --- CARREGAR DADOS NA LISTA ---


        // --- SALVAR (CRIAR OU EDITAR) ---
        /*protected override void Salvar()
        {
            try
            {
                // Validação simples de conversão
                if (!int.TryParse(hopeTextBox14.Text, out int period) ||
                    !int.TryParse(hopeTextBox17.Text, out int numStudents))
                {
                    MessageBox.Show("Período e Número de Alunos devem ser números válidos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var classEntity = new Class
                {
                    Course = hopeTextBox16.Text, // Nome do Curso
                    Period = period,            // Periodo (Convertido)
                    NumberStudents = numStudents // Num Alunos (Convertido)
                };

                if (IsEditMode)
                {
                    // Edição: Precisa do ID
                    classEntity.Id = int.Parse(hopeTextBox14.Text);
                    _classService.Update<Class, Class, ClassValidator>(classEntity);
                }
                else
                {
                    // Criação
                    _classService.Add<Class, Class, ClassValidator>(classEntity);
                }

                MessageBox.Show("Turma salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CarregarGrid(); // Atualiza a lista
                LimparCampos(); // Limpa os textbox

                // Volta para a aba de lista (opcional, igual ao BaseForm)
                // O BaseForm.btnBack_Click já faz isso, mas aqui confirmamos o fluxo.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/
        protected override void Salvar()
        {
            try
            {
                // 1. Valida se digitou o ID
                if (string.IsNullOrEmpty(hopeTextBox14.Text))
                {
                    MessageBox.Show("Para cadastro manual, você DEVE digitar um ID.", "Atenção");
                    return;
                }

                // 2. Prepara o objeto com o ID que o usuário digitou
                var classEntity = new Class
                {
                    Id = int.Parse(hopeTextBox14.Text), // <--- AGORA LEMOS O ID AQUI
                    Course = hopeTextBox16.Text,
                    Period = int.Parse(hopeTextBox15.Text),
                    NumberStudents = int.Parse(hopeTextBox17.Text)
                };

                if (IsEditMode)
                {
                    // Edição
                    _classService.Update<Class, Class, ClassValidator>(classEntity);
                }
                else
                {
                    // Criação Manual
                    // Dica: O BaseService vai tentar inserir. Se o ID já existir, vai dar erro no banco.
                    // Para ficar profissional, poderíamos verificar antes:
                    // var existe = _classService.GetById<Class>(classEntity.Id);
                    // if (existe != null) { MessageBox.Show("ID já existe!"); return; }

                    _classService.Add<Class, Class, ClassValidator>(classEntity);
                }

                MessageBox.Show("Salvo com sucesso!");
                CarregarGrid();
                LimparCampos();
                // Não esqueça de resetar o IsEditMode se necessário
            }
            catch (Exception ex)
            {
                // Se tentar salvar ID duplicado, o erro cai aqui
                MessageBox.Show($"Erro ao salvar (Verifique se o ID já existe): {ex.Message}");
            }
        }

        // --- PREENCHER CAMPOS AO CLICAR NA LISTA (EDITAR) ---
        protected override void PreencherFormulario(ListViewItem item)
        {
            // O ID fica escondido ou read-only no hopeTextBox3
            hopeTextBox14.Text = item.SubItems[0].Text;
            hopeTextBox16.Text = item.SubItems[1].Text; // Course
            hopeTextBox15.Text = item.SubItems[2].Text; // Period
            hopeTextBox17.Text = item.SubItems[3].Text; // Students
        }

        // --- EXCLUIR ---
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
