using ReaLTaiizor.Forms;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduData.App.Base
{
    public partial class BaseForm : LostForm
    {
        protected bool IsEditMode = false;

        public BaseForm()
        {
            InitializeComponent();
        }

        // Executa ao carregar o formulário para preencher a lista
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CarregarGrid();
        }

        #region Métodos Virtuais
        protected virtual void Salvar()
        {

        }

        protected virtual void Excluir()
        {

        }

        protected virtual void CarregarGrid()
        {

        }

        protected virtual void LimparCampos()
        {
            IsEditMode = false;
            // Percorre os controles da aba de registro para limpar
            foreach (Control control in Register.Controls)
            {
                if (control is MaterialTextBoxEdit || control is TextBox || control is MaterialMaskedTextBox)
                {
                    control.Text = string.Empty;
                }
                // Adicione outros tipos de controles se necessário (ComboBox, CheckBox, etc.)
            }
        }

        // Adaptado para ListViewItem pois o Designer usa PoisonListView
        protected virtual void PreencherFormulario(ListViewItem item)
        {

        }
        #endregion

        #region Eventos
        private void Register_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // volta registro
            LimparCampos();
            hopeTabPage1.SelectedIndex = 1; 
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // se tem algo selecionado
            if (poisonListView1.SelectedItems.Count > 0)
            {
                IsEditMode = true;
                PreencherFormulario(poisonListView1.SelectedItems[0]);
                hopeTabPage1.SelectedIndex = 0; 
            }
            else
            {
                MessageBox.Show("Selecione um item para editar.", "EduData", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (poisonListView1.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente excluir este registro?", "EduData", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Excluir();
                    CarregarGrid(); // Recarrega a lista após excluir
                }
            }
            else
            {
                MessageBox.Show("Selecione um item para excluir.", "EduData", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBackList_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // atualizar a lista
            CarregarGrid();
        }
        #endregion
    }
}