using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileGeneration
{
    internal class RandomEngSymbols
    {
        public static string randomEngSymbols()
        {
            string symbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string finalString="" ;
            
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                var index = random.Next(symbols.Length);
                var asd =  symbols.Count();
                 finalString += symbols[random.Next(0,asd)].ToString();                
            }
            
            return finalString;
            
        }
    }
}
