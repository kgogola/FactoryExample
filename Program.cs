using System;

namespace Factory_Patern
{
    class Program
    {
        static void Main(string[] args)
        {
            Product prod = new Product();
            prod.Name = "Super Washing Machine";
            prod.Price = 560;
            prod.Description = "hi-tech washing machine";

            EngineOfPayment engine = new EngineOfPayment();
            engine.CreatorOfPayment(prod, EMethodOfPayment.Normal_Transfer);
            Console.ReadKey();
        }

        public enum EMethodOfPayment
        {
            Credit_Card,
            Debit_Card,
            Normal_Transfer
        }
    }
}
