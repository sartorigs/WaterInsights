namespace Projeto_Aplicado.Entidades
{
    public class PowerBi : BaseEntity
    {
        public int value1 { get; set; }
        public int value2 { get; set; }
        public int value3 { get; set; }
        public int value4 { get; set; }
        public int value5 { get; set; }
        public long UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
