using EduData.App.Infra;
using EduData.App.Register;
using EduData.Domain.Base;
using EduData.Domain.Entities;
using EduData.Service.Validators;
using Microsoft.Extensions.DependencyInjection;
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

namespace EduData.App.Others
{
    public partial class Login : LostForm
    {
        private readonly IBaseService<User> _userService;
        public Login(IBaseService<User> userService)
        {
            _userService = userService;
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(hopeTextBox1.Text) || string.IsNullOrEmpty(hopeTextBox2.Text))
            {
                MessageBox.Show("Please enter your username and password.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            User user = GetUser(hopeTextBox1.Text, hopeTextBox2.Text);

            
            if (user != null)
            {

                MainForm.User = user; 
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {

                MessageBox.Show("Invalid username or password!", "Access Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hopeTextBox2.Text = string.Empty;
                hopeTextBox2.Focus();
            }
        }


        private User? GetUser(string login, string password)
        {
            VerifyRegistratedUserExistance();


            var user = _userService.Get<User>().FirstOrDefault(x => x.Name == login);

            if (user == null)
                return null;

            return user.Password != password ? null : user;
        }
        private void VerifyRegistratedUserExistance()
        {
            var users = _userService.Get<User>().ToList();
            if (!users.Any())
            {
                var user = new User
                {
                    Name = "admin",
                    Password = "admin7227",
                    Role = "Administrator"
                };
                _userService.Add<User, User, UserValidator>(user);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            var userForm = ConfigureDI.serviceProvider.GetService<UserForm>();

            if (userForm != null && !userForm.IsDisposed)
            {
                this.Hide();
                userForm.ShowDialog();
                this.Show();
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hopeTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
