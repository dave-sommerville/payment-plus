namespace PaymentPlus
{// Abstract class
    public class Payment
    {
        public int Amount { get; set; }
        public string Currency {  get; set; }

        public Payment(int amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }
            //  Assignmnent specifies abstract method
        public string ProcessPayment()
        {

        }
        public bool ValidatePayment()
        {

        }
        public string LogPayment()
        {
            //Prints out the details of the payment.You should aim to have this method print out the most accurate details, depending on the class implementation.
            //  This will definitely be getting overriden
        }
    }        
}
