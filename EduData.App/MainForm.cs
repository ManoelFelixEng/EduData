using EduData.App.Infra;
using EduData.App.Others;
using EduData.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;
using EduData.App.Register;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduData.App
{
    public partial class MainForm : LostForm
    {
        public static User User { get; set; }
        public MainForm()
        {
            InitializeComponent();
            LoadLogin();
        }
        private void LoadLogin()
        {
            var login = ConfigureDI.serviceProvider!.GetService<Login>();
            if (login != null && !login.IsDisposed)
            {
                if (login.ShowDialog() != DialogResult.OK)
                {
                    Environment.Exit(0);
                }
            }
        }

        private void ExibirFormulario<TFormulario>() where TFormulario : Form
        {
            try
            {
                var form = ConfigureDI.serviceProvider.GetService<TFormulario>();
                if (form != null && !form.IsDisposed)
                {
                    form.ShowDialog(); // Abre como janela modal (focada)
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir o formulário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Register_Class_Click(object sender, EventArgs e)
        {
            ExibirFormulario<ClassForm>();
        }


        private void Registration_CollegeSubject_Click(object sender, EventArgs e)
        {
            ExibirFormulario<CollegeSubjectForm>();
        }

        private void Register_Student_Click(object sender, EventArgs e)
        {
            ExibirFormulario<StudentForm>();
        }


        private void Enrollment_Management_Click(object sender, EventArgs e)
        {
            ExibirFormulario<EnrollmentForm>();
        }


        private void Evaluation_Management_Click(object sender, EventArgs e)
        {
            ExibirFormulario<EvaluationForm>();
        }


        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void RegisterTable_Click(object sender, EventArgs e)
        {

        }
    }
}
