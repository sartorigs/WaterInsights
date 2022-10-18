using Microsoft.EntityFrameworkCore;
using Projeto_Aplicado.Context;
using Projeto_Aplicado.Entidades;
using Projeto_Aplicado.Repositorios.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Projeto_Aplicado.Repositorios
{
    public class AcessoRepository : IAcessoRepository
    {
        private readonly AguaContext _context;

        public AcessoRepository(AguaContext context)
        {
            _context = context;
        }
        public void Cadastrar(Usuario usuario)
        {
            if (usuario.Id == 0)
            {
                _context.Usuarios.Add(usuario);
            }
            else
            {
                _context.Usuarios.Update(usuario);
            }
            _context.SaveChanges();
        }
    }
}
