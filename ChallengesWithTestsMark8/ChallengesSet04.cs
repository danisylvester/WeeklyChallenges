using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            if(numbers == null)
            {
                return 0;
            }
            int result = 0;
            foreach(int num in numbers)
            {
                if(num % 2 == 0)
                {
                    result += num;
                }
                else
                {
                    result -= num;
                }
            }
            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var array = new string[] { str1, str2, str3, str4 };
            array = array.OrderBy(a => a.Length).ToArray();
            return array.First().Length;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var numList = new List<int>() { number1, number2, number3, number4 };
            return numList.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 && sideLength2 + sideLength3 > sideLength1;
        }

        public bool IsStringANumber(string input)
        {
            double result;
            return double.TryParse(input, out result);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int countOfNull = objs.Where(n => n == null).ToArray().Count();
            int countOfNotNull = objs.Where(o => o != null).ToArray().Count();
            return countOfNull > countOfNotNull;

        }

        public double AverageEvens(int[] numbers)
        {
            if(numbers is null || numbers.All(n => n % 2 != 0))
            {
                return 0;
            }
            else
            {
                return numbers.Where(n => n % 2 == 0).ToArray().Average();
            }
        }

        public int Factorial(int number)
        {
            if(number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            int result = 1;        
            for (int i = 1; i <= number; i++)
            {
               result *= i;
            }
            return result;
        }
    }
}
