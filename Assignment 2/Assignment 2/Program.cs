using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            HR hr = new HR(1, "Shruti", "HR", 18000, 5, new DateTime(2014, 01, 01));
            Developer developer = new Developer(2, "Tufel", "Developer", 7000, 0, new DateTime(2019, 07, 07));
            hr.PrintDetails();
            Console.WriteLine();
            developer.PrintDetails();
        }
    }
}
