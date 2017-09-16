using System;

namespace Sklad.Silverlight.Api.Auth
{
    public class AuthToken
    {
        public string AccessToken { get; set; }

        public DateTime Expires { get; set; }

        public string UserName { get; set; }

        public string Role { get; set; }
    }
}
