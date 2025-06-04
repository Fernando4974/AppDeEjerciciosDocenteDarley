using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClase2Darley.modelo.FuncionesyProcedimientos
{
    internal class EjercicioVectorN : Ejercicio
    {
        string mensaje = "3. Leer un vector de N elementos numéricos enteros y posteriormente:\n" +
                        "Mostrar cuántas  veces  se repite el número 10.\n" +
                        "Sume los elementos de las posiciones pares.\n" +
                        "Muestre los elementos del vector empezando por el último elemento.\n\n";
        string entrada = "--------------------------------------------------------------------------\n" +
                            "Ingrese el tamaño del vector\n" +
            "--------------------------------------------------------------------------\n";
        public override void Ejecutar()
        {
            do
            {
                Console.WriteLine(mensaje);
                Console.WriteLine(entrada);
                int[] vector=llenarArreglo(int.Parse(Console.ReadLine()));
                Console.WriteLine(Respuesta());
                Console.WriteLine($"Vector tamaño {vector.Length}, generado aleatoriamente");
                mostrarVector(vector);
                Console.WriteLine("\nEl 10 se Repite "+valoresRepetidos(vector)+" veces");
                Console.WriteLine("La suma de la posiciniones pares es :"+posicionesPares(vector));
                Console.WriteLine("Vector invertido: ");
                mostrarVectorInvertido(vector);
                


            }
            while (!Salida());
        }
        public int[] llenarArreglo(int n) {

            int[] arreglo = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i]= rnd.Next(0,11);
            }

            return  arreglo;
        }
        public int valoresRepetidos(int[]_arreglo)
        {
            int cant = 0;
            for (int i = 0; i < _arreglo.Length; i++)
            {
                if (_arreglo[i] ==10)
                {
                    cant++;
                }
            }
            return cant;
        }
        public int posicionesPares(int[] _arreglo)
        {
            int sum = 0;
            for (int i = 0; i < _arreglo.Length; i++)
            {
                if (i%2==0)
                {
                    sum += _arreglo[i];
                }
            }
            return sum;
        }
        public void mostrarVector(int[] _arreglo)
        {
            foreach (var item in _arreglo)
            {
                Console.Write(item+" ");
            }

        }
        public void mostrarVectorInvertido(int[]_arreglo)
        {
            for (int i = _arreglo.Length-1; i >= 0; i--)
            {
                Console.Write(_arreglo[i]+" ");
            }
            Console.WriteLine("");
        }
    }
}
