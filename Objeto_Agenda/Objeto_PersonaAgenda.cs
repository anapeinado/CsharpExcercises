using Newtonsoft.Json;
using Objeto_Agenda;
using System;
using System.Collections.Generic;

namespace Objeto_PersonaAgenda
{
    class Objeto_PersonaAgenda
    {

        static void Main(string[] args)
        {
            PersonaAgenda Ana = new PersonaAgenda("Ana", "Peinado Jaen", "673424439", "apeinadojaen@gmail.com", "C / Lliri 48");
            PersonaAgenda Sergi = new PersonaAgenda("Sergi Bartomeu", "Roberti Vallori", "696303634", "sroberti@gmail.com", "C/Bonaire 80");

            Dictionary<string, PersonaAgenda> dicAgenda = new Dictionary<string, PersonaAgenda>();

            dicAgenda.Add(Ana.name, Ana);
            dicAgenda.Add(Sergi.name, Sergi);


            Console.WriteLine("Menu\nSeleccione una opción.\n1. Añadir un contacto:\n2. Consultar un contacto:\n3. Consultar todos los contactos.\n4.Borrar contacto.\n5. Cerrar programa.");

            

            var deserializedProduct = JsonConvert.SerializeObject(dicAgenda);
            string comando = string.Empty;


            do
            {
                comando = Console.ReadLine();
                switch (comando)
                {
                    case "1":
                        Console.WriteLine("Introduzca los datos que se solicitan a continuación:");
                        Console.Write("Nombre del contacto:");
                        string name = Console.ReadLine();
                        Console.Write("Apellidos del contacto:");
                        string surname = Console.ReadLine();
                        Console.Write("Telefono:");
                        string phone = Console.ReadLine();
                        Console.Write("Correo electrónico:");
                        string email = Console.ReadLine();
                        Console.Write("Direccion:");
                        string address = Console.ReadLine();


                        PersonaAgenda PX = new PersonaAgenda(name, surname, phone, email, address);


                        dicAgenda.Add(PX.name, PX);

                        Console.WriteLine("El contacto" + name + " se ha creado correctamente.");
                        break;

                    case "2":
                        Console.Write("Inserte el nombre del contacto que quiera consultar:");
                        string nombre = Console.ReadLine();

                        //Diccionario
                        if (dicAgenda.TryGetValue(nombre, out PersonaAgenda px))
                        {

                            Console.WriteLine(JsonConvert.SerializeObject(px));

                        }
                        else
                        {
                            Console.WriteLine("Contact not found.");

                        }

                        break;
                    case "3":

                        Console.WriteLine(JsonConvert.SerializeObject(dicAgenda));

                        break;
                    case "4":
                        Console.Write("Introduzca el nombre del contacto que quiera eliminar:");
                        string contactoEliminar = Console.ReadLine();
                        //Diccionario
                        if (!dicAgenda.Remove(contactoEliminar, out PersonaAgenda contactToDelete))
                        {
                            Console.WriteLine("Se ha eliminado el contacto " + contactToDelete.name);
                        }
                        else
                        {
                            Console.WriteLine("Contact not found. Can not delete");

                        }


                        break;

                    case "5":
                        Console.Write("Adios");

                        break;

                    default:
                        Console.WriteLine("Por favor, pulse la opción correcta.");
                        break;

                } 
            } while (comando != "5");


        }




    }
}

