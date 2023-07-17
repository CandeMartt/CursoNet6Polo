// EJERCICIOS MATRICES
/* 
    Ejercicio 1:

    Se dispone de un array de N numeros aleatorios.
    Diseñar un programa que permita insertar un valor X en una posicion especifica que determine el usuario.
 */

// GENERAMOS EL ARRAY
Console.WriteLine("Ingrese el tamaño deseado para el listado: ");
int n = int.Parse(Console.ReadLine()); // Console.ReadLine(): Lee el dato ingresado por consola

int [] vector = new int[n];

// Es una clase matematica del System
Random aleatorio = new Random(); // Genera numeros aleatorios. Aleatorio es una variable del tipo Random

for (int i = 0; i < vector.Length; i++) // Length: Obtiene el total de los elementos del array
{
    vector[i] = aleatorio.Next(100); // Next es una propiedad de la clase random el cual devuelve un numero entero. Le indicamos que queremos numeros menor al 100
}

Console.WriteLine();
Console.WriteLine("Los datos generados son: ");

int contador = 0;
// Para mostrar los valores
foreach (int i in vector) // El foreach recorre dentro. Para cada elemento del vector 
{
    contador++;
    Console.WriteLine("Posicion "+ contador+ ": " +i );
}


// POSICION A MODIFICAR
Console.WriteLine();
Console.WriteLine("Ingrese posicion a modificar: ");
var posicion = int.Parse(Console.ReadLine());


if (posicion > vector.Length || posicion < 0)
{
    Console.WriteLine("Posicion incorrecta.");
}
else
{
    Console.WriteLine("Ingrese el nuevo valor: ");
    while (true) // Bucle infinito
    {
        var nuevoValor = int.Parse(Console.ReadLine());
        if (nuevoValor > 0 && nuevoValor < 100)
        {
            // Debemos ponerle el -1 porque el largo del vector no es igual a las posiciones.
            // Por ejemplo nuestro vector tiene 0 al 9 posiciones, por lo que su largo son 10. Si la persona pusiera el valor 10 (haciendo referencia a la ultima posicion)
            // y nosotro no le restamos 1 para indicarle que es la posicion 9, nos generara un error porque el 10 esta por fuera del array
            vector[posicion - 1] = nuevoValor;
            break; // Para salir del bucle infinito
        }
        else
        {
            Console.WriteLine("RecuerdE que el valor debe ser positivo menor que 100."); 
        }
    }

    // Para mostrar los valores
    foreach (int i in vector)
    {
        contador++;
        Console.WriteLine("Posicion " + contador + ": " + i + " ");
    }
}

