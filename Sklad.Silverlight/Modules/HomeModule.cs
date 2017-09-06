using Nancy;

namespace Sklad.Silverlight.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => View["Index.html"];
        }
    }
}
