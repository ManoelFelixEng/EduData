using AutoMapper;
using EduData.App.ViewModel;         // Onde estão seus ViewModels
using EduData.App.View;              // Onde estarão seus Forms (crie essa pasta se não tiver)
using EduData.Domain.Base;
using EduData.Domain.Entities;
using EduData.Repository.Context;
using EduData.Repository.Repository;
using EduData.Service.Service;
using EduData.Service.Validators;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions; // Para o NullLoggerFactory

namespace EduData.App.Infra
{
    public static class ConfigureDI
    {
        pupublic static ServiceCollection services;
        public static IServiceProvider? serviceProvider;

        public static void ConfigureServices()
        {
            // Database config
            var dbConfigFile = "Config/DBConfig.txt";
            var strCon = File.ReadAllText(dbConfigFile);
            services = new ServiceCollection();
            services.AddDbContext<IFSPStoreContext>(
                options =>
                {
                    options.LogTo(Console.WriteLine);
                    options.UseMySQL(strCon);
                }
            );

            // 2. Repositórios
            services.AddScoped<IBaseRepository<User>, BaseRepository<User>>();
            services.AddScoped<IBaseRepository<Student>, BaseRepository<Student>>();
            services.AddScoped<IBaseRepository<Class>, BaseRepository<Class>>();
            services.AddScoped<IBaseRepository<College_Subject>, BaseRepository<College_Subject>>();
            services.AddScoped<IBaseRepository<Enrollment>, BaseRepository<Enrollment>>();
            services.AddScoped<IBaseRepository<Evaluation>, BaseRepository<Evaluation>>();

            // 3. Serviços
            services.AddScoped<IBaseService<User>, BaseService<User>>();
            services.AddScoped<IBaseService<Student>, BaseService<Student>>();
            services.AddScoped<IBaseService<Class>, BaseService<Class>>();
            services.AddScoped<IBaseService<College_Subject>, BaseService<College_Subject>>();
            services.AddScoped<IBaseService<Enrollment>, BaseService<Enrollment>>();
            services.AddScoped<IBaseService<Evaluation>, BaseService<Evaluation>>();

            // 4. Validadores
            services.AddScoped<UserValidator>();
            services.AddScoped<StudentValidator>();

            // 5. Formulários (Forms)
            // Aqui vamos registrar as telas conforme formos criando.
            // Vou deixar o Login e o MainForm como exemplo para o próximo passo.
            // services.AddScoped<Login>(); 
            // services.AddScoped<MainForm>();
            // services.AddScoped<CadastroTurma>(); // Exemplo futuro

            // 6. Mappings (AutoMapper) - IGUAL SUA REFERÊNCIA
            // Isso ensina o sistema a copiar dados de Class -> ClassViewModel sozinho
            services.AddSingleton(
                new MapperConfiguration(config =>
                {
                    config.CreateMap<Class, ClassViewModel>();
                    config.CreateMap<Student, StudentViewModel>();
                    config.CreateMap<College_Subject, CollegeSubjectViewModel>();
                    config.CreateMap<Enrollment, EnrollmentViewModel>();
                    config.CreateMap<Evaluation, EvaluationViewModel>();
                    config.CreateMap<User, UserViewModel>();
                }).CreateMapper()
            );

            // Constrói o provedor
            ServicesProvider = services.BuildServiceProvider();
        }
    }
}