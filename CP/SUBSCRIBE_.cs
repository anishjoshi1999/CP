using System;
using System.Collections.Generic;
using System.Linq;

public class SUBSCRIBE_
{
    public static void Compute()
    {
        string[] inputs = Console.ReadLine().Split(" ");
        List<string> ListInputs = new List<string>(inputs);
        List<int> ListOutputs = ListInputs.Select(x => Convert.ToInt32(x)).ToList();

        // Separate inputs
        double N = ListOutputs[0];
        double X = ListOutputs[1];

        //6 People can share one Chef-TV Subscription

        double TotalCost;

        if(N <=6)
        {
            Console.WriteLine(X);
        }else
        {
            TotalCost =  Math.Ceiling(N / 6) * X;
            Console.WriteLine(TotalCost);
        }
    }

    public static void Main()
    {
        // Number of test cases
        int tests = Convert.ToInt32(Console.ReadLine());
        while (tests-- > 0)
        {
            Compute();
        }
    }
}
