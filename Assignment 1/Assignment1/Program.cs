using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int tmpId;
            string tmpName, tmpDepartmentName;
            Console.WriteLine("Enter Employee Details");
            Console.WriteLine("Enter Id : ");
            tmpId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name : ");
            tmpName = Console.ReadLine();
            Console.WriteLine("Enter Department Name : ");
            tmpDepartmentName = Console.ReadLine();

            Console.WriteLine();
            Employee emp1 = new Employee(tmpId,tmpName,tmpDepartmentName);
            emp1.MethodCalled += new MethodCalledDelegate(onMethodCalled);
            Console.WriteLine("Employee Details");
            Console.WriteLine("Id : " + emp1.GetId());
            Console.WriteLine("Name : " + emp1.GetName());
            Console.WriteLine("Department : " + emp1.GetDepartmentName());

            Console.WriteLine();
            emp1.UpdateEmployee(11, "Tufel Chauhan", "IT Department");
            Console.WriteLine("Updated Employee Details");
            Console.WriteLine("Id : " + emp1.GetId());
            Console.WriteLine("Name : " + emp1.GetName());
            Console.WriteLine("Department : " + emp1.GetDepartmentName());
        }
        static void onMethodCalled(string methodName)
        {
            Console.WriteLine(methodName + " Method Called");
        }
    }
}
