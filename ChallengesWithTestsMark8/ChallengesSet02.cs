using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return (vals.Length % 2 == 0);
        }

        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0);
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 != 0);
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers != null && numbers.Any())
            {
                return numbers.Min() + numbers.Max();
        }
            else
            {
                return 0;
            }
}

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return (str1.Length < str2.Length) ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            if(numbers == null)
            {
                return 0;
            }
            else
            {
            return numbers.Sum();
            }
        }

        public int SumEvens(int[] numbers)
        {   
            if(numbers == null)
            {
                return 0;
            }
            else
            {
                int sum = 0;
                foreach(int num in numbers)
                {
                    if(num % 2 == 0)
                    {
                        sum += num;
                    }
                }
            return sum;
            }
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if(numbers == null)
            {
                return false;
            }
            else
            {
                return (numbers.Sum() % 2 != 0);
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long count = 0;
            for(int i = 0; i < number; i++)
            {
                if(i % 2 != 0)
                {
                    ++count;
                }
            }
            return count;
        }
    }
}
