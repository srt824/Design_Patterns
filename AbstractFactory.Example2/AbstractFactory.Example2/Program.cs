using AbstractFactory.Example2.Factories;

namespace AbstractFactory.Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPaymentGatewayFactory paymentGatewayFactory = new PayPalGatewayFactory();

            // Inject the payment gateway factory into the payment service
            PaymentService paymentService = new PaymentService(paymentGatewayFactory);

            decimal amount = 100.00m;
            paymentService.ProcessPayment(amount);

            // If you want to switch to another payment provider, simply change the factory
            IPaymentGatewayFactory anotherPaymentGatewayFactory = new StripeGatewayFactory();
            PaymentService anotherPaymentService = new PaymentService(anotherPaymentGatewayFactory);
            anotherPaymentService.ProcessPayment(amount);
        }
    }
}
