using System;
using System.Collections.Generic;
using System.Linq;

public class OFFICE
{
     public static void Compute()
    {
        string[] inputs = Console.ReadLine().Split(" ");
        List<string> ListInputs = new List<string>(inputs);
        List<int> ListOutputs = ListInputs.Select(x => Convert.ToInt32(x)).ToList();

        // Separate inputs
        int X = ListOutputs[0];
        int Y = ListOutputs[1];
        
        int TotalHours = (4 * X) + Y;
        Console.WriteLine(TotalHours);
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
