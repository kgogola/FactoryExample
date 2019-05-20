using static Factory_Patern.Program;

namespace Factory_Patern
{
    class EngineOfPayment
    {
        ITransitionOfPayment transition = null;

        public void CreatorOfPayment(Product product, EMethodOfPayment method)
        {
            TransitionOfPaymentFactory paymentFactory = new TransitionOfPaymentFactory();
            this.transition = paymentFactory.CreateTransitionOfPayment(method, product);
            this.transition.MakePayment(product);
        }
    }
}
