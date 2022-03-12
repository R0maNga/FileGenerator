using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileGeneration
{
    internal class RandomRuSymbols
    {
        public static string randomRuSymbols()
        {
            string symbols = "йцукенгшщзхъфывапролджэячсмитьбюЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ";
            string finalString = "";

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                var index = random.Next(symbols.Length);
                var asd = symbols.Count();
                finalString += symbols[random.Next(0, asd)].ToString();
            }

            return finalString;

        }
    }
}

