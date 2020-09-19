using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return !vals.All(b => b == true);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            else
            {
                int numOfOdds = numbers.Where(num => num % 2 != 0).Count();
                if (numOfOdds % 2 != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool containsUpper = password.Any(c => char.IsUpper(c));
            bool containsLower = password.Any(c => char.IsLower(c));
            bool containsNumber = password.Any(c => char.IsNumber(c));
            if(containsLower == true && containsUpper == true && containsNumber == true && password !=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if(divisor == 0)
            {
                return 0;
            }
            else
            {
                return dividend / divisor;
            }
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums.First();
        }

        public int[] GetOddsBelow100()
        {
            int[] result = new int[50];
            int oddNum = 1;
            for(int i = 0; i < 50; i++)
            {
                result[i] = oddNum;
                oddNum += 2;
            }
            return result;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for(int i = 0; i < words.Length; i++)
            {
                var wordArray = words[i].ToArray();
                for (int c = 0; c < wordArray.Length; c++)
                {
                    wordArray[c] = char.ToUpper(wordArray[c]);
                }
                string wordString = new string(wordArray);
                words[i] = wordString;
            }
        }
    }
}
