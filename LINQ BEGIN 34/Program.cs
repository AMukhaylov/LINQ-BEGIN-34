using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        // Вариант 2 Beginer
        // Задача 34
        static void Main(string[] args)
        {
            List<int> list2 = new List<int> { 2, 13, 33, 53, 9, 56, 58, 7, 9, 54, 87, 41, 86 };
            var result3 = list2.Where(x => x % 2 == 0).Select(x => x.ToString()).OrderBy(x => x);
            foreach (string i in result3)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
