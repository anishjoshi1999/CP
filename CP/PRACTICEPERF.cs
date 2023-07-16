using System;
using System.Collections.Generic;
using System.Linq;
public class PRACTICEPERF
{

    public static void Main()
    {
        //Behave just like Map Function
        string[] inputs = Console.ReadLine().Split(" ");
        List<string> list = new List<string>(inputs);
        List<int> IntegerList= list.Select(x => Convert.ToInt32(x)).ToList();

        int count = 0;
        foreach(int x in IntegerList)
        {
            if(x >= 10)
            {
                count++;
            }
        }  
        Console.WriteLine(count);

    }
}
