using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee1
{
    class Employee
    {
        private int Id;
        private string Name;
        private string DepartmentName;

        public Employee(int Id, string Name, string DepartmentName)
        {
            this.Id = Id;
            this.Name = Name;
            this.DepartmentName = DepartmentName;
        }



        public int GetId()
        {
            Console.WriteLine("Id:" + Id);
            return (Id);
        }
        public string GetName()
        {
            Console.WriteLine("Name:" + Name);
            return (Name);
        }
        public string GetDepartmentName()
        {
            Console.WriteLine("DepartmentName:" + DepartmentName);
            return (DepartmentName);
        }



        public MethodCalledDelegate MethodCalled;

        public string Name1 { get; private set; }
        public string DepartmentName1 { get; private set; }
    }
}