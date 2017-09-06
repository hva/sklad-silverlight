using Topshelf;

namespace Sklad.Silverlight
{
    class Program
    {
        static void Main(string[] args)
        {
            var port = Config.Load().Port;

            HostFactory.Run(x =>
            {
                x.Service<NancySelfHost>(s =>
                {
                    s.ConstructUsing(name => new NancySelfHost(port));
                    s.WhenStarted(tc => tc.Start());
                    s.WhenStopped(tc => tc.Stop());
                });

                x.RunAsLocalSystem();
                x.SetDescription("Sklad Silverlight Host");
                x.SetDisplayName("Sklad Silverlight");
                x.SetServiceName("Sklad-Silverlight");
            });
        }
    }
}
