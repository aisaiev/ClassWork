using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    public static class Task7
    {
        public static string ToCamelCase(string str)
        {
            string[] words = str.Split('-');
            if (words.Length == 1)
            {
                words = str.Split('_');
            }
            string[] resultWords = new string[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                if (i != 0)
                {
                    resultWords[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
                }
                else
                {
                    resultWords[i] = words[i];
                }
            }
            return string.Join("", resultWords);
        }
    }
}
