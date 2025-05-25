using Mysqlx.Cursor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClase2Darley.modelo.CondicionesyCiclos
{
    internal class Ejercicio3:Ejercicio
    {
        private const string mensaje = " imprime la numeración del 0 al 25, de 2 en 2.";
        private const string entrada = "------------------------------------------------------------\n" +
                                       "************************ Sin Datos De Entrada ******************************\n" +
                        "------------------------------------------------------------\n";
        public override void Ejecutar()
        {
            for (int i = 0; i <=25; i=i+2)
            {
                if (i<24)
                {
                    Console.Write(i + ", ");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }

            Console.WriteLine("Desea ver el codigo fuente de este algoritmo? S/N");
            if (Console.ReadLine().ToUpper()=="S")
            {
                verCodigoFuente();
            }
        }
    }
}
