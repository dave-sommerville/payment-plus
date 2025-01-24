using System.Diagnostics;

namespace PaymentPlus
{
    public abstract class PaymentManager
    {
        //  Or linked or sorted list? 
        public List<int> AddPayment(Payment payment)
        {
            //  Constructs the payments, addds to list
        }
        public bool ValidatePaymentsAll(List<int> paymentListElement)
        {
            //  Operates Validate method on all list element
        }
        public List<int> RecordOffline()
        {
            //  If it can run method on list element, does run method
        }
        public void ProcessPaymentsAll()
        {
            //  Operates Process method on list elements 
        }
    }
}
