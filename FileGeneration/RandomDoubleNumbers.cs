using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileGeneration
{
    internal class RandomDouble
    {
        public static double randomDoubleNumbers()
        {

            while (true)
            { 
            Random rnd = new Random();
            double randomNumber = rnd.NextDouble();
            string randomString = randomNumber.ToString("F8");
            string defoltString = "0.99999999";
            



                int lengthDefoltString = defoltString.Length;
                    int lengthRandomSring = randomString.Length;
                    if (lengthDefoltString == lengthRandomSring)
                    {
                        double inrRand = rnd.Next(1, 20);
                        double value = double.Parse(randomString);
                        double final = inrRand + value;
                        string stringFinal = final.ToString();
                        

                    if (stringFinal.Length == lengthDefoltString|| stringFinal.Length == lengthDefoltString+1)
                        {
                            return final;
                        }
                        

                    }
                
            

            }
           



        }
    }
}
