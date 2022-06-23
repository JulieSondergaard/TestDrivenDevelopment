using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopment
{
    // This class takes care of validating data
    public class Validator
    {
        public static bool IsPinValid(int pin, int enteredPin)
        {
            if (pin == enteredPin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsCardNumberLengthValid(string insertedCardNumber)
        {
            int validCardNumberLength = 16;

            if (insertedCardNumber.Length == validCardNumberLength)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
