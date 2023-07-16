// Array
string[] cars = { "Ford", "Fiat", "Renault", "Toyota" };
Console.WriteLine(cars[0]);

string[] Frutas = new string[4];

Frutas[0] = "Pera";
Frutas[1] = "Manzana";
Frutas[2] = "Banana";
Frutas[3] = "Kiwi";

Console.WriteLine(Frutas[2]);

int [] numeros = new int[5];
Console.WriteLine($"El array tiene {numeros.Length} posiciones. ");

//Console.WriteLine("Ingrese el primer numero: ");
//numeros[0] = int.Parse(Console.ReadLine());

//Console.WriteLine("Ingrese el segundo numero: ");
//numeros[1] = int.Parse(Console.ReadLine());

//Console.WriteLine("Ingrese el tercero numero: ");
//numeros[2] = int.Parse(Console.ReadLine());

//Console.WriteLine("Ingrese el cuarto numero: ");
//numeros[3] = int.Parse(Console.ReadLine());

//Console.WriteLine("Ingrese el quinto numero: ");
//numeros[4] = int.Parse(Console.ReadLine());


// i son las posiciones que tiene nuestro array
for(int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Por favor ingrese el numero {i+1}: ");
    // La variable i la usamos como indice de nuestro array 
    numeros[i] = int.Parse(Console.ReadLine()); 
}



int acumulador = 0;
for (int i = 0; i < numeros.Length; i++)
{
    acumulador = acumulador + numeros[i];
}
Console.WriteLine($"El resultado de la suma es: {acumulador}");

// TAREA
// Indique por consola cual es el numero mayor dentro del array
Console.WriteLine("Los valores son");
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}
Console.WriteLine($"El dato mayor es: {numeros.Max()}");