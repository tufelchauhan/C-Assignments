using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arr = new List<string> { "Boat", "house", "cat", "river", "cupboard" };

            foreach (var item in arr)
            {
                Console.WriteLine($"{item}s");
            }

            arr[1] = "residence";
            Console.WriteLine($"\nSecond word in list : {arr[1]}");

            arr.Add("toy");
            Console.WriteLine("\nWord added");
            Console.WriteLine($"Length of list is {arr.Count}");

            Console.WriteLine("\nList of words that contains the length of 7 characters :");
            foreach (var item in getWordByLength(arr,7))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"\nWord on third position : {arr[2]}");

            Console.WriteLine("\nWords in ascending order");
            foreach (var item in getWordsSorted(arr))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nReverse of array");
            for(int i=arr.Count-1;i>=0;i--)
            {
                Console.WriteLine(arr[i]);
            }
        }


        public static IEnumerable<string> getWordByLength(List<string> arr,int len)
        {
            var ProductQueryByType = arr.Where(v => v.Length>=len);
            return ProductQueryByType;
        }
        public static IEnumerable<string> getWordsSorted(List<string> arr)
        {
            var ProductQueryByType = arr.OrderBy(v=>v);
            return ProductQueryByType;
        }
    }
}
