using System;
using System.Collections.Generic;
using System.Linq;

public class MINPIZZA
{
     public static void Compute()
    {
        string[] inputs = Console.ReadLine().Split(" ");
        List<string> ListInputs = new List<string>(inputs);
        List<int> ListOutputs = ListInputs.Select(x => Convert.ToInt32(x)).ToList();
        //Take Inputs
        int N = ListOutputs[0];
        int X = ListOutputs[1];
        
        double TotalSlicesRequired = N * X;
        // a pizza contains only 4 slices
        Console.WriteLine((int)Math.Ceiling(TotalSlicesRequired / 4));
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
