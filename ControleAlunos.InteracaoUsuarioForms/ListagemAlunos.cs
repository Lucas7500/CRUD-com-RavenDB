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
            var telaCadastro = new CadastroAluno();
            telaCadastro.ShowDialog();
            
            if (telaCadastro.DialogResult == DialogResult.OK) 
            {
                _repositorio.Criar(CadastroAluno.alunoPreenchido);
                AtualizarGrid();
            }
        }

        private void Ao_Clicar_Editar(object sender, EventArgs e)
        {
            var aluno = _repositorio.ObterPorId(ListaAlunos.CurrentRow.Cells["colunaId"].Value.ToString());
            var telaCadastro = new CadastroAluno(aluno);
            telaCadastro.ShowDialog();

            if (telaCadastro.DialogResult == DialogResult.OK)
            {
                _repositorio.Editar(CadastroAluno.alunoPreenchido);
                AtualizarGrid();
            }
        }

        private void Ao_Clicar_Remover(object sender, EventArgs e)
        {
            var aluno = _repositorio.ObterPorId(ListaAlunos.CurrentRow.Cells["colunaId"].Value.ToString());
            var confirmacaoRemocao = MessageBox.Show("Você tem certeza que deseja remover o aluno?", "Confirmação de Remoção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (confirmacaoRemocao == DialogResult.Yes)
            {
                _repositorio.Remover(aluno.Id);
                AtualizarGrid();
            }
        }
    }
}
