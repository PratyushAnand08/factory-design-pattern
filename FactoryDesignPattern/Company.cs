using System;
namespace FactoryDesignPattern
{
    //Concrete Creator Class
    public class CompanyOne : Logistics
    {
        public override ITransport ModeOfDelivery()
        {
            return new SeaTransport();
        }
    }

    //Concrete Creator Class
    public class CompanyTwo : Logistics
    {
        public override ITransport ModeOfDelivery()
        {
            return new AirTransport();
        }
    }
}
