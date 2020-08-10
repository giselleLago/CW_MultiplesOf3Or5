using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CW_MultiplesOf3Or5
{
    public class Kata
    {
        public int Solution(int value)
        {
            return Enumerable.Range(0, value).Where(e => e % 3 == 0 || e % 5 == 0).Sum();

            /* var count = 0;
             for (int i = 0; i < value; i++)
             {
                 if (i % 3 == 0 || i % 5 == 0)
                 {
                     count += i;
                 }
             }
             return count;*/
        }
    }
}
