using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace weeklyChallenges03
{

    public class ChallengesSet03
    {
            public bool ArrayContainsAFalse(bool[] vals)
            {
                foreach (bool x in vals)
                {
                if (x == false)
                    return true;
                }
            return false;
            }

            public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
            {
            if (numbers == null)
                return false;
            int x = numbers.Sum();
            if (x % 2 == 0)
                return false;
            else
                return true;
            }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit))
              return true;
            else
            return false;
        }
            
            public char GetFirstLetterOfString(string val)
            {
            return val[0];
            }

            public char GetLastLetterOfString(string val)
            {
            return val.Last();  
            }

            public decimal Divide(decimal dividend, decimal divisor)
            {
            if (divisor == 0)
                return 0;
            return dividend / divisor;
            }

            public int LastMinusFirst(int[] nums)
            {
                int subtraend = nums[0];
                int minuend = nums.Last();

            return minuend - subtraend;
            }

        public int[] GetOddsBelow100()
        {
            List<int> NumbList = new List<int>();
            int x = 1;
            do
            {
                NumbList.Add(x);
                    x += 2;
            }
            while (x < 100);
            int[] FinalList = NumbList.ToArray();
            return FinalList;
        }
        public void ChangeAllElementsToUppercase(string[] words)
        {
            List<string> Baffled = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }   
        }

    }
}
