using Projeto_Aplicado.Context;
using Projeto_Aplicado.Entidades;
using Projeto_Aplicado.Repositorios.Interfaces;

namespace Projeto_Aplicado.Repositorios
{
    public class PowerBiRepository : IPowerBiRepository
    {
        private readonly AguaContext _context;

        public PowerBiRepository(AguaContext context)
        {
            _context = context;
        }

        public void Salvar(PowerBi powerBi)
        {
            _context.PowerBis.Add(powerBi);
            _context.SaveChanges();
        }
    }
}
