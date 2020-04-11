using System;
namespace FactoryDesignPattern
{
    // Creator class declaring the factory method which is supposed to return the object of Transport interface. 
    public abstract class Logistics
    {
        public abstract ITransport ModeOfDelivery();

        public string Delivery()
        {
            var delivery = ModeOfDelivery();

            return $"This is a Creator Class and does not know how delivery is going to happen. The concrete class calling this will be { delivery.Deliver() }";
        }
    }
}
