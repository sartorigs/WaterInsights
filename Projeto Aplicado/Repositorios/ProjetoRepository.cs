using Microsoft.EntityFrameworkCore;
using Projeto_Aplicado.Context;
using Projeto_Aplicado.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Projeto_Aplicado.Repositorios
{
    public class ProjetoRepository
    {
        private readonly AguaContext _context;

        public ProjetoRepository(AguaContext context)
        {
            _context = context;
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
