using EduData.App.Infra;
using System;
using System.Windows.Forms;

namespace EduData.App
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Inicializa as configurações da aplicação
            ApplicationConfiguration.Initialize();

            // Configura a Injeção de Dependência
            ConfigureDI.ConfigureServices();

            // Exemplo de como abrir o primeiro formulário usando DI
            // Supondo que você tenha um form de Login ou Principal
            // var loginForm = ConfigureDI.ServicesProvider.GetRequiredService<Login>();
            // Application.Run(loginForm);

            // Por enquanto, como ainda vamos criar os forms, deixamos comentado ou padrão:
            // Application.Run(new Form1()); 
        }
    }
}