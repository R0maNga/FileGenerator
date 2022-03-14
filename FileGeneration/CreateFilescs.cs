using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileGeneration
{
    internal class CreateFiles
    {
        public async Task generateFiles()
        {
            string path = @"D:\test\";
            if (Directory.Exists(path))
            {
                int i;
                for (i = 1; i <= 100; i++)
                {
                    string FileName = "Test" + i + ".txt";
                    var newpath = path + FileName;
                    if (!File.Exists(newpath))
                    {


                        using (StreamWriter sw = File.CreateText(newpath))
                        {
                            for (int b = 0; b < 100000; b++)
                            {

                                
                                 await sw.WriteLineAsync("//"+RandomDate.randomDay()+"//"+ RandomEngSymbols.randomEngSymbols()+"//"+ RandomRuSymbols.randomRuSymbols()+"//"+ RandomInt.randomIntNumbers()+"//"+ RandomDouble.randomDoubleNumbers()+"//");


                            }

                        }


                    }

                }
            }
        }
    }
}

