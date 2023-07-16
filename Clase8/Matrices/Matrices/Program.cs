// VECTOR

// Ingresamos el tamaño del vector
Console.WriteLine("Ingrese la cantidad de alumnos");
int cantAlumnos = int.Parse(Console.ReadLine());

//tipo[] nombre = new tipo[tamaño]
int[] notas = new int[cantAlumnos];

Console.WriteLine("Ingrese las notas de cada alumno");
Console.WriteLine();

// Recorremos el vector para cargar
for (int i = 0; i < notas.Length; i++) // Posicion determinada por la variable i
{
    Console.WriteLine($"Nota del alumno N° {i+1}");
    notas[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine();
Console.WriteLine("=========================================================");
Console.WriteLine();

for (int i = 0; i < notas.Length; i++) // Posicion determinada por la variable i
{
    Console.WriteLine($"Nota del alumno N° {i+1}: {notas[i]}");
}




// MATRICES MULTIPLES

Console.WriteLine("NOTAS DE EXAMENES");
Console.WriteLine("Ingrese la cantidad de alumnos: ");
int cantidadAlumnos = int.Parse(Console.ReadLine());  //Determina las columnas

Console.WriteLine("Ingrese las cantidad de notas por alumno: ");
int cantidadNotas= int.Parse(Console.ReadLine()); // Determina las filas

//tipo[,] nombre = new tipo[tamañoFilas, tamañoColumnas]
int[,] calificaciones = new int[cantidadNotas, cantidadAlumnos];

// Cantidad de filas 
// El metodo devuelve el ultimo metodo de la matriz. Arranca desde cero. Le sumamos uno para obtener la cantidad 
int lengthFilas = calificaciones.GetUpperBound(0) + 1; // Entre parentesis va a el indice de la dimension

// Cantidad de columnas
int lengthColumnas = calificaciones.GetUpperBound(1) + 1;

// ASIGNAMOS LAS NOTAS
// Recorre las columnas
for (int columna = 0; columna < lengthColumnas; columna++)
{
    Console.WriteLine("============================================================================");
    Console.WriteLine();
    Console.WriteLine($"Notas del alumno N° {columna +1}");

    // Recorre las filas
    for (int fila = 0; fila < lengthFilas; fila++) // Hasta que no termine de recorrer este for no va a pasar a la siguiente columna
    {
        Console.WriteLine($"Cargue la nota N° {fila + 1}");
        calificaciones[fila,columna] = int.Parse(Console.ReadLine()); // Guarda la nota en la posicion correpondiente
    }
}


// MOSTRAMOS LAS NOTAS EN CONSOLA
// Recorre las columnas
for (int columna = 0; columna < lengthColumnas; columna++)
{
    Console.WriteLine("============================================================================");
    Console.WriteLine();
    Console.WriteLine($"Notas del alumno N° {columna + 1}");

    // Recorre las filas
    for (int fila = 0; fila < lengthFilas; fila++) 
    {
        Console.WriteLine($"La nota N° {fila + 1}: {calificaciones[fila,columna]}");

        /*
            Si queremos un valor de una posicion concreta de la matriz
            
            if (fila == 2 && colimna == 0)
            {
                Console.WriteLine($"La nota N° {fila + 1}: "}
                Console.WriteLine(calificaciones[fila,columna]);
            }
         */
    }
}

// Obtenemos un valor de una posicion concreta
// int calificacion3 = calificaciones[2,0];