using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class TarjetaDeCredito
    {
        private string numero;
        private string titular;
        private double limiteDeCompra;
        private double acumuladoActual;

        public TarjetaDeCredito(string numero, string titular, double limiteDeCompra)
        {
            this.numero = numero;
            this.titular = titular;
            this.limiteDeCompra = limiteDeCompra;
            this.acumuladoActual = 0;
        }


        public string getNumero()
        {
            return this.numero;
        }

        public string getTitular()
        {
            return this.titular;
        }

        public double getLimiteDeCompra()
        {
            return this.limiteDeCompra;
        }

        public double getAcumuladoActual()
        {
            return this.acumuladoActual;
        }

        public void setNumero(string numero) 
        {  
            this.numero = numero; 
        }

        public void setTitular(string titular)
        {
            this.titular = titular;
        }

        public void setLimiteDeCompra(double limiteDeCompra)
        {
            this.limiteDeCompra = limiteDeCompra;
        }

        //Le restamos lo gastado al limite para saber cuanto nos queda disponible para gastar.
        public double montoDisponible()
        {
            if(this.acumuladoActual > this.limiteDeCompra)
            {
                double monto = 0;
                return 0;
            }
            else
            {
                double monto = this.limiteDeCompra - this.acumuladoActual;
                return monto;
            }
        }

        private Boolean compraPosible(int monto)
        {
            if(monto > this.limiteDeCompra)
            {
                return false;
            }
            
            return true; //Evitamos un innecesario else{}
        }

        //Realizamos la compra. Utilizamos el metodo anterior para comprobar si es posible según lo argumentado al metodo.
        public Boolean realizarCompra(int monto)
        {
            if (compraPosible(monto))
            {
                this.acumuladoActual += monto; //Actualizamos el acumulado del gasto.
                return true;
            }

            return false;
        }

        //Aumentamos el gasto via argumentación.
        private void acumularGastoActual(int gasto)
        {
            this.acumuladoActual += gasto;
        }

        //Actualizamos el limite para la compra.
        public void actualizarLimite(double nuevoLimite)
        {
            this.limiteDeCompra = nuevoLimite;
        }

        //ToString()
        public String toString()
        {
            return "TarjetaDeCredito [numero=" + numero + ", titular=" + titular + ", limite=" + limite
                    + ", acumuladoActual=" + montoDisponible() + "]";
        }

    }
}
