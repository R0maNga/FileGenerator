using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileGeneration
{
    internal class RandomInt
    {
         
        public static int randomIntNumbers()
        {
            while (true)
            {
                Random rnd = new Random();
                int value = rnd.Next(1, 100000000);
                if (value % 2 == 0)
                {
                    return value;
                }
            }
     
            

        }
    }
}
