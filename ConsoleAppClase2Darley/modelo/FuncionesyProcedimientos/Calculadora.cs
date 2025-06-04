using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClase2Darley.modelo.FuncionesyProcedimientos
{
    class Calculadora :Ejercicio
    {
        double num2;
        double num1Validado;
        public override void Ejecutar()
        {
            
            string[] operaciones = new string[] { 
            "1 Suma","2 Resta","3 Multipicacion","4 Division"};
             
            do
            {
                Console.WriteLine("Ingrese El primer numero");
                string num1 = Console.ReadLine();
                if (!string.IsNullOrEmpty(num1))
                {
                    num1Validado=double.Parse(num1);
                }
                

               Console.WriteLine("Ingrese el tipo de operacion que desea hacer");
                foreach (var item in operaciones)
                {
                    Console.WriteLine(item);
                }
                int operacion = int.Parse(Console.ReadLine());
              
                switch (operacion-1) {
                    

                    case 0:
                        Console.WriteLine("Ingrese el segundo Valor para sumar");
                         this.num2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Resultado = " + suma(num1Validado, num2));
                        break;
                    case 1:
                        Console.WriteLine("Ingrese el segundo Valor para restar");
                       this.num2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Resultado = "+resta(num1Validado, num2));
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el segundo Valor para multiplicar");
                        this.num2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Resultado = " + resta(num1Validado, num2));
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el segundo Valor para dividir");
                        this.num2 = double.Parse(Console.ReadLine());
                        if (this.num2!=0)
                        {
                            
                            Console.WriteLine("Resultado = " + div(num1Validado, num2));
                        }
                        else
                        {
                            Console.WriteLine(DatoInvalido());
                        }

                        break;

                }
                Salida();
            }
            while (!Salida());
        }

        public double suma(double n1, double n2) { return n1 + n2; }
        public double resta(double n1, double n2) { return n1 - n2; }
        public double multi(double n1, double n2) { return n1 * n2; }
        public double div(double n1, double n2) { return n1 / n2; }

    }
}
