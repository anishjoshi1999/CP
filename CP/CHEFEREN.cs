using System;
using System.Collections.Generic;
using System.Linq;

public class CHEFEREN
{
    public static void Compute()
    {
        string[] inputs = Console.ReadLine().Split(" ");
        List<string> ListInputs = new List<string>(inputs);
        List<int> ListOutputs = ListInputs.Select(x => Convert.ToInt32(x)).ToList();
        //Take Inputs
        int X = ListOutputs[0];
        int Y = ListOutputs[1];
        int Z = ListOutputs[2];
        int totalEvenTime = 0;
        int totalOddTime = 0;
        int TotalTime;
        for(int i = 1; i <= X;i++){
            if(i % 2 == 0){
                totalEvenTime += Y;
            }else{
                totalOddTime += Z;
            }
        }
        TotalTime = totalEvenTime + totalOddTime;
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
