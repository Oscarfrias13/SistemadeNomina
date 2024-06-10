
namespace SistemadeNomina
{
    public class EmpleadoPorComision : Empleado
    {
        List<Empleado> empleados;
        public EmpleadoPorComision()
        {
            empleados = new List<Empleado>();
        }
     public int _ventasbrutas {  get; set; }
     public double _tarifacomision {  get; set; }

        public override void Calcurar(Empleado empleado)
        {
            EmpleadoPorComision empleadoPorComision = new EmpleadoPorComision()
            {
             
            };
            this.empleados.Add(empleadoPorComision);
        }
    }
}
