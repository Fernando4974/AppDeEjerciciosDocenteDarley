using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleAppClase2Darley.modelo.FuncionesyProcedimientos
{
    internal class EjercicioVector125 : Ejercicio
    {
        Random random = new Random();
        int[] vector= new int[125];
        string mensaje= " Se tiene un vector de 125 elementos con  valores  numéricos, realice lo siguiente:\n\n"+
            "Hallar y mostrar el valor promedio del vector.\n\n"+
            "Leer  un  valor x  y   buscar  en  que posición  del  vector  se encuentra.\n\n" +
            "Llene un vector con los elementos de las posiciones impares\n\n"+
            "Busque cuántos elementos del vector son múltiplos de 3 y positivos.\n\n";
        public override void Ejecutar()
        {
            do
            {

                Console.WriteLine(mensaje);
                llenarMostrarPromVector125(vector);
                buscarValor();
            }
            while (!Salida());
        }
        public void llenarMostrarPromVector125(int[] _vector) {
            int[] vectorImpares = new int[125];
            double prom = 0;
            int contP3= 0;
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Valores:");
            for (int i = 0; i < _vector.Length; i++)
            {
                _vector[i] = random.Next(-150, 150);
                prom+= _vector[i];
                if (_vector[i]>0 && _vector[i]%3==0)
                {
                    contP3++;
                    
                }
                if (i%2!=0)
                {
                    vectorImpares[i] = _vector[i];
                }
                Console.Write(_vector[i]+ " ");
                if (i%10==0)
                {
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("El promedio de lo valores es: "+(prom/_vector.Length));
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("El el vector, encontramos "+contP3+ " valores que son múltiplos de 3 y positivos");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Valores en Posiciones Impares");
            contP3 = 0;
            foreach (var item in vectorImpares)
            {
               
                if (item != 0)
                {
                    Console.Write(item + " ");
                }
                if (contP3%10==0)
                {
                    Console.WriteLine("");   
                }
                contP3++;
            }



            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("");
        }
        public void buscarValor() {

            Console.WriteLine("ingrese un valor para saber si existe y cual es su posicion");
            string dato= Console.ReadLine();
            bool flag= false;
            
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i].ToString() == dato)
                {
                    Console.WriteLine($"Valor {dato} encontrado en la posicion {i}");
                    flag = true;
                }
                
            }
            if (!flag) { Console.WriteLine("Valor no encontrado"); }
            Console.WriteLine("--------------------------------------------------------------------");

        }
        
    }
}
