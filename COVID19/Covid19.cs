﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;

namespace COVID19
{
    public static class Covid19
    {

        public static List<CovidMyRS> doCovidProcess(string country, string regionInput, string dateFrom, string dateTo = "")
        {
            string ret = string.Empty;

            HttpClient client = new HttpClient();
            HttpResponseMessage covidResponse = new HttpResponseMessage();
            client.BaseAddress = new Uri("https://api.covid19tracking.narrativa.com/");

            if (dateTo == "")
            {
                covidResponse = client.GetAsync("api/" + dateFrom + "/country/" + country.ToLower()).Result;

            }
            else
            {
                covidResponse = client.GetAsync("api/country/" + country.ToLower() + "?date_from=" + dateFrom + "&date_to=" + dateTo).Result;

            }

            string response = covidResponse.Content.ReadAsStringAsync().Result;

            CovidRS covidRS = new CovidRS();

            covidRS = JsonConvert.DeserializeObject<CovidRS>(response);

            List<CovidMyRS> covidMyRS = convertRSToMyRS(covidRS, dateFrom, country, regionInput);

            return covidMyRS;

         
        }

        public static string buildStringCSV(List<CovidMyRS> covidMyRSList) 
        {
            StringBuilder sbCSVText = new StringBuilder();

            sbCSVText.AppendLine("Fecha|País|Región|Muertos hoy|Total muertes|Contagios hoy|Total contagios");

            foreach (var covidMyRS in covidMyRSList)
            {
                sbCSVText.AppendLine(covidMyRS.date+"|"+ covidMyRS.country+"|"+ covidMyRS.nameRegion+"|"+ covidMyRS.todayNewDeaths+"|"+ covidMyRS.totalDeaths+"|"+ covidMyRS.todayNewCases+"|"+ covidMyRS.totalCases);


            }




            return sbCSVText.ToString();
        
        }

        public static string buildStringTelegram(List<CovidMyRS> covidMyRSList)
        {


            StringBuilder sbTelegramText = new StringBuilder();

            foreach (var covidMyRS in covidMyRSList)
            {

                sbTelegramText.AppendLine("DATOS DEL DÍA " + covidMyRS.date + " EN " + covidMyRS.country);
                sbTelegramText.AppendLine(covidMyRS.nameRegion);
                sbTelegramText.AppendLine("· Muertos hoy: " + covidMyRS.todayNewDeaths);
                sbTelegramText.AppendLine("· Total muertos: " + covidMyRS.totalDeaths);
                sbTelegramText.AppendLine("· Contagios hoy: " + covidMyRS.todayNewCases);
                sbTelegramText.AppendLine("· Total contagios: " + covidMyRS.totalCases);
                sbTelegramText.AppendLine();
            }




            return sbTelegramText.ToString();
        }

        private static List<CovidMyRS> convertRSToMyRS(CovidRS covidRS, string date, string country, string regionInput)
        {

            List<CovidMyRS> covidMyRsList = new List<CovidMyRS>();

            foreach (var dates in covidRS.dates)
            {
                dates.Value.countries.TryGetValue(country, out CovidRS.Dates.Countries countries);
                foreach (var region in countries.regions)
                {
                    if (region.name_es.ToLower() == regionInput.ToLower())
                    {
                        CovidMyRS covidMyRS = new CovidMyRS();
                        covidMyRS.nameRegion = region.name_es;
                        covidMyRS.country = countries.name_es;
                        covidMyRS.todayNewCases = (int)region.today_new_confirmed;
                        covidMyRS.todayNewDeaths = (int)region.today_new_deaths;
                        covidMyRS.totalCases = (int)region.today_confirmed;
                        covidMyRS.totalDeaths = (int)region.today_deaths;
                        covidMyRS.date = region.date;
                        covidMyRsList.Add(covidMyRS);
                        break;
                    }


                }
            }


            return covidMyRsList;
        }
    }
}
