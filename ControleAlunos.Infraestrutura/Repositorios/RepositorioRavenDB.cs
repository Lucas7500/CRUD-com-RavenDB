using ControleAlunos.Dominio.Entidades;
using ControleAlunos.Infraestrutura.Interfaces;
using Raven.Client.Documents.Session;

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
            using var session = DocumentStoreHolder.Store.OpenSession();
            var alunoEdicao = ObterPorId(aluno.Id);
            
            alunoEdicao.Matricula = aluno.Matricula;
            alunoEdicao.Nome = aluno.Nome;
            alunoEdicao.Email = aluno.Email;
            alunoEdicao.MediaGlobal = aluno.MediaGlobal;
            alunoEdicao.Formacao = aluno.Formacao;
            alunoEdicao.Curso = aluno.Curso;
            
            session.SaveChanges();
        }

        public Aluno ObterPorId(string id)
        {
            using var session = DocumentStoreHolder.Store.OpenSession();
            return session.Load<Aluno>(id);
        }

        public List<Aluno> ObterTodos()
        {
            using var session = DocumentStoreHolder.Store.OpenSession();

            return [.. session.Query<Aluno>()];
        }

        public void Remover(string id)
        {
            throw new NotImplementedException();
        }
    }
}
