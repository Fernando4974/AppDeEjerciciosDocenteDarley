using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClase2Darley.modelo.FuncionesyProcedimientos
{
    internal class Ejercicio8 : Ejercicio
    {
        string mensaje = "Desarrolle un algoritmo para la empresa Constructora de Casas,\n" +
                         "que le permita calcular e imprimir la nómina para su paga a un\n" +
                         "total de 10 obreros.La hora trabajada se pautó en 30.000 pesos,\n" +
                         "mas de 8 horas son extras(usar los precios colombianos)";
        string entrada = "-----------------------------------------------\n" +
                        "Ingrese las horas totales trabajadas del empleado ";

        string entradaExtra = "-----------------------------------------------\n" +
                              "Ingrese la canditad de horas extras trabajadas \n" +
                              "-----------------------------------------------";
        public int[,] horas = new int[4, 2];
        string dato = "";
        bool salida = false;
        public override void Ejecutar()
        {

            Console.WriteLine(mensaje);
            do
            {
                for (int i = 0; i < horas.GetLength(0); i++)
                {
                    do
                    {
                        salida = false;

                        Console.WriteLine($"{entrada} 0000{i+1}");
                        dato= Console.ReadLine();
                        if (!string.IsNullOrEmpty(dato))
                        {
                            if (ValidarEnteroPositivo(dato))
                            {
                                horas[i, 0] = int.Parse(dato);

                                Console.WriteLine(entradaExtra);
                                dato = Console.ReadLine();
                                if (!string.IsNullOrEmpty(dato))
                                {
                                    if (ValidarEnteroPositivo(dato))
                                    {
                                        horas[i, 1] = int.Parse(dato);
                                        salida = true;
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
                            else
                            {
                                DatoInvalido();
                            }

                        }
                        else
                        {
                            DatoInvalido();
                        }
                    } while (!salida);






                }
                for (int j = 0;  j < horas.GetLength(0); j++)
                {
                    double he= 30000+(30000 * 0.75);//precio de hora extra
                    he = he * horas[j, 1];//catidad por total de horas extras
                    double tp = (horas[j, 0] - horas[j, 1]);//horas totales menos extras
                    tp = (tp * 30000)+(he);//pago de horas normal mas pago de horas extras

                    Console.WriteLine($"Empleado 0000{j+1}\n          Horas trabajadas: {horas[j,0]}\n          Horas Extras: {horas[j,1]} \n           Total a Pagar : {tp}");
                }
            } while (!Salida());
           
        }
    }
}
                




            


       
   
