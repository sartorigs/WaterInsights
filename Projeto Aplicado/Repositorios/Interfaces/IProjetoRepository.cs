using Projeto_Aplicado.Entidades;
using System.Collections.Generic;

namespace Projeto_Aplicado.Repositorios.Interfaces
{
    public interface IProjetoRepository
    {
        void Cadastrar(Usuario usuario);
        void Salvar(Projeto projeto);
        List<Projeto> BuscarTodosProjetos();
        Projeto BuscarProjetoPorId(long id);
        void Excluir(Projeto projeto);
    }
}
