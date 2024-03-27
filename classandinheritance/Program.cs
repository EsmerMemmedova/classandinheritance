using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace classandinheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Department[] department = new Department[20];
            int secim;
            do {
                Console.WriteLine("Menu sechimi: ");
                Console.WriteLine("1.Empoyee elave et");
                Console.WriteLine("2.Butun ishcilere bax");
                Console.WriteLine("0.Proqrami bitir");

                Console.WriteLine("seciminizi daxl edin");
                secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        AddEmployee(department);
                        break;
                    case 2:
                        ShowAllEmployees(department);
                        break;
                    case 0:
                        Console.WriteLine("Proqram bitirildi.");
                        break;
                    default:
                        Console.WriteLine("Yanlış seçim. Yenidən seçim edin.");
                        break;
                }
            } while (secim != 0);
        }

       public static void AddEmployee(Department department)
        {
            Console.WriteLine("Employee məlumatlarını daxil edin:");
            Console.Write("Ad: ");
            string name = Console.ReadLine();
            Console.Write("Soyad: ");
            string surname = Console.ReadLine();
            Console.Write("Yaş: ");
            byte age = Convert.ToByte(Console.ReadLine());
            Console.Write("Department adı: ");
            string departmentName = Console.ReadLine();
            Console.Write("Maaş: ");
            decimal salary = Convert.ToDecimal(Console.ReadLine());

            Employee newEmployee = new Employee
            {
                Name = name,
                Surname = surname,
                Age = age,
                DepartmentName = departmentName,
                Salary = salary
            };

            department.AddEmployee(newEmployee);
        }
    }
     public static void ShowAllEmployees(Department department)
    {
        department.ShowEmployeeInfo();
    }


}
        public class Employee
        {
            public string Name;
            public string Surname;
            public byte Age;
            public string DepartmentName;
            public decimal Salary;


        }
        public class Department
        {
            public Employee[] employees;
            public int currentIndex = 0;

            public Department(int tutum)
            {
                employees = new Employee[tutum];

            }
            public void AddEmployee(Employee newEmployee)
            {
                if (currentIndex < employees.Length)
                {
                    employees[currentIndex] = newEmployee;
                    currentIndex++;
                }
                else
                {
                    Console.WriteLine("siyahiya isci elave etmek olmur");
                }
            }
            public void ShowEmployeeinfo()
    {
        Console.WriteLine("Bütün işçilər:");
        for (int i = 0; i < currentIndex; i++)
        {
            Console.WriteLine(employees[i]);
        }
    }
            public Employee[] GetAllEmployee()
            {
                return employees;
            }




         }

    

   

