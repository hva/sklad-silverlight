using Topshelf;

namespace Sklad.Silverlight
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(x =>
            {
                x.Service<NancySelfHost>(s =>
                {
                    s.ConstructUsing(name => new NancySelfHost());
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
