namespace Projeto_Aplicado.Entidades
{
    public class UsuarioProjeto : BaseEntity
    {
        public int Likes { get; set; }
        public int Deslikes { get; set; }

        public long UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public long ProjetoId { get; set; }
        public Projeto Projeto { get; set; }


    }
}
