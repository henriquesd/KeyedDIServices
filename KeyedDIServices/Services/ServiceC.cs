using KeyedDIServices.Interfaces;

namespace KeyedDIServices.Services
{
    public class ServiceC : IService
    {
        public string Execute()
        {
            return "Service C was executed.";
        }
    }
}