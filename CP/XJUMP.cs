using System;
using System.Collections.Generic;
using System.Linq;

public class XJUMP
{
     public static void Compute()
    {
        string[] inputs = Console.ReadLine().Split(" ");
        List<string> ListInputs = new List<string>(inputs);
        List<int> ListOutputs = ListInputs.Select(x => Convert.ToInt32(x)).ToList();
        //Take Inputs
        double X = ListOutputs[0];
        double Y = ListOutputs[1];
        double TotalSteps;
        double Steps;
        double RemainingSteps;
        Steps = Math.Floor(X / Y);
        RemainingSteps = X % Y;
        if(RemainingSteps < Y){
            TotalSteps = Steps + RemainingSteps;
            Console.WriteLine(TotalSteps);
            
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
