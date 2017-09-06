using System;
using Nancy.Hosting.Self;

namespace Sklad.Silverlight
{
    class NancySelfHost
    {
        private NancyHost host;
        private readonly Uri uri;

        public NancySelfHost(int port)
        {
            uri = new UriBuilder(Uri.UriSchemeHttp, "localhost", port).Uri;
        }

        public void Start()
        {
            host = new NancyHost(uri);
            host.Start();
            Console.WriteLine("Running on {0}.", uri);
        }

        public void Stop()
        {
            host.Stop();
            Console.WriteLine("Stopped. Good bye!");
        }
    }
}
