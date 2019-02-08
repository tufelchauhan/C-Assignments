using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> pm = new Dictionary<int, string>();
            pm.Add(1998, "Atal Bihari Vajpayee");
            pm.Add(2014, "Narendra Modi");
            pm.Add(2004, "Manmohan Singh");

            if(pm.ContainsKey(2004))
            {
                Console.WriteLine($"Prime Minister Name : {pm[2004]} | Year : 2004");
            }

            pm.Add(2019, "Ghajendra Modi");
            Console.WriteLine("\nPrime Minister Added");

            Console.WriteLine("\nDictionary Sorted By Year");
            pm = sortDictionary(pm);
            //pm = sortDictionary(pm).ToDictionary(v=>v.Key,k=>k.Value);
            foreach (var item in pm)
            {
                Console.WriteLine($"Prime Minister Name : {item.Value} | Year : {item.Key}");
            }
        }
        public static Dictionary<int,string> sortDictionary(Dictionary<int, string> dict)
        {
            var Iterator = dict.OrderBy(k => k.Key);
            return Iterator.ToDictionary(k=>k.Key,v=>v.Value);
        }
        //public static IEnumerable<KeyValuePair<int,string>> sortDictionary(Dictionary<int, string> dict)
        //{
        //    var Iterator = dict.OrderBy(v => v.Key);
        //    return Iterator;
        //}
    }
}
