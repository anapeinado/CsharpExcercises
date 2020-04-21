using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Menu_Listas
{
    public static class Listas
    {

        public static void Execute()
        {
            // Programa que pide: escribe un texto, cuantas veces sale una palabra, cuantas veces sale una letra...

            Console.WriteLine("Escriba un texto: ");
            string texto = Console.ReadLine();


            Console.WriteLine("Introduzca una letra del texto: ");
            string letraRepe = Console.ReadLine();
            char caracterRepe = Convert.ToChar(letraRepe);
            int countLetra = 0;
            foreach (char caracter in texto)
            {
                if (caracter == caracterRepe)
                {
                    countLetra++;
                }
            }

            Console.WriteLine("La letra se repite " + countLetra + " veces en el texto.");


            Console.WriteLine("Introduzca una palabra del texto: ");
            char[] wordToFind = Console.ReadLine().ToCharArray();

            int indexPositionTexto = 0;
            int indexWordToFind = 0;
            int countFounds = 0;
            bool isFinding = false;

            foreach (var letter in texto.ToCharArray())
            {
                if (letter == wordToFind[indexWordToFind])
                {

                    if (!isFinding && indexPositionTexto == 0 || texto[indexPositionTexto - 1] == ' ')
                    {
                        isFinding = true;
                    }

                    else if (wordToFind.Length - 1 == indexWordToFind)
                    {
                        if (indexPositionTexto + 1 == texto.Length || texto[indexPositionTexto + 1] == ' ' || texto[indexPositionTexto + 1] == ',' || texto[indexPositionTexto + 1] == '.' || texto[indexPositionTexto + 1] == '?')
                        {
                            countFounds++;
                            indexWordToFind = 0;
                            isFinding = false;

                        }
                    }

                    if (isFinding)
                    {
                        indexWordToFind++;
                    }

                }
                indexPositionTexto++;
            }


            Console.WriteLine("La palabra se repite " + countFounds + " veces en el texto.");

            // Cuantas palabras tiene el texto.

            int cuentaPalabra = 0;
            char[] simbolos = { ' ', '.', ',', ':', ';', '?', '!', '\n' };

            for (int i = 0; i < texto.Length; i++)
            {
                if (texto.Length == i + 1)
                {
                    if (!simbolos.Contains(texto[i]))
                    {
                        cuentaPalabra++;
                    }
                }
                else if (simbolos.Contains(texto[i + 1]))
                {
                    cuentaPalabra++;
                }
            }

            Console.WriteLine("El texto tiene " + cuentaPalabra + " palabras.");











        }

    }
}
