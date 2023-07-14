// Condicional if
// Ejemplo de condicional if

Console.WriteLine("Ingrese su edad: "); // Le pedimos al usuario que ingrese su edad
int edad = int.Parse(Console.ReadLine()); // Obtenemos la edad por teclado
Console.WriteLine("Ingrese su equipo de futbol");
string equipo = Console.ReadLine();

Console.WriteLine("La edad ingresada es: " + edad);

/* Operadores
    AND -> && (Y)
    OR -> || (O)
    IGUAL QUE-> ==
    DISTINTO QUE-> != 
*/

bool condicion = edad < 18 && equipo == "River";
if (condicion) // Evaluamos la edad 
{
    // Intrucciones si se cumple la condicion evaluada
    Console.WriteLine("Usted es menor de edad.");
    Console.WriteLine("Usted tiene prohibida la entrada.");
}
else
{
    // Intrucciones si no se cumple la condicion evaluada
    Console.WriteLine("Usted es mayor de edad.");
}


// Ejercicio if-elseif-else
Console.WriteLine("Ingrese su edad: ");
int edad2 = int.Parse(Console.ReadLine());

if (edad2 < 0 || edad2 > 110)
{
    Console.WriteLine("La edad no es valida."
        );
}
else if (edad2 < 12)
{
    Console.WriteLine("Va a la primaria");
}
else if (edad2 < 18)
{
    Console.WriteLine("Va a la secundaria");
}
else if (edad2 < 28)
{
    Console.WriteLine("Va a la universidad");
}
else
{
    Console.WriteLine("A trabajar!");
}


//Ejercicio if-else anidados
Console.Write("Ingrese numero 1: ");
int numero1 = int.Parse(Console.ReadLine());

Console.Write("Ingrese numero 2: ");
var numero2 = int.Parse(Console.ReadLine());

Console.Write("Ingrese numero 3: ");
int numero3= int.Parse(Console.ReadLine());

if(numero1 > numero2)
{
    if(numero1 > numero3)
    {
        Console.WriteLine("El primer numero es el mayor: " + numero1);
    }
    else
    {
        Console.WriteLine("El tercer numero es el mayor: " + numero3);
    }
}
else
{
    if(numero2 > numero3)
    {
        Console.WriteLine("El segundo numero es el mayor: " + numero2);
    }
    else
    {
        Console.WriteLine("El tercer numero es el mayor: " + numero3);
    }
}


//Ejercicio switch
Console.WriteLine("Ingrese el primer numero: ");
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero: ");
double num2 = double.Parse(Console.ReadLine());

Console.WriteLine("1 - Suma");
Console.WriteLine("2 - Resta");
Console.WriteLine("3 - Multiplicacion");
Console.WriteLine("4 - Division");


Console.WriteLine("Ingrese la operacion a iniciar: ");
string operacion = Console.ReadLine();

double resultado = 0;

switch (operacion)
{
	case "1":
        resultado = num1 + num2;
		Console.WriteLine("Sumando ...");
		break;
    case "2":
        resultado = num1 - num2;
        Console.WriteLine("Restando ...");
        break;
    case "3":
        resultado = num1 * num2;
        Console.WriteLine("Multiplicando ...");
        break;
    case "4" when num2 != 0:
        resultado = num1 / num2;
        Console.WriteLine("Dividiendo ...");
        break;
    default:
        Console.WriteLine("Opcion no valida");
		break;
}

Console.WriteLine("El resultado es: " + resultado);