using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;

namespace COVID19
{
    class Covid19
    {
        static void Main(string[] args)
        {


            HttpClient client = new HttpClient();

            Console.WriteLine("Introduzca el día que quiera ver con el formato YYYY-MM-DD:");
            string date = Console.ReadLine();

            client.BaseAddress = new Uri("https://api.covid19tracking.narrativa.com/");
            HttpResponseMessage covidResponse = client.GetAsync("api/" + date + "/country/spain").Result;
            string response = covidResponse.Content.ReadAsStringAsync().Result;

            CovidRS covidRS = new CovidRS();

            covidRS = JsonConvert.DeserializeObject<CovidRS>(response);

            CovidMyRS covidMyRS = convertRSToMyRS(covidRS, date);

            string output = JsonConvert.SerializeObject(covidMyRS);


            Console.WriteLine(output);

        }

        private static CovidMyRS convertRSToMyRS(CovidRS covidRS, string date)
        {
            CovidMyRS covidMyRS = new CovidMyRS();


            covidRS.dates.TryGetValue(date, out CovidRS.Dates dates);
            dates.countries.TryGetValue("Spain", out CovidRS.Dates.Countries countries);
            foreach (var region in countries.regions)
            {
                if (region.name_es == "Baleares")
                {
                    covidMyRS.name = region.name_es;
                    covidMyRS.todayNewCases = (int) region.today_new_confirmed;
                    covidMyRS.todayNewDeaths = (int)region.today_new_deaths;
                    covidMyRS.totalCases = (int)region.today_confirmed;
                    covidMyRS.totalDeaths = (int)region.today_deaths;
                    covidMyRS.date = region.date;

                }



            }
        



            return covidMyRS;

        }
    }
}
