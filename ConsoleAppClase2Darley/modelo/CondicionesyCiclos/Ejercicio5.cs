using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClase2Darley.modelo.CondicionesyCiclos
{
    internal class Ejercicio5 : Ejercicio
    {
        string[,] arregloEstudiantes = new string[3,5];
        public string mensaje = "Mostrar el promedio general de 3 estudiante, que tienen 4 notas cada uno\n" +
                                "adicional mostrar el promedio de cada estudiante y que diga si ganó o perdió\n" +
                                "sabiendo que la nota mínima para ganar es 3.5.";
        public override void Ejecutar()
        {
            Console.WriteLine(mensaje);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese el nombre del estudiante numero # " + (i + 1));
                arregloEstudiantes[i, 0] = Console.ReadLine();
                for(int j = 1; j < 5; j++)
                {
                    Console.WriteLine("Ingrese la nota # "+j+ " de "+ arregloEstudiantes[i,0]);
                    arregloEstudiantes[i,j] = Console.ReadLine();

                }
            }
            int contadorA = 0;

            foreach (var item in arregloEstudiantes)
            {
               

                if (item == arregloEstudiantes[contadorA, 0])
                {
                    Console.WriteLine("");
                    Console.WriteLine(item+" : ");
                    contadorA++;

                }
                else { 
                Console.Write(item +" "); 
                }
               
            }
         
            Console.ReadLine();
            
        }
    }
}
