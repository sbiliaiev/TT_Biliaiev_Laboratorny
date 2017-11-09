using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Number
    {
        public static bool IsOdd(int value)
        {
            if (value % 2 == 1)
            {
                return true;
            }

            return false;
        }
    }
}
