using System;
using System.Collections.Generic;
using System.Linq;

public class COUGAME
{
    public static void Compute()
    {
        string[] inputs = Console.ReadLine().Split(" ");
        List<string> ListInputs = new List<string>(inputs);
        List<int> ListOutputs = ListInputs.Select(x => Convert.ToInt32(x)).ToList();

        // Separate inputs
        int Girls = ListOutputs[0];
        int Boys = ListOutputs[1];

        // if girls number is greater then boys 
        // 7G and 7B
        if(Girls >= Boys)
        {
            Console.WriteLine(0);
        }else
        {
            // 3G and 5B
            Console.WriteLine(Boys - Girls);
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
