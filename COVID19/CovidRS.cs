using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace COVID19
{
    public class CovidRS
    {

        public Dictionary<string, Dates> dates { get; set; }
        public Total total { get; set; }
        public string updated_at { get; set; }

        public class Total
        {
            public string date { get; set; }
            public string name { get; set; }
            public string name_es { get; set; }
            public string name_it { get; set; }
            public string rid { get; set; }
            public string source { get; set; }
            public int? today_confirmed { get; set; }
            public int? today_deaths { get; set; }
            public int? today_new_confirmed { get; set; }
            public int? today_new_deaths { get; set; }
            public int? today_new_open_cases { get; set; }
            public int? today_new_recovered { get; set; }
            public int? today_open_cases { get; set; }
            public int? today_recovered { get; set; }
            public double? today_vs_yesterday_confirmed { get; set; }
            public double? today_vs_yesterday_deaths { get; set; }
            public double? today_vs_yesterday_open_cases { get; set; }
            public double? today_vs_yesterday_recovered { get; set; }
            public int? yesterday_confirmed { get; set; }
            public int? yesterday_deaths { get; set; }
            public int? yesterday_open_cases { get; set; }
            public int? yesterday_recovered { get; set; }
        }

        public class Dates
        {
            public Dictionary<string, Countries> countries { get; set; }

            public class Countries
            {
                public string date { get; set; }
                public string id { get; set; }
                public string name { get; set; }
                public string name_es { get; set; }
                public string name_it { get; set; }
                public List<Regions> regions { get; set; }
                public string source { get; set; }
                public int? today_confirmed { get; set; }
                public int? today_deaths { get; set; }
                public int? today_hospitalised_patients_with_symptoms { get; set; }
                public int? today_intensive_care { get; set; }
                public int? today_new_confirmed { get; set; }
                public int? today_new_deaths { get; set; }
                public int? today_new_hospitalised_patients_with_symptoms { get; set; }
                public int? today_new_intensive_care { get; set; }
                public int? today_new_open_cases { get; set; }
                public int? today_new_recovered { get; set; }
                public int? today_new_total_hospitalised_patients { get; set; }
                public int? today_open_cases { get; set; }
                public int? today_recovered { get; set; }
                public int? today_total_hospitalised_patients { get; set; }
                public double? today_vs_yesterday_confirmed { get; set; }
                public double? today_vs_yesterday_deaths { get; set; }
                public object today_vs_yesterday_hospitalised_patients_with_symptoms { get; set; }
                public double? today_vs_yesterday_intensive_care { get; set; }
                public double? today_vs_yesterday_open_cases { get; set; }
                public double? today_vs_yesterday_recovered { get; set; }
                public double? today_vs_yesterday_total_hospitalised_patients { get; set; }
                public int? yesterday_confirmed { get; set; }
                public int? yesterday_deaths { get; set; }
                public int? yesterday_hospitalised_patients_with_symptoms { get; set; }
                public int? yesterday_intensive_care { get; set; }
                public int? yesterday_open_cases { get; set; }
                public int? yesterday_recovered { get; set; }
                public int? yesterday_total_hospitalised_patients { get; set; }

                public class Regions
                {
                    public string date { get; set; }
                    public string id { get; set; }
                    public string name { get; set; }
                    public string name_es { get; set; }
                    public string name_it { get; set; }
                    public string source { get; set; }
                    public int? today_confirmed { get; set; }
                    public int? today_deaths { get; set; }
                    public int? today_hospitalised_patients_with_symptoms { get; set; }
                    public int? today_intensive_care { get; set; }
                    public int? today_new_confirmed { get; set; }
                    public int? today_new_deaths { get; set; }
                    public int? today_new_hospitalised_patients_with_symptoms { get; set; }
                    public int? today_new_intensive_care { get; set; }
                    public int? today_new_open_cases { get; set; }
                    public int? today_new_recovered { get; set; }
                    public int? today_new_total_hospitalised_patients { get; set; }
                    public int? today_open_cases { get; set; }
                    public int? today_recovered { get; set; }
                    public int? today_total_hospitalised_patients { get; set; }
                    public double? today_vs_yesterday_confirmed { get; set; }
                    public double? today_vs_yesterday_deaths { get; set; }
                    public object today_vs_yesterday_hospitalised_patients_with_symptoms { get; set; }
                    public double? today_vs_yesterday_intensive_care { get; set; }
                    public double? today_vs_yesterday_open_cases { get; set; }
                    public double? today_vs_yesterday_recovered { get; set; }
                    public double? today_vs_yesterday_total_hospitalised_patients { get; set; }
                    public int? yesterday_confirmed { get; set; }
                    public int? yesterday_deaths { get; set; }
                    public int? yesterday_hospitalised_patients_with_symptoms { get; set; }
                    public int? yesterday_intensive_care { get; set; }
                    public int? yesterday_open_cases { get; set; }
                    public int? yesterday_recovered { get; set; }
                    public int? yesterday_total_hospitalised_patients { get; set; }

                }



            }
        }

    }
}
