namespace PaymentPlus
{
    public class CreditCard :OnlinePayment
    {
        public int CardNumber { get; set; }
        public string ExpiryDate { get; set; } 
        public int CVV { get; set; }
        public CreditCard(int amount, string currency, string paymentGateway, int cardNumber, string expiryDate, int cvv) :base(amount, currency, paymentGateway)
        {
            CardNumber = cardNumber;
            ExpiryDate = expiryDate;
            CVV = cvv;
        }
        public abstract string ProcessPayment();
        public abstract bool ValidatePayment();
        public abstract string LogPayment();

        public override void Authorize()
        {
            base.Authorize();
        }

    }
}
