using System;
using System.Collections.Generic;
using System.Linq;
class COURSERG
{
    public static void Main(string[] args)
    {
        // n testcase
        int t = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < t; i++)
        {
            //take three inputs values (n,m,k)in a single input
            string[] Inputs = Console.ReadLine().Split();
            List<string> list = new List<string>(Inputs);
            List<int> IntegerInputs = list.Select(x => Convert.ToInt32(x)).ToList();
            int n = IntegerInputs[0];
            int m = IntegerInputs[1];
            int k = IntegerInputs[2];

            if (m - k >= n)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
