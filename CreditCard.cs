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
        //For credit payments, the minimum is $5.00 if using CAD or USD, but €10.00 with EUR.

    }
}
