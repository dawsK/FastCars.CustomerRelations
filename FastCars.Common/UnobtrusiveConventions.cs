using NServiceBus;

namespace FastCars.Common
{
    public class UnobtrusiveConventions : IWantToRunBeforeConfiguration
    {
        public void Init()
        {
            Configure.Instance.DefiningEventsAs(t => t.Namespace != null
                                                     && t.Namespace.StartsWith("FastCars")
                                                     && t.Namespace.EndsWith("Events"));
        }
    }
}
