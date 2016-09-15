using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumIntegersHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] addNum = { 1, 5, 7, 9 }; //create array
            answer(addNum); 
            Console.WriteLine("The sum of the AddNum array is {0}", answer(addNum)); //sum of adding array values
        }

        static int answer(params int[] numbers) //begin method
        {
            int sum = 0; // creating temp vaiable for math
            
            for (int i = 0; i < numbers.Length; i++) //counter to go thru the array
            {
                sum += numbers[i]; //math on the array variables
            }
            return sum; // sending final result to the writeline in main
        }


    }

}
