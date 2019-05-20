using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Patern
{
    interface ITransitionOfPayment
    {
        void MakePayment(Product product);
    }
}
