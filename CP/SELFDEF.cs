using System;
using System.Collections.Generic;
using System.Linq;

public class SELFDEF
{
     public static void Compute1(int input)
    {
        string[] inputs = Console.ReadLine().Split(" ");
        List<string> ListInputs = new List<string>(inputs);
        List<int> ListOutputs = ListInputs.Select(x => Convert.ToInt32(x)).ToList();
        //Take Inputs
        int count = 0;
        if(ListOutputs.Count == input){
            foreach(int i in ListOutputs){
                if(i >= 10 && i <= 60){
                    count++;
                }
            }
            Console.WriteLine(count);
            
        }else{
            Console.WriteLine("Invalid Input");
        }
    }
   
    public static void Compute()
    {
        int input = Convert.ToInt32(Console.ReadLine());
        Compute1(input);
        
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
