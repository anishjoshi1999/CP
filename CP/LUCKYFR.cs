using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    static List<int> GetDigitsList(int number){
        string numberStr = number.ToString();
        List<int> digitsList = new List<int>();
        foreach(char digitChar in numberStr){
            if(int.TryParse(digitChar.ToString(),out int digit)){
                digitsList.Add(digit);
            }
        }
        return digitsList;
    }
   
   
   
    public static void Compute()
    {
        string[] inputs = Console.ReadLine().Split(" ");
        List<string> ListInputs = new List<string>(inputs);
        List<int> ListOutputs = ListInputs.Select(x => Convert.ToInt32(x)).ToList();
        //Take inputs
        int N = ListOutputs[0];
        List<int> Lists = GetDigitsList(N);
        int count = 0;
        foreach(int i in Lists){
            if(i == 4){
                count++;
            }
        }
        Console.WriteLine(count);
        
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
