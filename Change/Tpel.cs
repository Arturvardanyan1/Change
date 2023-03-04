using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change
{
    internal class Tpel
    {
        public void Tpell(int k)
        {
            int[] x = { 100000, 50000, 20000, 10000, 5000, 2000, 1000, 500, 200, 100, 50, 20, 10 };
            for (int i = 0; i < x.Length; i++)
            {
                int z = k / x[i];
                if (z > 0)
                    Console.WriteLine(z + "*" + x[i]);
                k = k - (z * x[i]);
            }
            
        }
    }
}
