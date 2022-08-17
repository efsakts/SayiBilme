using System;

namespace NumberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            Random ran = new Random();
            int holdNumber = ran.Next(1000, 9999);
            Console.WriteLine("guess a 4-digit number");
            int guess = Convert.ToInt32(Console.ReadLine());
            while (guess != holdNumber)
            {


                counter++;


                if (holdNumber < guess)
                {
                    Console.WriteLine("enter smaller number");
                }
                else if (holdNumber > guess)
                {
                    Console.WriteLine("enter bigger number");
                }
                guess = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Well done!.");
            Console.WriteLine("You know on the {0}. guess", counter);
        }
    }
}
