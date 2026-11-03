using System;

class Program
{
    static void Main()
    {
        // =====================================================================
        // PARTE 1 - YOKENDDY
        // Esta es mi parte del código: declaro las variables, inicio el ciclo
        // principal del simulador y valido el monto del préstamo.
        // Sigue Antoni Ramirez.
        // =====================================================================

        double monto, tasaAnual, tasaMensual;
        double cuota, interes, abonoCapital, saldo;
        double totalPagado, totalIntereses;
        int plazo;
        string categoria, respuesta;

        do
        {
            Console.WriteLine("\n===== SIMULADOR DE PRESTAMO =====");

            // Validación del monto (entre 5,000 y 500,000)
            do
            {
                Console.Write("Ingrese el monto del prestamo (5000 - 500000): ");

                if (!double.TryParse(Console.ReadLine(), out monto))
                {
                    monto = 0;
                }

                if (monto < 5000 || monto > 500000)
                {
                    Console.WriteLine("Monto invalido. Intente nuevamente.");
                }

            } while (monto < 5000 || monto > 500000);


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
