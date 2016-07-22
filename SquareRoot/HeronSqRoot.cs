using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exercise 1: Lets compute square root

//The Heron algorithm for computing the square root of a number N is: 

//1. Start with a guess number G, (for example, G = N / 2) 

//2. If G* G is close enough to N, then return G. (*1) 

//3. Otherwise, compute G = (G + N / G) / 2 and iterate.

//We are going to have a class that computes square root of numbers.We will provide the class with a 
//constructor that takes the acceptable error limit(*1, as a double).  

//Then we will implement a method that computes the square root for an arbitrary number.

//The method needs to validate the number is positive, and throw an exception otherwise, then will compute 
//the square root following Heron’s method, and return the given result(as a double). 

namespace SquareRoot
{
    class HeronSqRoot
    {
        /// <summary>
        /// Number input by the user as their guess of the square root
        /// </summary>
        public int _guessNumber { get; set; }

        /// <summary>
        /// Number to guess will be set when object is constructed
        /// Value will persist for the life of the object
        /// </summary>
        public double _number { get; set; }
        public double _errorLimit { get; set; }

        public HeronSqRoot(double errorLimit)
        {
            //Set the number to guess
            _number = 25;
            _errorLimit = errorLimit;
        }

        /// <summary>
        /// Get user guess for the square root value
        /// Check to ensure a number is provided
        /// </summary>
        /// <returns></returns>
        public double AskForNumber()
        {
            double result = 0;
            bool check = false;

            do
            {
                Console.Write("Which number do you want to calculate the square root for? ");
                string input = Console.ReadLine();
                check = Double.TryParse(input, out result);

                if (!check || result < 0)
                    Console.WriteLine("A valid number was not provided. Please try again.");

            } while (!check || result < 0);            

            return result;
        }

        /// <summary>
        /// Computes the square root of a number
        /// Validates the number is positive, and throw an exception otherwise
        /// </summary>
        public double CalcHeronSqRoot(double number)
        {                        
            if (Math.Round(number * number,1) == Math.Round(_number))
            {
                return number;
            }
            //Add an errorlimit for the range to check
            else if (number == Math.Round(_number + _errorLimit, 1) || number == Math.Round(_number - _errorLimit, 1))
            {
                return number;
            }

            return CalcHeronSqRoot( Math.Round(((number + (_number / number)) / 2),2));            
        }
        
    }
}
