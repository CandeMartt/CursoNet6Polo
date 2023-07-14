// CICLO
// CICLO WHILE

// Lo inicializamos a cero
Console.WriteLine("Cuantas vueltas quiere dar?");
var totalDeVueltas = int.Parse(Console.ReadLine());

var contador = 0;


while (contador < totalDeVueltas) // Mientras el contador sea menor al total de vueltas el ciclo va a seguir dando vueltas. Cuando no se cumpla sale
{
    // Va a ir contando las vueltas que va dando
    contador++; // es lo mismo que escribir contador = contador + 1
    Console.WriteLine("Seguimos dando vueltas. Vuelta numero: " + contador);

}


Console.WriteLine("Cuantas vueltas quiere dar?");
//// Se declaran las variables por fuera del ciclo porque sino cada vez que entre al ciclo se vuelve a inicializar en cero, es decir se crea y se detruye constantemente
var respuesta = "S"; //Lo inicializamos como string porque sino nos tirara un error
var contador2 = 0;

while (respuesta.ToUpper() != "N")
{
    contador2++;
    Console.WriteLine("Seguimos dando vueltas. Vuelta numero: " + contador2);
    Console.WriteLine("Seguimos? (S/N)");
    respuesta = Console.ReadLine();
}

// CICLO FOR
//   declaracion;      condicion;     paso
for (var cantCara = 0; cantCara <= 12; cantCara++)
{
    //Console.WriteLine("Mi bolsita tiene: " + cantCara + " caramelos.");
    Console.WriteLine($"Mi bolsita tiene {cantCara} caramelos.");
    // El for arranca con el valor especificado en en la declaracion de la variable y el paso lo hace al finalizar la ejecucion

    // cantCara+=2 es lo mismo que cantCara = cantCara + 2
    // cantCara-=8 es lo mismo que cantCara = cantCara - 8
}

var cantCar = 0;
while (cantCar < 12)
{
    Console.WriteLine("Mi bolsita tiene " + cantCar + " caramelos.");
    cantCar++; // El for de arriba es equivalente a hacer este ciclo while con el contador AL FINAL DE LA EJECUCION
              //  El incremento se hace al final de la ejecucion
}

var cantCaram = 0;
while (cantCaram < 12)
{
    cantCaram++; // El incremento se hace al principio de la ejecucion
    Console.WriteLine("Mi bolsita tiene " + cantCaram + " caramelos.");
}