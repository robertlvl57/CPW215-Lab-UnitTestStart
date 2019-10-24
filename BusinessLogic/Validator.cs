using System;

namespace BusinessLogic
{
    public static class Validator
    {
        /// <summary>
        /// Determines if string is a valid Social Security number
        /// </summary>
        /// <param name="ssn"></param>
        /// <returns></returns>
        public static bool IsSsn(string ssn)
        {
            if (ssn.Length >= 9)
            {
                if (ssn.Substring(3, 1) == "-" && ssn.Substring(6, 1) == "-")
                {
                    ssn = ssn.Replace("-", "");
                    if (ssn.Length != 9)
                    {
                        return false;
                    }
                    return true;
                }
            }
            if (ssn.Contains("-"))
            {
                return false;
            }
            if (ssn.Length != 9)
            {
                return false;
            }
            return true;
                
        }

        /// <summary>
        /// Checks if a number is within range
        /// </summary>
        /// <param name="numToTest">The number to test</param>
        /// <param name="minValue">The minimum INCLUSIVE range</param>
        /// <param name="maxValue">The maximum INCLUSIVE range</param>
        /// <returns></returns>
        public static bool IsWithinRange(int numToTest, int minValue, int maxValue)
        {
            if(numToTest <= maxValue && numToTest >= minValue)
            {
                return true;
            }
            return false;
        }
    }
}
