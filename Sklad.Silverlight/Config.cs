using System.IO;
using Newtonsoft.Json;

namespace Sklad.Silverlight
{
    class Config
    {
        public int Port { get; set; }

        internal static Config Load()
        {
            var json = File.ReadAllText("config.json");
            return JsonConvert.DeserializeObject<Config>(json);
        }
    }
}
