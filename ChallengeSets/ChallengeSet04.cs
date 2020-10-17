using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengeSets
{
    public class ChallengeSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return numbers.Where(x => x % 2 == 0).Sum() - numbers.Where(x => x % 2 == 1).Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var lengths = new int[] { str1.Count(), str2.Count(), str3.Count(), str4.Count()};
            return lengths.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var size = new int[] { number1, number2, number3, number4};
            return size.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 + sideLength2 > sideLength3 && sideLength3 + sideLength1 > sideLength2 && sideLength2 + sideLength3 > sideLength1;
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out double x);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            return objs.Count(x => x == null) > objs.Count() - objs.Count(x => x == null);
        }

        public double AverageEvens(int[] numbers)
        {
            try
            {
                return numbers.Where(x => x % 2 == 0).Average();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int Factorial(int number)
        {
            return number == 0 ? 1 :Enumerable.Range(1, number).Aggregate((x, y) => x * y);
        }
    }
}
