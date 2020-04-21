using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Objeto_Hotels
{
    class Objeto_Hotel
    {

        static void Main(string[] args)
        {
            Hotel H1 = new Hotel("Hotel Amic Horizonte", "C/Vista Alegre 1", "Spain", "Palma de Mallorca", 3, "0001");
            Hotel H2 = new Hotel("Hotel Saratoga", "C/Paseo de Mallorca 6", "Spain", "Palma de Mallorca", 4, "0002");
            Hotel H3 = new Hotel("San Francesc Hotel Singular", "Plaza San Francesc 5", "Spain", "Palma de Mallorca", 5, "0003");
            Hotel H4 = new Hotel("Brondo Architect Hotel", "Calle Can Brondo 4", "Spain", "Palma de Mallorca", 4, "0004");

            Dictionary<string, Hotel> dicHotels = new Dictionary<string, Hotel>();
            dicHotels.Add(H1.hotelID, H1);
            dicHotels.Add(H2.hotelID, H2);
            dicHotels.Add(H3.hotelID, H3);
            dicHotels.Add(H4.hotelID, H4);

            List<Hotel> HotelsDataBase = new List<Hotel>();
            HotelsDataBase.Add(H1);
            HotelsDataBase.Add(H2);
            HotelsDataBase.Add(H3);
            HotelsDataBase.Add(H4);

            Console.WriteLine("Menu\nSeleccione una opción.\n1. Añadir un hotel:\n2. Consultar un hotel:\n3. Consultar todos los hoteles.\n4.Borrar Hotel.\n5. Cerrar programa.");

            var deserializedProduct = JsonConvert.SerializeObject(dicHotels);

            string comando = string.Empty;


            var deserializedProduct2 = JsonConvert.SerializeObject(HotelsDataBase);

            do
            {
                comando = Console.ReadLine();
                switch (comando)
                {
                    case "1":
                        Console.WriteLine("Introduzca los datos que se solicitan a continuación:");
                        Console.Write("Nombre del hotel:");
                        string nomHotel = Console.ReadLine();
                        Console.Write("Dirección:");
                        string address = Console.ReadLine();
                        Console.Write("País:");
                        string country = Console.ReadLine();
                        Console.Write("Localidad:");
                        string locality = Console.ReadLine();
                        Console.Write("Categoría(0-5*):");
                        string category = Console.ReadLine();
                        int categoria = Convert.ToInt32(category);
                        Console.Write("Inserte un ID correlativo para el hotel:");
                        string ID = Console.ReadLine();

                        Hotel HX = new Hotel(nomHotel, address, country, locality, categoria, ID);

                        HotelsDataBase.Add(HX);
                        dicHotels.Add(HX.hotelID, HX);

                        Console.WriteLine("El hotel" + nomHotel + " se ha creado correctamente.");
                        break;
                    case "2":
                        Console.Write("Inserte el ID del hotel que quiera consultar:");
                        string hotelID = Console.ReadLine();

                        //Diccionario
                        if (dicHotels.TryGetValue(hotelID, out Hotel hx))
                        {
                            // Console.WriteLine(returnHotelInfo(hx));
                            Console.WriteLine(JsonConvert.SerializeObject(hx));
                            
                        }
                        else
                        {
                            Console.WriteLine("Hotel not found.");

                        }


                        ////Lista
                        //foreach (var hotel in HotelsDataBase)
                        //{

                        //    if (hotelID == hotel.hotelID)
                        //    {
                        //        Console.WriteLine(returnHotelInfo(hotel));
                        //    }

                        //}
                        break;
                    case "3":

                        Console.WriteLine(JsonConvert.SerializeObject(dicHotels));

                        ////Diccionario
                        //foreach (var item in dicHotels)
                        //{

                        //    Console.WriteLine(returnHotelInfo(item.Value));
                        //}
                        ////Lista
                        //foreach (var hotel in HotelsDataBase)
                        //{
                        //    Console.WriteLine(returnHotelInfo(hotel));
                        //}

                        break;
                    case "4":
                        Console.Write("Introduzca el ID del hotel que quiera eliminar:");
                        string hotelIDeliminar = Console.ReadLine();
                        //Diccionario
                        if (!dicHotels.Remove(hotelIDeliminar, out Hotel hotelToDelete))
                        {
                            Console.WriteLine("Se ha eliminado el hotel " + hotelToDelete.hotelName);
                        }
                        else
                        {
                            Console.WriteLine("Hotel not found. Can not delete");

                        }
                        //Lista
                        Hotel hotelTMP = null;
                        foreach (var hotel in HotelsDataBase)
                        {

                            if (hotelIDeliminar == hotel.hotelID)
                            {
                                hotelTMP = hotel;
                                break;
                            }

                        }
                        HotelsDataBase.Remove(hotelTMP);
                        Console.WriteLine("Se ha eliminado el hotel " + hotelTMP.hotelName);


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
        static string returnHotelInfo(Hotel hotel)
        {
            string hotelString = "Hotel con codigo " + hotel.hotelID + " llamado " + hotel.hotelName + " sito en " + hotel.hotelCountry + " " + hotel.hotelLocality + " " + hotel.hotelAddress + " con cateogría " + hotel.HotelCategory;

            return hotelString;
        }

    }
}
