
namespace PaymentPlus
{   // Abstract Class
    public class OnlinePayment :Payment
    {
        public string PaymentGateway {  get; set; }
        public OnlinePayment(int amount, string currency, string paymentGateway) :base(amount, currency)
        {
            PaymentGateway = paymentGateway;
        }
        //  Specifies Abstract method 
        public void Authorize()
        {
            //            In general, you cannot accept payments with amounts ending in .99(e.g 0.99, 1.99), except for cash payments, which can end in any number.
            //For online payments, the transaction amount must be greater than $5.00 / €5.00(in whichever currency is used)

        }
    }
}
