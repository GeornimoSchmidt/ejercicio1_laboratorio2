using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1_laboratorio2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Mostrar numero al azar del 1 al 100

            int miliseg = DateTime.Now.Millisecond;
            int dado = miliseg % 100 + 1;
            Console.WriteLine("El numero del dado es " + dado);
            Console.ReadKey();
        }
    }
}
