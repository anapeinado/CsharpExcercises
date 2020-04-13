using System;
using System.Collections.Generic;
using System.Text;

namespace Notes
{
    public class CastingsAndConverters
    {

        public void CastingsAndConvertersMethod()
        {
            //Texto
            string palabra = "Hola";
            char letra = 'A';
            //Numeros enteros
            int num = 8;
            long numLargo = 13545154;
            //Numeros decimales
            decimal dec = 3.14M;
            double dob = 3.1416;
            //Boolea
            bool bol = true;



            //Convert to String
            string letraToString;
            string numToString;
            string numLargoToString;
            string decToString;
            string dobToString;
            string bolToString;

            letraToString = Convert.ToString(letra);
            numToString = Convert.ToString(num);
            numLargoToString = Convert.ToString(numLargo);
            decToString = Convert.ToString(dec);
            dobToString = Convert.ToString(dob);
            bolToString = Convert.ToString(bol);

            //Convert to Integer
            int numLargoToInt;
            int decToInt;
            int dobToInt;
            int bolToInt;

            

            numLargoToInt = Convert.ToInt32(numLargo);
            decToInt = Convert.ToInt32(dec);
            dobToInt = Convert.ToInt32(dob);
            bolToInt = Convert.ToInt32(bol); // true= 1, false = 0






        }





    }
}
