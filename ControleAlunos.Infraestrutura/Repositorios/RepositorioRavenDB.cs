using ControleAlunos.Dominio.Entidades;
using ControleAlunos.Infraestrutura.Interfaces;
using Raven.Client.Documents.Session;

namespace ControleAlunos.Infraestrutura.Repositorios
{
    public class RepositorioRavenDB : IRepositorio
    {
        private static IDocumentSession AbrirSessao()
        {
            return DocumentStoreHolder.Store.OpenSession();
        }

        public List<Aluno> ObterTodos()
        {
            using var session = AbrirSessao();

            return [.. session.Query<Aluno>()];
        }
        
        public Aluno ObterPorId(string id)
        {
            using var session = AbrirSessao();
            return session.Load<Aluno>(id);
        }

        public void Criar(Aluno aluno)
        {
            using var session = AbrirSessao();
            session.Store(aluno);
            session.SaveChanges();
        }

        public void Editar(Aluno aluno)
        {
            using var session = AbrirSessao();

            var alunoEdicao = session.Load<Aluno>(aluno.Id);
            alunoEdicao.Matricula = aluno.Matricula;
            alunoEdicao.Nome = aluno.Nome;
            alunoEdicao.Email = aluno.Email;
            alunoEdicao.MediaGlobal = aluno.MediaGlobal;
            alunoEdicao.Formacao = aluno.Formacao;
            alunoEdicao.Curso = aluno.Curso;

            session.SaveChanges();
        }

        public void Remover(string id)
        {
            using var session = AbrirSessao();
            session.Delete(id);
            session.SaveChanges();
        }
    }
}
