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


// =================================================================
 // PARTE 3 - DALBERT HERNANDEZ
 // Esta es mi parte del código: asigno la tasa según la categoría,
 // calculo la cuota mensual y genero la tabla de amortización.
 // Sigue Emmanuel.
 // =================================================================

 // Tasa anual según la categoría
 switch (categoria)
 {
     case "A":
         tasaAnual = 0.12;
         break;

     case "B":
         tasaAnual = 0.15;
         break;

     default:
         tasaAnual = 0.18;
         break;
 }

 tasaMensual = tasaAnual / 12;

 // Fórmula de la cuota fija mensual
 cuota = monto * (tasaMensual * Math.Pow(1 + tasaMensual, plazo))
         / (Math.Pow(1 + tasaMensual, plazo) - 1);

 saldo = monto;
 totalPagado = 0;
 totalIntereses = 0;

 Console.WriteLine("\n===== TABLA DE AMORTIZACION =====");
 Console.WriteLine("Mes\tCuota\t\tInteres\t\tCapital\t\tSaldo");

 for (int mes = 1; mes <= plazo; mes++)
 {
     interes = saldo * tasaMensual;
     abonoCapital = cuota - interes;
     saldo -= abonoCapital;

     // Ajuste en la última cuota para que el saldo quede en 0
     if (mes == plazo)
     {
         abonoCapital += saldo;
         cuota = interes + abonoCapital;
         saldo = 0;
     }

     totalPagado += cuota;
     totalIntereses += interes;

     Console.WriteLine(
         mes + "\t" +
         cuota.ToString("N2") + "\t\t" +
         interes.ToString("N2") + "\t\t" +
         abonoCapital.ToString("N2") + "\t\t" +
         saldo.ToString("N2")
     );
 }            
            // =================================================================
            // PARTE 4 - EMMANUEL
            // Esta es mi parte del código: muestro el resumen del préstamo,
            // pregunto si se desea simular otro y cierro el programa.
            // Fin del código.
            // =================================================================

            Console.WriteLine("\n===== RESUMEN DEL PRESTAMO =====");
            Console.WriteLine("Monto solicitado: RD$ " + monto.ToString("N2"));
            Console.WriteLine("Categoria: " + categoria);
            Console.WriteLine("Tasa anual: " + (tasaAnual * 100) + "%");
            Console.WriteLine("Plazo: " + plazo + " meses");
            Console.WriteLine("Cuota mensual aproximada: RD$ " + (monto * (tasaMensual * Math.Pow(1 + tasaMensual, plazo)) / (Math.Pow(1 + tasaMensual, plazo) - 1)).ToString("N2"));
            Console.WriteLine("Total pagado: RD$ " + totalPagado.ToString("N2"));
            Console.WriteLine("Total de intereses: RD$ " + totalIntereses.ToString("N2"));

            Console.Write("\nDesea simular otro prestamo? (S/N): ");
            respuesta = Console.ReadLine().ToUpper();

        } while (respuesta == "S");

        Console.WriteLine("\nGracias por utilizar el simulador de prestamos.");
    }
}
