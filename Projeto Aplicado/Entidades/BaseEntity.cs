using System.ComponentModel.DataAnnotations;

namespace Projeto_Aplicado.Entidades
{
    public class BaseEntity
    {
        [Key,Required]
        public long Id { get; set; }
    }
}
