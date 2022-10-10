using System.ComponentModel.DataAnnotations;

namespace Projeto_Aplicado.Entidades
{
    public class Regiao : BaseEntity
    { 

        [MaxLength(80)]
        public string Bairro { get; set; }
        [MaxLength(2)]
        public string Estado { get; set; }
        [MaxLength(80)]
        public string Cidade { get; set; }
        public long UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

    }
}
