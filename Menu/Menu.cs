using System;

namespace Menu
{
    class Menu
    {
        static void Main(string[] args)
        {
            // Pedir al usuario el precio de un producto (valor positivo) y la forma de pagar (efectivo o tarjeta) si la forma de pago es mediante tarjeta, pedir el numero de cuenta.

            Console.WriteLine("Introduzca precio del producto.");

            string price = Console.ReadLine();

            Console.WriteLine("Introduzca la forma de pago; efectivo o tarjeta.");

            string answer = Console.ReadLine().ToLower();

            if (answer == "tarjeta")
            {

                Console.WriteLine("Introduzca su número de cuenta.");
                string num = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Adiós");

            }

        }
    }
}
