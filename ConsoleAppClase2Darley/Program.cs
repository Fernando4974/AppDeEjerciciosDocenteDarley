using ConsoleAppClase2Darley.controlador;
using ConsoleAppClase2Darley.modelo;
using ConsoleAppClase2Darley.modelo.CondicionesyCiclos;
using ConsoleAppClase2Darley.vista;
string entradaString = "";
bool iniciado = false;
int entradaNum = 0;
Controlador controlador = new Controlador();
Menu.Inicio();
Console.ReadLine(); 
Menu objMostrarMenu = new Menu();

do
{
    iniciado = true;
    Ejercicio objValidarEntrada = new ConsoleAppClase2Darley.modelo.CondicionesyCiclos.Ejercicio1();

      
    objMostrarMenu.MostarCarpetas();
    

    entradaString = Console.ReadLine();
    if (objValidarEntrada.ValidarEnteroPositivo(entradaString))
    {
        entradaNum = int.Parse(entradaString);
        controlador.ControladorPrincipal(entradaNum);
    }
    else { Menu.datoInvalido(); }
  

} while (entradaNum!=0 || entradaNum!=null);    

