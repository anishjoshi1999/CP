using System;
using System.Collections.Generic;
using System.Linq;

public class FOODPLAN
{
   
    public static void Compute()
    {
        string[] inputs = Console.ReadLine().Split(" ");
        List<string> ListInputs = new List<string>(inputs);
        List<int> ListOutputs = ListInputs.Select(x => Convert.ToInt32(x)).ToList();
        //Take Inputs
        //N means order online
        double N = ListOutputs[0];
        //M means via resturant
        double M = ListOutputs[1];
        if((0.9 * N) < M){
            Console.WriteLine("Online");
        }else if((0.9 * N) > M){
            Console.WriteLine("Dining");
        }else{
            Console.WriteLine("Either");
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
