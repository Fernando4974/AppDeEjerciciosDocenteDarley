using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClase2Darley.modelo.CondicionesyCiclos
{
    internal class Ejercicio6 : Ejercicio
    {
        string mensaje = "Crea un programa que pida al usuario su contraseña (numérica). Deberá terminar\n" +
            "cuando introduzca como contraseña el número 1111, pero volvérsela a pedir\n" +
            "tantas veces como sea necesario.";
        string entrada = "Introduzca su contraseña";
        int intentos = 0;
        public override void Ejecutar()
        {
            string contraseña="1111";
          
          
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine(mensaje);
                    Console.WriteLine(entrada);
                    Console.WriteLine("Intentos: "+intentos);
                    intentos++;
                  
                   
                }
                while (Console.ReadLine()!=contraseña);
                

                Console.WriteLine("FIN || "+ "Intentos: "+intentos);
            }
            while (!Salida());
        

        }
    }
}
