
namespace PaymentPlus
{   //  Abstract Class
    public class OfflinePayments :Payment
    {
        public OfflinePayments(int amount, string currency) : base(amount, currency)
        {

        }
        public void RecordPayment()
        {
            //  Abstract method, supposed to be an offline record, only needs to print for assignment 
            //            In general, you cannot accept payments with amounts ending in .99(e.g 0.99, 1.99), except for cash payments, which can end in any number.
            //For offline payments, EUR is not accepted.


        }
    }
}
