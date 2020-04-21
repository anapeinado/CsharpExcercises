using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Objeto_Persona
{
    class Objeto_Persona
    {
        static void Main(string[] args)
        {

            Persona Ana = new Persona();

            Ana.nombre = "Ana Peinado Jaen";
            Ana.nacionalidad = "España";
            Ana.altura = 160;
            Ana.edad = 27;
            Ana.peso = 50;
            Ana.hijos = 1;



            Persona Sergi = new Persona("Sergi", 26, 174);

            Sergi.nombre = "Sergi Bartomeu Roberti Vallori";
            Sergi.nacionalidad = "España";
            Sergi.altura = 174;
            Sergi.edad = 26;
            Sergi.peso = 68;
            Sergi.hijos = 0;


            XmlSerializer xsSubmit = new XmlSerializer(typeof(Persona));
          
            var xml = "";

            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    xsSubmit.Serialize(writer, Sergi);
                    xml = sww.ToString(); // Your XML
                }
            }

            Console.WriteLine(xml);


            Persona Consola = new Persona();

            Console.WriteLine("¿Como te llamas?");
            Consola.nombre = Console.ReadLine();
            Console.WriteLine("Indica tu nacionalidad");
            Consola.nacionalidad = Console.ReadLine();
            Console.WriteLine("¿Cuantos años tienes?");
            Consola.edad = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Cuanto mides?");
            Consola.altura = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Cuanto pesas?");
            Consola.peso = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Cuantos hijos tienes?");
            Consola.hijos = int.Parse(Console.ReadLine());




            Console.WriteLine(presentacion(Consola));
            Console.ReadLine();



            Console.WriteLine(presentacion(Sergi));
            Console.WriteLine(presentacion(Ana));
            Console.ReadLine();


        }



        public static string presentacion(Persona personaX)

        {

            string presentacion = string.Empty;

            presentacion = "Hola me llamo " + personaX.nombre + " tengo "
                + personaX.edad + " años. Soy de " + personaX.nacionalidad + ". Mido "
                + personaX.altura + " cm y peso " + personaX.peso + " kilos. Tengo " + personaX.hijos + " hij@/s.";


            return presentacion;


        }


    }



}
