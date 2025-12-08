using AutoMapper;
using EduData.Domain.Base;
using EduData.Domain.Entities;
using EduData.Repository.Context;
using EduData.Repository.Repository;
using EduData.Service.Service;
using EduData.Service.Validators;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.Json;

namespace EduData.Test
{
    [TestClass]
    public sealed class ServiceTest
    {
        private ServiceCollection services;

        public ServiceProvider ConfigureServices()
        {
            services = new ServiceCollection();

            // Configuração do Banco (Necessário passar a string aqui para o teste funcionar)
            services.AddDbContext<EduDataContext>(options =>
                options.UseMySQL("server=localhost;database=EduData;user=root;password=")
            );

            services.AddScoped<IBaseRepository<User>, BaseRepository<User>>();
            services.AddScoped<IBaseService<User>, BaseService<User>>();

            // CONFIGURAÇÃO IGUAL AO MODELO: Mapeia User -> User
            services.AddSingleton(
                new MapperConfiguration(
                    config => { config.CreateMap<User, User>(); },
                    NullLoggerFactory.Instance).CreateMapper()
                );

            return services.BuildServiceProvider();
        }

        [TestMethod]
        public void TestUserService()
        {
            var serviceProvider = ConfigureServices();
            var _userService = serviceProvider.GetService<IBaseService<User>>();

            // Preenchemos com os dados do EduData (Name, Password, Role)
            var user = new User
            {
                Name = "Arthur",
                Password = "Arthur@15",
                Role = "Admin"
            };

            // O PULO DO GATO: Aqui usamos <User, User, UserValidator> igual ao IFSPStore
            // Em vez de usar ViewModel, passamos a própria entidade.
            var result = _userService.Add<User, User, UserValidator>(user);

            Console.WriteLine(JsonSerializer.Serialize(result));
        }
    }
}