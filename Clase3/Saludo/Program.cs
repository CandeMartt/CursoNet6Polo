// Borra la pantalla
Console.Clear();

// Pedimos al usuario que introduzca su nombre
Console.WriteLine("Hola, ingrese su nombre:");

// Leemos el nombre de usuario
string nombre;
nombre = Console.ReadLine();
Console.WriteLine("Ahora por favor, ingrese su apellido:");
string apellido;
apellido = Console.ReadLine();

// Mostramos el nombre
Console.Write("Hola " + nombre + " " + apellido);
Console.WriteLine(", este es mi segundo programa");

Console.WriteLine("Pulse cualquier letra para finalizar");
Console.ReadKey();
