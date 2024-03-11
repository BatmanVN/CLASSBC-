using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C_nangcao
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Action<float, int> subact = sub;
            //subact(3, 2);
            //subact?.Invoke(3,2); //Invoke là 1 phương thức tham chiếu đến delegate
            //subact.Invok.e(3,2);
            //Console.ReadKey();
            //Func<string, int> cw = delegate (string str)
            //{
            //    return str.Split(new char[] { ' ' }).Length;
            //};
            //Console.WriteLine("Thread 2 running!");
            //Thread th1 = new Thread(
            //    delegate ()
            //    {
            //        Console.WriteLine("Thread 1 running!");
            //    }
            //    );
            //th1.Start();
            List<Item> items = new List<Item>();
            for (int i = 0; i < 10; i++)
            {
                Item item = new Item();
                items.Add(item);
            }
            //List<int> itemsPrice = items.Select(i => i.price).ToList();
            //List<Item> itemsSorted = items.OrderBy(i => i.price).ToList();
            List<Item> newitems = items.Where(i => i.price > 20).OrderBy(i => i.price).ToList();
            List<Item> sortedItems = items.OrderBy(i => i.price).ThenBy(i => i.level).ToList();
            //List<Item> itemThan20 = GetItems(items);
            /*List<Item> itemThan20 = items.Where(i => i.price > 20).ToList();*/ //(i la chu cai dau tien cua bien) //.tolist la de convert sang items do Item la List<Item>
            //LinQ(truy van qua cac phan tu cua tap hop): ten Collection(vd:Item) -> bieu thuc Lambda -> neu du dkien thi luu vao List
            ////foreach (var item in itemThan20) 
            ////{
            ////    Console.WriteLine(item.price);
            ////}
            Console.ReadKey();
        }
        private static List<Item> GetItems(List<Item> items) //vi dung LinQ nen k can ham nay nua
        {
            List<Item> result = new List<Item>();
            foreach (Item item in items)
            {
                if (item.price > 20)
                    result.Add(item);
            }
            return result;
        }
        //public static void sub(float num1, int num2)
        //{
        //    Console.WriteLine(num1 / num2);
        //}
    }
}
