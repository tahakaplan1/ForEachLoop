using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachDöngüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayılar = { 15, 55, 85, 14, 65, 87 };
            foreach (var sayi in sayılar) 
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(sayılar[0] + " " + sayılar[1] + " " + sayılar[5]);
            Console.ReadLine();
        }
    }
}
