using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppClase2Darley.modelo;

namespace ConsoleAppClase2Darley.modelo.CondicionesyCiclos
{
    internal class Ejercicio2 : Ejercicio
    {
        int[] arreglo= new int[3];
   
        
         string mensaje = "Cree un programa que pida tres números e indique cual es el menor y el mayor.";
         string entrada = "------------------------------------------------------------\n" +
                                "--------------------- Ingrese un numero: -------------------\n" +
                                "------------------------------------------------------------\n";


        public override void Ejecutar() {
            bool salida = false;
            do
            {
                string datoNoValidado;
                int datoValidado;
                int contator = 0;
                Console.WriteLine(mensaje);
                int[] arregloLleno = llenarArreglo(3, entrada);
                int mayor = arregloLleno[0];
                int menor = arregloLleno[2];
                Respuesta();
                Console.Write("Numeros Ingresados:");
                foreach (var item in arregloLleno)
                {
                    Console.Write(item+", ");
                    if (item > mayor)
                    {
                        mayor = item;

                    }
                    if (item < menor)
                    {
                        menor = item;
                    }
                }
                Console.WriteLine("------------------------------------------------------------");

                Console.WriteLine("El numero mayor es: " + mayor);
                Console.WriteLine("El numero menor es: " + menor);

                salida = Salida();

            } while (!salida);


        }

      
    }
}
