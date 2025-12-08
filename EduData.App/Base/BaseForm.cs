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

namespace EduData.App.Base
{
    public partial class BaseForm : LostForm
    {
        public BaseForm()
        {
            InitializeComponent();

        }
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

        }

        private void Register_Click(object sender, EventArgs e)
        {

        }
        protected virtual void PreencherFormulario(DataGridViewRow row)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnBackList_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
