using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projeto_Aplicado.Entidades
{
    public class Projeto : BaseEntity
    {
        [MaxLength(45),Required]
        public string Titulo { get; set; }
        [MaxLength(255),Required]
        public string Descricao { get; set; }
        [MaxLength(255)]
        public string Itens { get; set; }
        public string Imagem { get; set; }
        public List<UsuarioProjeto> UsuarioProjeto { get; set; }

    }
}
