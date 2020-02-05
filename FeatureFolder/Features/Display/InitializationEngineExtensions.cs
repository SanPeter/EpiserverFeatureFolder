using EPiServer.Framework.Initialization;
using Features.Display;
using System.Web.Mvc;

namespace Foundation.Cms.Extensions
{
    public static class InitializationEngineExtensions
    {
        public static void InitializeCms(this InitializationEngine context)
        {
            ViewEngines.Engines.Insert(0, new FeaturesViewEngine());
        }
    }
}
