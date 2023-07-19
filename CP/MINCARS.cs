using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
     public static void Compute()
    {
        string[] inputs = Console.ReadLine().Split(" ");
        List<string> ListInputs = new List<string>(inputs);
        List<int> ListOutputs = ListInputs.Select(x => Convert.ToInt32(x)).ToList();
        //Take Inputs
        //Grab total number of friends
        double N = ListOutputs[0];
        double TotalCars = Math.Ceiling(N / 4);
        Console.WriteLine(TotalCars);
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
