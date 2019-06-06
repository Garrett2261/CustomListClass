using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> list = new CustomList<int>();
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Add(10);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            list.Remove(10);
            Console.WriteLine(list.Count);
            Console.ReadLine();
        }
    }
}
