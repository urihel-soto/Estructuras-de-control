// =================================================================
// PARTE 2 - ANTONI RAMIREZ
// Esta es mi parte del código: valido el plazo en meses y la
// categoría del socio (A, B o C).
// Sigue Dalbert Hernandez.
// =================================================================

// Validación del plazo (entre 6 y 60 meses)
do
{
    Console.Write("Ingrese el plazo en meses (6 - 60): ");

    if (!int.TryParse(Console.ReadLine(), out plazo))
    {
        plazo = 0;
    }

    if (plazo < 6 || plazo > 60)
    {
        Console.WriteLine("Plazo invalido. Intente nuevamente.");
    }

} while (plazo < 6 || plazo > 60);

// Validación de la categoría del socio
do
{
    Console.Write("Ingrese la categoria del socio (A, B o C): ");
    categoria = Console.ReadLine().ToUpper();

    if (categoria != "A" && categoria != "B" && categoria != "C")
    {
        Console.WriteLine("Categoria invalida. Intente nuevamente.");
    }

} while (categoria != "A" && categoria != "B" && categoria != "C");
