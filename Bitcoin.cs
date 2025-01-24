namespace PaymentPlus
{
    public class Bitcoin :OnlinePayment
    {
        public string WalletID { get; set; }

        //  Need Wallet ID
        public Bitcoin(int amount, string currency, string paymentGateway, string walletID) :base(amount, currency, paymentGateway)
        {
            WalletID = walletID;
        }
        public abstract string ProcessPayment()
        {

        }
        public abstract bool ValidatePayment()
        {

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
