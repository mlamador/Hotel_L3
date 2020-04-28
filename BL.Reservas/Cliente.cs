namespace BL.Reservas
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }

        public Cliente()
        {
            Activo = true;
        }
    }

}
