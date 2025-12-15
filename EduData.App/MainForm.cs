using EduData.App.Infra;
using EduData.App.Others;
using EduData.App.Register;
using EduData.Domain.Base;
using EduData.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EduData.App
{
    public partial class MainForm : LostForm
    {
        // --- PROPRIEDADES E SERVIÇOS ---
        public static User User { get; set; }

        private readonly IBaseService<Student> _studentService;
        private readonly IBaseService<Class> _classService;
        private readonly IBaseService<Enrollment> _enrollmentService;

        // --- CONSTRUTOR E LOAD ---
        public MainForm(
            IBaseService<Student> studentService,
            IBaseService<Class> classService,
            IBaseService<Enrollment> enrollmentService)
        {
            _studentService = studentService;
            _classService = classService;
            _enrollmentService = enrollmentService;

            InitializeComponent();
            LoadLogin();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            AtualizarDashboard(); // Carrega todos os gráficos
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

        // --- MÉTODO CENTRALIZADOR ---
        private void AtualizarDashboard()
        {
            // Chama todos os métodos de gráficos para atualizar a tela
            CarregarGraficoMedia();
            CarregarGraficoMelhoresAlunos();
            CarregarGraficoTaxaAprovacao();
        }

        // --- GRÁFICO 1: MÉDIA POR TURMA (formsPlot1) ---
        private void CarregarGraficoMedia()
        {
            try
            {
                formsPlot1.Plot.Clear();
                formsPlot1.Plot.Title("Média de Notas por Turma");
                formsPlot1.Plot.Axes.Left.Label.Text = "Nota Média";
                formsPlot1.Plot.Axes.Bottom.Label.Text = "Turmas";

                // Estilo Dark
                formsPlot1.Plot.FigureBackground.Color = ScottPlot.Color.FromHex("#1c1c1c");
                formsPlot1.Plot.DataBackground.Color = ScottPlot.Color.FromHex("#2d2d2d");
                formsPlot1.Plot.Axes.Color(ScottPlot.Colors.White);
                formsPlot1.Plot.Grid.MajorLineColor = ScottPlot.Color.FromHex("#404040");

                var matriculas = _enrollmentService.Get<Enrollment>(new List<string> { "Class" }).ToList();

                if (!matriculas.Any())
                {
                    formsPlot1.Plot.Title("Sem dados");
                    formsPlot1.Refresh();
                    return;
                }

                var dadosAgrupados = matriculas
                    .Where(x => x.Class != null)
                    .GroupBy(x => new { x.Class.Id, x.Class.Course })
                    .Select(g => new
                    {
                        // AQUI ESTÁ A MUDANÇA: \n para quebrar a linha
                        Turma = $"{g.Key.Id}\n{g.Key.Course}",
                        Media = g.Any() ? g.Average(x => x.FinalScore) : 0
                    })
                    .ToList();

                var bars = new List<ScottPlot.Bar>();
                var ticks = new ScottPlot.TickGenerators.NumericManual();

                for (int i = 0; i < dadosAgrupados.Count; i++)
                {
                    var item = dadosAgrupados[i];

                    var barra = new ScottPlot.Bar()
                    {
                        Position = i,
                        Value = item.Media,
                        FillColor = ScottPlot.Colors.DodgerBlue,
                        Label = $"{item.Media:F1}"
                    };
                    bars.Add(barra);
                    ticks.AddMajor(i, item.Turma);
                }

                var barPlot = formsPlot1.Plot.Add.Bars(bars);

                // Estilo do Texto
                barPlot.ValueLabelStyle.ForeColor = ScottPlot.Colors.White;
                barPlot.ValueLabelStyle.FontSize = 14;

                // Eixos
                formsPlot1.Plot.Axes.Bottom.TickGenerator = ticks;
                formsPlot1.Plot.Axes.Bottom.TickLabelStyle.Rotation = 0; // Reto
                formsPlot1.Plot.Axes.Bottom.TickLabelStyle.Alignment = ScottPlot.Alignment.MiddleCenter; // Centralizado

                formsPlot1.Plot.Axes.SetLimitsY(0, 10); // Nota 0 a 10
                formsPlot1.UserInputProcessor.Disable();
                formsPlot1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar Média: " + ex.Message);
            }
        }

        // --- GRÁFICO 2: MELHORES ALUNOS (formsPlot2) ---
        private void CarregarGraficoMelhoresAlunos()
        {
            try
            {
                formsPlot2.Plot.Clear();
                formsPlot2.Plot.Title("Melhor Aluno por Turma");
                formsPlot2.Plot.Axes.Left.Label.Text = "Nota";
                formsPlot2.Plot.Axes.Bottom.Label.Text = "Aluno (Turma)";

                formsPlot2.Plot.FigureBackground.Color = ScottPlot.Color.FromHex("#1c1c1c");
                formsPlot2.Plot.DataBackground.Color = ScottPlot.Color.FromHex("#2d2d2d");
                formsPlot2.Plot.Axes.Color(ScottPlot.Colors.White);
                formsPlot2.Plot.Grid.MajorLineColor = ScottPlot.Color.FromHex("#404040");

                var enrollments = _enrollmentService.Get<Enrollment>(new List<string> { "Class", "Student" }).ToList();

                if (!enrollments.Any())
                {
                    formsPlot2.Plot.Title("Sem dados");
                    formsPlot2.Refresh();
                    return;
                }

                var melhoresAlunos = enrollments
                    .Where(x => x.Class != null && x.Student != null)
                    .GroupBy(x => x.Class.Course)
                    .Select(grupo =>
                    {
                        var melhor = grupo.OrderByDescending(e => e.FinalScore).FirstOrDefault();
                        return new
                        {
                            Turma = grupo.Key,
                            Aluno = melhor.Student.Name,
                            Nota = melhor.FinalScore
                        };
                    })
                    .ToList();

                var bars = new List<ScottPlot.Bar>();
                var ticks = new ScottPlot.TickGenerators.NumericManual();

                for (int i = 0; i < melhoresAlunos.Count; i++)
                {
                    var item = melhoresAlunos[i];

                    var barra = new ScottPlot.Bar()
                    {
                        Position = i,
                        Value = item.Nota,
                        FillColor = ScottPlot.Colors.MediumSeaGreen,
                        Label = $"{item.Nota:F1}"
                    };

                    bars.Add(barra);
                    // Já estava com \n aqui
                    string textoEixoX = $"{item.Aluno}\n({item.Turma})";
                    ticks.AddMajor(i, textoEixoX);
                }

                var barPlot = formsPlot2.Plot.Add.Bars(bars);
                barPlot.ValueLabelStyle.ForeColor = ScottPlot.Colors.White;
                barPlot.ValueLabelStyle.FontSize = 14;

                formsPlot2.Plot.Axes.Bottom.TickGenerator = ticks;
                formsPlot2.Plot.Axes.Bottom.TickLabelStyle.Rotation = 0;
                formsPlot2.Plot.Axes.Bottom.TickLabelStyle.Alignment = ScottPlot.Alignment.MiddleCenter;

                formsPlot2.Plot.Axes.SetLimitsY(0, 10);
                formsPlot2.UserInputProcessor.Disable();
                formsPlot2.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar Melhores Alunos: " + ex.Message);
            }
        }

        // --- GRÁFICO 3: TAXA DE APROVAÇÃO (formsPlot3) ---
        private void CarregarGraficoTaxaAprovacao()
        {
            try
            {
                formsPlot3.Plot.Clear();
                formsPlot3.Plot.Title("Taxa de Aprovação por Turma");
                formsPlot3.Plot.Axes.Left.Label.Text = "Aprovação (%)";
                formsPlot3.Plot.Axes.Bottom.Label.Text = "Turma (ID)";

                formsPlot3.Plot.FigureBackground.Color = ScottPlot.Color.FromHex("#1c1c1c");
                formsPlot3.Plot.DataBackground.Color = ScottPlot.Color.FromHex("#2d2d2d");
                formsPlot3.Plot.Axes.Color(ScottPlot.Colors.White);
                formsPlot3.Plot.Grid.MajorLineColor = ScottPlot.Color.FromHex("#404040");

                var enrollments = _enrollmentService.Get<Enrollment>(new List<string> { "Class" }).ToList();

                if (!enrollments.Any())
                {
                    formsPlot3.Plot.Title("Sem dados");
                    formsPlot3.Refresh();
                    return;
                }

                var dadosAprovacao = enrollments
                    .Where(x => x.Class != null)
                    .GroupBy(x => new { x.Class.Id, x.Class.Course })
                    .Select(grupo =>
                    {
                        double totalAlunos = grupo.Count();
                        double aprovados = grupo.Count(x => x.FinalScore >= 6.0);
                        double porcentagem = totalAlunos > 0 ? (aprovados / totalAlunos) * 100 : 0;

                        return new
                        {
                            // AQUI ESTÁ A MUDANÇA: \n para quebrar a linha
                            Turma = $"{grupo.Key.Id}\n{grupo.Key.Course}",
                            Porcentagem = porcentagem
                        };
                    })
                    .ToList();

                var bars = new List<ScottPlot.Bar>();
                var ticks = new ScottPlot.TickGenerators.NumericManual();

                for (int i = 0; i < dadosAprovacao.Count; i++)
                {
                    var item = dadosAprovacao[i];

                    var barra = new ScottPlot.Bar()
                    {
                        Position = i,
                        Value = item.Porcentagem,
                        FillColor = item.Porcentagem >= 60 ? ScottPlot.Colors.MediumSeaGreen : ScottPlot.Colors.IndianRed,
                        Label = $"{item.Porcentagem:F0}%"
                    };
                    bars.Add(barra);
                    ticks.AddMajor(i, item.Turma);
                }

                var barPlot = formsPlot3.Plot.Add.Bars(bars);
                barPlot.ValueLabelStyle.ForeColor = ScottPlot.Colors.White;
                barPlot.ValueLabelStyle.FontSize = 14;

                formsPlot3.Plot.Axes.Bottom.TickGenerator = ticks;
                formsPlot3.Plot.Axes.Bottom.TickLabelStyle.Rotation = 0;
                formsPlot3.Plot.Axes.Bottom.TickLabelStyle.Alignment = ScottPlot.Alignment.MiddleCenter;
                //formsPlot3.Plot.Axes.SetLimitsY(0, 110);
                formsPlot1.Plot.Axes.Bottom.MinimumSize = 10;
                //formsPlot3.UserInputProcessor.Disable();
                formsPlot3.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na Taxa de Aprovação: " + ex.Message);
            }
        }

        // --- NAVEGAÇÃO E HELPERS ---
        private void ExibirFormulario<TFormulario>() where TFormulario : Form
        {
            try
            {
                var form = ConfigureDI.serviceProvider.GetService<TFormulario>();
                if (form != null && !form.IsDisposed)
                {
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir: {ex.Message}");
            }
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair e voltar ao login?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Restart();
                Environment.Exit(0);
            }
        }

        // --- EVENTOS DE BOTÕES (Menus) ---
        private void Register_Class_Click(object sender, EventArgs e)
        {
            ExibirFormulario<ClassForm>();
            AtualizarDashboard(); // Recarrega gráficos ao voltar
        }

        private void Registration_CollegeSubject_Click(object sender, EventArgs e)
        {
            ExibirFormulario<CollegeSubjectForm>();
        }

        private void Register_Student_Click(object sender, EventArgs e)
        {
            ExibirFormulario<StudentForm>();
            AtualizarDashboard();
        }

        private void Enrollment_Management_Click(object sender, EventArgs e)
        {
            ExibirFormulario<EnrollmentForm>();
            AtualizarDashboard();
        }

        private void Evaluation_Management_Click(object sender, EventArgs e)
        {
            ExibirFormulario<EvaluationForm>();
            AtualizarDashboard();
        }

        // Eventos vazios mantidos para não quebrar o designer
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
    }
}