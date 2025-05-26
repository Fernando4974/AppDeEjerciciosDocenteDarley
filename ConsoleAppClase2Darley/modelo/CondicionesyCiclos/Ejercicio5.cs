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

        string[,] arregloEstudiantes = new string[3, 5];
        double[,] resultadosEtudiantes = new double[3, 4];
        public string mensaje = "Mostrar el promedio general de 3 estudiante, que tienen 4 notas cada uno\n" +
                                "adicional mostrar el promedio de cada estudiante y que diga si ganó o perdió\n" +
                                "sabiendo que la nota mínima para ganar es 3.5.";
        public override void Ejecutar()
        {
            bool salida = false;
            do
            {
                Console.WriteLine(mensaje);
                string numeroSinValidar;
                int numeroValidado = 0;
                double promedioTodosCalculado;
                double promedio1 = 0;
                double promedio2 = 0;
                double promedio3 = 0;
                double promAll = 0;

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese el nombre del estudiante numero # " + (i + 1));
                    arregloEstudiantes[i, 0] = Console.ReadLine();

                    resultadosEtudiantes[i, 0] = 0;


                    bool flag = false;

                    for (int j = 1; j < 5; j++)
                    {
                        do
                        {

                            Console.WriteLine("Ingrese la nota # " + j + " de " + arregloEstudiantes[i, 0]);
                            numeroSinValidar = Console.ReadLine();

                            double promI = 0;


                            if (ValidarEnteroPositivo(numeroSinValidar) && int.Parse(numeroSinValidar) <= 5)
                            {
                                numeroValidado = int.Parse(numeroSinValidar);
                                arregloEstudiantes[i, j] = numeroSinValidar;
                                promI += numeroValidado;
                                if (i == 0)
                                {
                                    promedio1 += double.Parse(arregloEstudiantes[i, j]);
                                }
                                else if (i == 1)
                                {
                                    promedio2 += double.Parse(arregloEstudiantes[i, j]);
                                }
                                else if (i == 2) { promedio3 += double.Parse(arregloEstudiantes[i, j]); }
                                flag = true;


                            }
                            else
                            {
                                Console.WriteLine(DatoInvalido());
                                flag = false;
                            }
                        } while (flag == false);


                    }

                }
                double[] promedios = new double[3];
                promedios[0] = promedio1 / 4;
                promedios[1] = promedio2 / 4;
                promedios[2] = promedio3 / 4;
                promAll = (promedios[0] + promedios[1] + promedios[2]) / 3;
                //promedioTodosCalculado = calcularPromedioArregloConNombresEn0(arregloEstudiantes);
                int contadorA = 0;
                Console.WriteLine(Respuesta());
                Console.WriteLine(Respuesta());
                for (int i = 0; i < 3; i++)
                {
                    bool paso = promedios[i] >= 3.5;

                    Console.WriteLine(); // Salto de línea
                    Console.WriteLine($"Promedio {arregloEstudiantes[i, 0]}: {promedios[i]} Aprobo: {paso} || Notas:");

                    for (int j = 1; j < 5; j++)
                    {
                        Console.Write(arregloEstudiantes[i, j] + " ");
                    }

                    Console.WriteLine(); // Otra línea para separar estudiantes
                }
                Console.WriteLine("");
                Console.WriteLine("Promedio Genereal:  " + promAll);
                contadorA = 0;
               
            }
            while (!Salida());
        }
    }
}