using System;
using System.Globalization;

namespace ExercicioCinco
{
    class Program 
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++){
                if ((i % 3 == 0) && (i % 5 == 0)){
                    Console.WriteLine($"{i} FizzBuzz");
                }
                else if (i % 3 == 0) {
                    Console.WriteLine($"{i} Fizz");
                }
                else if (i % 5 == 0){
                    Console.WriteLine($"{i} Buzz");
                }
                else{
                    Console.WriteLine(i);
                }
            }

        }
    }
}
