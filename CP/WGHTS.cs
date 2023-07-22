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
        double W = ListOutputs[0];
        double X = ListOutputs[1];
        double Y = ListOutputs[2];
        double Z = ListOutputs[3];
        
        if(W == X || W == Y || W == Z || W == X+Y || W == X + Z || W == Y + Z || W == X + Y + Z){
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
