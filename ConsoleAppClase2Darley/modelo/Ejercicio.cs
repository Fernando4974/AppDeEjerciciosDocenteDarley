using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClase2Darley.modelo
{
    public abstract class Ejercicio
    {
        //variable comunes, abajo estan los get:set
       public static int num1;
       public static int num2;
       public static int num3;

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

       ;
            }

        public int[] llenarArreglo(int tamaño, string entrada)
        {
            string datoNoValidado;
            int datoValidado;
            
            int[] arregloLleno= new int[tamaño];
            for (int i = 0; i < arregloLleno.Length; i++)
            {
                Console.WriteLine(entrada);
                datoNoValidado = Console.ReadLine();
                if (validarEntero(datoNoValidado))
                {
                    datoValidado = int.Parse(datoNoValidado);
                    arregloLleno[i] = datoValidado;

                }
                else { i--; }
            }



            return arregloLleno;
        }
        //multiplicar
        public int multiplicar2Enteros(int n1, int n2)
        {
                 return n1 * n2;
        }


        public bool validarEntero(string dato)
        {

          

            if (int.TryParse(dato, out int datoValidado))
            {
                return  true;

            }else
            
            {
                Console.WriteLine("Error en la validacion");
               
                Console.ReadLine();
                return false;
            }

            
        }
        //funcion ver codigo (cambiar la ruta) (solo funciona para eje 3 / condiciones y ciclos)
        public void verCodigoFuente() {

            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "C:\\Users\\Fertch\\source\\repos\\ConsoleAppClase2Darley\\ConsoleAppClase2Darley\\modelo\\CondicionesyCiclos\\Ejercicio3.cs");
            string[] lineas = File.ReadAllLines(ruta);
            foreach (string line in lineas)
            {
                Console.WriteLine(line);

            }
            Console.ReadLine();
        }

            //GET:SET dejar hasta el fondo >>>
            public int getNum1()
        {

            return num1;
        }
        public int getNum2()
        {

            return num2;
        }
        public int getNum3()
        {

            return num1;
        }
        public void setNum1(int num)
        {

            num1 = num;
        }
        public void setNum2(int num)
        {

            num2 = num;
        }
        public void setNum3(int num)
        {

            num3 = num;
        }
    }
}
