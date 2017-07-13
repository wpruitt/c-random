using System;
using System.Collections.Generic;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> randomNumbers = new List<int>();
            while (randomNumbers.Count < 20)
            {
            randomNumbers.Add(random.Next(1, 51));
            }
            foreach (int number in randomNumbers)
            {
                Console.WriteLine(number);
            }
            List<int> squaredNumbers = new List<int>();
            foreach (int number in randomNumbers)
            {
                squaredNumbers.Add(number*number);
            }
            foreach (int number in squaredNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine($"squaredNumbers contains {squaredNumbers.Count} numbers.");
            squaredNumbers.RemoveAll(number => number %2 != 0);
            foreach (int number in squaredNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine($"squaredNumbers now contains {squaredNumbers.Count} numbers.");

            
        }
    }

}
