using System;
using System.Collections.Generic;
using System.Linq;

public class CANCHEF
{
    public static void Main()
    {
        //t test cases
        int tests = Convert.ToInt32(Console.ReadLine());
        while(tests-->0) {
            string[] inputs = Console.ReadLine().Split(" ");
            List<string> ListInputs = new List<string>(inputs);
            List<int> ListOutputs = ListInputs.Select(x => Convert.ToInt32(x)).ToList();

            //seperate inputs
            int TotalPetrol = ListOutputs[0];
            int TotalDistance = 2 * ListOutputs[1];

            int TotalDistanceTravelledByPetrol = TotalPetrol * 15;
            if(TotalDistanceTravelledByPetrol >= TotalDistance)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
