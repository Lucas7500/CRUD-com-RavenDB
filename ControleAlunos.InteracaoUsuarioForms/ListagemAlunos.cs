using ControleAlunos.Dominio.Entidades;
using ControleAlunos.Dominio.Enum;
using ControleAlunos.Infraestrutura.Interfaces;

namespace ControleAlunos.InteracaoUsuarioForms
{
    public partial class ListagemAlunos : Form
    {
        private readonly IRepositorio _repositorio;
        public ListagemAlunos(IRepositorio repositorio)
        {
            _repositorio = repositorio;
            InitializeComponent();
        }

        private void Ao_Clicar_Em_Adicionar(object sender, EventArgs e)
        {
            var aluno = new Aluno
            {
                Matricula = 202400432,
                Nome = "Lucas Moreira Iglesias",
                Email = "lucas_iglesias@discente.ufg.br",
                MediaGlobal = 8.5,
                Formacao = Formacao.Bacharelado,
                Curso = Curso.SI
            };

            _repositorio.Criar(aluno);
        }
    }
}
