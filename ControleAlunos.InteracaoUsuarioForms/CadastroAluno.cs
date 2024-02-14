using ControleAlunos.Dominio.Entidades;
using ControleAlunos.Dominio.Enum;
using ControleAlunos.Infraestrutura.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleAlunos.InteracaoUsuarioForms
{
    public partial class CadastroAluno : Form
    {
        private readonly IRepositorio _repositorio;

        public CadastroAluno(IRepositorio repositorio)
        {
            InitializeComponent();
            _repositorio = repositorio;
            comboBoxFormacao.DataSource = Enum.GetValues(typeof(FormacaoEnum));
            comboBoxCurso.DataSource = Enum.GetValues(typeof(CursoEnum));
        }

        private Aluno ObterAlunoPreenchido()
        {
            return new Aluno
            {
                Matricula = Convert.ToInt32(textBoxMatricula.Text),
                Nome = textBoxNome.Text,
                Email = textBoxNome.Text,
                MediaGlobal = Convert.ToDouble(textBoxMediaGlobal.Text),
                Formacao = (FormacaoEnum)comboBoxFormacao.SelectedItem,
                Curso = (CursoEnum)comboBoxCurso.SelectedItem,
            };
        }
        
        private void Ao_Clicar_Salvar(object sender, EventArgs e)
        {
            _repositorio.Criar(ObterAlunoPreenchido());
            Close();
        }

        private void Ao_Clicar_Cancelar(object sender, EventArgs e)
        {
            Close();
        }

    }
}
