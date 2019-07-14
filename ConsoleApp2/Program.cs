using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. sayiyi giriniz: ");
            int sayi1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("2. sayiyi giriniz: ");
            int sayi2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("3. sayiyi giriniz: ");
            int sayi3 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("4. sayiyi giriniz: ");
            int sayi4 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine((sayi1+sayi2) * (sayi3 + sayi4));
            Console.ReadLine();
        }
        
    }
}
