using System;
using System.Collections.Generic;
using System.Linq;

public class VISA
{
     public static void Compute()
    {
        string[] inputs = Console.ReadLine().Split(" ");
        List<string> ListInputs = new List<string>(inputs);
        List<int> ListOutputs = ListInputs.Select(x => Convert.ToInt32(x)).ToList();
        //Take Inputs
        if(ListOutputs.Count == 6){
            int X1 = ListOutputs[0];
            int X2 = ListOutputs[1];
            int Y1 = ListOutputs[2];
            int Y2 = ListOutputs[3];
            int Z1 = ListOutputs[4];
            int Z2 = ListOutputs[5];
            if(X2 >= X1 && Y2 >= Y1 && Z2 <= Z1){
                Console.WriteLine("Yes");
            }else{
                Console.WriteLine("No");
            }
            
        }else {
            Console.WriteLine("Invalid Inputs");
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
