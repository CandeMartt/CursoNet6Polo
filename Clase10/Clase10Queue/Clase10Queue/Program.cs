// PILAS
var miPila = new Stack<int>();

miPila.Push(1);
miPila.Push(2);
miPila.Push(3);
miPila.Push(4);

// Salir
Console.WriteLine(miPila.Pop()); // Me devuelve los elementos con los que estoy trabajando
Console.WriteLine(miPila.Pop()); 
Console.WriteLine(miPila.Pop()); 
Console.WriteLine(miPila.Pop());

Console.WriteLine();
Console.WriteLine();

// COLAS
var miCola = new Queue<int>();

miCola.Enqueue(1);
miCola.Enqueue(2);
miCola.Enqueue(3);
miCola.Enqueue(4);

// Salir
Console.WriteLine(miCola.Dequeue());
Console.WriteLine(miCola.Dequeue());
Console.WriteLine(miCola.Dequeue());
Console.WriteLine(miCola.Dequeue());