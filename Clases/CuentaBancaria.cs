using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class CuentaBancaria
    {

        private string CBU;
        private TipoCuenta tipo;
        private Persona titular;
        private int saldo;

        public CuentaBancaria(string CBU, TipoCuenta tipo, Persona titular, int saldo)
        {
            this.CBU = CBU;
            this.tipo = tipo;
            this.titular = titular;
            this.saldo = saldo; 
        }

        public String getCBU()
        {
            return this.CBU;
        }

        public TipoCuenta getTipo()
        {
                return this.tipo;
        }

        public Persona getTitular()
        {
            return this.titular;
        }

        public int getSaldo()
        {
            return this.saldo;
        }

        public void setCBU (String CBU)
        {
            this.CBU = CBU;
        }

        public void setTipo(TipoCuenta tipo)
        {
            this.tipo = tipo;
        }

        public void setTitular(Persona titular)
        {
            this.titular = titular;
        }

        public void setSaldo(int saldo)
        {
            this.saldo = saldo;
        }
    }
}
