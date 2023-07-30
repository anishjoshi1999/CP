using System;

class Program
{
    static void Main()
    {
        int numTestCases, days, proteinPerDay;
        numTestCases = int.Parse(Console.ReadLine());

        while (numTestCases-- > 0)
        {
            // Read the number of days (N) and the required protein per day (K)
            string[] nk = Console.ReadLine().Split();
            days = int.Parse(nk[0]);
            proteinPerDay = int.Parse(nk[1]);

            // Read the protein amounts for each day into an array
            int[] proteinAmounts = new int[days];
            string[] proteinValues = Console.ReadLine().Split();
            for (int i = 0; i < days; i++)
            {
                proteinAmounts[i] = int.Parse(proteinValues[i]);
            }

            int extraProtein = 0, remainingProtein = 0;
            for (int i = 0; i < days; i++)
            {
                // Add the protein bought in the morning to the total
                remainingProtein += proteinAmounts[i];

                // Check if Chef has enough protein for dinner
                if (proteinPerDay > remainingProtein)
                {
                    extraProtein = i + 1; // The first day with insufficient protein
                    break;
                }

                // Deduct the protein eaten during dinner
                remainingProtein -= proteinPerDay;
            }

            if (extraProtein == 0)
            {
                Console.WriteLine("YES"); // Chef has enough protein every day
            }
            else
            {
                Console.WriteLine("NO " + extraProtein); // Chef doesn't have enough protein from the 'extraProtein' day
            }
        }
    }
}
