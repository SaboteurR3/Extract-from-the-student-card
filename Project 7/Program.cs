using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool mainBool = true;
            while (mainBool)
            {
                try
                {
                    ArrayList employee = new ArrayList();
                    Console.WriteLine("Enter total students: ");
                    int numberOfStudents = int.Parse(Console.ReadLine());
                    for (int i = 0; i < numberOfStudents; i++)
                    {
                        Console.WriteLine("Enter employee firstname: ");
                        string firstname = Console.ReadLine();
                        Console.WriteLine("Enter employee lastname: ");
                        string lastname = Console.ReadLine();
                        Console.WriteLine("Enter employee id: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter employee birthYear: ");
                        int birthYear = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter employee salary: ");
                        int salary = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter employee rating: ");
                        byte rating = byte.Parse(Console.ReadLine());
                        int currentYear = DateTime.Now.Year;
                        int age = currentYear - birthYear;
                        employee.Add(new Employee { FirstName = firstname, LastName = lastname, Id = id, BirthYear = birthYear, Age = age, Salary = salary, Rating = rating });
                        Console.WriteLine("==============================================================");
                    }
                    // Sort by ascending age
                    employee.Sort(new SortByAge());
                    Console.WriteLine("\n!!!!!!!!sort by ascending age!!!!!!!!\n");
                    foreach (var item in employee)
                    {
                        Console.WriteLine(item);
                    }
                    // Sort by ascending salary
                    employee.Sort(new SortBySalary());
                    Console.WriteLine("\n!!!!!!!!sort by ascending salary!!!!!!!!\n");
                    foreach (var item in employee)
                    {
                        Console.WriteLine(item);
                    }
                    // Sort by Descending rating
                    employee.Sort(new SortBySalary());
                    Console.WriteLine("\n!!!!!!!!sort by Descending rating!!!!!!!!\n");
                    foreach (var item in employee)
                    {
                        Console.WriteLine(item);
                    }
                }
                catch (FormatException exc)
                {
                    Console.WriteLine("Enter integer only!", exc.Message);
                }
                catch (OverflowException exc)
                {
                    Console.WriteLine("Number is too big!", exc.Message);
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
                finally
                {
                    Console.WriteLine("\nDo you want to continue again (Y/N)?");
                    bool question = true;
                    while (question)
                    {
                        char Continue = Console.ReadLine()[0];
                        if (Continue == 'y' || Continue == 'Y')
                        {
                            question = false;
                        }
                        else if (Continue == 'n' || Continue == 'N')
                        {
                            question = false;
                            mainBool = false;
                            Console.WriteLine("Bye <3");
                        }
                        else
                        {
                            Console.WriteLine("Choose 'Y' or 'N' ");
                        }
                    }
                }
            }
        }
    }
}