using System;
using System.Collections.Generic;
using System.Linq;

public class LASTLEVELS
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
        double TotalTime;
        if(X <= 3){
            TotalTime = X * Y;
        }else{
        
            double Breaks = Math.Floor(X / 3);
            if(X % 3 != 0){
            TotalTime = (X * Y) + Breaks * Z;
            }else{
                 TotalTime = (X * Y) + ((Breaks - 1) * Z);
            }
        }
        Console.WriteLine(TotalTime);
        
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
