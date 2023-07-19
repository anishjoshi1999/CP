using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
     public static void SecondInput(int totalPeople,int Age)
    {
        string[] inputs1 = Console.ReadLine().Split(" ");
        List<string> ListInputs1 = new List<string>(inputs1);
        List<int> ListOutputs1 = ListInputs1.Select(x => Convert.ToInt32(x)).ToList();
        int count = 0;
        if(inputs1.Length == totalPeople){
            foreach(var value in ListOutputs1){
                if(value >= Age){
                    count++;
                }
            }
            Console.WriteLine(count);
        }else {
            Console.WriteLine("Invalid Inputs");
        }
    }
     public static void Input()
    {
        string[] inputs = Console.ReadLine().Split(" ");
        List<string> ListInputs = new List<string>(inputs);
        List<int> ListOutputs = ListInputs.Select(x => Convert.ToInt32(x)).ToList();
        //Take Inputs
        int N = ListOutputs[0];
        int X = ListOutputs[1];
        SecondInput(N,X);
    }

	public static void Main()
	{
		// Number of test cases
        int tests = Convert.ToInt32(Console.ReadLine());
        while (tests-- > 0)
        {
            Input();
        }
	}
}
