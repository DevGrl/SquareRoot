using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SquareRoot;

namespace CalcSquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            SquareRoot.HeronSqRoot sq = new SquareRoot.HeronSqRoot(.1);

            sq._number = sq.AskForNumber();
            double result = sq.CalcHeronSqRoot(sq._number);
            
            Console.WriteLine("The square root of is {0}", result);
            Console.Read();
        }
    }
}
