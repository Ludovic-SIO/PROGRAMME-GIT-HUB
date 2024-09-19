using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMME_GIT_HUB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quel est votre pseudo ?");
            string input = Console.ReadLine();
            Console.WriteLine("Votre pseudo est {0}", input);
            Console.ReadKey();
        }
    }
}
