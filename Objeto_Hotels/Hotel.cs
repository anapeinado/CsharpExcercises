using System;

namespace Objeto_Hotels
{


    public class Hotel
    {
        public string hotelName;
        public string hotelAddress;
        public string hotelCountry;
        public string hotelLocality;
        private int hotelCategory;
        public  string hotelID;
      



        public Hotel(string aHotelName, string aHotelAddress, string aHotelCountry, string aHotelLocality, int aHotelCategory, string aHotelID)
        {
            hotelName = aHotelName;
            hotelAddress = aHotelAddress;
            hotelCountry = aHotelCountry;
            hotelLocality = aHotelLocality;
            HotelCategory = aHotelCategory;
            hotelID = aHotelID;

        }

        public Hotel() { }

        public int HotelCategory
        {

            get
            {
                return hotelCategory;
            }


            set
            {
                if (value <= 5 && value >= 0)
                {
                    hotelCategory = value;
                }
                else
                {
                    hotelCategory = -1;
                }

            }
        }





    }





}
