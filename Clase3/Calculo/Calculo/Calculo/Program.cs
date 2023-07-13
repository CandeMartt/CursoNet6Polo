// Borra la pantalla
Console.Clear();


Console.WriteLine("Este programa calcula la superficie de un rectangulo");
Console.WriteLine();

Console.WriteLine("Ingrese la base del rectangulo");
// Hacer esto 
//string baseRectanguloTexto = Console.ReadLine();
//double baseRectangulo = double.Parse(baseRectanguloTexto);

// Es lo mismo que hacer esto
double baseRectangulo = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la altura del rectangulo");
double alturaRectangulo = double.Parse(Console.ReadLine());

double superficieRectangulo = baseRectangulo * alturaRectangulo;

Console.Write("La superficie del rectangulo es: ");
Console.WriteLine(superficieRectangulo);

bool esMayorADiez = superficieRectangulo > 10;

if (esMayorADiez)
{
    // Mostramos mensaje solamente si es mayor a diez
    Console.WriteLine("La superficie del rectangulo es mayor a 10");
};

Console.ReadKey();