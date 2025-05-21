using ConsoleAppClase2Darley.vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClase2Darley.modelo
{
    internal class Ejercicio1 : Ejercicio
    {
        private string mensaje =
            "Se ingresa por teclado un número positivo de uno o dos dígitos (1..99)\n " +
            "mostrar un mensaje indicando si el número tiene uno o dos dígitos,\n " +
            "debe verificar las condiciones para evitar errores.\n";

        private string entrada =
            "------------------------------------------------------------\n" +
             "--------------- Ingrese un numero de 1 al 99: --------------\n" +
            "------------------------------------------------------------\n" ;
        

       

      
        public string ShowMensaje()
        {
            return this.mensaje;
        }
        public string ShowEntrada()
        {
            return this.entrada;
        }
        static int repetir = 0;
        public override void Ejecutar() {
           
            bool salida = false;
            Console.WriteLine(this.ShowMensaje());
            do
            {

                if (repetir!=0)
                {
                    Console.WriteLine(this.ShowMensaje());
                }
                int numeroValidado;
                repetir++;
                Console.WriteLine(this.ShowEntrada());
                string numero = Console.ReadLine();
                if (this.ValidarEnteroPositivo(numero))
                {
                    numeroValidado = int.Parse(numero);
                    if (numeroValidado<=99)
                    {
                        if (numeroValidado>9)
                        {
                            Console.WriteLine(Respuesta());
                            Console.WriteLine($"El numero {numeroValidado} tiene 2 digitos ");
                            salida=Salida();
                            
                        }
                        else
                        {
                            Console.WriteLine(Respuesta());
                            Console.WriteLine($"El numero {numeroValidado} tiene 1 solo digito ");
                            salida = Salida();
                        }
                    }
                    else
                    {
                        Console.WriteLine(this.DatoInvalido());
                        salida = false;
                        repetir = 0;
                    }
                }
                else
                {
                    Console.WriteLine(this.DatoInvalido());
                    salida = false;
                    
                }

            }while (!salida);
            repetir = 0;
          
        }

    }
}
