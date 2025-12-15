using EduData.App;
using EduData.App.Infra;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace EduData.App
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // 1. Configura os serviços (Injeção de Dependência)
            ConfigureDI.ConfigureServices();

            // 2. Pega o MainForm já construído com os serviços injetados
            var mainForm = ConfigureDI.serviceProvider.GetService<MainForm>();

            // 3. Roda a aplicação
            if (mainForm != null)
            {
                Application.Run(mainForm);
            }
            else
            {
                MessageBox.Show("Erro fatal: Não foi possível iniciar o MainForm.");
            }
        }
    }
}