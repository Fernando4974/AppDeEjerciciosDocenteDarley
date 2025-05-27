using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleAppClase2Darley.modelo.FuncionesyProcedimientos
{
    internal class Ejercicio1 :Ejercicio
    {
        string mensaje = "Hacer un programa que ingrese dos números por consola y los multiplique usando\r\nfunciones y métodos.";
        string entrada = "------------------- Ingrese el numero -------------------";
                static int cont = 1;

        string dato1 = "";
        string dato2 = "";
        public override void Ejecutar()
        {
           
            do
            {
                Console.WriteLine(mensaje);
                do
                {
                    Console.WriteLine(entrada + " "+cont );
                    dato1 = Console.ReadLine();
                    cont++;
                    Console.WriteLine(entrada + " "+ cont);
                    dato2 = Console.ReadLine();
                    cont = 1;

                }
                while (!validarEntero(dato1) && !validarEntero(dato2));
                setNum1(int.Parse(dato1));
                setNum2(int.Parse(dato2));
                Console.WriteLine(Respuesta());
                Console.WriteLine(multiplicar2Enteros(getNum1(),getNum2()));
                cont = 0;
            }
            while (!Salida());



        }
    }
}
