using System;
using System.Net.Http;

namespace Warehouse.Silverlight.Data.Http
{
    public class BaseHttpClient : HttpClient
    {
        public BaseHttpClient()
        {
            BaseAddress = new Uri("https://sklad-staging.skl.by:8000");
        }
    }
}
