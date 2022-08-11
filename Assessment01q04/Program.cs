using System;

// Raihan Khalil Abdillah, 30065695
// 04/08/2022 - 04/08/2022
// Perfect Number and Twin-Prime number generator
// This program will calculate twin primes and perfect numbers up to max value inputted
// This code had to be debugged and cleaned up

namespace Assessment01q04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Max number for Perfect Number: "); // for Perfect Number
            int max1 = Convert.ToInt32(Console.ReadLine());
            PerfectNumber(max1);

            Console.Write("Input Max number for Twin-Prime Number: "); // for Twin Prime
            int max2 = Convert.ToInt32(Console.ReadLine());
            TwinPrimes(max2);

            Console.WriteLine("\n\nEnd of Program");
           
        }
        #region Perfect Number 

        /// <summary>
        /// Perfect number is when all divisor of the number, can be added and equal to the number itself.
        /// perfect number, a positive integer that is equal to the sum of its proper divisors, excluding the number itself. https://www.britannica.com/science/perfect-number https://en.wikipedia.org/wiki/Perfect_number
        /// e.g 6 is a Perfect Number.
        /// 6 is divisible by 1, 2 and 3
        /// 1 + 2 + 3 = 6
        /// </summary>
        /// <param name="uppperLimit"></param>

        static void PerfectNumber(int uppperLimit)
        {
            int divisor; // declaring variable at the top
            int sum;

            for (int counter = 0; counter < uppperLimit; counter++) // program will keep looping 'max1' amount of time
            {
                sum = 0;
                for (divisor = 1; divisor < counter; divisor++) // calculation will keep looping 'max1' amount of time because 'divisor' will always be higher than 'counter'
                {
                    if (counter % divisor == 0) // when 'counter'%'divisor' == 0, it satisfies the first condition of Perfect Number
                        sum = sum + divisor; // all %'divisor' == 0 has to be summed up ('sum') to find if the 'counter' satisfies the second condtion of Perfect Number
                }
                if (sum == counter) // when 'sum' == 'counter', the second condition of Perfect Number is satisfied
                    Console.WriteLine("perfect number is {0}", counter);
            }
        }
        #endregion Perfect Number

        #region Twin-Prime Number

        /// <summary>
        /// Twin-Prime number is when two different prime numbers are seperated by 2 digits.
        /// A twin prime is a prime number that is either 2 less or 2 more than another prime number—for example, either member of the twin prime pair (41, 43). https://en.wikipedia.org/wiki/Twin_prime
        /// e.g 5 and 7, 11 and 13
        /// </summary>
        /// <param name="upperLimit"></param>
        
        static void TwinPrimes(int upperLimit)
        {
            int firstPrime; // declaring variable at the top
            int secondPrime;
            int count1 = 0;
            int count2 = 0;

            for (firstPrime = 3; firstPrime < upperLimit; firstPrime++)
            {
                for (int j = 2; j < firstPrime; j++) 
                {
                    if (firstPrime % j == 0)
                    {
                        count1++;
                        break;
                    }
                }
                secondPrime = firstPrime + 2;
                for (int k = 2; k < firstPrime; k++)
                {
                    if (secondPrime % k == 0)
                    {
                        count2++;
                        break;
                    }
                }
                if (count1 == 0 && count2 == 0) // both counter need to be equal to print twin-primes
                { 
                    Console.WriteLine("twin primes are {0}, {1}", firstPrime, secondPrime); 
                }
                count1 = 0; count2 = 0;
            }
        }
        #endregion Twin-Prime Number

    }
}
