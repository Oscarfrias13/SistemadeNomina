
namespace SistemadeNomina
{
    public class Empleadobasecomision : EmpleadoPorComision
    {
        List<Empleadobasecomision> empleados;
        public Empleadobasecomision()
        {
            empleados = new List<Empleadobasecomision>();
        }
        public int _salariobase {  get; set; }
       
        public override void Calcurar(Empleado empleado)

        {
            Empleadobasecomision empleadobasecomision = new Empleadobasecomision()
            {
               
            };
            this.empleados.Add(empleadobasecomision);
        }
    }
}
