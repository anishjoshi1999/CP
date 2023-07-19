using System;
using System.Collections.Generic;
using System.Linq;

public class AMR15A
{
     public static void Compute()
    {
        string[] inputs = Console.ReadLine().Split(" ");
        List<string> ListInputs = new List<string>(inputs);
        List<int> ListOutputs = ListInputs.Select(x => Convert.ToInt32(x)).ToList();
        
        int EvenWeapons = 0;
        int OddWeapons = 0;
        
        foreach(int weapon in ListOutputs){
            if(weapon % 2 == 0){
                EvenWeapons++;
            }else{
                OddWeapons++;
            }
        }
        if(EvenWeapons > OddWeapons){
            Console.WriteLine("READY FOR BATTLE");
        }else{
            Console.WriteLine("NOT READY");
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
