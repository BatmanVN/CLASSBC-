using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 20;
            int number2 = 50;
            Swap<int>(ref number1 , ref number2);

            string str1 = "Linh";
            string str2 = "Thuy";

            Console.WriteLine(number1);
            Console.WriteLine(number2);

            Swap<string>(ref str1 , ref str2);
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.ReadKey();
        }
        public static void Swap<T>(ref T value1, ref T value2)
        {
            T temp = value1;
            value1= value2;
            value2= temp;
        }
    }
}
