using System;

namespace GestionCitasMedicas.Models
{
    public enum EstadoCita { Programada, Cancelada, Atendida }
    
    public class Cita
    {
        public int Id { get; set; }
        public Paciente Paciente { get; set; }
        public Medico Medico { get; set; }
        public DateTime FechaHora { get; set; }
        public EstadoCita Estado { get; set; } = EstadoCita.Programada;
    }
}