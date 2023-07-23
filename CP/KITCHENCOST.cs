using System;
using System.Collections.Generic;
using System.Linq;

public class KITCHENCOST
{
      public static void Compute2(List<int> freshness,int value1)
    {
        string[] costs = Console.ReadLine().Split(" ");
        List<string> ListCosts = new List<string>(costs);
        List<int> ListCosts1 = ListCosts.Select(x => Convert.ToInt32(x)).ToList();
        //To get the freshness of eachitem 
        int count = 0;
        for(int i = 0;i < ListCosts1.Count;i++){
            if(freshness[i] >= value1){
                count= count + ListCosts1[i];
            }
        }
        Console.WriteLine(count);
    }
     public static void Compute1(int input,int value)
    {
        string[] inputs1 = Console.ReadLine().Split(" ");
        List<string> ListInputs = new List<string>(inputs1);
        List<int> ListOutputs1 = ListInputs.Select(x => Convert.ToInt32(x)).ToList();
        //To get the freshness of eachitem 
        if(ListOutputs1.Count == input){
            Compute2(ListOutputs1,value);
        }
    }
   
    public static void Compute()
    {
        string[] inputs = Console.ReadLine().Split(" ");
        List<string> ListInputs = new List<string>(inputs);
        List<int> ListOutputs = ListInputs.Select(x => Convert.ToInt32(x)).ToList();
        //Take inputs
        //N means number of items
        int N = ListOutputs[0];
        //Freshness of eachitem
        int X = ListOutputs[1];
        Compute1(N,X);
        
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
