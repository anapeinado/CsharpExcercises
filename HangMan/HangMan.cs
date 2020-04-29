using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HangMan
{
    class HangMan
    {
        static void Main(string[] args)
        {

            //HangMan

            int tries = 0;
            List<string> Jugadores = new List<string>();
            string playerOne = string.Empty;
            string secretWord = string.Empty;
            string parsedWord = string.Empty;

            // Ref = Se modifica el valor, sino se pone "ref", no se modifica.
            startHangManParameters(ref tries, ref Jugadores, ref playerOne);

            enterWord(playerOne, ref secretWord, ref parsedWord);

            mainGame(secretWord, parsedWord, tries, Jugadores);


        }

        public static string writePassword()
        {
            string pass = "";
            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                // Backspace Should Not Work
                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    pass += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && pass.Length > 0)
                    {
                        pass = pass.Substring(0, (pass.Length - 1));
                        Console.Write("\b \b");
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            } while (true);

            return pass;
        }

        public static void startHangManParameters(ref int tries, ref List<string> Jugadores, ref string playerOne)
        {
            Console.WriteLine(@"
         Add the number of tries to guess the secret word:");
            string intentos = Console.ReadLine();
            tries = Convert.ToInt32(intentos);

            Console.WriteLine(@"
         Add number of players:");
            string jugadores = Console.ReadLine();
            int players = Convert.ToInt32(jugadores);

            for (int i = 1; i <= players; i++)
            {
                Console.Write("Player " + i + " name: ");
                string nombreJugador = Console.ReadLine();
                Jugadores.Add(nombreJugador);
            }


            while (true)
            {
                Console.WriteLine(@"
         Choose the main player:");
                playerOne = Console.ReadLine();

                if (Jugadores.Contains(playerOne))
                {
                    Jugadores.Remove(playerOne);

                    break;

                }
                else
                {
                    Console.WriteLine("Player not found.");

                }
            }



        }

        public static void mainGame(string secretWord, string parsedWord, int tries, List<string> Jugadores)
        {
            int indexOfPlayer = 0;

            do
            {


                string playerX = playerSelector(ref indexOfPlayer, Jugadores);

                Console.WriteLine(playerX + " your turn! Please enter a letter:");
                string letraComprobar = Console.ReadLine();
                int position = 0;
                bool wordIsCorrect = false;

                foreach (var letra in secretWord)
                {
                    if (letra.ToString() == letraComprobar)
                    {
                        wordIsCorrect = true;

                        StringBuilder aStringBuilder = new StringBuilder(parsedWord);
                        aStringBuilder = aStringBuilder.Replace('*', letra, position, 1);

                        parsedWord = aStringBuilder.ToString();


                    }

                    position++;
                }

                Console.WriteLine(parsedWord);
                if (!parsedWord.Contains('*'))
                {
                    Console.WriteLine("YOU WIN");
                    break;
                }
                if (!wordIsCorrect)
                {
                    tries--;
                    Console.WriteLine("Wrong guess, you have " + tries + " tries left.");
                }




            } while (tries != 0);

            if (tries == 0)
            {
                Console.WriteLine("GAME OVER");
            }



        }

        private static string playerSelector(ref int indexOfPlayer, List<string> jugadores)
        {
            //Sabiendo el tamaño de la lista, y el index actual del player, devolver el siguiente jugador. En caso que ya no hay mas jugadores, devolver el 1r.

            string playerX = jugadores[indexOfPlayer];

            if (jugadores.Count == indexOfPlayer + 1)
            {
                indexOfPlayer = 0;
            }
            else
            {

                indexOfPlayer++;
            }

            return playerX;
        }

        public static void enterWord(string playerOne, ref string secretWord, ref string parsedWord)
        {

            Console.Write("Player " + playerOne + " please, enter a word to guess: ");

            secretWord = writePassword();


            foreach (var item in secretWord)
            {
                parsedWord += "*";
            }

            Console.WriteLine(parsedWord);


            Console.WriteLine(@"
         Guess the word");
            Console.WriteLine(parsedWord);


        }











    }


}
