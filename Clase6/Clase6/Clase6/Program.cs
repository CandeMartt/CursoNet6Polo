// Diferencia entre variable implicitay variables del tipo explicito

// Es casi lo mismo porque ambas variables son del tipo entero
var numero = 1; // Var no especifica a nivel de texto, pero el compilador lo va a inferir. Esta var es del tipo int porque la inicialice con un int. Lo define el compilador 

int numero2 = 4; // En la declaracion explicita lo defino con el int 

// Puedo hacer declaraciones multiples
int numero3, numero4, numero5;
// var numero3, numero4, numero5; Aqui no se puede definir que tipo de datos van a ser


//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
/* Escribir un programa que haga lo siguiente:
  
    1) Borrar la pantalla.
    2) Pedir el nombre de una persona
    3) Saludarlo con un texto que diga "Hola [NombreIngresado]!"
    4) Preguntar si se quiere continuar.
    5) Si la respuesra es "S" repetir desde el punto 1.
    6) Si la respuesta es "N" finalizar el programa mostrando un mesaje que diga "Programa finalizado correctamente."
    7) Si la respuesta no es ni "S" ni "N" que tambien finalice el programa, pero mostrando un mesaje que diga "Opcion no valida."

 */

//  SOLUCION CANDE
var respuesta = "S";
while (respuesta.ToUpper() == "S")
{
    // Borrar pantalla
    Console.Clear();

    // Pedir el nombre de la persona
    Console.Write("Ingrese su nombre, por favor: ");
    var nombre = Console.ReadLine();

    // Mostrar en pantalla el nombre de la persona
    Console.WriteLine($"Hola {nombre}!");

    // Preguntar si se quiere continuar.
    Console.WriteLine("Desea continuar? (S/N)");
    respuesta = Console.ReadLine();
}


if (respuesta.ToUpper() == "N")
{
    Console.WriteLine("Programa finalizado correctamente.");
}
else
{
    Console.WriteLine("Opcion no valida.");
}

//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

// SOLUCION VISTA EN CLASES CON EL DO-WHILE

// Primero comienza con la palabra do y define un bloque de codigo que va a ser el que se va a realizar en el bucle
// Primero se ejecuta el codigo y luego se pregunta la condicion del bucle 
string resp;                                                                                                                                                                                ; // No hace falta inicializarlo porque en la linez 75 siempre se le asigna un valor
do
{
    // Borrar pantalla
    Console.Clear();

    // Pedir el nombre de la persona
    Console.Write("Ingrese su nombre, por favor: ");
    var nomb = Console.ReadLine();

    // Mostrar en pantalla el nombre de la persona
    Console.WriteLine($"Hola {nomb}!");

    // Preguntar si se quiere continuar.
    Console.WriteLine("Desea continuar? (S/N)");
    resp = Console.ReadLine();
}
while (resp.ToUpper() == "S");

switch (resp)
{
    case "N":
        Console.WriteLine("Programa finalizado correctamente.");
        break;
    default:
        Console.WriteLine("Opcion no valida.");
        break;
}

