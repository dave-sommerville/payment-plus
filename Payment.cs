using System.Text.RegularExpressions;

namespace PaymentPlus
{
    public abstract class Payment
    {
        public double Amount { get; set; }
        public string Currency { get; set; }

        public Payment(double amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }
        public abstract void ProcessPayment();
        public virtual void ValidatePayment()
        {
            if (Amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Amount), "Amount must be greater than zero");
            }
            if (GetDecimalPlaces(Amount) != 2)
            {
                throw new ArgumentOutOfRangeException(nameof(Amount), "Amount must have 2 decimal places");
            }
            if (!IsAlphaNum(Amount.ToString()) || !IsAlphaNum(Currency))
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
                return numberString.Split(".").Length;
            } else
            {
                return 0;
            }
        }
        public static bool EndsWithZero(double number)
        {
            double fractionalPart = number % 1;
            fractionalPart = Math.Round(fractionalPart * 100, 10);
            return fractionalPart % 100 == 0;
        }
        public static bool IsAlphaNum(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Z0-9]+$");
        }
        /*
                if (int.TryParse(myString, out int result))
        {
            Console.WriteLine("The string is a valid integer.");
        }
        else
        {
            Console.WriteLine("The string is not a valid integer.");
        }
*/
    }
}
