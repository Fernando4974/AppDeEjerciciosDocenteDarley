using ConsoleAppClase2Darley.modelo;
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
        Ejercicio ejercicioSeleccionado = new Ejercicio1();
        public void ControladorPrincipal(int opcion) {

        

            switch (opcion) {
            
                case 1:


                    objLista.MostrarMenuEjercicios(objLista.ListaEjercicios1);

                    entradaString = Console.ReadLine();
                    if (ejercicioSeleccionado.ValidarEnteroPositivo(entradaString))
                    {
                        entradaNum = int.Parse(entradaString);

                        switch (entradaNum) {
                            //"1", "Número de 1 o 2 dígitos" 
                            case 1:
                                ejercicioSeleccionado.Ejecutar();
                                break;

                            case 2:
                                ejercicioSeleccionado.Ejecutar();
                                break;

                        
                        }
                    }
                    else { Menu.datoInvalido(); }




                    break;
             
            
            };
        
        }
    }
}
