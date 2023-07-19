// ESTRUCTURAS DE DATOS
/*
    a) Arrays
    b) Listas
    c) Colas
    d) Pilas
    e) Diccionario
 */

// ARRAY
// Inicializacion de Array
var myArray = new int[10];

// Recorro un array
for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine(myArray[i]); // De esa forma recorro el array e imprimo sus elementos
}

foreach (var item in myArray) // No especifico cuantas vueltas va a dar el bucle. Se declara una variable iteradora y decimos en que coleccion se va a iterar
{
    Console.WriteLine(item);  // Esta variable item representa cada elemento del array
}

// LISTA
// Estructura de dato que la guardo en una variable 
var personas = new List<string>();

personas.Add("Ezequiel");
personas.Add("Joaquin");
personas.Add("Eugenio");

foreach (var person in personas)
{
    Console.WriteLine(person);
}

/*
    Escribir un programa que permita al usuario confeccionar una lista de nombres. Se debe
    ofrecer las siguientes opciones: Agregar un elemento (al finalizar o en una posicion determinada), 
    quitar un elemento, mostrar en que posicion se encuentra un determinado elemento, invertir lista.
 */

var listaNombres = new List<string>();

Console.WriteLine("Bienvenido a Lista.");

string entradaUsuario;


do
{
    Console.WriteLine("Seleccione una de las siguientes opciones.");
    Console.WriteLine("1- Agregar un elemento.");
    Console.WriteLine("2- Quitar un elemento.");
    Console.WriteLine("3- Ubicar un elemento.");
    Console.WriteLine("4- Invertir un elemento.");
    Console.WriteLine("5- Ver el contenido de la lista.");
    Console.WriteLine("0- Salir.");
    Console.WriteLine();
    entradaUsuario = Console.ReadLine();

    switch (entradaUsuario)
    {
        case "1":
            Console.WriteLine("Ingrese el elemento: ");
            var nuevoElemento = Console.ReadLine();
            Console.WriteLine("Donde desea agregar el elemento?");
            Console.WriteLine("1- Al final.");
            Console.WriteLine("2- En una posicion determinada.");
            Console.WriteLine();
            var opcionIngresada = Console.ReadLine();

            switch (opcionIngresada)
            {
                case "1":
                    // Al final
                    listaNombres.Add(nuevoElemento);
                    break;
                case "2":
                    // Insertar un elemento en una posicion
                    Console.WriteLine("Ingrese posicion: ");
                    var posicionAIngresar = int.Parse(Console.ReadLine());
                    listaNombres.Insert(posicionAIngresar, nuevoElemento);
                    Console.WriteLine();
                    break;
                default:
                    break;
            }
            break;
        case "2":
            // Quitar elemento
            Console.WriteLine("Ingrese el elemento que desee quitar: ");
            var elementoARemover = Console.ReadLine();
            listaNombres.Remove(elementoARemover);// Eliminar la primera ocurrencia de un eleemnto especifico de la lista
            Console.WriteLine();
            break;
        case "3":
            // Ubicar elemento
            Console.WriteLine("Ingrese el elemento que desee ubicar: ");
            var elementoAUbicar = Console.ReadLine();
            var ubicacion = listaNombres.IndexOf(elementoAUbicar); // Que me ubique el indice de un determinado elemento.
            if (ubicacion > -1)
            {
                Console.WriteLine("El elemento se encuentra en la posicion: " + ubicacion);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Ese elemento no existe");
                Console.WriteLine();
            }
            break;
        case "4":
            // Invertir la lista
            listaNombres.Reverse();
            Console.WriteLine("La lista se ha invertido.");
            Console.WriteLine();
            Console.WriteLine(listaNombres);
            break;
        case "5":
            // Ver lista
            if (listaNombres.Count == 0)
            {
                Console.WriteLine("La lista esta  vacia.");
                Console.WriteLine();
            }
            else
            {
                foreach (var item in listaNombres)
                {
                    Console.WriteLine(item);
                }
            }
            break;
    }
}
while (entradaUsuario != "0");


