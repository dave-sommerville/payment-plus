namespace PaymentPlus
{
    public class Bitcoin :OnlinePayment
    {
        public string WalletID { get; set; }
        public Bitcoin(double amount, string currency, string paymentGateway, string walletID) :base(amount, currency, paymentGateway)
        {
            WalletID = walletID;
        }
        public abstract string ProcessPayment()
        {

        }
        public override void ValidatePayment()
        {
            base.ValidatePayment();
            if (!IsAlphaNum(WalletID))
            {
                throw new ArgumentOutOfRangeException(nameof(WalletID), "Wallet must be letters and numbers only.");
            }
        }
        public abstract string LogPayment()
        {

        }

        public override void Authorize()    
        {
            base.Authorize();
        }
    }

}
