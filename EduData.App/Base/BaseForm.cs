using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Windows.Forms;

namespace EduData.App.Base
{
    public partial class BaseForm : LostForm
    {
        #region Variables
        protected bool isEditMode = false;
        #endregion

        #region Constructor Method
        public BaseForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            PopulateGrid();

            // Estado inicial dos botões
            if (btnCreate != null)
            {
                btnCreate.Text = "CREATE";
                btnCreate.Visible = true;
            }
        }
        #endregion

        #region Events
        private void btnCreate_Click(object sender, EventArgs e)
        {
            Save();
            ClearFields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (poisonListView1.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente excluir este registro?", "EduData", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Como sua lista usa ListViewItem e não tem ID direto na propriedade, 
                    // a lógica de pegar o ID fica no método Excluir do filho ou adaptada aqui.
                    // Aqui chamamos o método genérico.
                    Excluir(); // Mantive o nome interno Excluir se você preferir, ou mude para Delete()
                    PopulateGrid();
                }
            }
            else
            {
                MessageBox.Show("Selecione um item para excluir.", "EduData", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBackList_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        // Eventos vazios ou gerados pelo designer
        private void Register_Click(object sender, EventArgs e) { }
        private void poisonListView1_SelectedIndexChanged(object sender, EventArgs e) { }
        #endregion

        #region Methods

        protected virtual void ClearFields()
        {
            isEditMode = false;

            // 1. Limpa recursivamente (entra em Paineis)
            foreach (Control control in Register.Controls)
            {
                RecursiveClear(control);
            }

            // 2. Reseta o botão para o estado original "CREATE"
            if (btnCreate != null)
            {
                btnCreate.Text = "CREATE";
                btnCreate.Visible = true;
            }

            // Foca na aba de registro (opcional, como no New do professor)
            // hopeTabPage1.SelectedIndex = 0; 
        }

        // Método auxiliar para recursividade (Mantido por causa do Painel)
        private void RecursiveClear(Control control)
        {
            if (control is HopeTextBox || control is TextBox || control is MaterialMaskedTextBox || control is MaterialTextBoxEdit)
            {
                control.Text = string.Empty;
            }

            if (control.HasChildren)
            {
                foreach (Control child in control.Controls)
                {
                    RecursiveClear(child);
                }
            }
        }

        protected virtual void Edit()
        {
            if (poisonListView1.SelectedItems.Count > 0)
            {
                isEditMode = true;

                // Primeiro limpa para garantir
                // ClearFields(); // Cuidado: ClearFields reseta o botão para "Create". 
                // Vamos limpar manualmente aqui ou ajustar a ordem.

                GridToForm(poisonListView1.SelectedItems[0]);

                
                if (btnCreate != null) btnCreate.Text = "SAVE";

                hopeTabPage1.SelectedIndex = 0; 
            }
            else
            {
                MessageBox.Show("Selecione um item para editar.", "EduData", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        protected virtual void Save()
        {
            
        }

        protected virtual void Excluir() 
        {
            
        }

        protected virtual void PopulateGrid()
        {
            
        }

        protected virtual void GridToForm(ListViewItem item)
        {
            
        }

        #endregion
    }
}