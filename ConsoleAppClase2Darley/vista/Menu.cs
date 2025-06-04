using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClase2Darley.vista
{
    internal class Menu
    {//Carpeta Condiciones y ciclos
        public string[,] ListaEjercicios1 = new string[15, 2] {

    { "1", "Número de 1 o 2 dígitos" },
    { "2", "Mayor y menor de tres números" },
    { "3", "Numeración del 0 al 25 (de 2 en 2)" },
    { "4", "De 100 a -100 (de 10 en 10)" },
    { "5", "Promedio de 3 estudiantes (4 notas)" },
    { "6", "Contraseña hasta acertar (1111)" },
    { "7", "Calculador de cuadrados (while)" },
    { "8", "( UNDEVELOPED!! )Pares del 256 al -132 (while)" },
    { "9", "( UNDEVELOPED!! )Adivinar número (3 intentos)" },
    { "10", "( UNDEVELOPED!! )Suma de impares del 300 al 400" },
    { "11", "( UNDEVELOPED!! )Pagos crecientes por 20 meses" },
    { "12", "( UNDEVELOPED!! )Triángulo de números" },
    { "13", "( UNDEVELOPED!! )Imprimir 1 al 100 con 'PUMM!!'" },
    { "14", "( UNDEVELOPED!! )Votación entre 3 candidatos" },
    { "15", "( UNDEVELOPED!! )Operar según el valor de entrada" }

        };

        // Carpeta ejercicio Funfiones y procedimientos
        public string[,] ListaEjercicios2 = new string[,]
        {
    { "1", "Multiplicación de dos números con funciones" },
    { "2", "( UNDEVELOPED!! )Mostrar números del 1 al 100 con método" },
    { "3", "( UNDEVELOPED!! )Calculadora con switch y funciones" },
    { "4", "( UNDEVELOPED!! )Cuadrado de un número usando función" },
    { "5", "( UNDEVELOPED!! )Comparar dos números con método" },
    { "6", "( UNDEVELOPED!! )Mayor y menor entre tres números distintos" },
    { "7", "( UNDEVELOPED!! )Promedio de notas hasta ingresar cero" },
    { "8", "Cálculo de nómina para 10 obreros (horas extra)" },
    { "9", "Calculadora En Clases" },
    { "10", "Tercer Vector Reprobados"},
    { "11", "Vector 125"},
     { "12", "Vector N"}
        };


        // Carpeta de apis
        public string[,] ListaApis = new string[,]
        {
             { "1 GET", "https:/jsonplaceholder.typicode.com/posts/1"}

        };
        //lista carpetas

        public static string[,] ListaCarpetas = new string[,] {


         { "1", "Condiciones y Ciclos"},
            { "2"," Funciones y Procedimientos"},
            {"3"," Respuestas de Apis" }

        };

           

        
        

        
        public static void Inicio(){
            
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("------------------------- Ejercicios Propuestos C# -------------------------");
            Console.WriteLine("----------------------------------- Por: -----------------------------------");
            Console.WriteLine("---------------------------- Fernando Villarreal ---------------------------");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("---------------------------------- Docente: --------------------------------");
            Console.WriteLine("------------------------------- Edison Suarez ------------------------------");
            Console.WriteLine("--------------------------------- SENA 2025 --------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine(@"                   _________           __      __");
            Console.WriteLine(@"                  /         |         |  |    |  | ");
            Console.WriteLine(@"                 |     _____|     ____|  |____|  |____");
            Console.WriteLine(@"                 |    /          |____    ____    ____|");
            Console.WriteLine(@"                 |    |               |  |    |  |");
            Console.WriteLine(@"                 |    |           ____|  |____|  |____");
            Console.WriteLine(@"                 |    |          |____    ____    ____|     ");
            Console.WriteLine(@"                 |    \_____          |  |    |  | ");
            Console.WriteLine(@"                 |          |         |__|    |__| ");
            Console.WriteLine(@"                  \_________|                         ©Fertch");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(@"                             Enter para Iniciar...");
        }
        public void MostarCarpetas()
        {
            Console.Clear();
            int opcion;
            Console.WriteLine("MENU CARPETAS --------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("--------- Seleccione La Carpeta de Ejercicios que Desea Acerder ------------");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------");
            for (int i = 0; i < ListaCarpetas.GetLength(0); i++)
            {
                Console.WriteLine($"------------Marque {ListaCarpetas[i, 0]} para {ListaCarpetas[i, 1]}");
            }
        }
        public void MostrarMenuEjercicios(String[,] ListaEjercicio) {
            Console.Clear();
            int opcion;
            Console.WriteLine("MENU EJERCICIOS ------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("--------------- Seleccione el ejercicio que desea ejecutar -----------------");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------");
            for (int i = 0; i < ListaEjercicio.GetLength(0); i++)
            {
                Console.WriteLine($"------------Marque {ListaEjercicio[i,0]} para {ListaEjercicio[i,1]}" );
    
            }
           


        }
        public static void datoInvalido() {

            Console.WriteLine("----------------------------------------------------------------------------\n" +
                "---------------------- Dato Invalido ---------------------------------------\n" +
                "---------------------- Enter Para Continuar ---------------------------------");
            Console.ReadLine();
        
        }
    }
}
