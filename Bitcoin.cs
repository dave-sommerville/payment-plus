namespace PaymentPlus
{
    public class Bitcoin :OnlinePayment
    {
        public string WalletID { get; set; }
        public Bitcoin(double amount, string currency, string paymentGateway, string walletID) :base(amount, currency, paymentGateway)
        {
            WalletID = walletID;
        }
        public override void ProcessPayment()
        {
            Console.WriteLine($"Bitcoin payment of {Amount} {Currency} completed");
        }
        public override void ValidatePayment()
        {
            base.ValidatePayment();
            if (!IsAlphaNum(WalletID))
            {
                throw new ArgumentOutOfRangeException(nameof(WalletID), "Wallet must be letters and numbers only.");
            }
        }
        public override string LogPayment()
        {
            return $"Bitcoin payment of {Amount} {Currency} completed. Wallet# {WalletID}";
        }

        public override void Authorize()    
        {
            Console.WriteLine("Bitcoin payment authorized");
        }
    }

}
