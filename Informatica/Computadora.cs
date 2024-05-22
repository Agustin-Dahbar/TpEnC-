namespace Clases
{
    public class Computadora
    {
        private string marca;
        private TipoComputadora tipo;
        private Procesador procesador;
        private LectoraDVD lectoraDVD;
        private Boolean apagada = false;

        public Computadora(string marca, TipoComputadora tipo, Procesador procesador, LectoraDVD lectoraDVD)
        {
            this.marca = marca;
            this.tipo = tipo;
            this.procesador = procesador;
            this.lectoraDVD = lectoraDVD;
        }


       public void prender()
        {
            Console.WriteLine("Prendiendo");
        }

        public void vicear()
        {
            Console.WriteLine("A vicear..");
        }
        
        public void apagar()
        {
            if (apagada)
            {
                Console.WriteLine("Apagando..");
            }

            Console.WriteLine("¿Apagar? ¿Que es eso? ");
        }

        public void reiniciar()
        {
            Console.WriteLine("Reiniciando..");
        }

    }
}
