using System;
using System.Collections.Generic;

public class Test
{
    public static void Dolls()
    {
        int N = Convert.ToInt32(Console.ReadLine());

        // Use a dictionary to store the count of each doll
        Dictionary<int, int> dollCounts = new Dictionary<int, int>();

        for (int i = 0; i < N; i++)
        {
            int doll = Convert.ToInt32(Console.ReadLine());

            // Increment the count of the doll in the dictionary
            if (dollCounts.ContainsKey(doll))
                dollCounts[doll]++;
            else
                dollCounts[doll] = 1;
        }

        // Find the dolls with an odd count
        foreach (var pair in dollCounts)
        {
            if (pair.Value % 2 != 0)
            {
                Console.WriteLine(pair.Key);
            }
        }
    }

    public static void Main()
    {
        // Number of test cases
        int tests = Convert.ToInt32(Console.ReadLine());
        while (tests-- > 0)
        {
            Dolls();
        }
    }
}
