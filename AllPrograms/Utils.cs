using System;
using System.Collections.Generic;

namespace AllPrograms
{
    public static class Utils
    {
        public static string convertListToMessage(List<int> listToConvert)

        {

            string message = string.Empty;

            foreach (var item in listToConvert)
            {

                string myString = item.ToString();

                message = string.Concat(message, myString, ",");

            }


            return message;

        }



        public static List<int> invertList(List<int> listToInvert)
        {
            List<int> invertedList = new List<int>();

            int count = listToInvert.Count;

            for (int i = count; i > 0; i--)
            {

                int number = listToInvert[i - 1];
                invertedList.Add(number);


            }

            return invertedList;

        }

        public static List<int> convertToBinaryList(List<int> allNumList)

        {
            List<int> listBinary = new List<int>();

            int count = allNumList.Count;


            for (int i = 0; i < count; i++)
            {


                int num = allNumList[i];
                int residu = num % 2;

                if (residu == 0)
                {

                    listBinary.Add(num);

                }


            }

            return listBinary;

        }

        public static List<int> convertToUnaryList(List<int> allNumList)
        {

            List<int> listUnary = new List<int>();
            int count = allNumList.Count;


            for (int i = 0; i < count; i++)
            {


                int num = allNumList[i];
                int residu = num % 2;

                if (residu != 0)
                {

                    listUnary.Add(num);

                }


            }

            return listUnary;

        }

    }
}
