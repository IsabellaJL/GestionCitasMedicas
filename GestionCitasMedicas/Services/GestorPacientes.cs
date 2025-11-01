using GestionCitasMedicas.Models;

namespace GestionCitasMedicas.Services;

public class GestorPacientes
{
    private List<Paciente> pacientes = new List<Paciente>();

    public void RegistrarPaciente(Paciente p)
    {
        if (p == null) throw new ArgumentNullException(nameof(p));
        if (pacientes.Any(x => x.Documento == p.Documento))
            throw new Exception("Ya existe un paciente con ese documento");
        
        pacientes.Add(p);
        Console.WriteLine("Paciente Registrado con exito");
    }

    public void EditarPaciente(string documento, string nuevoTelefono, string nuevoCorreo)
    {
        
    }
}