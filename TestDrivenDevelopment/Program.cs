using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopment
{
    class Program
    {
        static void Main(string[] args)
        {

            // Insert card
            Console.WriteLine("Insert Card");
            string insertedCardnumber = Console.ReadLine();

            // Validate Card number length
            Validator.IsCardNumberLengthValid(insertedCardnumber);

            // Enter pin
            int enteredPin = ATM.EnterPincode();

            //Validate pin
            Validator.IsPinValid(5522, enteredPin);
        }
    }
}
