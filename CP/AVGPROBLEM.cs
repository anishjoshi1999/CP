using System;
using System.Collections.Generic;
using System.Linq;

public class AVGPROBLEM
{
    public static void Compute()
    {
        string[] inputs = Console.ReadLine().Split(" ");
        List<string> ListInputs = new List<string>(inputs);
        List<int> ListOutputs = ListInputs.Select(x => Convert.ToInt32(x)).ToList();

        // Separate inputs
        double A = ListOutputs[0];
        double B = ListOutputs[1];
        double C = ListOutputs[2];

        if((A + B )/ 2 > C)
        {
            Console.WriteLine("Yes");
        }else
        {
            Console.WriteLine("No");
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
