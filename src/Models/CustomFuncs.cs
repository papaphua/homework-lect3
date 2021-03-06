using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_lect3.Models
{
    internal class CustomFuncs
    {
        internal static int CalculateFact(int n)
        {
            if(n < 0)
            {
                throw new Exception("Invalid value. Factorial is defined only for non-negative integers.");
            }
            else if(n == 0)
            {
                return 1;
            }
            else
            {
                var numList = Enumerable.Range(1, n);
                var res = numList.Aggregate((currNum, nextNum) => currNum * nextNum);
                return res;
            }
        }

        internal static List<ulong> CalculateFibonacci(int n)
        {
            if(n <= 0)
            {
                throw new Exception("Invalid value.");
            }
            else
            {
                var numList = Enumerable.Range(0, n);
                var resList = new List<ulong>();
                numList.ToList()
                    .ForEach(i => resList.Add(i > 1 ? resList[i - 1] + resList[i - 2] : (ulong)i ));
                return resList;
            }
        }
    }
}
