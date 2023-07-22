using System;
using System.Collections.Generic;
using System.Linq;

public class WTRMIXING
{
    public static void Compute()
    {
        string[] inputs = Console.ReadLine().Split(" ");
        List<string> ListInputs = new List<string>(inputs);
        List<int> ListOutputs = ListInputs.Select(x => Convert.ToInt32(x)).ToList();
        //Take Inputs
        double A = ListOutputs[0];
        double B = ListOutputs[1];
        double X = ListOutputs[2];
        double Y = ListOutputs[3];
        double FinalIncrementByHotWater;
        double FinalDecrementByColdWater;
        if(A == B){
            Console.WriteLine("Yes");
        }else{
            if(A < B){
                //for increment 
                FinalIncrementByHotWater = A + X;
                if(FinalIncrementByHotWater >= B){
                    Console.WriteLine("Yes");
                }else{
                    Console.WriteLine("No");
                }
            }else{
                //for decrement 
                FinalDecrementByColdWater = A - Y;
                if(FinalDecrementByColdWater <= B){
                    Console.WriteLine("Yes");
                }else{
                    Console.WriteLine("No");
                }
                
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
