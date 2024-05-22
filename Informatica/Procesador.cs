using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Procesador
    {
        private string marca;
        private int modelo;
        private int nivelTemperatura;

        public void temperaturaAlta()
        {
            if(this.nivelTemperatura > 95)
            {
                Console.WriteLine("Temperatura elevada. Cuidado.");
            }
        }



    }
}
