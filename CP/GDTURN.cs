using System;
using System.Collections.Generic;
using System.Linq;

public class GDTURN
{
    public static void Compute()
    {
        string[] inputs = Console.ReadLine().Split(" ");
        List<string> ListInputs = new List<string>(inputs);
        List<int> ListOutputs = ListInputs.Select(x => Convert.ToInt32(x)).ToList();

        // Separate inputs
        int Chef = ListOutputs[0];
        int Chefina = ListOutputs[1];

        if (Chef + Chefina > 6)
        {
            Console.WriteLine("Yes");
        }
        else
        {
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
