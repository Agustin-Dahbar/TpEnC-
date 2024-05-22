namespace Clases
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int DNI;
        private CuentaBancaria cuentaBancaria;
        private TarjetaDeCredito tarjetaCredito;
        private Domicilio domicilio;
        private Computadora computadora;
            

        //Constructor simple.
        public Persona(string nombre, string apellido, int DNI)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.DNI = DNI;
        }

        //Mostrar domicilio
        public void printDomicilio()
        {
            if(this.domicilio != null)
            {
                Console.WriteLine(domicilio);
            }
            else
            {
                Console.WriteLine("Esta persona no tiene domicilio");
            }
        }

        //Trabajar
        private void trabajar()
        {
            Console.WriteLine("Trabajando..");
        }

        //Descansar
        private void descansar()
        {
            Console.WriteLine("Descansando..");
        }


        //Getters 
        public string getNombre()
        {
            return this.nombre;
        }

        public string getApellido()
        {
            return this.apellido;
        }

        public string getNombreCompleto()
        {
            return this.nombre + " " + this.apellido;   
        }

        public int getDNI()
        {
            return this.DNI;
        }



        //Setters

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void setApellido(string apellido)
        {
            this.apellido = apellido;
        }

        public void setDNI(int DNI)
        {
            this.DNI = DNI;
        }

        public void setDomicilio(Domicilio domicilio)
        {
            this.domicilio = domicilio;
        }



        //To string.
        public string ToString()
        {
            return "Nombre = " + this.nombre + " Apellido = " + this.apellido + " DNI = " + this.DNI;
        }
    }
}
