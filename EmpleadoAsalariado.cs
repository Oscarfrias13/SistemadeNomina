
namespace SistemadeNomina
{
    public class EmpleadoAsalariado : Empleado
    {
        List<Empleado> empleados;
        public EmpleadoAsalariado()
        {
            empleados = new List<Empleado>();
        }
        public int _salariosemanal {  get; set; }

        public override void Calcurar(Empleado empleado)
        {
            
            EmpleadoAsalariado empleadoAsalariado = new EmpleadoAsalariado()
            {
              
            };
           this.empleados.Add(empleadoAsalariado);

        }
    }
}
