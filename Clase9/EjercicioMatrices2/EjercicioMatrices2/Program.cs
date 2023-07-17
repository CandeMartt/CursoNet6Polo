/* Ejercicio 2:
   
 */

Console.WriteLine("Ingrese la cantidad de numeros primos deseados: ");
int n = int.Parse(Console.ReadLine());

int[] primos = new int[n];


Console.WriteLine();
Console.WriteLine("NUMEROS PRIMOS");
// Nos va a permitir contar los 100 numeros
int posicion = 0;
int aux = 0;
int numero = 1;
while (posicion < primos.Length)
{
    aux = 0; //Contara la cantidad de divisores luego de hacer la division
    // inicia la variable en 1 porque no se puede dividir por 0
    for (int i = 1; i <= numero ; i++)
    {
        // Si el numero dividio a la variable i da como resto 0
        if(numero % i == 0) // % --> Nos devuelve el resto de una operacion
        {
            aux++; // Cuenta la cantidad de divisores que tiene un numero. Un numero primo tiene solo dos divisores
        } 
    }
    if (aux == 2) // Si al salir del bucle aux es igual a 2 ingresa al if
    {
        primos[posicion] = numero;
        posicion++;
    }
    numero++;

}
foreach (int i in primos)
{
    Console.WriteLine(i);
}