using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClase2Darley.modelo.FuncionesyProcedimientos
{
    internal class EjercicioVectorC : Ejercicio
    {
        string mensaje = "1.Cargar 2 vectores, uno con los códigos de los estudiantes que perdieron C,\n" +
                           "el segundo con los códigos de los estudiantes que perdieron Java.\n" +
                           "Se pide crear otro arreglo formado por los códigos de  los estudiantes\n" +
                           "que perdieron  ambas materias.  Mostrar el arreglo resultante\n";
        string[] perdioC = new string[5];
        string[] perdioJava = new string[5];
        string[] tercerArreglo = new string[10];


    
        public override void Ejecutar()
        {
            do
            {

                Console.WriteLine(mensaje);

            perdioC =llenarArreglosYaCreados(perdioC,1);
            perdioJava = llenarArreglosYaCreados(perdioJava, 3);
            LLenartercerArreglo(perdioC,perdioJava);
                Console.Write("Perdieron C: ");
                foreach (var item in perdioC)
                {
                    Console.Write(item+" ");
                }
                Console.WriteLine("\n");
                Console.Write("Perdieron Java: ");
                foreach (var item in perdioJava)
                {
                    Console.Write(item+" ");
                }
                Console.WriteLine("\n");
                Console.Write("Perdieron Ambas: ");
                foreach (var item in tercerArreglo)
            {
                    if (item != null)
                    {
                        Console.Write(item + " ");
                    }
                    
            }
                Console.WriteLine("");

            }
            while (!Salida());

        }
        public void LLenartercerArreglo(string[]aRR1, string[]aRR2) {

            for (int i = 0; i < aRR1.Length; i++)
            {
                for (int j = 0; j < aRR2.Length; j++)
                {
                    if (aRR1[i] == aRR2[j])
                    {
                        tercerArreglo[i] = aRR1[i];
                    }
                }
            }



            
        }
        //abtraido a SuperClase Ejercicio.cs
       /* public string[] llenarArreglosYaCreados(string[] arreglo, int diferencial)
        {
          
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = $"0000{i + diferencial}";
            }
            return arreglo;
        }*/
}
};