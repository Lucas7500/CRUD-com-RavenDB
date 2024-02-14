using ControleAlunos.Dominio.Entidades;
using ControleAlunos.Dominio.Enum;
using ControleAlunos.Infraestrutura.Interfaces;

namespace ControleAlunos.InteracaoUsuarioForms
{
    public partial class CadastroAluno : Form
    {
        public static Aluno alunoPreenchido = new();
        private readonly IRepositorio _repositorio;

        public CadastroAluno(Aluno? aluno = null)
        {
            InitializeComponent();
            
            if (aluno != null)
            {
                alunoPreenchido = aluno;
                PreencherCadastroEdicao();
            }

            comboBoxFormacao.DataSource = Enum.GetValues(typeof(FormacaoEnum));
            comboBoxCurso.DataSource = Enum.GetValues(typeof(CursoEnum));
        }

        private void PreencherCadastroEdicao()
        {
            textBoxMatricula.Text = alunoPreenchido.Matricula.ToString();
            textBoxNome.Text = alunoPreenchido.Nome.ToString();
            textBoxEmail.Text = alunoPreenchido.Email.ToString();
            textBoxMediaGlobal.Text = alunoPreenchido.MediaGlobal.ToString();
            comboBoxFormacao.SelectedItem = alunoPreenchido.Formacao;
            comboBoxCurso.SelectedItem = alunoPreenchido.Curso;
        }

        private void PreencherAluno()
        {
            alunoPreenchido.Matricula = Convert.ToInt32(textBoxMatricula.Text);
            alunoPreenchido.Nome = textBoxNome.Text;
            alunoPreenchido.Email = textBoxEmail.Text;
            alunoPreenchido.MediaGlobal = Convert.ToDouble(textBoxMediaGlobal.Text);
            alunoPreenchido.Formacao = (FormacaoEnum)comboBoxFormacao.SelectedItem;
            alunoPreenchido.Curso = (CursoEnum)comboBoxCurso.SelectedItem;
        }
        
        private void Ao_Clicar_Salvar(object sender, EventArgs e)
        {
            PreencherAluno();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Ao_Clicar_Cancelar(object sender, EventArgs e)
        {
            Close();
        }

    }
}
