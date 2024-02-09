using System.ComponentModel;

namespace ControleAlunos.Dominio.Enum
{
    public enum Curso
    {
        [Description("Sistemas de Informação")]
        SI,
        [Description("Engenharia de Software")]
        ES,
        [Description("Ciências da Computação")]
        CC,
        [Description("Inteligência Artificial")]
        IA
    }
}
