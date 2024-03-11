using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multi_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation cal = Ultility.Add;
            cal += Ultility.Sub;
            cal = Ultility.Add;
            cal(10, 20);
            Console.ReadKey();
        }
    }
    public class Ultility
    {
        public static void Add(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("Sum of {0}+{1}={2}", a, b, sum);
        }
        public static void Sub(int a, int b)
        {
            int sub = a - b;
            Console.WriteLine("Sub of {0}+{1}={2}", a, b, sub);
        }
    }
    public delegate void Calculation(int a, int b); 
}
