
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileGeneration
{
    internal class Program
    {
         public static async Task Main(string[] args)
        {
            /*var tempTask1 = new CreateFiles();
            await tempTask1.generateFiles();

            var files = Directory.GetFiles(@"D:\test\").Select(fn => Path.GetFileName(fn));
            string fileNameOutput = @"D:\test\generalFile.txt";
            FileMerge.mergeFiles(files.ToArray(), fileNameOutput);

            var tempTask = new DeleteStringFromFile();
            await tempTask.deleteString();*/
            var addFilesToDataBase = new AddFilesToDb();
            addFilesToDataBase.AddFilesToDataBase();
        }   
    }
}
