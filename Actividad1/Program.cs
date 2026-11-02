using System;

class Program
{
    static void Main()
    {
        int pinCorrecto = 1234;
        int intentos = 0;
        int pin;
        double saldo = 10000;
        double monto;
        int depositos = 0;
        int retiros = 0;
        int opcion;

        while (intentos < 3)
        {
            Console.Write("Ingrese su PIN de 4 digitos: ");

            if (!int.TryParse(Console.ReadLine(), out pin))
            {
                Console.WriteLine("PIN invalido.");
                intentos++;
                continue;
            }

            if (pin == pinCorrecto)
            {
                Console.WriteLine("\nAcceso permitido.");

                do
                {
                    Console.WriteLine("\n===== CAJERO AUTOMATICO =====");
                    Console.WriteLine("1. Consultar saldo");
                    Console.WriteLine("2. Depositar");
                    Console.WriteLine("3. Retirar");
                    Console.WriteLine("4. Salir");
                    Console.Write("Seleccione una opcion: ");

                    if (!int.TryParse(Console.ReadLine(), out opcion))
                    {
                        opcion = 0;
                    }

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Saldo actual: RD$ " + saldo.ToString("N2"));
                            break;

                        case 2:
                            Console.Write("Ingrese el monto a depositar: ");

                            if (double.TryParse(Console.ReadLine(), out monto))
                            {
                                if (monto > 0)
                                {
                                    saldo += monto;
                                    depositos++;
                                    Console.WriteLine("Deposito realizado correctamente.");
                                }
                                else
                                {
                                    Console.WriteLine("El monto debe ser mayor que cero.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Monto invalido.");
                            }
                            break;

                        case 3:
                            Console.Write("Ingrese el monto a retirar: ");

                            if (double.TryParse(Console.ReadLine(), out monto))
                            {
                                if (monto <= 0)
                                {
                                    Console.WriteLine("El monto debe ser mayor que cero.");
                                }
                                else if (monto > saldo)
                                {
                                    Console.WriteLine("Fondos insuficientes.");
                                }
                                else if (monto % 100 != 0)
                                {
                                    Console.WriteLine("El retiro debe ser multiplo de RD$ 100.");
                                }
                                else
                                {
                                    saldo -= monto;
                                    retiros++;
                                    Console.WriteLine("Retiro realizado correctamente.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Monto invalido.");
                            }
                            break;

                        case 4:
                            Console.WriteLine("\n===== RESUMEN DE CUENTA =====");
                            Console.WriteLine("Cantidad de depositos: " + depositos);
                            Console.WriteLine("Cantidad de retiros: " + retiros);
                            Console.WriteLine("Saldo final: RD$ " + saldo.ToString("N2"));
                            Console.WriteLine("Gracias por utilizar nuestros servicios.");
                            break;

                        default:
                            Console.WriteLine("Opcion invalida.");
                            break;
                    }

                } while (opcion != 4);

                return;
            }
            else
            {
                intentos++;
                Console.WriteLine("PIN incorrecto. Intentos restantes: " + (3 - intentos));
            }
        }

        Console.WriteLine("\nCuenta bloqueada por superar los 3 intentos.");
    }
}
