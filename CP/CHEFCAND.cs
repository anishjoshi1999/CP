using System;
using System.Collections.Generic;
using System.Linq;

public class CHEFCAND
{
     public static void Compute()
    {
        string[] inputs = Console.ReadLine().Split(" ");
        List<string> ListInputs = new List<string>(inputs);
        List<int> ListOutputs = ListInputs.Select(x => Convert.ToInt32(x)).ToList();
        //Take Inputs
        //Total Number of Childrens
        int N = ListOutputs[0];
        //Total Number of Candles the chef Already has
        int X = ListOutputs[1];
        //A Candle packet contains 4 candles
        double CandlesToBeBrought;
        CandlesToBeBrought = (N - X) <= 0 ? 0: (N-X);
        
        Console.WriteLine(Math.Ceiling(CandlesToBeBrought / 4));
        
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
