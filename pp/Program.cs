using System;
using System.Collections.Generic;
using System.Linq;

namespace pp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строки через запятую");
            List<string> list = Console.ReadLine().Split(new char[] { ',' }).ToList();
            List<char> doubles = new List<char>();
            List<char> example = list.Last().ToList();
            foreach (char c in example)
            {
                if (!doubles.Contains(c))
                {
                    for (int i = example.Where(j => j == c).Count(); i > 0; i--)
                    {
                        if (list.TrueForAll(x => x.ToList().Where(j => j == c).Count() >= i))
                        {
                            for (int j = 0; j < i; j++)
                            {
                                doubles.Add(c);
                            }
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(String.Join(", ", doubles));
        }
    }
}
