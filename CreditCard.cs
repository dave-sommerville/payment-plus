namespace PaymentPlus
{
    public class CreditCard :OnlinePayment
    {
        public int CardNumber { get; set; }
        public int ExpiryDate { get; set; } 
        public int CVV { get; set; }
        public CreditCard(double amount, string currency, string paymentGateway, int cardNumber, int expiryDate, int cvv) :base(amount, currency, paymentGateway)
        {
            CardNumber = cardNumber;
            ExpiryDate = expiryDate;
            CVV = cvv;
        }
        public override void ProcessPayment()
        {
            Console.WriteLine($"Credit Card payment of {Amount} {Currency} completed.");
        }
        public override void ValidatePayment()
        {
            base.ValidatePayment();
            if (Currency.ToLower() == "eur" && Amount < 10)
            {
                throw new ArgumentOutOfRangeException(nameof(Amount), "Credit Card payments in EUR must be more than 10.00");
            }
            if (CardNumber.ToString().Length != 16)
            {
                throw new ArgumentOutOfRangeException(nameof(CardNumber), "Credit Card number must be 16 numbers long.");
            }
            if (ExpiryDate.ToString().Length != 4)
            {
                throw new ArgumentOutOfRangeException(nameof(ExpiryDate), "Expiry Date must be four digits long (MMYY)");
            }
            if (CVV.ToString().Length > 16)
            {
                throw new ArgumentOutOfRangeException(nameof(CVV), "cvv must be 3 digits long");
            }
        }
        public override string LogPayment()
        {
            return $"Credit Card payment of {Amount} {Currency} completed Credit Card#: {CardNumber}, Expiry Date: {ExpiryDate}, CVV: {CVV}";
        }

        public override void Authorize()
        {
            Console.WriteLine("Credit Card payment authorized");
        }

    }
}
