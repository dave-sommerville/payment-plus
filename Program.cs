namespace PaymentPlus
{
    public class Program
    {
        static void Main(string[] args)
        {
            // First lets create a Payment Manager for a new client 

            PaymentManager newClient = new PaymentManager(new LinkedList<Payment>());

            //  Now that we've initialized the client's Payment Manager, we can create payments to be added. 
            //  Payments must be valid for their type. For example
            Cash cashPayment1 = new Cash(100.00, "CDN");
            // But the following payments throw errors, as the payment must be a valid amount in an accepted currency
            Cash cashPayment2 = new Cash(-100.00, "CDN");
            Cash cashPayment3 = new Cash(100.00, "DOGE");
            //  Also, EUR is not an accepted currency for offline payments, so the following transactions will throw errors 
            Cash cashPayment4 = new Cash(100.00, "EUR");
            Cheque chqPayment1 = new Cheque(100.00, "EUR", 123456, "RBC");
            //  To create a cheque payment, you must also enter a valid cheque number and bank name
            //  So this is a valid cheque payment
            Cheque chqPayment2 = new Cheque(100.00, "CDN", 123456, "RBC");
            //  But this is not
            Cheque chqPayment3 = new Cheque(100.00, "CDN", -123456, "Fauxnance");
            //  All online payments must end with double zeros (".00") so for example a valid bit coin payment would be
            Bitcoin bitcoinPayment1 = new Bitcoin(100.00, "CDN", "Bitcoin", "123ABC");
            //  And an invalid one would be 
            Bitcoin bitcoinPayment2 = new Bitcoin(100.99, "CDN", "Bitcoin", "123ABC");
            //  All online payments must be at least $5.00 as well, so an invalid Bitcoin transaction would be 
            Bitcoin bitcoinPayment3 = new Bitcoin(1.00, "CDN", "Bitcoin", "123ABC");
            //  The Bitcoin wallet must also be valid (No special characters) 
            Bitcoin bitcoinPayment4 = new Bitcoin(100.00, "CDN", "Bitcoin", "*/$#%^$");
            //  Finally, the following is a valid credit card payment 
            CreditCard creditCardPayment1 = new CreditCard(100.00, "CDN", "MasterCard", 1234567891234567, 0429, 741);
            // But credit card in EUR must be over 10.00 Euros
            CreditCard creditCardPayment2 = new CreditCard(9.00, "EUR", "MasterCard", 1234567891234567, 0429, 741);
            //  And the credit card must have valid authorization numbers 
            CreditCard creditCardPayment3 = new CreditCard(100.00, "CDN", "MasterCard", 123456789123456, 04, 1);

            //  Once a payment is created, simply add it using the Payment Managers add method 
            newClient.AddPayment(cashPayment1);
            newClient.AddPayment(chqPayment1);
            newClient.AddPayment(bitcoinPayment1);
            newClient.AddPayment(creditCardPayment1);

            //  You can now validate, log, and process all the payments using the client's method
            newClient.ValidatePaymentsAll();
            newClient.AuthorizePayements();
            newClient.RecordOffline();
            newClient.ProcessPaymentsAll();
        }
    }
}
