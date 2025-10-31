namespace GestionCitasMedicas.Models
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Documento { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
    }
}