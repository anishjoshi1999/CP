using System;
using System.Collections.Generic;
using System.Linq;

public class CHEFSCORE
{
     public static void Compute()
    {
        string[] inputs = Console.ReadLine().Split(" ");
        List<string> ListInputs = new List<string>(inputs);
        List<int> ListOutputs = ListInputs.Select(x => Convert.ToInt32(x)).ToList();
        //Take Inputs
        int N = ListOutputs[0];
        int X = ListOutputs[1];
        int Y = ListOutputs[2];
        int Remainder = Y % X;
        int Quotient = Y / X;
        if(Remainder == 0){
            //the quotient must be less than or equal to N 
            if(Quotient <= N) {
                Console.WriteLine("Yes");
            }
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
