using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class MysticNumbers
    {
        public int ThreeNumbers(int a, int b, int c)
        {
            int result;

            if (b > a)
            {
                result = b;
                if (c > b)
                {
                    result = c;
                }
            }
            else
            {
                result = a;
                if (c > a)
                {
                    result = c;
                }
            }

            return result;
            
        }//end of public int threenumbers

        public int TwoNumbers(int a, int b)
        {
            int result = a;

            if (b > a)
            {
                result = b;
            }

            return result;
        }
    }//end of class
}
