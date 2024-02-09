using ControleAlunos.Dominio.Entidades;
using ControleAlunos.Infraestrutura.Interfaces;

namespace ControleAlunos.Infraestrutura.Repositorios
{
    public class RepositorioRavenDB : IRepositorio
    {
        public void Criar(Aluno aluno)
        {
            using var session = DocumentStoreHolder.Store.OpenSession();

            session.Store(aluno);
            session.SaveChanges();
        }

        public void Editar(Aluno aluno)
        {
            throw new NotImplementedException();
        }

        public Aluno ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Aluno> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(int id)
        {
            throw new NotImplementedException();
        }
    }
}
