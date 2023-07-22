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
        double P = ListOutputs[0];
        double Q = ListOutputs[1];
        double totalPoints = P + Q;
        if((Math.Floor(totalPoints / 2)) % 2 == 0){
            Console.WriteLine("Alice");
        }else{
            Console.WriteLine("Bob");
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
