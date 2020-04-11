using System;

namespace FactoryDesignPattern
{
    class Client
    {
        public void Main()
        {
            Console.WriteLine("In Client.Main()");

            Console.WriteLine("Logistics of the first company ->");
            CallCreator(new CompanyOne());

            Console.WriteLine("Logistics of the second company ->");
            CallCreator(new CompanyTwo());

            Console.WriteLine("End of Client");
        }

        public void CallCreator(Logistics logistics)
        {
            Console.WriteLine(logistics.Delivery());
        }
    }

    class Program
    {
        static void Main(string[] args) => new Client().Main();
    }
}
