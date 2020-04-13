using System;

namespace COVID_Calculos
{
    class ERTE_Calculos
    {
        static void Main(string[] args)
        {
            string respuesta = string.Empty;

            do
            {


                Console.WriteLine("Introduzca su base reguladora:");
                string salary = Console.ReadLine();

                Console.WriteLine("Introduzca su sueldo neto:");
                string salaryNeto = Console.ReadLine();

                Console.WriteLine("Introduzca el número de hijos que tiene:");
                string children = Console.ReadLine();

                decimal sueldo = Convert.ToDecimal(salary);
                decimal sueldoNeto = Convert.ToDecimal(salaryNeto);
                int hijos = Convert.ToInt32(children);

                decimal sueldoErte = sueldo * 0.7M;
                decimal sueldoMax = 1098.09M;
                decimal diferencia = 0;

                if (hijos == 1)
                {
                    sueldoMax = 1254.96M;

                }
                else if (hijos > 1)
                {
                    sueldoMax = 1411.83M;
                }

                if (sueldoErte > sueldoMax)
                {
                    Console.WriteLine("Ha superado la cuantía máxima a recibir por el Estado, su importe a cobrar será " + sueldoMax);

                    diferencia = sueldoNeto - sueldoMax;

                    Console.WriteLine("Su sueldo disminuirá " + diferencia);

                }
                else
                {
                    Console.WriteLine("Importe a cobrar " + sueldoErte);

                    diferencia = sueldoNeto - sueldoErte;

                    Console.WriteLine("Su sueldo disminuirá " + diferencia);

                }


                Console.WriteLine("Quieres consultar de nuevo? (Si/No)");
                respuesta = Console.ReadLine().ToLower();

            } while (respuesta == "si");


        }
    }
}
