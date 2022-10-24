using Projeto_Aplicado.Entidades;

namespace Projeto_Aplicado.Repositorios.Interfaces
{
    public interface IAcessoRepository
    {
        void Cadastrar(Usuario usuario);

        bool Acessa(Usuario usuario, string email, string senha);
    }
}
