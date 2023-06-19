using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChef
{
    public class CP_1
    {
        public static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            while (t != 0)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                string? s = Console.ReadLine();
                int count = 0;
                bool value = true;
                for (int i = 0; i < n; i++)
                {
                    if (s[i] != 'a' && s[i] != 'e' && s[i] != 'i' && s[i] != 'o' && s[i] != 'u')
                    {
                        count++;
                    }
                    else
                    {
                        count = 0;
                    }
                    if (count >= 4)
                    {
                        value = false;
                        break;
                    }
                }
                if (value)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }

                t--;
            }
        }
    }
}
