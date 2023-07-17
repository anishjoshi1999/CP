using System;
using System.Collections.Generic;
using System.Linq;

public class CHEAPFOOD
{
    public static void Compute()
    {
        string[] inputs = Console.ReadLine().Split(" ");
        List<string> ListInputs = new List<string>(inputs);
        List<int> ListOutputs = ListInputs.Select(x => Convert.ToInt32(x)).ToList();

        // Separate inputs
        int X = ListOutputs[0];
        //Cash Discount is 100
        //10 percentage discount
        double DiscountViaCash;
        double DiscountViaPercentage;

        DiscountViaCash =  100;
        DiscountViaPercentage = X * 0.1;

        if (DiscountViaCash > DiscountViaPercentage)
        {
            Console.WriteLine(100);
        }
        else
        {
            Console.WriteLine(DiscountViaPercentage);
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
