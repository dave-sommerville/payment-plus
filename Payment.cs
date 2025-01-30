namespace PaymentPlus
{
    public abstract class Payment
    {
        public double Amount { get; set; }
        public string Currency { get; set; }

        public Payment(double amount, string currency)
        {
            Amount = Math.Round(amount, 2);
            Currency = currency;
        }
        public abstract void ProcessPayment();
        public virtual void ValidatePayment()
        {
            if (Amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Amount), "Amount must be greater than zero");
            }
            if (!IsAlphaNum(Currency))
            {
                throw new ArgumentException("Only letters and numbers permitted");
            }
            if (string.IsNullOrEmpty(Currency))
            {
                throw new ArgumentException("Currency must be in CDN, USD, or EUR");
            } else if (Currency.ToLower() != "cdn" && Currency != "usd" && Currency != "eur") {
                throw new ArgumentException("Currency must be in CDN, USD, or EUR");
            }
        }
        public abstract string LogPayment();
        public static int GetDecimalPlaces(double number)
        {
            string numberString = number.ToString();
            if (numberString.Contains("."))
            {
                return numberString.Split('.')[1].Length;
            } else
            {
                return 0;
            }
        }
        public static bool IsAlphaNum(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            return input.All(char.IsLetterOrDigit);
        }
    }
}
