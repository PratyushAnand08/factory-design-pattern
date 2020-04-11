using System;

// Contains all concrete class
namespace FactoryDesignPattern
{
    public class SeaTransport : ITransport
    {
        public string Deliver()
        {
            return "delivering through Sea routes";
        }
    }

    public class LandTransport : ITransport
    {
        public string Deliver()
        {
            return "delivering through Land routes";
        }
    }

    public class AirTransport : ITransport
    {
        public string Deliver()
        {
            return "delivering through Air routes";
        }
    }
}
