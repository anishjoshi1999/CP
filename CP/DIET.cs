using System;

class Program
{
    static void Main()
    {
        int t, n, k;
        t = int.Parse(Console.ReadLine());

        while (t-- > 0)
        {
            string[] nk = Console.ReadLine().Split();
            n = int.Parse(nk[0]);
            k = int.Parse(nk[1]);

            int[] arr = new int[n];
            string[] numbers = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(numbers[i]);
            }

            int ex = 0, el = 0;
            for (int i = 0; i < n; i++)
            {
                el += arr[i];
                if (k > el)
                {
                    ex = i + 1;
                    break;
                }
                el -= k;
            }

            if (ex == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO " + ex);
            }
        }
    }
}
