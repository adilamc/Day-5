using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    
    class Structure
    {
        public struct Employee
        {
            public int EmployeeId;
            public string EmployeeName;
            public Salary sal;
        }
        public struct Salary
        {
            public int monthly;
            public int yearly;
        }
        public static void Main()
        {
            int total ;
            Console.WriteLine("Enter No of Employees:");
            total = Convert.ToInt32(Console.ReadLine());
            Employee[] emp = new Employee[total];
            for (int i=0; i<total;i++)
            {
                Console.WriteLine("Enter EmployeeId");
                emp[i].EmployeeId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter EmployeeName");
                emp[i].EmployeeName = Console.ReadLine();
                Console.WriteLine("Enter MonthlySalary");
                emp[i].sal.monthly = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter yearlySalary");
                emp[i].sal.yearly = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("****************List of employees***************");
            Console.WriteLine("EmployeeId_" + "\t EmployeeName" + "\t monthly Salary" + "\t Yearly salary");
            for (int i = 0; i < total; i++)
            {
                Console.WriteLine("\t" + emp[i].EmployeeId +"\t \t"+ emp[i].EmployeeName + "\t \t" + emp[i].sal.monthly + "\t \t" + emp[i].sal.yearly + "\t \t");
                //Console.WriteLine("EmployeeId_"+i);
                //Console.WriteLine("\t" + emp[i].EmployeeId);
                //Console.WriteLine("EmployeeName_" +i);
                //Console.WriteLine("\t" + emp[i].EmployeeName);
            }
            Console.ReadLine();
        }
    }
}
