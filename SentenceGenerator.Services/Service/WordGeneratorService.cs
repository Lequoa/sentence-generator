using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SentenceGenerator.Services.IService;
using SentenceGenerator.Services.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SentenceGenerator.Services.Service
{
    public class WordGeneratorService : IWordGeneratorService
    {
        private string baseUrl = "https://random-word-form.herokuapp.com/";
        private readonly HttpClient client;

        public WordGeneratorService()
        {
            client = new HttpClient();
        }

        public async Task<List<Words>> GetWords(string type)
        {
            string result = string.Empty;
            List<Words> wordsList = new List<Words>();
            try
            {
                using var webRequest = new HttpRequestMessage(HttpMethod.Get, new Uri($"{baseUrl}random/{type}?count=100"));
                var response = await client.SendAsync(webRequest);
                var content = await response.Content.ReadAsStringAsync();


                using (Stream stream = await response.Content.ReadAsStreamAsync())
                {
                    result = new StreamReader(stream).ReadToEnd();
                }

                var items = result.Split(",");

                foreach (var item in items)
                {
                    var word = new Words
                    {
                        Word = item
                    };
                    wordsList.Add(word);
                }
            }
            catch (Exception)
            {
                throw;
            }
            

            return wordsList;
        }
    }
}
