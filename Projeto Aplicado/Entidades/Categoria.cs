using Projeto_Aplicado.Entidades.Enum;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projeto_Aplicado.Entidades
{
    public class Categoria : BaseEntity
    {
        [Required]
        public DefinicaoCategoria DefinicaoCategoria { get; set; }
        public List<Projeto> Projetos { get; set; }
    }
}
