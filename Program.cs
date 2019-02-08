using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee1
{
    public class Program
    {

        static void Main(string[] args)
        {
            int Id;
            string Name;
            string DepartmentName;
            int UpdateDatas;

            Console.WriteLine("Enter the details:");

            Console.WriteLine("Id:");
            Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Name:");
            Name = Console.ReadLine();

            Console.WriteLine("Department Name:");
            DepartmentName = Console.ReadLine();

            Employee data = new Employee(Id, Name, DepartmentName);

            data.GetId();
            data.GetName();
            data.GetDepartmentName();

            Console.WriteLine("Enter the attribute which is to to be updated:");
            UpdateDatas =int.Parse(Console.ReadLine());

            

            UpdateData data1 = new UpdateData(Id, Name, DepartmentName);

            if (UpdateDatas == 1)
            {
                data1.GetId1();
            }
            else if (UpdateDatas == 2)
            {
                data1.GetName1();
            }
            else
            {
                data1.GetDepartmentName1();
            }

          /* switch (data1)
            {
                case "":
                    data1.GetId1();
                    break;
                case "Name":
                    data1.GetName1();
                    break;
                case "Department Name"
                    data1.GetDepartmentName1();
                    break;
            }*/


            MethodCalled(Id,Name,DepartmentName);
            data.MethodCalled += new MethodCalledDelegate(OnMethodCalled);

        }

        public static void GetDepartmentName1()
        {
            throw new NotImplementedException();
        }

        public static void GetName1()
        {
            throw new NotImplementedException();
        }

        public static void GetId1()
        {
            throw new NotImplementedException();
        }

        private static void MethodCalled(int id, string name, string departmentName)
        { }

        static void OnMethodCalled(int Id, string GetName, string DepartmentName)
        {
            Console.WriteLine();
   
        }

    }
    }
