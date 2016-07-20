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
            SquareRoot.SquareRoot sq = new SquareRoot.SquareRoot(.1);
            
            double numberGuess = sq.AskForNumber();
            double result = sq.CalcSquareRoot(numberGuess);
            
            Console.WriteLine("The square root of is {0}", result);
            Console.Read();
        }
    }
}
