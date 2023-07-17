using System;
using System.Collections.Generic;
using System.Linq;

public class CGYM
{
    public static void Compute()
    {
        string[] inputs = Console.ReadLine().Split(" ");
        List<string> ListInputs = new List<string>(inputs);
        List<int> ListOutputs = ListInputs.Select(x => Convert.ToInt32(x)).ToList();

        // Separate inputs
        int X = ListOutputs[0];
        int Y = ListOutputs[1];
        int Z = ListOutputs[2];
        if(X + Y <= Z)
        {
            Console.WriteLine(2);
        }else if (X <= Z)
        {
            Console.WriteLine(1);
        }
        else
        {
            Console.WriteLine(0);
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
