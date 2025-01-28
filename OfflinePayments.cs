
namespace PaymentPlus
{
    public abstract class OfflinePayments :Payment
    {
        public OfflinePayments(double amount, string currency) : base(amount, currency)
        {

        }
        public override void ValidatePayment()
        {
            base.ValidatePayment();
            if (Currency.ToLower() == "eur")
            {
                throw new ArgumentException("EUR is not acceptable currency for offline payments");
            }
        }

        public abstract void RecordPayment();
    }
}
