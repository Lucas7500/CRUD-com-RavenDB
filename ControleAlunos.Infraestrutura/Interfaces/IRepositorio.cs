using ControleAlunos.Dominio.Entidades;

namespace ControleAlunos.Infraestrutura.Interfaces
{
    public interface IRepositorio
    {
        public List<Aluno> ObterTodos();
        public Aluno ObterPorId(int id);
        public void Criar(Aluno aluno);
        public void Editar(Aluno aluno);
        public void Remover(int id);
    }
}
