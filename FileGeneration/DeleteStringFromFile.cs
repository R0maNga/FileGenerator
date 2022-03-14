using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileGeneration
{
    internal class DeleteStringFromFile
    {
        
    public async Task deleteString()
        {
           
            var generalFile = @"D:\test\generalFile.txt";
            
            try
            {
                Console.WriteLine("Введите символы по которым необходимо удалить строки");
                var inputData = Console.ReadLine();
                int countBefore=0;
                int countAfter=0;
                for (int i = 1; i <= 100; i++)
                {
                    countBefore = +File.ReadAllLines($@"D:\test\Test{i}.txt").Length;
                    File.WriteAllLines($@"D:\test\Test{i}.txt", (await File.ReadAllLinesAsync($@"D:\test\Test{i}.txt")).Where(v => v.Trim().IndexOf(inputData) == -1).ToArray());
                    countAfter = +File.ReadAllLines($@"D:\test\Test{i}.txt").Length;
                    
                }
                int result = countBefore - countAfter;
                Console.WriteLine($"Cтрок удалено: {result}");
                    
             }
             catch (Exception e)
             {

                Console.WriteLine(e.Message);
             }
                
            
        }
    }
}
