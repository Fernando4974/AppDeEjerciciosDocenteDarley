using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClase2Darley.modelo
{
    public abstract class Ejercicio
    {
        public abstract void Ejecutar();

        public void Encabezado(int opcion)
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------\n" +
             $"----------------------- Ejercicio #{opcion} -----------------------\n" +
             "------------------------------------------------------------\n" +
              "------------------- Problema planteado: --------------------\n" +
             "------------------------------------------------------------\n");
        }
        public bool ValidarEnteroPositivo(string numero)
        {
            bool valido = false;

            if (int.TryParse(numero, out int numerovalidado) && numerovalidado >= 0)
            {
                valido = true;
            }

            return valido;
        }
        public string DatoInvalido()
        {

            string mensaje = "------------------------------------------------------------\n" +
              "!!!!! Datos ingresados no cumplen con los parametros establecidos: !!!!!\n" +
             "------------------------------------------------------------\n";
         
            return mensaje;
        }


        public bool Salida()
        {
            string salidaRespuesta = "s";
            bool salida = false;
            bool salidaBucle = false;
            do
            {

                Console.WriteLine("------------------------------------------------------------\n" +
                      "????? Marque S para Volver al Menu de Carpetas ?????\n" +
                      "????? Marque N para Repetir el ejercicio actual ?????\n" +
                     "------------------------------------------------------------\n");
                salidaRespuesta = Console.ReadLine().ToLower();
                switch (salidaRespuesta)
                {
                    case "s":
                        salida = true;
                        salidaBucle = true;
                        Console.Clear();
                        break;
                    case "n":
                        salida = false;
                        salidaBucle = true;
                        Console.Clear();
                      
                        break;
                    default:
                        salida = false;
                        salidaBucle = false;
                        Console.Clear();
                        Console.WriteLine(this.DatoInvalido());

                        break;

                }
               
            } while (!salidaBucle);
            
            return salida;
        }
        public string Respuesta() {

            string mensaje="------------------------------------------------------------\n" +
                         "************************ RESULTADOS ******************************\n"+
                        "------------------------------------------------------------\n";
            return mensaje;

        }
    }
}
