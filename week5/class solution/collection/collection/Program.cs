using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace collection
{
    class Program
    {
  
        static void Main(string[] args)
        {
            //int[] books = new int[4];
            String[] books = {"VB","C#",".Net","Java" };
            int[] price = { 10, 20, 15, 5 };
            IEnumerator enumerator = price.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            Queue shoplist = new Queue();
            shoplist.Enqueue("Abhishek");
            shoplist.Enqueue("Kartik");
            shoplist.Enqueue("Carlos");
            shoplist.Enqueue(56);
            Console.WriteLine(shoplist.Peek());
            Console.WriteLine(shoplist.Count);
            Console.WriteLine(shoplist.Dequeue());
            Console.WriteLine(shoplist.Count);
            foreach(var item in shoplist)
            {
                Console.WriteLine(item);
            }
            var filterprice =
                from temp in price
                where temp > 10
                orderby temp descending
                select temp;
            foreach (var item in filterprice.Distinct())
            {
                Console.WriteLine(item);
            }
        }
    }
}
