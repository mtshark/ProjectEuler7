using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler7 {
    public class Euler7Main {
        private const int PrimeRequiredForSolution = 10001;
        static void Main(string[] args) {
            List<long> primes = GetPrimes(PrimeRequiredForSolution);
            for (int i = 0; i < primes.Count; i++) {
                Console.WriteLine("prime number " + i + " is: " + primes[i]);
            }
            Console.ReadKey();
        }

        public static bool IsPrime(int candidate) {
            if ((candidate & 1) == 0) {
                return candidate == 2;
            }

            for (int i = 3; (i * i) <= candidate; i += 2) {
                if ((candidate % i) == 0) {
                    return false;
                }
            }
            return candidate != 1;
        }

        public static List<long> GetPrimes(int numberOfPrimesToFind) {
            List<long> primes = new List<long>();
            if (numberOfPrimesToFind < 1)
                return primes;
            primes.Add(1);
            if (numberOfPrimesToFind > 1)
                primes.Add(2);
            for (int i = 3; primes.Count <= numberOfPrimesToFind; i += 2) {
                if (IsPrime(i))
                    primes.Add(i);
            }
            return primes;
        }
    }
}
