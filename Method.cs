using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSTUDY3202
{
    internal class Method
    {
        public int Multi(int a, int b)
        {
            return a * b;
        }
        /// <summary>
        /// min부터 max까지의 합
        /// </summary>
        /// <param name="min">시작값</param>
        /// <param name="max">최댓값</param>
        /// <returns>min부터 sum까지의 합계</returns>
        public int Sum(int min, int max)
        {
            int sum = 0;
            for(int i = min; i <= max; i++)
            {
                sum += i;
            }
            return sum;
        }

        public int Multiply(int min, int max)
        {
            int output = 1;
            for(int i = min; i <= max; i++)
            {
                output *= i;
            }
            return output;
        }
    }
}
