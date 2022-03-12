using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileGeneration
{
    internal class RandomDate
    {
        public static string randomDay()
        {
            DateTime start = new DateTime(2017, 1, 1);
            Random gen = new Random();
            int range = (DateTime.Today - start).Days;
            var fullDate = start.AddDays(gen.Next(range));
            var dateWithoutTime =fullDate.ToString("dd/MM/yyyy");
            return dateWithoutTime;
        }
    }
}
