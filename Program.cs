using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Transactions;

namespace PaymentPlus
{
    public class Program
    {
        static void Main(string[] args)
        {
            //  Must demonstrate to users how to process payments 

        }
        //  Will need a parse function 
        private static int PrintMenu(int options)
        {
            int intDecision;
            bool isValid;
            do
            {
                string decision = Console.ReadLine();
                isValid = int.TryParse(decision, out intDecision) && intDecision >= 1 && intDecision <= options;
                if (!isValid)
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            } while (!isValid);
            return intDecision;
        }
    }
}
