using AutoMapper;
using EduData.App.Others;
using EduData.App.ViewModel;
using EduData.Domain.Base;
using EduData.Domain.Entities;
using EduData.Repository.Context;
using EduData.Repository.Repository;
using EduData.Service.Service;
using EduData.Service.Validators;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;
using EduData.App.Register;
using System;
using System.IO;

namespace EduData.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection services;
        public static IServiceProvider? serviceProvider;

        public static void ConfigureServices()
        {
            
            var dbConfigFile = "Config/DBConfig.txt";



            var strCon = File.ReadAllText(dbConfigFile);

            services = new ServiceCollection();
            services.AddDbContext<EduDataContext>(
                options =>
                {
                    options.LogTo(Console.WriteLine);
                    options.UseMySQL(strCon);
                }
            );

            #region Repositories
            services.AddScoped<IBaseRepository<User>, BaseRepository<User>>();
            services.AddScoped<IBaseRepository<Class>, BaseRepository<Class>>();
            services.AddScoped<IBaseRepository<Student>, BaseRepository<Student>>();
            services.AddScoped<IBaseRepository<CollegeSubject>, BaseRepository<CollegeSubject>>();
            services.AddScoped<IBaseRepository<Enrollment>, BaseRepository<Enrollment>>();
            services.AddScoped<IBaseRepository<Evaluation>, BaseRepository<Evaluation>>();
            #endregion

            #region Services
            services.AddTransient<MainForm>();
            services.AddScoped<IBaseService<Student>, BaseService<Student>>();
            services.AddScoped<IBaseService<Class>, BaseService<Class>>();
            services.AddScoped<IBaseService<Enrollment>, BaseService<Enrollment>>();

            services.AddScoped<IBaseService<User>, BaseService<User>>();
            services.AddScoped<IBaseService<Class>, BaseService<Class>>();
            services.AddScoped<IBaseService<Student>, BaseService<Student>>();
            services.AddScoped<IBaseService<CollegeSubject>, BaseService<CollegeSubject>>();
            services.AddScoped<IBaseService<Enrollment>, BaseService<Enrollment>>();
            services.AddScoped<IBaseService<Evaluation>, BaseService<Evaluation>>();
            #endregion

            #region Validators
            services.AddScoped<IValidator<User>, UserValidator>();
            services.AddScoped<IValidator<Class>, ClassValidator>();
            services.AddScoped<IValidator<Student>, StudentValidator>();
            services.AddScoped<IValidator<CollegeSubject>, CollegeSubjectValidator>();
            services.AddScoped<IValidator<Enrollment>, EnrollmentValidator>();
            services.AddScoped<IValidator<Evaluation>, EvaluationValidator>();
            #endregion

            #region Forms
           services.AddTransient<Login>();
            services.AddTransient<Register.UserForm>();
            services.AddTransient<Register.ClassForm>();
            services.AddTransient<Register.CollegeSubjectForm>();
            services.AddTransient<Register.StudentForm>();
            services.AddTransient<Others.EnrollmentForm>(); 
            services.AddTransient<Register.EvaluationForm>();
            #endregion

            #region Mappings

            services.AddSingleton(
                new MapperConfiguration(config =>
                {


                    
                    config.CreateMap<User, User>(); 
                    config.CreateMap<User, UserViewModel>().ReverseMap();
                    config.CreateMap<Class, ClassViewModel>().ReverseMap();
                    config.CreateMap<CollegeSubject, CollegeSubjectViewModel>().ReverseMap();
                    config.CreateMap<Evaluation, EvaluationViewModel>().ReverseMap();

                   
                    config.CreateMap<Student, StudentViewModel>()
                        .ForMember(dest => dest.ClassId, opt => opt.MapFrom(src => src.Class.Id))
                        .ForMember(dest => dest.ClassCourse, opt => opt.MapFrom(src => src.Class.Course));

                    config.CreateMap<StudentViewModel, Student>()
                        .ForMember(dest => dest.Class, opt => opt.Ignore());

                 
                    config.CreateMap<Enrollment, EnrollmentViewModel>()
                        .ForMember(dest => dest.StudentName, opt => opt.MapFrom(src => src.Student.Name))
                        .ForMember(dest => dest.ClassCourse, opt => opt.MapFrom(src => src.Class.Course))
                        .ForMember(dest => dest.CollegeSubjectName, opt => opt.MapFrom(src => src.CollegeSubject.Name));

                    config.CreateMap<EnrollmentViewModel, Enrollment>()
                         .ForMember(dest => dest.Student, opt => opt.Ignore())
                         .ForMember(dest => dest.Class, opt => opt.Ignore())
                         .ForMember(dest => dest.CollegeSubject, opt => opt.Ignore());

                }, NullLoggerFactory.Instance).CreateMapper() 
            );
            #endregion

            serviceProvider = services.BuildServiceProvider();
        }
    }
}