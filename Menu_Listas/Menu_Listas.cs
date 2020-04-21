using AllPrograms;
using System;
using System.Collections.Generic;

namespace Menu_Listas
{
    static class Menu_Listas
    {

        static void Main(string[] args)
        {

            Listas.Execute();

            string mensaje = string.Empty;
            List<int> listaRandom = new List<int>() { 2, 3, 9, 7, 1, 32, 14, 54, 21, 3, 21, 28, 21, 23, 4, 98, 54, 56, 36, 54, 45 };

            // Menu Listas.

            Console.WriteLine("Pulse la opción deseada\nMenú\n1. Mostrar la lista original.\n2. Mostrar la lista invertida.\n3. Mostrar la lista de números pares.\n4. Mostrar la lista de números impares.\n5. Salir del menú.");

            string options = string.Empty;

            while (options != "5")
            {
                options = Console.ReadLine();
                switch (options)
                {
                    case "1": //1. Mostrar la lista original.
                        mensaje = Utils.convertListToMessage(listaRandom);
                        Console.WriteLine("La lista original es: " + mensaje);
                        break;

                    case "2": //2. Mostrar la lista invertida.
                        List<int> invertedList = Utils.invertList(listaRandom);
                        mensaje = Utils.convertListToMessage(invertedList);
                        Console.WriteLine("La lista invertida es: " + mensaje);
                        break;

                    case "3": //3. Mostrar la lista de números pares.
                        List<int> listaPares = Utils.convertToBinaryList(listaRandom);
                        mensaje = Utils.convertListToMessage(listaPares);
                        Console.WriteLine("Los numero pares son " + mensaje);
                        break;

                    case "4": //4. Mostrar la lista de números impares.
                        List<int> listaImpares = Utils.convertToUnaryList(listaRandom);
                        mensaje = Utils.convertListToMessage(listaImpares);
                        Console.WriteLine("Los numero impares son " + mensaje);
                        break;
                    case "5": //5. Salir del menu.
                        Console.WriteLine("Bye Bye");
                        break;

                    default:

                        Console.WriteLine("Por favor, pulse la opción correcta.");

                        break;
                }
            }


        }






    }
}
