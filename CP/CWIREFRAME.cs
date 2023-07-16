using System;
using System.Collections.Generic;
using System.Linq;

public class CWIREFRAME
{
    public static void Compute()
    {
        string[] inputs = Console.ReadLine().Split(" ");
        List<string> ListInputs = new List<string>(inputs);
        List<int> ListOutputs = ListInputs.Select(x => Convert.ToInt32(x)).ToList();

        // Separate inputs
        int N = ListOutputs[0];
        int M = ListOutputs[1];
        int X = ListOutputs[2];

        int TotalCost = 2 * (N + M) * X;
        Console.WriteLine(TotalCost);

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
