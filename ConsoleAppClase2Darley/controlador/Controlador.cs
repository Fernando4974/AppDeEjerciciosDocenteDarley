using ConsoleAppClase2Darley.modelo;
using ConsoleAppClase2Darley.modelo.CondicionesyCiclos;
using ConsoleAppClase2Darley.vista;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClase2Darley.controlador
{





    internal class Controlador
    {
        Menu objLista = new Menu();
        string entradaString = "";
        int entradaNum = 0;
        //uso eje obj de tipo eje1 para usar su metodo de validacion (debo crearle el metodo al controlador)
        Ejercicio ejercicioSeleccionado = new modelo.CondicionesyCiclos.Ejercicio1();
        public void ControladorPrincipal(int opcion) {

        

            switch (opcion) {
            
                case 1:


                    objLista.MostrarMenuEjercicios(objLista.ListaEjercicios1);

                    entradaString = Console.ReadLine();
                    if (ejercicioSeleccionado.ValidarEnteroPositivo(entradaString))
                    {
                        entradaNum = int.Parse(entradaString);

                        switch (entradaNum) {
                           
                            case 1: //"1", "Número de 1 o 2 dígitos" 

                                ejercicioSeleccionado.Encabezado(entradaNum);
                                ejercicioSeleccionado.Ejecutar();
                                break;

                            
                            case 2: // "2" "Mayor y menor de 3 numeros"

                                Ejercicio objEje2 = new Ejercicio2();
                               objEje2.Encabezado(entradaNum);
                               objEje2.Ejecutar();
                                break;

                        
                        }
                    }
                    else { Menu.datoInvalido(); }




                    break;
             
            
            };
        
        }
    }
}
