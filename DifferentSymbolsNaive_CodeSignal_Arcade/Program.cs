using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentSymbolsNaive_CodeSignal_Arcade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string st = "asadaa";
            int x = differentSymbolsNaive(st);
            Console.WriteLine(x);
        }

        static int differentSymbolsNaive(string s)
        {
            HashSet<char> list = new HashSet<char>();
            for (int i = 0; i < s.Length; i++)
            {
                list.Add(s[i]);
            }
            return list.Count;
        }

    }
}
