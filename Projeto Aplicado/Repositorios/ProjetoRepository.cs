using Microsoft.EntityFrameworkCore;
using Projeto_Aplicado.Context;
using Projeto_Aplicado.Entidades;
using Projeto_Aplicado.Repositorios.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Projeto_Aplicado.Repositorios
{
    public class ProjetoRepository : IProjetoRepository
    {
        private readonly AguaContext _context;

        public ProjetoRepository(AguaContext context)
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

        public void Salvar(Projeto projeto)
        {
            if(projeto.Id == 0)
                _context.Projetos.Add(projeto);
            else
                _context.Projetos.Update(projeto);
            _context.SaveChanges();
        }

        public List<Projeto> BuscarTodosProjetos()
        {
            return _context.Projetos.Include(p => p.Categoria).ToList();
        }

        public Projeto BuscarProjetoPorId(long id)
        {
            return _context.Projetos.Include(c => c.Categoria).Where(c => c.Id == id).FirstOrDefault();
        }

        public void Excluir(Projeto projeto)
        {
            _context.Projetos.Remove(projeto);
            _context.SaveChanges();
        }
    }
}
