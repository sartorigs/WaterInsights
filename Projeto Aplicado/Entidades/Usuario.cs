using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projeto_Aplicado.Entidades
{
    public class Usuario : BaseEntity
    {
        [Required,MaxLength(45)]
        public string Nome { get; set; }
        [Required,MaxLength(45)]
        public string Sobrenome { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }
        public Regiao Regiao { get; set; } 
        public List<UsuarioProjeto> UsuarioProjeto { get; set; }
    }
}
