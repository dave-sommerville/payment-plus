namespace PaymentPlus
{
    public class Cash : OfflinePayments
    {
        public Cash(double amount, string currency) : base(amount, currency)
        {

        }
        public override void ProcessPayment()
        {
            Console.Write($"Cash payment of {Amount} {Currency} completed");
        }
        public override string LogPayment()
        {
            return $"Cash payment of {Amount} {Currency} completed";
        }
        public override void RecordPayment()
        {
            Console.WriteLine(LogPayment());
        }
    }
}
