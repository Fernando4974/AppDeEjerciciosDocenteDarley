﻿using ConsoleAppClase2Darley.modelo;
using ConsoleAppClase2Darley.modelo.CondicionesyCiclos;
using ConsoleAppClase2Darley.vista;
using ConsoleAppClase2Darley.modelo.FuncionesyProcedimientos;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppClase2Darley.modelo.Apis;

namespace ConsoleAppClase2Darley.controlador
{





    internal class Controlador
    {
        Menu objListar = new Menu();
        string entradaString = "";
        int entradaNum = 0;
        //uso eje obj de tipo eje1 para usar su metodo de validacion (debo crearle el metodo al controlador)
        Ejercicio ejercicioSeleccionado = new modelo.CondicionesyCiclos.Ejercicio1();
        public void ControladorPrincipal(int opcion) {



            switch (opcion) {

                case 1:// carpeta Condiciones y cliclos


                    objListar.MostrarMenuEjercicios(objListar.ListaEjercicios1);

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

                            case 3:// Contador de 2 en 2 (pureba File.ReadAllLines)
                                Ejercicio objEje3 = new Ejercicio3();
                                objEje3.Encabezado(entradaNum);
                                objEje3.Ejecutar();

                                break;
                            case 4://de o a -100
                                Ejercicio objEje4 = new Ejercicio4();
                                objEje4.Encabezado(entradaNum);
                                objEje4.Ejecutar();
                                break;
                            case 5://promedio de 3
                                Ejercicio objEje5 = new Ejercicio5();
                                objEje5.Encabezado(entradaNum);
                                objEje5.Ejecutar();

                                break;
                            case 6:// clave 1111
                                Ejercicio objEje6 = new Ejercicio6();
                                objEje6.Encabezado(entradaNum);
                                objEje6.Ejecutar();
                                break;
                            case 7: // raiz cuadrada
                                Ejercicio objEje7 = new Ejercicio7();
                                objEje7.Encabezado(entradaNum);
                                objEje7.Ejecutar();
                                break;
                        }
                    }
                    else { Menu.datoInvalido(); }




                    break;



                //Carpeta Funciones y procedimientos
                case 2:

                    objListar.MostrarMenuEjercicios(objListar.ListaEjercicios2);
                    entradaString = Console.ReadLine();
                    if (ejercicioSeleccionado.ValidarEnteroPositivo(entradaString))
                    {
                        entradaNum = int.Parse(entradaString);
                        switch (entradaNum) {
                            case 1://Multiplicación de dos números con funciones
                                Ejercicio objEje1 = new modelo.FuncionesyProcedimientos.Ejercicio1();
                                objEje1.Encabezado(entradaNum);
                                objEje1.Ejecutar();

                                break;


                            case 8://nomina 10 obreros
                                Ejercicio objEje8 = new modelo.FuncionesyProcedimientos.Ejercicio8();
                                objEje8.Encabezado(entradaNum);
                                objEje8.Ejecutar();
                                break;

                            case 9://calculadore clase
                                Ejercicio objCal = new Calculadora();
                                objCal.Encabezado(entradaNum);
                                objCal.Ejecutar();
                                break;
                            case 10://tecer vector reprobados
                                Ejercicio objEjeTercer = new EjercicioVectorC();
                                objEjeTercer.Encabezado(entradaNum);
                                objEjeTercer.Ejecutar();
                                break;

                            case 11: // vector 125

                                Ejercicio objVec125= new EjercicioVector125();
                                objVec125.Encabezado(entradaNum);
                                objVec125.Ejecutar();

                                break;

                            case 12://vector N
                                Ejercicio ejeVectN= new EjercicioVectorN();
                                ejeVectN.Encabezado(entradaNum);
                                ejeVectN.Ejecutar();
                                break;
                        }
                         }

                        break;
                case 3:
                    objListar.MostrarMenuEjercicios(objListar.ListaApis);
                    entradaString = Console.ReadLine();
                    if (ejercicioSeleccionado.ValidarEnteroPositivo(entradaString))
                    {
                        entradaNum= int.Parse(entradaString);
                        switch (entradaNum)
                        {
                            case 1:
                                Ejercicio EjeApi1 = new modelo.Apis.EjercicioApi1();
                                EjeApi1.Encabezado(entradaNum);
                                EjeApi1.Ejecutar();
                                break;
                        }

                    }
                    else { ejercicioSeleccionado.DatoInvalido(); }
                    break;

                        
            }
        }
    }
}
