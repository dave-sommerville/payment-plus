using System.Diagnostics;

namespace PaymentPlus
{
    public class PaymentManager
    {
        public LinkedList<Payment> PaymentList { get; set; }
        public PaymentManager(LinkedList<Payment> paymentList)
        {
            PaymentList = paymentList;
        }
        public void AddPayment(Payment payment)
        {
            PaymentList.AddFirst(payment);
        }
        public void ValidatePaymentsAll()
        {
            foreach (Payment pay in PaymentList)
            {
                pay.ValidatePayment();
            }
        }
        public void AuthorizePayements()
        {
            foreach (Payment pay in PaymentList)
            {
                if (pay is OnlinePayment a)
                {
                    a.Authorize();
                }
            }
        }
        public void RecordOffline()
        {
            foreach (Payment pay in PaymentList)
            {
                if (pay is OfflinePayment b)
                {
                    b.RecordPayment();
                }
            }
        }
        public void ProcessPaymentsAll()
        {
            foreach (Payment pay in PaymentList)
            {
                pay.ProcessPayment();
            }
        }
    }
}
