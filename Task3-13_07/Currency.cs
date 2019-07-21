using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Task3_13_07
{
    class Currency
    {
        [JsonProperty("currencyCodeA")]
        private int CurrencyCodeA { get; set; }

        [JsonProperty("currencyCodeB")]
        private int CurrencyCodeB { get; set; }

        [JsonProperty("date")]
        private long Date { get; set; }

        [JsonProperty("rateBuy")]
        private float RateBuy { get; set; }

        [JsonProperty("rateSell")]
        private float RateSell { get; set; }

        [JsonProperty("rateCross")]
        private float RateCross { get; set; }

        public List<Currency> currencies;

        private readonly string URL = "https://api.monobank.ua/bank/currency";

        public async Task GetCurrenciesAsync()
        {
            using(HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.GetAsync(URL);
                if (response.IsSuccessStatusCode)
                {
                    string currenciesResponce = await response.Content.ReadAsStringAsync();
                    this.currencies = JsonConvert.DeserializeObject<List<Currency>>(currenciesResponce);
                }
            }
        }
    }
}
