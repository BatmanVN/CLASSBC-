using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            //arr.Add(1);
            //arr.Add("Hello");
            //arr.Add(true);
            //arr.Insert(1,true);
            //string[] names = { "Linh", "Khai", "Tung" };
            //arr.AddRange(names);
            //if(arr != null && arr.Count > 0 )
            //{
            //    //arr.RemoveRange(1,3);
            //}

            ////for (int i=0;i<arr.Count;i++)
            ////{

            ////    Console.Write(arr[i] + " ");
            ////}
            //ArrayList collect = new ArrayList() { "Long", "Tung", "truc", "Mai" };
            //collect.Sort();
            //if (collect.Contains("Long"))
            //{
            //    int pos = collect.IndexOf("Long");
            //    collect.RemoveAt(pos);
            //    for (int i = 0; i < collect.Count; i++)
            //    {
            //        Console.Write(collect[i] + " ");
            //    }
            //}
            //else
            //    Console.WriteLine("Khong tim thay");
            Hashtable collect = new Hashtable();
            collect.Add("SR", "Shoot Right");
            collect.Add("MK", "Mortal Knight");
            collect["IT"] = "Information Tech";
            foreach (var key in collect.Keys)
            {
                Console.WriteLine(key+ "." + collect[key]);
            }
            if (!collect.ContainsKey("SC"))
                collect.Add("SC", "Security");
            Console.ReadKey();
        }
    }
}
