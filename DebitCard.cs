using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Patern
{
    class DebitCard : ITransitionOfPayment
    {
        public void MakePayment(Product product)
        {
            Console.WriteLine("Taking money from your DEBIT card...\n" +
                "Product: {0} Price: {1}", product.Name, product.Price);
        }
    }
}
