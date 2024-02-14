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
            InitializeComponent();
            _repositorio = repositorio;
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            ListaAlunos.DataSource = null;
            ListaAlunos.DataSource = _repositorio.ObterTodos();
        }

        private void Ao_Clicar_Em_Adicionar(object sender, EventArgs e)
        {
            var telaCadastro = new CadastroAluno(_repositorio);
            telaCadastro.ShowDialog();
            telaCadastro.Close();
            AtualizarGrid();
        }
    }
}
