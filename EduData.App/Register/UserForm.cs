using EduData.Domain.Base;
using EduData.Domain.Entities;
using EduData.Service.Validators;
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
    public partial class UserForm : LostForm
    {
        private readonly IBaseService<User> _userService;

        public UserForm(IBaseService<User> userService)
        {
            _userService = userService;
            InitializeComponent();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {

                var newUser = new User
                {
                    Name = hopeTextBox1.Text,
                    Password = hopeTextBox2.Text,
                    Role = hopeComboBox1.SelectedItem.ToString()
                };

                // salvar
                _userService.Add<User, User, UserValidator>(newUser);

                MessageBox.Show("Usuário cadastrado com sucesso!", "EduData", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void hopeTextBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
