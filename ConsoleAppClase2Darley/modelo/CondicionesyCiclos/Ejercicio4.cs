using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClase2Darley.modelo.CondicionesyCiclos
{
    internal class Ejercicio4: Ejercicio

    {
        public string mensaje = "Imprime de 10 en 10 partiendo del 100, llegando al -100,\n" +
            " es decir, corre de manera negativa.";



        public override void Ejecutar()
        {
            bool salida = false;
            do
            {
                Console.WriteLine(mensaje);
               Console.WriteLine( Respuesta());

                for (int i = 0; i >= -100; i-=10)
                {
                    
                    if (i % 10 == 0) { Console.WriteLine(""); }
                    Console.Write(i+", ");
                }
                Console.WriteLine("");
                salida = Salida();
            }while (!salida);
            
        }
       

    }
}
