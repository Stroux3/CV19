using System;
using System.Net;

namespace CV19Console 
{
    class Program 
    {
        const string DATA_URL = @"https://raw.githubusercontent.com/CSSEGISandData/COVID-19/refs/heads/master/csse_covid_19_data/csse_covid_19_time_series/time_series_covid19_confirmed_global.csv";

        static void Main(string[] args) 
        {
            HttpClient client = new();
            var response = client.GetAsync(DATA_URL).Result;
            var csv_str = response.Content.ReadAsStringAsync().Result;
            Console.ReadLine();
        }
    }
}
