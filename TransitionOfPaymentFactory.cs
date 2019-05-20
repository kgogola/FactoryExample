using System;
using System.Collections.Generic;
using System.Text;
using static Factory_Patern.Program;

namespace Factory_Patern
{
    class TransitionOfPaymentFactory
    {
        public virtual ITransitionOfPayment CreateTransitionOfPayment(EMethodOfPayment method, Product product)
        {
            ITransitionOfPayment transition = null;
            
            switch(method)
            {
                case EMethodOfPayment.Credit_Card:
                    transition = new CreditCard();
                    break;
                case EMethodOfPayment.Debit_Card:
                    transition = new DebitCard();
                    break;
                default:
                    break;
            }

            return transition;
        }
    }
}
