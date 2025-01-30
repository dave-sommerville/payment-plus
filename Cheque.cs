namespace PaymentPlus
{
    public class Cheque :OfflinePayment
    {
        int ChqNumber { get; set; }
        string BankName { get; set; }
        public Cheque(double amount, string currency, int chqNumber, string bankName) : base(amount, currency)
        {
            ChqNumber = chqNumber;
            BankName = bankName;
        }
        public override void ProcessPayment()
        {
            Console.WriteLine($"Cheque payment of {Amount} {Currency} completed");
        }
        public override void ValidatePayment()
        {
            base.ValidatePayment();
            if ( ChqNumber.ToString().Length > 16)
            {
                throw new ArgumentOutOfRangeException(nameof(ChqNumber), "Cheque number can't be more than 16 numbers long");
            }
            if (ChqNumber < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(ChqNumber), "Cheque number must be a positive number greater than zero");
            }
            //if (!EndsWithZero(Amount))
            //{
            //    throw new ArgumentOutOfRangeException(nameof(Amount), "Cheque payments must be whole dollars (end with 00)");
            //}
        }
        public override string LogPayment()
        {
            return $"Cheque payment of {Amount} {Currency}. Chq# {ChqNumber} from bank {BankName}";
        }
        public override void RecordPayment()
        {
            Console.WriteLine(LogPayment());
        }
    }
}
