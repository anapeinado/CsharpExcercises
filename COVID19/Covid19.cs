using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Text;

namespace COVID19
{
    public static class Covid19
    {

        public static string doCovidProcess(string date, string country, string regionInput)
        {


            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("https://api.covid19tracking.narrativa.com/");
            HttpResponseMessage covidResponse = client.GetAsync("api/" + date + "/country/" + country.ToLower()).Result;
            string response = covidResponse.Content.ReadAsStringAsync().Result;

            CovidRS covidRS = new CovidRS();

            covidRS = JsonConvert.DeserializeObject<CovidRS>(response);

            CovidMyRS covidMyRS = convertRSToMyRS(covidRS, date, country, regionInput);

            return buildStringTelegram(covidMyRS);
        }

        private static string buildStringTelegram(CovidMyRS covidMyRS)
        {


            StringBuilder sbTelegramText = new StringBuilder();

            sbTelegramText.AppendLine("DATOS DEL DÍA " + covidMyRS.date + " EN " + covidMyRS.country);
            sbTelegramText.AppendLine(covidMyRS.nameRegion);
            sbTelegramText.AppendLine("· Muertos hoy: " + covidMyRS.todayNewDeaths);
            sbTelegramText.AppendLine("· Total muertos: " + covidMyRS.totalDeaths);
            sbTelegramText.AppendLine("· Contagios hoy: " + covidMyRS.todayNewCases);
            sbTelegramText.AppendLine("· Total contagios: " + covidMyRS.totalCases);



            return sbTelegramText.ToString();
        }

        private static CovidMyRS convertRSToMyRS(CovidRS covidRS, string date, string country, string regionInput)
        {
            CovidMyRS covidMyRS = new CovidMyRS();


            covidRS.dates.TryGetValue(date, out CovidRS.Dates dates);
            dates.countries.TryGetValue(country, out CovidRS.Dates.Countries countries);
            foreach (var region in countries.regions)
            {
                if (region.name_es.ToLower() == regionInput.ToLower())
                {
                    covidMyRS.nameRegion = region.name_es;
                    covidMyRS.country = countries.name_es;
                    covidMyRS.todayNewCases = (int)region.today_new_confirmed;
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
