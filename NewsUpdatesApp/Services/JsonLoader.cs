using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using WorldNewsDM.Models;

namespace WorldNewsDM.Services
{
    public class JsonLoader
    {
        public static ObservableCollection<Country> LoadCountryJsonFromFile()
        {
            return JsonConvert.DeserializeObject<ObservableCollection<Country>>(JsonReader());
        }

        static string JsonReader()
        {
            string jsonFromFile;
            using (var reader = new StreamReader(GlobalVariables._path))
            {
                jsonFromFile = reader.ReadToEnd();
            }
            return jsonFromFile;
        }

        static string GetCountryUrl(string code)
        {
            return "http://newsapi.org/v2/top-headlines?country=" + code + "&apiKey=89e115ba2cc5474dbb8f474d4daecc82";
        }
        public static async Task<ObservableCollection<News>> GetNewsJsonFromUrl(Country selectedCountry)
        {
            using (var httpClient = new HttpClient())
            {
                var rawJSON = await httpClient.GetStringAsync(GetCountryUrl(selectedCountry.Code));
                return JsonConvert.DeserializeObject<NewsObject>(rawJSON).articles;          
            }
        }
    }
}
