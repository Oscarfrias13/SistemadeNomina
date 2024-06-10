


namespace SistemadeNomina
{
    public abstract class Empleado
    {
        public string? _primernombre { get; set; }
        public string? _apellidos { get; set; }
        public string? _numerodeidentificacion { get; set; }
        public abstract void Calcurar(Empleado empleado);

    }


}
