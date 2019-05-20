using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Patern
{
    class CreditCard : ITransitionOfPayment
    {
        public void MakePayment(Product product)
        {
            Console.WriteLine("Taking money from your CREDIT card...\n" +
                "Product: {0} Price: {1}", product.Name, product.Price);
        }
    }
}
