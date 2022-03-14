using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileGeneration
{
    public class FileMerge
    {
        public static void mergeFiles(string[] sourceFiles, string destFile)
        {
            using (StreamWriter writer = new StreamWriter(destFile, false, Encoding.Default))
            {
                foreach (string sourceFile in sourceFiles)
                {
                   var Text = new DirectoryInfo(@"D:\test\").GetFiles().Length;

                    for (int i = 1; i < Text; i++)
                    {
                        string[] strArray = File.ReadAllLines($@"D:\test\Test{i}.txt");
                        foreach (string line in strArray)
                        {
                            writer.WriteLine(line);
                            
                        }
                    }

                    break;


                }
            }
        }
    }
}
