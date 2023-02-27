using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWord
{
    public class Program
    {
        static void Main(string[] args)
        {
            string str = "tevc dfg";

            string revers = Anagram.Revers(str); 

            Console.WriteLine(revers);
            Console.ReadLine();
 
        }
    }
}
