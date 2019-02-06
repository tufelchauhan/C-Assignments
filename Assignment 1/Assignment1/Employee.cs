using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Employee
    {
        public Employee(int id,string name,string departmentname)
        {
            this.Id = id;
            this.Name = name;
            this.DepartmentName = departmentname;
        }

        public int GetId()
        {
            MethodCalled("GetId");
            return this.Id;
        }
        public string GetName()
        {
            MethodCalled("GetName");
            return this.Name;
        }
        public string GetDepartmentName()
        {
            MethodCalled("GetDepartmentName");
            return this.DepartmentName;
        }
        public void UpdateEmployee(int tmpId)
        {
            this.Id = tmpId;
        }
        public void UpdateEmployee(int tmpId,string tmpName)
        {
            this.Id = tmpId;
            this.Name = tmpName;
        }
        public void UpdateEmployee(int tmpId, string tmpName,string tmpDepartmentName)
        {
            this.Id = tmpId;
            this.Name = tmpName;
            this.DepartmentName = tmpDepartmentName;
        }
        private int Id { get; set; }
        private string Name { get; set; }
        private string DepartmentName { get; set; }
        public event MethodCalledDelegate MethodCalled;
    }
}
