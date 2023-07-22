using System;
using System.Collections.Generic;
using System.Linq;

public class FILLCANDIES
{
     public static void Compute()
    {
        string[] inputs = Console.ReadLine().Split(" ");
        List<string> ListInputs = new List<string>(inputs);
        List<int> ListOutputs = ListInputs.Select(x => Convert.ToInt32(x)).ToList();
        //Take Inputs
        //Total number os candles
        double N = ListOutputs[0];
        //K means total number of Pockets a bag has
        double K = ListOutputs[1];
        //M means a pocket can hold at most M candles
        double M = ListOutputs[2];
        double TotalBags;
        double TotalCapacity = K * M;
        if(N % TotalCapacity != 0){
            TotalBags = Math.Floor(N / TotalCapacity) + 1;
            
        }else{
            TotalBags = Math.Floor(N / TotalCapacity);
            
        }
        Console.WriteLine(TotalBags);
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
