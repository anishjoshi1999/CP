using System;
using System.Collections.Generic;
using System.Linq;

public class BULLET
{
     public static void Compute()
    {
        string[] inputs = Console.ReadLine().Split(" ");
        List<string> ListInputs = new List<string>(inputs);
        List<int> ListOutputs = ListInputs.Select(x => Convert.ToInt32(x)).ToList();
        //Take Inputs
        double X = ListOutputs[0];
        double Y = ListOutputs[1];
        double Z = ListOutputs[2];
        //total time required to hit the goomba
        double time = Y / X;
        if(time <= Z){
            Console.WriteLine(Z-time);
        }else{
            Console.WriteLine(0);
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
