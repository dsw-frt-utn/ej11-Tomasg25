using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList casolist = new CasoList();

        Alumno a2 = new Alumno(58142, "Pedro", 8.0);
        casolist.AgregarAlumno(new Alumno(58141, "Tomas" , 7.5));
        casolist.AgregarAlumno(a2);
        casolist.AgregarAlumno(new Alumno(58143, "Santiago" , 6.5));

        Console.WriteLine("Listado de alumnos:\n");
        foreach (Alumno item in casolist.GetAlumnos())
        {
            Console.WriteLine($"Legajo: {item.Id} - Nombre: {item.Nombre} - Promedio: {item.Promedio}");
        }

        Console.WriteLine("\nPresione una tecla para continuar...");
        Console.ReadKey();

        Console.Clear();
        Console.WriteLine("Buscar alumno por nombre 'Pedro':\n");
        
        Alumno? alumnoBuscado = casolist.BuscarAlumnoNombre("Pedro");

        if (alumnoBuscado != null)
        {
            Console.WriteLine($"ID: {alumnoBuscado.Id} -  Nombre: {alumnoBuscado.Nombre} - Promedio: {alumnoBuscado.Promedio}");
        }

        Console.WriteLine("\nPresione una tecla para continuar...");
        Console.ReadKey();

        Console.Clear();
        Console.WriteLine("Buscar alumno por nombre 'Marcos':\n");
        Alumno? alumno = casolist.BuscarAlumnoNombre("Marcos");
        if (alumno == null)
        {
            
            Console.WriteLine("No existe");
        }

        Console.WriteLine("\nPresione una tecla para continuar...");
        Console.ReadKey();

        Console.Clear();
        Console.WriteLine("Eliminar alumno con ID 58142:\n");
        if (casolist.EliminarAlumno(a2))
        {
            Console.WriteLine("Alumno eliminado exitosamente.\n");
        }
        else
        {
            Console.WriteLine("No se pudo eliminar el alumno.\n");
        }

        Console.WriteLine("Alumnos en la lista después de la eliminación:\n");
        foreach (var item in casolist.GetAlumnos())
        {
            Console.WriteLine($"ID: {item.Id} - Nombre: {item.Nombre} - Promedio: {item.Promedio}");
        }

        Console.WriteLine("\nPresione una tecla para continuar...");
        Console.ReadKey();

        Console.Clear();
        Console.WriteLine("Eliminar el primer alumno de la lista:\n");
        if (casolist.EliminarAlumnoPosicion(0))
        {
            Console.WriteLine("Primer alumno eliminado correctamente.\n");
        }
        else
        {
            Console.WriteLine("No se pudo eliminar.\n");
        }
        Console.WriteLine("Alumnos en la lista después de la eliminación:\n");
        foreach (var item in casolist.GetAlumnos())
        {
            Console.WriteLine($"ID: {item.Id}, Nombre: {item.Nombre}, Promedio: {item.Promedio}");
        }
    }
    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary casoDictionary = new CasoDictionary();

        
        casoDictionary.AgregarAlumno(new Alumno(58141, "Tomas", 9.8));
        casoDictionary.AgregarAlumno(new Alumno(58142, "Pedro", 8.5));
        casoDictionary.AgregarAlumno(new Alumno(58143, "Santiago", 7.2));

        Console.WriteLine("Alumnos en el diccionario:\n");
        foreach (var item in casoDictionary.GetAlumnos())
        {
            Console.WriteLine($"ID: {item.Key} - Nombre: {item.Value.Nombre} - Promedio: {item.Value.Promedio}");
        }

        Console.WriteLine("\nPresione una tecla para continuar...");
        Console.ReadKey();

        Console.Clear();
        Console.WriteLine("Buscar alumno con ID 58141:\n");
        Alumno? alumnoBuscado = casoDictionary.BuscarAlumno(58141);

        if (alumnoBuscado != null)
        {
            Console.WriteLine(alumnoBuscado);
        }

        Console.WriteLine("\nPresione una tecla para continuar...");
        Console.ReadKey();

        Console.Clear();
        Console.WriteLine("Buscar alumno con ID 58146:\n");
        Alumno? alumno = casoDictionary.BuscarAlumno(58146);
        if (alumno == null)
        {
            Console.WriteLine("No existe");
        }

        Console.WriteLine("\nPresione una tecla para continuar...");
        Console.ReadKey();

        // Eliminar un alumno por clave y listar por consola los alumnos
        Console.Clear();
        Console.WriteLine("Eliminar alumno con ID 58143:\n");
        if (casoDictionary.EliminarAlumno(58143))
        {
            Console.WriteLine("Alumno eliminado exitosamente.\n");
        }
        else
        {
            Console.WriteLine("No se pudo eliminar el alumno.\n");
        }
        Console.WriteLine("Alumnos en el diccionario después de la eliminación:\n");
        foreach (var item in casoDictionary.GetAlumnos())
        {
            Console.WriteLine($"ID: {item.Key} - Nombre: {item.Value.Nombre} - Promedio: {item.Value.Promedio}");
        }

    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq casoLinq = new CasoLinq();

        // 1. Obtener el primer libro
        Console.WriteLine("Obtener el primer libro:");
        Libro primerLibro = casoLinq.GetPrimero();
        Console.WriteLine($"ID: {primerLibro.Id} - Título: {primerLibro.Titulo} - Precio: {primerLibro.Precio:C}");


        // 2. Obtener el último libro
        Console.WriteLine("\nObtener el último libro:");
        Libro ultimoLibro = casoLinq.GetUltimo();
        Console.WriteLine($"ID: {ultimoLibro.Id} - Título: {ultimoLibro.Titulo} - Precio: {ultimoLibro.Precio:C}");

        Console.WriteLine("\nPresione una tecla para continuar...");
        Console.ReadKey();

        // 3. Obtener el total de precios
        Console.Clear();
        Console.WriteLine("Obtener el total de precios:");
        decimal totalPrecios = casoLinq.GetTotalPrecios();
        Console.WriteLine($"Total de precios: {totalPrecios:C}");

        // 4. Obtener el promedio de precios
        Console.WriteLine("\nObtener el promedio de precios:");
        decimal promedioPrecios = casoLinq.GetPromedioPrecios();
        Console.WriteLine($"Promedio de precios: {promedioPrecios:C}");

        Console.WriteLine("\nPresione una tecla para continuar...");
        Console.ReadKey();

        // 5. Obtener la lista de libros con ID > 15
        Console.Clear();
        Console.WriteLine("Obtener la lista de libros con ID > 15:\n");
        foreach (var libro in casoLinq.GetListById())
        {
            Console.WriteLine($"Titulo: {libro.Titulo} - Precio: {libro.Precio :C}");
        }

        Console.WriteLine("\nPresione una tecla para continuar...");
        Console.ReadKey();

        // 6. Obtener una lista de cada libro con su título y precio en formato moneda
        Console.Clear();
        Console.WriteLine("Obtener una lista de cada libro con su título y precio en formato moneda:\n");
        foreach (var titulo in casoLinq.GetLibros())
        {
            Console.WriteLine(titulo);
        }

        Console.WriteLine("\nPresione una tecla para continuar...");
        Console.ReadKey();

        // 7. Obtener el libro con el mayor precio
        Console.Clear();
        Console.WriteLine("Obtener el libro con el mayor precio:");
        Libro libroMayorPrecio = casoLinq.GetMayorPrecio();
        Console.WriteLine($"ID: {libroMayorPrecio.Id} - Título: {libroMayorPrecio.Titulo} - Precio: {libroMayorPrecio.Precio:C}");

        // 8. Obtener el libro con el menor precio
        Console.WriteLine("\nObtener el libro con el menor precio:");
        Libro libroMenorPrecio = casoLinq.GetMenorPrecio();
        Console.WriteLine($"ID: {libroMenorPrecio.Id}, Título: {libroMenorPrecio.Titulo}, Precio: {libroMenorPrecio.Precio:C}");

        Console.WriteLine("\nPresione una tecla para continuar...");
        Console.ReadKey();

        // 9. Obtener una lista de libros con precio mayor al promedio
        Console.Clear();
        Console.WriteLine("Obtener una lista de libros con precio mayor al promedio:\n");
        foreach (var libro in casoLinq.GetMayorPromedio())
        {
            Console.WriteLine($"Titulo: {libro.Titulo} - Precio: {libro.Precio:C}");
        }

        Console.WriteLine("\nPresione una tecla para continuar...");
        Console.ReadKey();

        //10. Obtener los libros ordenados por título de forma descendente
        Console.Clear();
        Console.WriteLine("Obtener los libros ordenados por título de forma descendente:\n");
        foreach (var libro in casoLinq.GetOrdenadosPorTituloDesc())
        {
            Console.WriteLine($"Titulo: {libro.Titulo} - Precio: {libro.Precio:C}");
        }
    }

}
