using COVID19;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FormCovid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      public   Dictionary<string, List<string>> Countries;

        public MainWindow()
        {
            InitializeComponent();

            HttpClient client = new HttpClient();
            HttpResponseMessage covidResponse = new HttpResponseMessage();
            client.BaseAddress = new Uri("https://api.covid19tracking.narrativa.com/");

            covidResponse = client.GetAsync("api/2020-03-10").Result;

            string response = covidResponse.Content.ReadAsStringAsync().Result;

            CovidRS covidRS = JsonConvert.DeserializeObject<CovidRS>(response);

            Countries = new Dictionary<string, List<string>>();

            foreach (var country in covidRS.dates["2020-03-10"].countries)
            {
                string keyDicCountries = string.Empty;
                List<string> valuesDicCountries = new List<string>();

                keyDicCountries = country.Key;

                foreach (var region in country.Value.regions)
                {
                    valuesDicCountries.Add(region.name_es);
                }


                Countries.Add(keyDicCountries, valuesDicCountries);
            }


            foreach (var country in Countries)
            {
                ListBoxCountry.Items.Add(country.Key);
            }

        }


        private void SearchClick(object sender, RoutedEventArgs e)
        {

            string country = TextBoxCountry.Text;
            string region = TextBoxRegion.Text;

            string dateFrom = DatesRange.SelectedDates[0].ToString("dd-MM-yyyy");

            string dateTo = DatesRange.SelectedDates[DatesRange.SelectedDates.Count - 1].ToString("dd-MM-yyyy");

            var covidMyRS = Covid19.doCovidProcess(country, region, dateFrom, dateTo);

            var result = Covid19.buildStringTelegram(covidMyRS);

            TextBoxResult.Text = result;
        }

        private void TextBoxCountry_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ListBoxCountry_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string countrySelected = ListBoxCountry.SelectedItem.ToString();

            Countries.TryGetValue(countrySelected, out List<string> regions);
            foreach (var region in regions)
            {
                ListBoxRegion.Items.Add(region);
            }



        }
    }
}
