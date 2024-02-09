using ControleAlunos.Dominio.Enum;

namespace ControleAlunos.Dominio.Entidades
{
    public class Aluno
    {
        public string Id { get; set; } = string.Empty;
        public int Matricula {  get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public double MediaGlobal { get; set; }
        public Formacao Formacao { get; set; }
        public Curso Curso { get; set; }
    }
}
