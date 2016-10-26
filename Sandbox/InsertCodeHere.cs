using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            MysticNumbers newNumber = new MysticNumbers();
            Console.WriteLine($"Largest number is: {newNumber.ThreeNumbers(23, 20, 19)}");

            Console.WriteLine($"Largest number is: {newNumber.TwoNumbers(23, 24)}");
            Console.WriteLine($"Largest number is: {newNumber.ThreeNumbersVersion2(23, 24, 54)}");
            Console.WriteLine($"Largest number is: {newNumber.FourNumbers(23, 24, 10, 5)}");

            // The LAST line of code should be ABOVE this line
        }
    }
}
