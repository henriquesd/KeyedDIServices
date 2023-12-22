using KeyedDIServices.Interfaces;

namespace KeyedDIServices.Services
{
    public class ServiceB : IService
    {
        public string Execute()
        {
            return "Service B was executed.";
        }
    }
}