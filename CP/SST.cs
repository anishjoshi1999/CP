using System;
using System.Collections.Generic;
using System.Linq;

public class SST
{
     public static void Compute()
    {
        string[] inputs = Console.ReadLine().Split(" ");
        List<string> ListInputs = new List<string>(inputs);
        List<int> ListOutputs = ListInputs.Select(x => Convert.ToInt32(x)).ToList();
        //Take Inputs
        double A = ListOutputs[0];
        double B = ListOutputs[1];
        double ValuationA = A * 10;
        double ValuationB = B * 5;
        if(ValuationA > ValuationB){
            Console.WriteLine("First");
        }else if(ValuationA < ValuationB){
            Console.WriteLine("Second");
        }else {
            Console.WriteLine("Any");
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
