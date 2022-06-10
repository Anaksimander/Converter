using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Converter.Model;
using Converter.View;

using System.Net.Http;
using System.Text.Json;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;

namespace Converter.ViewModel
{
    public class JsonRequesterViewModel
    {
        public ObservableCollection<Valute> Valutes { get; set; }

        public JsonRequesterViewModel()
        {
            Download();
        }

        //понимаю что не лучший вариант - но не знаю как правильно.
        /// <summary>
        /// загружаем данные
        /// </summary>
        /// <returns></returns>
        private async Task Download()
        {
            var client = new HttpClient();

            using (var response = await client.GetAsync(new Uri("https://www.cbr-xml-daily.ru/daily_json.js")))
            {
                var result = await response.Content.ReadAsStringAsync();
                JsonObj obj = JsonSerializer.Deserialize<JsonObj>(result);
                Valutes = new ObservableCollection<Valute>(obj.Valute.Values);
            }
        }
    }

}
