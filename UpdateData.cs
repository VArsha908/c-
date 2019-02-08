using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee1
{
    class UpdateData
    {
        public int Id1 { get; private set; }
        public string Name1 { get; private set; }
        public string DepartmentName1 { get; private set; }

        public UpdateData(int Id1, string Name1, string DepartmentName1)
        {
            this.Id1 = Id1;
            this.Name1 = Name1;
            this.DepartmentName1 = DepartmentName1;
        }
        public int GetId1()
        {
            Console.WriteLine("Enter the updated Id:");
            Id1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Id:" + Id1);
            return (Id1);
        }
        public string GetName1()
        {
            Console.WriteLine("Enter the updated Name:");
            Name1 = Console.ReadLine();
            Console.WriteLine("Name:" + Name1);
            return (Name1);
        }
        public string GetDepartmentName1()
        {
            Console.WriteLine("Enter the updated Department Name:");
            DepartmentName1 = Console.ReadLine();
            Console.WriteLine("Department Name:" + DepartmentName1);
            return (DepartmentName1);
        }
    }
}
