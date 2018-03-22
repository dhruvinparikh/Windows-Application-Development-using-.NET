using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Array list
            //List<String> namelist = new List<String>();
            //namelist.Add("xyz");
            //namelist.Add("abc");
            //Console.WriteLine("no of elements " + namelist.Count);
            //Console.WriteLine("Capacity " +namelist.Capacity);
            //bool cont = namelist.Contains("Abc");
            //Console.WriteLine("Element present status : " + cont);
            //Console.WriteLine("Elements present are");
            //namelist.ForEach(item => { Console.WriteLine(item); });
            //namelist.Sort();
            ////namelist.RemoveRange(0, 2);
            //namelist.ForEach(item => { Console.WriteLine(item); });
            //Console.WriteLine( namelist.BinarySearch("abc"));
            //List<String> list1 = new List<String>();
            //list1.Add("123");
            //list1.Add("456");
            //namelist.AddRange(list1);
            //namelist.ForEach(item => { Console.WriteLine(item); });
            //Console.ReadLine();

            //int books = new int[4];
            String[] bboks = { "VB", "C#", ".Net", "Java" };
            int[] price = { 10, 20, 15, 5 };
            IEnumerator enumerator = price.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

            //Create a collection to store price > 10
            //Method - 1
            List<int> pList = new List<int>();
            while (enumerator.MoveNext())
            {
                if ((int)enumerator.Current > 10)
                {
                    pList.Add((int)enumerator.Current);
                }
            }

            //language integrated query -> LINQ
            //Method - 2
            var filterprice =
                from temp in price
                where temp > 10
                orderby temp descending
                select temp;
            IEnumerator ien = filterprice.GetEnumerator();
            while (ien.MoveNext())
            {
                Console.WriteLine(ien.Current);
            }
            //to remove duplicate data
            foreach(var item in filterprice.Distinct())
            {
                Console.WriteLine(item);
            }

            ////Queues
            //queue shoplist = new queue();
            //shoplist.enqueue("abhishek");
            //shoplist.enqueue("kartik");
            //shoplist.enqueue("carlos");
            //shoplist.enqueue(56);
            //console.writeline(shoplist.peek());
            //console.writeline(shoplist.count);
            //console.writeline(shoplist.dequeue());
            //console.writeline(shoplist.count);
            //foreach(var item in shoplist)
            //{
            //    console.writeline(item);
            //}

            ////Stack
            //Stack stack = new Stack();
            //stack.Push("Hey");
            //stack.Push("Good");
            //Console.WriteLine(stack.Peek());
            ////Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Count);
            //Console.WriteLine(stack.Contains("Good"));
        }
    }
}
