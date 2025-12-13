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

            // 1. CHAMA A CRIAÇÃO DO GRID AQUI
            ConfigurarGrid();

            // 2. DEPOIS CARREGA OS DADOS
            CarregarGrid();

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

        private void ConfigurarGrid()
        {
            // Verifica se a lista existe antes de mexer (Segurança contra o erro Null)
            if (poisonListView1 != null)
            {
                // Limpa tudo que tiver antes
                poisonListView1.Columns.Clear();

                // Configurações visuais importantes
                poisonListView1.View = View.Details; // Modo Tabela
                poisonListView1.GridLines = true;
                poisonListView1.FullRowSelect = true;
                poisonListView1.OwnerDraw = false;  // Deixa o Windows desenhar (evita tela branca)
                poisonListView1.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;

                // ADICIONA AS COLUNAS (Nome, Largura)
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
        protected override void CarregarGrid()
        {
            // 1. Busca os dados do banco e converte para ViewModel
            var classes = _classService.Get<ClassViewModel>();

            // 2. Limpa a lista visual antes de preencher
            poisonListView1.Items.Clear();

            // 3. Percorre cada turma encontrada e adiciona na lista
            foreach (var c in classes)
            {
                // Cria a linha começando pelo ID (Coluna 0)
                var item = new ListViewItem(c.Id.ToString());

                // Adiciona as colunas seguintes na ordem certa
                item.SubItems.Add(c.Course);                   // Coluna 1: Curso
                item.SubItems.Add(c.Period.ToString());        // Coluna 2: Período
                item.SubItems.Add(c.NumberStudents.ToString());// Coluna 3: Alunos

                // Adiciona a linha completa na tabela
                poisonListView1.Items.Add(item);
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
