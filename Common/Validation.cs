using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Common
{
    public class Validation
    {
        public static bool IsValidName(string firstname, string secondname)
        {
            Regex regex = new Regex(@"^[A-z]*$");
            return regex.IsMatch(firstname) && regex.IsMatch(secondname);
        }

        public static bool IsValidHIS(string HIS)
        {
            Regex regex = new Regex(@"^[0-9]{3}\s[0-9]{3}\s[0-9]{3}$");
            return regex.IsMatch(HIS);
        }
    }
}
