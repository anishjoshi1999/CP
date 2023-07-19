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
        
        //N is total number of items
        int N = ListOutputs[0];
        //X is cost of each item
        int X = ListOutputs[1];
        //Total Cost 
        int TotalCost = N * X;
        
        //Total Cost must be greater then valid phone Number
        //must be greater then 10000
        
        if(TotalCost >= 10000 && TotalCost <= 99999){
            Console.WriteLine("Yes");
        }else{
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
