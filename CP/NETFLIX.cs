using System;
using System.Collections.Generic;
using System.Linq;

public class NETFLIX
{
    public static void Compute()
    {
        string[] inputs = Console.ReadLine().Split(" ");
        List<string> ListInputs = new List<string>(inputs);
        List<int> ListOutputs = ListInputs.Select(x => Convert.ToInt32(x)).ToList();

        // Separate inputs
        int A = ListOutputs[0];
        int B = ListOutputs[1];
        int C = ListOutputs[2];
        int X = ListOutputs[3];

        if(A + B >= X || A + C >= X || B+ C >= X) {
            Console.WriteLine("Yes");
        }
        else
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
