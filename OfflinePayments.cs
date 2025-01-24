
namespace PaymentPlus
{   //  Abstract Class
    public abstract class OfflinePayments :Payment
    {
        public OfflinePayments(int amount, string currency) : base(amount, currency)
        {

        }
        public abstract string ProcessPayment();
        public abstract bool ValidatePayment();
        public abstract string LogPayment();

        public abstract void RecordPayment();
            //  Abstract method, supposed to be an offline record, only needs to print for assignment 
            //For offline payments, EUR is not accepted.
    }
}
