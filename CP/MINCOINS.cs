using System;
using System.Collections.Generic;
using System.Linq;

public class MINCOINS
{
   
    public static void Compute()
    {
        string[] inputs = Console.ReadLine().Split(" ");
        List<string> ListInputs = new List<string>(inputs);
        List<int> ListOutputs = ListInputs.Select(x => Convert.ToInt32(x)).ToList();
        //Take Inputs
        double X = ListOutputs[0];
        if(X % 5 != 0){
            Console.WriteLine(-1);
        }else{
            double Remainder = X % 10;
            double Quotient = Math.Floor(X / 10);
            Console.WriteLine((Remainder / 5) + Quotient);
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
