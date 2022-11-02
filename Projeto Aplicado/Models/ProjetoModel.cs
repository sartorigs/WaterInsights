using Microsoft.AspNetCore.Http;
using Projeto_Aplicado.Entidades;
using System.Collections.Generic;

namespace Projeto_Aplicado.Models
{
    public class ProjetoModel
    {
        public long Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Itens { get; set; }
        public List<IFormFile> Imagem { get; set; }
        //public UsuarioProjeto UsuarioProjeto { get; set; }
    }
}
