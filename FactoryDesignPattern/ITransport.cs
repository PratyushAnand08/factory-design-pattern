using System;

// Interface declaring an operation which all concrete class will implement 
namespace FactoryDesignPattern
{
    public interface ITransport
    {
        string Deliver();
    }
}
