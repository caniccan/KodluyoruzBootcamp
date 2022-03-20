using System;

namespace PrimeNumberFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            //we will find out if the number entered by the user is prime

            int number, control = 0, counter = 0, i = 2;
        back:
            try
            {
                Console.Write("Enter a number :");
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)        //we check the number input with try-catch
            {
                Console.Write("you have entered an incorrect value, do you want to try again ? [y/n] :");
                char answer = Convert.ToChar(Console.ReadLine());
                if (answer=='y')
                    goto back;
                else                //we ask the user what to do in case of a possible incorrect entry
                {
                    Console.WriteLine("Prime number finding process will not happen");
                    goto skip;
                }
            }

            while (i<number)       //we find out if the number entered with the while loop is prime
            {
                if (number % i == 0)
                    control++;
                i++;
            }
            if (control == 0)
                Console.WriteLine($"{number} is a prime number!");
            else                                                        //we print the result to console
                Console.WriteLine($"{number} is not a prime number!");
            skip:
            Console.WriteLine("Prime numbers between 0 and 10000 will be printed. [press any key to continue]");
            Console.ReadKey();
            Console.WriteLine("==============================================================================");
            
            for (int j = 2; j <= 10000; j++)
            {
                control = 0;

                for (int k = 2; k < j; k++)
                {
                    if (j % k == 0)                    //we find prime numbers from 1 to 10000 with for loops
                    {
                        control = 1;
                        break;
                    }
                }
                if (control == 0)
                {
                    Console.WriteLine("{0} is the prime number! ", j);
                    counter++;
                }
            }
            Console.WriteLine("=========================");                        //we print the results to console
            Console.WriteLine($"{counter} prime numbers found between 0 and 10000");
        }
    }
}
