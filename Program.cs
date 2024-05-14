using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long Start;
            bool playing = true;
            Console.WriteLine("Welcome to the Collatz Conjecture plaything");
            while (playing)
            {
                Console.WriteLine("Input the first number for the 3n+1 algorithm or 0 if you want to exit the program:");
                Start = Convert.ToInt64(Console.ReadLine());
                if(Start == 0){
                    Console.WriteLine("Thank you for playing with the Collatz conjecture");
                    playing = false;
                }
                else {
                    Console.WriteLine("Starting the algorithm:");
                    collatz(Start, 0); 
                }
            }
        }
        static void collatz(long prev_step,int numSteps)
        {
            Console.WriteLine(prev_step);
            if (prev_step <0)
            {
                Console.WriteLine("An error occurred (Integer Overflow)\n");
            }
            else if(prev_step == 1){
                Console.WriteLine("It took " + numSteps +" steps to reach 1 from the given number\n");

            } else if (prev_step % 2 == 0){
                collatz(prev_step/2, numSteps+1);

            } else if(prev_step % 2 == 1){
                collatz(3*prev_step+1,numSteps+1);
            }

            
        }
    }
}