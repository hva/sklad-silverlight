using System;
using System.IO;
using System.Windows;
using Newtonsoft.Json;
using Warehouse.Silverlight.Infrastructure;

namespace Warehouse.Silverlight
{
    public class Config : IConfig
    {
        [JsonProperty("base_url")]
        public string BaseUrl { get; set; }

        public Config()
        {
            var uri = new Uri("config.json", UriKind.Relative);
            var res = Application.GetResourceStream(uri);
            using (var sr = new StreamReader(res.Stream))
            {
                var json = sr.ReadToEnd();
                JsonConvert.PopulateObject(json, this);
            }
        }
    }
}
