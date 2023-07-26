using System;
using System.Collections.Generic;
using System.Linq;

public class KTTABLE
{
    public static void Compute2(List<int> ListOutputs1,int temp)
    {
        // Take Inputs
        string[] inputs2 = Console.ReadLine().Split(" ");
        List<int> ListOutputs2 = inputs2.Select(x => Convert.ToInt32(x)).ToList();
        int count = 0;
        int prev = 0;
        int next = ListOutputs1[0];
        int diff;
            for (int i = 0; i < temp; i++)
            {
                diff = next - prev;
                if (ListOutputs2[i] <= diff)
                {
                    count++;
                }
                if(i+1 == temp){
                    break;
                }
                next = ListOutputs1[i+1];
                prev = ListOutputs1[i];
            }
            Console.WriteLine(count);
       
    }

    public static void Compute1(int n)
    {
        // Take Inputs
        string[] inputs1 = Console.ReadLine().Split(" ");
        List<int> ListOutputs1 = inputs1.Select(x => Convert.ToInt32(x)).ToList();
        Compute2(ListOutputs1,n);
    }

    public static void Compute()
    {
        string[] inputs = Console.ReadLine().Split(" ");
        List<int> ListOutputs = inputs.Select(x => Convert.ToInt32(x)).ToList();
        // Take Inputs
        int N = ListOutputs[0];
        Compute1(N);
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
