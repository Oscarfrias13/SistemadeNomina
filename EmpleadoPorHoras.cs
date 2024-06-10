

namespace SistemadeNomina
{
    public  class EmpleadoPorHoras : Empleado
    {
        List<Empleado> empleados;
        public EmpleadoPorHoras ()
        {
            empleados = new List<Empleado> ();
        }
        public int _sueldoporhoras { get; set; }
        public int _horastrabajadas { get; set; }

        public override void Calcurar(Empleado empleado)

        {
            EmpleadoPorHoras empleadoPorHoras = new EmpleadoPorHoras()
            {
             
            };
           this.empleados.Add (empleadoPorHoras);

            Console.WriteLine("Digite el nombre del empleado");
            _primernombre = Console.ReadLine ();


        }
    }
}
