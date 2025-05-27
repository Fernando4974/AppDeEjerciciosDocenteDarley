using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClase2Darley.modelo.CondicionesyCiclos
{
    internal class Ejercicio7 : Ejercicio
    {
        string mensaje = "Crea un calculador de cuadrados, pedirá al usuario un número y mostrará su"+
                            "cuadrado\n.Se repetirá mientras el número introducido no sea cero(usa while para conseguirlo)";

        string entrada = "Ingresa un numero para calcular su cuadrado\n";
     
        public override void Ejecutar()
        {
            bool flag = false;
            Console.WriteLine(mensaje);
            double num = 0;
            string num_ = "";

            while (!flag)
            {
                Console.WriteLine(entrada);
                num_ = Console.ReadLine();
                if (!string.IsNullOrEmpty(num_) )
                {
                    if (ValidarEnteroPositivo(num_))
                    {
                        num = Math.Sqrt(int.Parse(num_));
                        Respuesta();
                        Console.WriteLine(num);
                        if (Salida())
                        {
                            flag = true;
                        }
                    }
                    else
                    {
                        DatoInvalido();
                    }
                }
                else
                {
                    DatoInvalido();
                }

            }
        }
    }
}
