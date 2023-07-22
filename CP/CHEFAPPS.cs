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
        double S = ListOutputs[0];
        double X = ListOutputs[1];
        double Y = ListOutputs[2];
        double Z = ListOutputs[3];
        double RemainingSpace = S - (X + Y);
        if(RemainingSpace >= Z){
            Console.WriteLine(0);
        }else{
            //if we delete the first app
            double RemainingSpaceAfterFirstApp = RemainingSpace + X;
            //if we delete the second app
            double RemainingSpaceAfterSecondApp = RemainingSpace + Y;
            //if we delete both apps 
            RemainingSpace = RemainingSpace + (X + Y);
            if(RemainingSpaceAfterFirstApp >= Z|| RemainingSpaceAfterSecondApp >= Z){
                Console.WriteLine(1);
            }else{
                Console.WriteLine(2);
            }
            
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
