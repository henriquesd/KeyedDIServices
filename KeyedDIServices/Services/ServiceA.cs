using KeyedDIServices.Interfaces;

namespace KeyedDIServices.Services
{
    public class ServiceA : IService
    {
        public string Execute()
        {
            return "Service A was executed.";
        }
    }
}