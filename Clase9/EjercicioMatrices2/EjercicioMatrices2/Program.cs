/* Ejercicio 2:
   Mostrar por consola la cantidad de numeros primos que una persona desea calcular.
 */

Console.WriteLine("Ingrese la cantidad de numeros primos deseados: "); // Pedimos por teclado la cantidad para determinar el tamano que va a tener el array
int n = int.Parse(Console.ReadLine());

int[] primos = new int[n];


Console.WriteLine();
Console.WriteLine("NUMEROS PRIMOS");

int posicion = 0; // La posicion dentro del array 
int aux = 0; // Lo vamos a ir aumentando la cantidad de veces que nos da 0. Cantidad de veces que un nuemro es divisible
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
                  // Si el auxiliar es dos significa que es divisible por uno y por si mismo.
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