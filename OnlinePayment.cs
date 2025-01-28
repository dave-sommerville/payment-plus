
namespace PaymentPlus
{   
    public abstract class OnlinePayment :Payment
    {
        public string PaymentGateway {  get; set; }
        public OnlinePayment(double amount, string currency, string paymentGateway) :base(amount, currency)
        {
            PaymentGateway = paymentGateway;
        }
        public override void ValidatePayment()
        {
            base.ValidatePayment();
            if (EndsWithZero(Amount))
            {
                throw new ArgumentOutOfRangeException(nameof(Amount), "Online payments must be whole dollars (end with 00)");
            }
            if (Amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Amount), "Online payments must exceed $5.00");
            }
        }
        public abstract void Authorize();
    }
}
