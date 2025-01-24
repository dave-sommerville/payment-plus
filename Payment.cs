namespace PaymentPlus
{// Abstract class
    public abstract class Payment
    {
        public int Amount { get; set; }
        public string Currency {  get; set; }

        public Payment(int amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }
        //  Assignmnent specifies abstract method
        public abstract string ProcessPayment(); // Specifies abstract 
        public virtual void ValidatePayment()
        {
            if (Amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Amount), "Amount must be greater than zero");
            }
            if (string.IsNullOrEmpty(Currency))
            {
                throw new ArgumentException("Currency must be in CDN, USD, or EUR");    //Make sure to change to lowercase 
            } else if (Currency != "cdn" && Currency != "usd" && Currency != "eur") {
                throw new ArgumentException("Currency must be in CDN, USD, or EUR");
            }
        }
        public abstract string LogPayment();
            //Prints out the details of the payment.You should aim to have this method print out the most accurate details, depending on the class implementation.
        
    }        
}
