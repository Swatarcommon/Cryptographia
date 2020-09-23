using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CalcPervoobr
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 p = 17;
            Int64 q = 3;
            Int32 i;
            BigInteger pervoobr;
            ArrayList result = new ArrayList();
            for (i = 1; i <= p - 1; i++)
            {
                result.Add(BigInteger.Pow(q, i) % p);
            }

            result.Sort();

            foreach (var pervoobraz in result)
            {
                Console.WriteLine(pervoobraz);
            }

            //Int64 p = 167;
            //Int64 q = 55;
            //Int32 i = 13;
            //Int32 letterNumb = 1;
            //BigInteger result;
            //Console.WriteLine((BigInteger.Pow(q, i)*letterNumb) % p);
        }
    }
}
