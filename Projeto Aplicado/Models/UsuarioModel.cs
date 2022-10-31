using System;
using System.ComponentModel.DataAnnotations;

namespace Projeto_Aplicado.Models
{
    public class UsuarioModel
    {
        public long id { get; set; }
        public object Id { get; internal set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
    }
}
