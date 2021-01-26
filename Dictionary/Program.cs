using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary sınıfı içinde belirleyeceğimiz bir keye uygun olarak değerler saklanır.
            //key türünü belirtmemiz şarttır ( string , int ) etc.

            Dictionary<int, string> NoProject = new Dictionary<int, string>();
            //veri ekliyoruz.

            NoProject.Add(1, "MEHMET BEY KONUT PROJESİ");
            NoProject.Add(2, "AYDINLAR TİCARET MERKEZİ");
            NoProject.Add(3, "EMİN HOTEL");

            foreach (var print in NoProject)
            {
                Console.WriteLine(print);
            }

            //dictionary değer sayma özelliği vardır.
            var total = NoProject.Count();
            Console.WriteLine();
            Console.WriteLine("Toplam Proje Sayısı:"+total);

            //silme özelliği vardır.
            NoProject.Remove(2);
            Console.WriteLine();
            foreach(var print in NoProject)
            {
                Console.WriteLine(print);
            }

            var total2 = NoProject.Count();
            Console.WriteLine();
            Console.WriteLine("Toplam Proje Sayısı:" + total2);
            Console.ReadLine();



        }
    }
}
