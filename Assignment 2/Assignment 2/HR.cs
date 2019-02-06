using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class HR : Employee
    {
        public HR(int id, string name, string designation, double salary, int experience, DateTime joiningdate)
        {
            this.Id = id;
            this.Name = name;
            this.Designation = designation;
            this.Experience = experience;
            this.AnnualSalary = salary + (1000 * this.Experience);
            this.JoiningDate = joiningdate;
        }
        public override void PrintDetails()
        {
            Console.WriteLine("Employee Details");
            Console.WriteLine("Id : " + this.Id);
            Console.WriteLine("Name : " + this.Name);
            Console.WriteLine("Designation : " + this.Designation);
            Console.WriteLine("Salary : " + this.AnnualSalary);
            Console.WriteLine("Experience : " + this.Experience + " Years");
            Console.WriteLine("Joining Date : " + this.JoiningDate.Day + "/" + this.JoiningDate.Month + "/" + this.JoiningDate.Year);
        }
    }
}
