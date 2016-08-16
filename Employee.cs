using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_System;

namespace HR_System
{
    public class Employee 
    {
        public static void Main()
        {
            //make an employee list
            IDictionary<string, string> Employees =
                new Dictionary<string, string>();

            EmployeeData.ExistingEmployees(Employees);

            // The customer has to make a choice - if he wants to add an employee either search an existing one
            Console.WriteLine("Dear Customer, \nIf you want to see the information for the existing employee, \nplease type 'Search'.\nIf you want to add some information, please type 'Add'");
            string userChoice = Console.ReadLine();

                if (userChoice == "Add")
                {
                    EmployeeData.InsertEmployeeData();
                }

                else if (userChoice == "Search")
                {
                    //enter name for the existing employee
                    Console.Write("\nPlease enter name of the employee: ");
                    string existingEmp = Console.ReadLine();
                        if (Employees.ContainsKey(existingEmp))
                        {
                            EmployeeData.SearchEmployee(Employees, existingEmp);
                        }
                        else
                        {
                            Console.WriteLine("\nThere is no employee named " + existingEmp);
                            Console.WriteLine("\nIf you want to see the list with all the employees, please enter 'List'");

                            string list = Console.ReadLine();
                                if (list == "List")
                                {
                                    EmployeeData.ShowExistingEmployees(Employees);

                                    //Delete an existing employee from the list
                                    Console.WriteLine("\nIf you want to delete an employee, please enter 'Delete'");
                                    string delete = Console.ReadLine();

                                    if (delete == "Delete")
                                    {
                                        Console.Write("Please enter name: ");
                                        string deleteName = Console.ReadLine();
                                        Employees.Remove(deleteName);
                                        Console.WriteLine(deleteName + " has been removed!");

                                        Console.WriteLine("If you want to see the employeelist, please enter 'List'");
                                        string deletelist = Console.ReadLine();
                                            if (deletelist == "List")
                                            {
                                                EmployeeData.ShowExistingEmployees(Employees);
                                            }
                                    }
                        }
                    }
            }
        }
    }

}