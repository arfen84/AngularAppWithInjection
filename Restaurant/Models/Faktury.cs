using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public  class Faktury
    {
        public static async Task<string> API(string nazwa, string miasto, string email)
        {
            string client = await DodajKlienta(nazwa, miasto, email);
            await DodajFakture(client);

            return "";
        }

        private static async Task<string> DodajKlienta(string clName, string miasto, string clEmail)
        {
            var postData = new
            {
                
                client = new
                {
                    name = clName,
                    tax_no = "someDataHere",
                    bank = "someDataHere",
                    bank_account = "someDataHere",
                    city = miasto,
                    country = "someDataHere",
                    email = clEmail,
                    person = "someDataHere",
                    post_code = "someDataHere",
                    phone = "someDataHere",
                    street = "someDataHere",
                    street_no = "someDataHere"
                }
            };
            var dataToPost = JsonConvert.SerializeObject(postData);

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://tuimprezapl.fakturownia.pl/clients.json ");

                var content = new StringContent(dataToPost, Encoding.UTF8, "application/json");
                var result = await client.PostAsync("someDataHere", content);
                string resultContent = await result.Content.ReadAsStringAsync();
               
                var res = JObject.Parse(resultContent)["id"].ToString();
                var interesting = res;
                return interesting;
            }
        }

        private static async Task<string> DodajFakture(string clientId)
        {
            var postData = new
            {
                api_token = "someDataHere",
                invoice = new
                {
                    kind = "vat",
                    sell_date = "someDataHere",
                    issue_date = "someDataHere",
                    payment_to = "someDataHere",
                    seller_name = "someDataHere",
                    seller_tax_no = "someDataHere",
                    client_id = clientId,
                    buyer_tax_no = "someDataHere",
                    positions = new { name = "someDataHere", tax = "23", total_price_gross = "1", quantity = "1" }

                }
            };
            var dataToPost = JsonConvert.SerializeObject(postData);

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("someDataHere";

                var content = new StringContent(dataToPost, Encoding.UTF8, "application/json");
                var result = await client.PostAsync("someDataHere", content);
                string resultContent = await result.Content.ReadAsStringAsync();
                var res = JObject.Parse(resultContent)["id"].ToString();
                var interesting = res;
                WyslijMailemFakture(res);
                return resultContent;
            }

        }

        private static async void WyslijMailemFakture(string number)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent("", Encoding.UTF8, "application/json");
                var result = await client.PostAsync("someDataHere", content);

                string resultContent = await result.Content.ReadAsStringAsync();
            }
        }
    }
}
