using System.ComponentModel;

namespace API_SistemaDeAtividades.Enums
{
    public enum StatusAtividade
    {
        [Description("A fazer")]
        AFazer = 1,
        [Description("Em andamento")]
        EmAndamento = 2,
        [Description("Concluído")]
        Concluido = 3



    }
}
