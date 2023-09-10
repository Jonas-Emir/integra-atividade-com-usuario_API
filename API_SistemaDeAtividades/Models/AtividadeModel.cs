using API_SistemaDeAtividades.Enums;

namespace API_SistemaDeAtividades.Models
{
    public class AtividadeModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public StatusAtividade Status { get; set; }
        public int? UsuarioId { get; set; }
        public virtual UsuarioModel? Usuario { get; set; }
    }
}
