using EduData.Domain.Entities;
using EduData.Repository.Context;
using EduData.Repository.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.Json;
using System.Linq;

namespace EduData.Test
{
    [TestClass]
    public sealed class RepositoryTest
    {
        private EduDataContext GetContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<EduDataContext>();
            optionsBuilder.UseMySQL("server=localhost;database=EduData;user=root;password=");
            return new EduDataContext(optionsBuilder.Options);
        }

        [TestMethod]
        public void TestClass() 
        {
            using (var context = GetContext())
            {
                Console.WriteLine("Connected!");

                var class1 = new Class(1, 1, "Engenharia de Software", 40);
                var class2 = new Class(2, 3, "Ciência de Dados", 35);
                var class3 = new Class(3, 5, "Redes de Computadores", 30);

                // Adiciona se não existir (para não duplicar em múltiplos testes)
                if (!context.Classes.Any(c => c.Id == 1)) context.Classes.Add(class1);
                if (!context.Classes.Any(c => c.Id == 2)) context.Classes.Add(class2);
                if (!context.Classes.Any(c => c.Id == 3)) context.Classes.Add(class3);

                context.SaveChanges();
                Console.WriteLine("Insert Class done!");
            }

            using (var context = GetContext())
            {
                foreach (var item in context.Classes)
                {
                    Console.WriteLine(JsonSerializer.Serialize(item));
                }
                Console.WriteLine("List Class Done!");
            }
        }

        [TestMethod]
        public void TestCollegeSubject() // Testa Disciplinas
        {
            using (var context = GetContext())
            {
                Console.WriteLine("Connected!");

                var subject1 = new CollegeSubject(1, "Programação Orientada a Objetos", 80);
                var subject2 = new CollegeSubject(2, "Banco de Dados", 60);
                var subject3 = new CollegeSubject(3, "Matemática Discreta", 40);

                if (!context.CollegeSubjects.Any(c => c.Id == 1)) context.CollegeSubjects.Add(subject1);
                if (!context.CollegeSubjects.Any(c => c.Id == 2)) context.CollegeSubjects.Add(subject2);
                if (!context.CollegeSubjects.Any(c => c.Id == 3)) context.CollegeSubjects.Add(subject3);

                context.SaveChanges();
                Console.WriteLine("Insert Subject done!");
            }
        }

        [TestMethod]
        public void TestStudent() // Testa Alunos (Depende de Turma)
        {
            using (var context = GetContext())
            {
                Console.WriteLine("Connected!");

                // Busca as turmas criadas no teste anterior
                var turma1 = context.Classes.Find(1);
                var turma2 = context.Classes.Find(2);

                if (turma1 != null && turma2 != null)
                {
                    var student1 = new Student(1, "João Silva", new DateTime(2000, 5, 10), turma1);
                    var student2 = new Student(2, "Maria Souza", new DateTime(1999, 8, 22), turma1);
                    var student3 = new Student(3, "Pedro Santos", new DateTime(2001, 1, 15), turma2);

                    if (!context.Students.Any(s => s.Id == 1)) context.Students.Add(student1);
                    if (!context.Students.Any(s => s.Id == 2)) context.Students.Add(student2);
                    if (!context.Students.Any(s => s.Id == 3)) context.Students.Add(student3);

                    context.SaveChanges();
                    Console.WriteLine("Insert Student done!");
                }
            }
        }

        [TestMethod]
        public void TestUser() // Testa Usuários
        {
            using (var context = GetContext())
            {
                Console.WriteLine("Connected!");

                var user1 = new User(1, "Admin", "admin123", "Administrador");
                var user2 = new User(2, "ProfessorX", "senha123", "Professor");

                if (!context.Users.Any(u => u.Id == 1)) context.Users.Add(user1);
                if (!context.Users.Any(u => u.Id == 2)) context.Users.Add(user2);

                context.SaveChanges();
                Console.WriteLine("Insert User done!");
            }
        }

        [TestMethod]
        public void TestEnrollment() // Testa Matrícula (Liga Aluno, Turma e Disciplina)
        {
            using (var context = GetContext())
            {
                Console.WriteLine("Connected!");

                var aluno = context.Students.Find(1);
                var turma = context.Classes.Find(1);
                var disciplina = context.CollegeSubjects.Find(1);

                if (aluno != null && turma != null && disciplina != null)
                {
                    // Aluno 1, na Turma 1, fazendo POO, com Nota 8
                    var enrollment = new Enrollment(1, aluno, turma, disciplina, 8);

                    if (!context.Enrollments.Any(e => e.Id == 1)) context.Enrollments.Add(enrollment);

                    context.SaveChanges();
                    Console.WriteLine("Insert Enrollment done!");
                }
            }
        }

        [TestMethod]
        public void TestEvaluation() // Testa Avaliação
        {
            using (var context = GetContext())
            {
                Console.WriteLine("Connected!");

                var matricula = context.Enrollments.Find(1);

                if (matricula != null)
                {
                    var prova = new Evaluation(1, "Prova P1", DateTime.Now, 85, matricula);

                    if (!context.Evaluations.Any(e => e.Id == 1)) context.Evaluations.Add(prova);

                    context.SaveChanges();
                    Console.WriteLine("Insert Evaluation done!");
                }
            }
        }

        [TestMethod]
        public void TestRepositoryPattern() // Testa usando a classe BaseRepository
        {
            var context = GetContext();
            var _classRepository = new BaseRepository<Class>(context);
            var _studentRepository = new BaseRepository<Student>(context);

            // Cria uma nova turma via Repository
            var novaTurma = new Class();
            novaTurma.Course = "Medicina";
            novaTurma.Period = 1;
            novaTurma.NumberStudents = 60;
            _classRepository.Insert(novaTurma);

            // Cria um novo aluno para essa turma
            var novoAluno = new Student();
            novoAluno.Name = "Dr. House";
            novoAluno.DateBirth = new DateTime(1980, 1, 1);
            novoAluno.Class = novaTurma; // Associa o objeto

            _studentRepository.Insert(novoAluno);

            Console.WriteLine("Teste via Repository Pattern Finalizado!");
        }
    }
}