namespace PaymentPlus
{
    public class Cheque :OfflinePayments
    {
        int ChqNumber { get; set; }
        string BankName { get; set; }
        public Cheque(int amount, string currency, int chqNumber, string bankName) : base(amount, currency)
        {
            ChqNumber = chqNumber;
            BankName = bankName;
        }
        //For cheque payments in USD or EUR, it can only be in whole - dollar amounts($1.00 /€1.00, $5.00 /€5.00)

    }
}
