using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hard_4_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст-> ");
            string str = Convert.ToString(Console.ReadLine());
            var result = String.Concat(str.Split(new Char[] { ' ', ',', '.', '!', '?' },
            StringSplitOptions.RemoveEmptyEntries).Select(word => word.First()));
            Console.WriteLine("Вервые буквы всех слов-> ", result);
            Console.ReadKey();
        }
    }
}
