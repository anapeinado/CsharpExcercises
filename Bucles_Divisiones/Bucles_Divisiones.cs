using System;
using System.Collections.Generic;

namespace Bucles_Divisiones
{
    class Bucles_Divisiones
    {
        static void Main(string[] args)
        {

            //// Recorre los números del 1 al 100. Usa un bucle for.

            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine(i + 1);
            //}


            ////  Recorre los números del 1 al 100. Usa un bucle while.

            //int z = 0;


            //while (z < 100)
            //{

            //    Console.WriteLine(z + 1);
            //    z++;

            //}


            //// Recorre los números del 1 al 100. Muestra los números pares. Usar el tipo de bucle que quieras.

            //for (int i = 1; i <= 100; i++)
            //{
            //    int rest = i % 2;
            //    if (rest == 0)
            //    {
            //        Console.WriteLine(i);
            //    }


            //}


            //// Recorre los números del 1 al 100. Muestra los números pares o divisibles entre 3.

            //for (int i = 1; i <= 100; i++)
            //{
            //    int rest = i % 2;
            //    int dev = i % 3;
            //    if (rest == 0 || dev == 0)
            //    {
            //        Console.WriteLine(i);
            //    }


            //}
            //// Recorrer array de numeros y suma el total de estos.


            //int[] arr = { 4, 6, 5, 8, 4, 2, 1 };
            //int count = 0;
            //int sumaTotal = 0;


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    count++;
            //    sumaTotal = sumaTotal + arr[i];

            //}

            //foreach (var number in arr)
            //{
            //    count++;
            //    sumaTotal = sumaTotal + number;
            //}

            //while (count < arr.Length)
            //{

            //    count++;
            //    sumaTotal = sumaTotal + arr[count];
            //}

            //// Indica los numeros que aparecen en la lista, cuales no son repetidos, los pares y los impares.


            //List<int> numList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 5 };

            //List<int> numNoRep = new List<int>();

            //List<int> binaryNum = new List<int>();

            //List<int> unaryNum = new List<int>();

            //foreach (int number in numList)
            //{

            //    if (number % 2 == 0)
            //    {
            //        binaryNum.Add(number);
            //    }
            //    else if (number % 2 != 0)
            //    {

            //        unaryNum.Add(number);

            //    }

            //    if (!numNoRep.Contains(number))
            //    {
            //        numNoRep.Add(number);
            //    }

            //}

            //Random rnd = new Random();

            //int numToCheck = rnd.Next(0, 10);
            //var countNumber = 0;

            //foreach (int number in numList)
            //{
            //    if (numToCheck == number)
            //    {
            //        countNumber++;
            //    }
            //}

            //Console.WriteLine("El numero " + numToCheck + " se repite " + countNumber + " veces");

            // Tablas multiplicar.

            int tabla1 = 1;
            int tabla2 = 2;
            int tabla3 = 3;
            int tabla4 = 4;
            int tabla5 = 5;
            int tabla6 = 6;
            int tabla7 = 7;
            int tabla8 = 8;
            int tabla9 = 9;
            int tabla10 = 10;

            List<int> TablaMulti1 = new List<int>();
            List<int> TablaMulti2 = new List<int>();
            List<int> TablaMulti3 = new List<int>();
            List<int> TablaMulti4 = new List<int>();
            List<int> TablaMulti5 = new List<int>();
            List<int> TablaMulti6 = new List<int>();
            List<int> TablaMulti7 = new List<int>();
            List<int> TablaMulti8 = new List<int>();
            List<int> TablaMulti9 = new List<int>();
            List<int> TablaMulti10 = new List<int>();

            for (int i = 0; i < 11; i++)
            {

                TablaMulti1.Add(tabla1 * i);
                TablaMulti2.Add(tabla2 * i);
                TablaMulti3.Add(tabla3 * i);
                TablaMulti4.Add(tabla4 * i);
                TablaMulti5.Add(tabla5 * i);
                TablaMulti6.Add(tabla6 * i);
                TablaMulti7.Add(tabla7 * i);
                TablaMulti8.Add(tabla8 * i);
                TablaMulti9.Add(tabla9 * i);
                TablaMulti10.Add(tabla10 * i);

            }

            printTablas(1, TablaMulti1);
            printTablas(2, TablaMulti2);
            printTablas(3, TablaMulti3);
            printTablas(4, TablaMulti4);
            printTablas(5, TablaMulti5);
            printTablas(6, TablaMulti6);
            printTablas(7, TablaMulti7);
            printTablas(8, TablaMulti8);
            printTablas(9, TablaMulti9);
            printTablas(10, TablaMulti10);

            ///////////////////////////////////

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("Tabla " + i);
                for (int j = 0; j < 11; j++)
                {

                    Console.WriteLine(i * j);
                }
            }


        }
        static void printTablas(int numTabla, List<int> TablaMultiX)
        {


            Console.WriteLine("Tabla " + numTabla);
            foreach (int numbr in TablaMultiX)
            {

                Console.WriteLine(numbr);

            }



        }
    }
}
