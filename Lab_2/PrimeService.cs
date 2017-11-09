using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate == 1)
            {
                return false;
            }

            for (int i = 2; i <= candidate / 2; ++i)
            {
                if (candidate % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
