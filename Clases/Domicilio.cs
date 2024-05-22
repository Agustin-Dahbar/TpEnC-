using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Domicilio
    {

        //Atributos
        private string calle;
        private int numero;
        private string barrio;

        //Constructor
        public Domicilio(string calle, int numero, string barrio)
        {
            this.calle = calle;
            this.numero = numero;
            this.barrio = barrio;
        }   


        //Getters
        public string getCalle()
        {
            return this.calle;
        }

        public int getNumero()
        {
            return this.numero;
        }


        public string getBarrio()
        {
            return this.barrio;
        }

        //Setters
        public void setCalle(string calle)
        {
            this.calle = calle;
        }

        public void setNumero(int numero) 
        { 
            this.numero = numero;
        }

        public void setBarrio(string barrio)
        {
            this.barrio = barrio;
        }

        //ToString
        public string ToString()
        {
            return "Calle = " + this.calle + " Numero = " + this.numero + " Barrio = " + this.barrio;
        }
    }
}
