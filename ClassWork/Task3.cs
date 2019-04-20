using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassWork
{
    public static class Task3
    {
        public static bool ValidatePin(string pin)
        {
            Regex regex = new Regex("^[0-9]{4}$");
            return regex.IsMatch(pin);
        }
    }
}
