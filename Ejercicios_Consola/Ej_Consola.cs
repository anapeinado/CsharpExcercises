using System;
using System.Collections.Generic;

namespace Ejercicios_consola
{
    class Ej_Consola
    {
        static void Main(string[] args)
        {



            //1) Crear 3 variables numéricas con el valor que tu quieras y en otra variable numérica guardar el valor de la suma de las 3 anteriores.Mostrar por consola.


            int v1 = 2;
            int v2 = 12;
            int v3 = 4;



            int suma = v1 + v2 + v3;


            Console.WriteLine("La suma es : " + suma);


            //2) Pedir por consola un nombre de persona y el nombre de una ciudad(no hace falta que sean reales o comprobarlos) y mostrar por pantalla, el siguiente mensaje “Hola ” < nombre > ” bienvenido a ” < ciudad >

            Console.WriteLine("Introduzca su nombre");

            string nombre = Console.ReadLine();


            Console.WriteLine("Introduzca su población");

            string poblacion = Console.ReadLine();

            string mensaje = "Hola " + nombre + " bienvenido a " + poblacion;


            Console.WriteLine(mensaje);

            //3) Pedir por consola tu nombre y tu edad y mostrar el siguiente mensaje: “Te llamas ” < nombre > ” y tienes ” < años > ” años”


            Console.WriteLine("Introduzca su nombre");

            string nombre1 = Console.ReadLine();

            Console.WriteLine("Introduzca su edad");

            string edad = Console.ReadLine();

            string mensaje1 = "Te llamas " + nombre1 + " y tienes " + edad + " años.";

            Console.WriteLine(mensaje1);

            //4) Pedir dos números al usuario por teclado y decir que número es el mayor.

            Console.WriteLine("Introduzca un número");

            string numString = Console.ReadLine();

            int num = Int32.Parse(numString);

            Console.WriteLine("Introduzca un número");

            string numString1 = Console.ReadLine();

            int num1 = Int32.Parse(numString1);

            if (num > num1)
            {
                Console.WriteLine("El número más grande es " + num);


            }
            else
            {
                Console.WriteLine("El número más grande es " + num1);
            }

            Console.WriteLine("");

            //5) Pedir el nombre de la semana al usuario y decirle si es fin de semana o no.En caso de error, indicarlo.

            Console.WriteLine("Introduzca un día de la semana");

            string diaString = Console.ReadLine().ToLower();

            if (diaString == "lunes" || diaString == "martes" || diaString == "miercoles" || diaString == "jueves" || diaString == "viernes")

            {
                Console.WriteLine("Es entresemana");
            }
            else if (diaString == "sabado" || diaString == "domingo")
            {
                Console.WriteLine("Es fin de semana");
            }
            else
            {
                Console.WriteLine("El campo introducido es incorrecto");
            }



            Console.WriteLine("");

            // Con listado.

            List<string> listWeek = new List<string>();


            listWeek.Add("lunes");
            listWeek.Add("martes");
            listWeek.Add("miercoles");
            listWeek.Add("jueves");
            listWeek.Add("viernes");

            List<string> listWeekend = new List<string>();

            listWeekend.Add("sabado");
            listWeekend.Add("domingo");

            Console.WriteLine("Introduzca un día de la semana");

            string diaString1 = Console.ReadLine().ToLower();

            if (listWeek.Contains(diaString1))

            {
                Console.WriteLine("Es entresemana");
            }
            else if (listWeekend.Contains(diaString1))
            {
                Console.WriteLine("Es fin de semana");
            }
            else
            {
                Console.WriteLine("El campo introducido es incorrecto");
            }

            //Introduir vocal per consola i dir si es debil o forta.


            Console.WriteLine("Introduzca una vocal");

            string vocal = Console.ReadLine().ToLower();

            List<string> vocalDebil = new List<string>() { "i", "u" };
            List<string> vocalFuerte = new List<string>() { "a", "e", "o" };

            if (vocalDebil.Contains(vocal))
            {
                Console.WriteLine("La vocal introducida es débil.");
            }
            else if (vocalFuerte.Contains(vocal))
            {

                Console.WriteLine("La vocal introducida es fuerte.");
            }
            else
            {
                Console.WriteLine("El caracter introducido no es una vocal.");
            }


            //Intorduir una paraula i dir quants de caracters te.

            Console.WriteLine("Introduzca una palabra:");

            string palabro = Console.ReadLine();



            // EASY WAY: Console.WriteLine("La palabra introducida tiene " + palabro.Length + " letras.");

            char[] letras = palabro.ToCharArray(); //char[] aka Array = Lista.

            int contar = 0;

            foreach (char item in letras) // Loop. recorre un listados de tipo de datos (int, double, string, etc.) o un listado de listados de objetos.
            {

                contar++;

            }

            Console.WriteLine("La palabra introducida tiene " + contar + " letras.");

            //Introduir 3 nombres i dir quin és el menor.

            Console.WriteLine("Introduzca 3 numeros");

            string numm1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            string num3 = Console.ReadLine();

            int numero1;
            int numero2;
            int numero3;

            numero1 = Convert.ToInt32(numm1);
            numero2 = Convert.ToInt32(num2);
            numero3 = Convert.ToInt32(num3);


            List<int> numOrdenados = new List<int>() { numero1, numero2, numero3 };

            int numMesPetit = 0;
            bool isFirstRound = true;

            foreach (int numAValorar in numOrdenados)
            {
                if (isFirstRound)
                {
                    numMesPetit = numAValorar;
                    isFirstRound = false;
                }

                if (numAValorar < numMesPetit)
                {
                    numMesPetit = numAValorar;

                }
            }
            Console.WriteLine("El número más pequeño es " + numMesPetit);

            //Introduir dos costats de un rectangle i dir quin es la suma dels costats, area, diagonal.

            Console.WriteLine("Introduzca los valores de dos de los lados de un rectangulo:");

            string lado1String = Console.ReadLine();
            string lado2String = Console.ReadLine();

            double lado1;
            double lado2;
            double sumaLados = 0;
            double area = 0;
            double diagonal = 0;


            lado1 = Convert.ToDouble(lado1String);
            lado2 = Convert.ToDouble(lado2String);

            sumaLados = (lado1 * 2) + (lado2 * 2);

            area = lado1 * lado2;

            diagonal = Math.Sqrt(Math.Pow(lado1, 2) + Math.Pow(lado2, 2));

            Console.WriteLine("La suma de los lados del rectangulo es " + sumaLados);
            Console.WriteLine("El area del rectangulo es " + area);
            Console.WriteLine("La diagonal del rectangulo es " + diagonal);


            // Introduir radi i dir: Longitud circ, area circ, volum esfera.

            Console.WriteLine("Introduzca el radio de una esfera:");

            string radioString = Console.ReadLine();

            double radio;

            radio = Convert.ToDouble(radioString);

            double longitudEsfera = 2 * Math.PI * radio;
            double areaEsfera = Math.PI * Math.Pow(radio, 2);
            double volumenEsfera = (4 / 3) * Math.PI * Math.Pow(radio, 3);

            Console.WriteLine("La longitud de la esfera es " + Math.Round(longitudEsfera, 2));
            Console.WriteLine("El area de la esfera es " + Math.Round(areaEsfera, 2));
            Console.WriteLine("El volumen de la esfera es " + Math.Round(volumenEsfera, 2));


            //Introduir n notes separades per "," i dir quina es la nota mes alta, la mes baixa i calcular la mitjana.

            Console.WriteLine("Introduce las notas de la evaluación separadas por ',':");

            string marksString = Console.ReadLine();


            List<int> marks = new List<int>();

            for (int i = 0; i < marksString.Length; i++)
            {

                string markChar = marksString[i].ToString();

                if (markChar == "1")
                {
                    string markCharNext = marksString[i + 1].ToString();

                    if (markCharNext == "0")
                    {
                        marks.Add(10);
                        i++;
                    }
                }
                else if (markChar != ",")
                {
                    int mark = Convert.ToInt32(markChar);

                    marks.Add(mark);
                }

            }
            int smallestMark = 0;
            bool isFirstTime = true;

            foreach (int numToValue in marks)
            {
                if (isFirstTime)
                {
                    smallestMark = numToValue;
                    isFirstTime = false;
                }

                if (numToValue < smallestMark)
                {
                    smallestMark = numToValue;

                }
            }

            Console.WriteLine("La nota más baja es " + smallestMark);

            int biggestMark = 0;
            isFirstTime = true;

            foreach (int numToValue in marks)
            {
                if (isFirstTime)
                {
                    biggestMark = numToValue;
                    isFirstTime = false;

                }


                if (numToValue > biggestMark)
                {

                    biggestMark = numToValue;

                }

            }

            Console.WriteLine("La nota más alta es " + biggestMark);

            int sumaTotal = 0;

            foreach (var mark in marks)
            {
                sumaTotal = sumaTotal + mark;

            }

            double average = sumaTotal / marks.Count;


            Console.WriteLine("La nota media es " + average);

            // Declara dos variables numéricas (con el valor que desees), muestra por consola la suma, resta, multiplicación, división y módulo (resto de la división).

            Console.WriteLine("Introduzca dos números:");

            string numberStr1 = Console.ReadLine();
            string numberStr2 = Console.ReadLine();

            double number1 = Convert.ToDouble(numberStr1);
            double number2 = Convert.ToDouble(numberStr2);

            double sum = number1 + number2;
            double rest = number1 - number2;
            double multi = number1 * number2;
            double div = number1 / number2;
            double mod = number1 % number2;


            Console.WriteLine("La suma de los números introducidos es " + sum);

            Console.WriteLine("La resta de los números introducidos es " + rest);

            Console.WriteLine("La multiplicación de los números introducidos es " + multi);

            Console.WriteLine("La divisón de los números introducidos es " + div);

            Console.WriteLine("El resto de la divisón de los números introducidos es " + mod);

            // Declara 2 variables numéricas (con el valor que desees), he indica cual es mayor de los dos. Si son iguales indicarlo también. Ves cambiando los valores para comprobar que funciona.

            Console.WriteLine("Introduzca dos números:");
            string varString1 = Console.ReadLine();
            string varString2 = Console.ReadLine();

            double var1 = Convert.ToDouble(varString1);
            double var2 = Convert.ToDouble(varString2);


            // List<double> variables = new List<double>() { var1, var2 };

            if (var1 < var2)
            {
                Console.WriteLine("El número mayor es: " + var2);
            }
            else if (var1 > var2)
            {
                Console.WriteLine("El número mayor es: " + var1);
            }
            else if (var1 == var2)
            {
                Console.WriteLine("Los números son iguales");
            }

            // Declara un String que contenga tu nombre, después muestra un mensaje de bienvenida por consola. Por ejemplo: si introduzco “Fernando”, me aparezca “Bienvenido Fernando”.

            Console.WriteLine("Introduzca su nombre:");
            string myName = Console.ReadLine();
            Console.WriteLine("Bienvenido/a " + myName);

            // Haz una aplicación que calcule el área de un círculo(pi* R2). El radio se pedirá por teclado(recuerda pasar de String a double con Double.parseDouble). Usa la constante PI y el método pow de Math.

            Console.WriteLine("Introduzca el radio del circulo:");

            string radiusString = Console.ReadLine();

            double radi = Convert.ToDouble(radiusString);

            double areaC = Math.PI * Math.Pow(radi, 2);

            Console.WriteLine("El area del ciruclo es igual a " + areaC);

        }
    }
}
