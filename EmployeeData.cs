using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_System
{
    class EmployeeData
    {
        public string empName 
        {
            get { return this.empName; }
            set { this.empName = value; }
        }
        public string empPosition
        {
            get { return this.empPosition; }
            set { this.empPosition = value; }
        }
        public string empPhone
        {
            get { return this.empPhone; }
            set { this.empPhone = value; }
        }
        public string empMail
        {
            get { return this.empMail; }
            set { this.empMail = value; }
        }

        public static void ExistingEmployees(IDictionary<string, string> Employees)
        {
            Employees["Asen Asenov"] = "\nID - 4545 , \nPosition - Trainee, \ne-mail - a.asenov@test.com , \nPhone - 0889/455620";
            Employees["Maria Marinova"] = "\nID - 4546, \nPosition - Junior, \ne-mail - m.marinovav@test.com , \nPhone - 0889/456203";
            Employees["Ivan Ivanov"] = "\nID - 4547, \nPosition - Senior, \ne-mail - i.ivanov@test.com , \nPhone - 0889/789526";
            Employees["Simona Simeonova"] = "\nID - 4548, \nPosition - Intermediate, \ne-mail - s.simeonova@test.com , \nPhone - 0889/203563";
            Employees["Georgi Georgiev"] = "\nID - 4549, \nPosition - Team leader, \ne-mail - g.georgiev@test.com , \nPhone - 0889/015697";
            Employees["Viktoria Viktorova"] = "\nID - 4550, \nPosition - Project manager, \ne-mail - v.viktorova@test.com , \nPhone - 0889/748523";
            Employees["Mila Markova"] = "\nID - 4551 , \nPosition - CEO, \ne-mail - m.markova@test.com , \nPhone - 0889/852145";
        }
        public static void InsertEmployeeData()
        {
            // insert data for the employee
            Console.Write("\nPlease enter name: ");
            string empName = Console.ReadLine();
            Console.Write("Please enter position: ");
            string empPosition = Console.ReadLine();
            Console.Write("Please enter phone: ");
            string empPhone = Console.ReadLine();
            Console.Write("Please enter e-mail: ");
            string empMail = Console.ReadLine();

            //print the information that the cutomer just entered
            Console.WriteLine("\nHere is the information you just entered: ");
            Console.WriteLine("Name: " + empName + "\nPosition: " + empPosition + "\nPhone: " + empPhone + "\ne-mail: " + empMail);
        }

        public static void SearchEmployee(IDictionary<string, string> Employees, string existingEmp)
        {
            foreach (var item in Employees)
            {
                if (item.Key.ToString() == existingEmp)
                {
                    Console.WriteLine("\nThe result for  " + item.Key + " is: \n" + item.Value);
                }
            }
        }

        public static void ShowExistingEmployees(IDictionary<string, string> Employees)
        {
            Console.WriteLine("\nThere are " + Employees.Count + " employees in the list:");

            foreach (KeyValuePair<string, string> pair in Employees)
            {
                Console.WriteLine("\nName = " + pair.Key + pair.Value);
            }
        }
    }
}
